// date.js
minutesInMilliseconds = 60 * 1000;              //       60000
hoursInMilliseconds = 60 * 60 * 1000;           //     3600000
dayInMilliseconds = 24 * 60 * 60 * 1000;        //    86400000
monthInMilliseconds = 30 * 24 * 60 * 60 * 1000; //  2592000000
yearInMilliseconds = 365 * 24 * 60 * 60 * 1000; // 31536000000
 
now = new Date();
today = new Date(now.setHours(0, 0, 0, 0));
dob = new Date(1988, 7, 16);
 
diff = today - dob;
years = Math.floor(diff / yearInMilliseconds);
console.log("Years", years);
 
noOfLeapDays = countLeapDays(dob, today);
console.log("No of Leap Days", noOfLeapDays);
diff = diff - ( noOfLeapDays * dayInMilliseconds);
 
diff = diff % yearInMilliseconds;
console.log("Diff left for months", diff)
months = Math.floor(diff / monthInMilliseconds);
console.log("Months", months);
 
diff = diff % monthInMilliseconds;
console.log("Diff left for days", diff)
days = diff / dayInMilliseconds;
console.log("Days", days);
 
function isLeapYear(year){
    if(year % 4 !== 0) return false;         // 2017
    else if (year % 100 !== 0) return true;  // 1988
    else if (year % 400 !== 0) return false; // 1990
    else return true;                        // 2000
}
 
function getLeapYears(startYear, endYear){
    var leapYears = [];
    for(var i=startYear; i<=endYear; i++){
        if(isLeapYear(i)){
            leapYears.push(i);
        }
    }
    return leapYears;
}
 
function countLeapDays(startDate, endDate){
    var leapYears = [];
    for(var year=startDate.getFullYear(); year<=endDate.getFullYear(); year++){
        // 1988 => true && 1988-02-29 >= 1988-08-16 && 1988-02-29 <= 2020-01-12
        // 2000 => true && 2000-02-29 >= 1988-08-16 && 2000-02-29 <= 2020-01-12
        // 2020 => true && 2020-02-29 >= 1988-08-16 && 2020-02-29 <= 2020-01-12
        if(isLeapYear(year) && (new Date(year, 1, 29) >= startDate) && new Date(year, 1, 29) <= endDate){
            leapYears.push(year);
        }
    }
    return leapYears.length;
}
 
function countYears(startDate, endDate){
    var years = 0;
    for(var year=startDate.getFullYear(); year<=endDate.getFullYear(); year++){
        years++;
    }
    return leapYears.length;
}
 
 
var dob = new Date(1988, 7, 16)
var today = new Date((new Date()).setHours(0, 0, 0, 0))
var d = new Date(dob.getTime());
d.setFullYear(today.getFullYear())
if(d > today){
    d.setFullYear(d.getFullYear() - 1)
}
console.log(d.getFullYear() - dob.getFullYear());
console.log(dob.getMonth() - today.getMonth());
//  Aug. 16, 2016 and Jan. 13, 2017
//  Jan. 12, 2016 and Jan. 13, 2017
 
function getAge(birthday) {
    var today = new Date();
    var thisYear = 0, thisMonth = 0, months=0, days=0;
    if (today.getMonth() < birthday.getMonth()) {
        if(today.getDate() < birthday.getDate()){
            // 13 16
            thisMonth = 1;
        }       
        months = (11 - birthday.getMonth()) + (today.getMonth() + 1) - thisMonth
        thisYear = 1; // birthday month yet to come
    } else if (today.getMonth() == birthday.getMonth()) {
        if(today.getDate() < birthday.getDate()){
            thisYear = 1; // birthday yet to come in current month
            months = ((11 - birthday.getMonth()));       
        }
    }
    else{
        if(today.getDate() < birthday.getDate()){
            thisMonth = 1; // birthday yet to come in current month           
        }
        // 7 1
        months = (today.getMonth() - birthday.getMonth()) - thisMonth
    }
   
    
    var age = today.getFullYear() - birthday.getFullYear() - thisYear;
    console.log('years', age);
    console.log('months', months);
    console.log('days', today.getDate() >= birthday.getDate() ? today.getDate() - birthday.getDate() : 31 - (birthday.getDate() - today.getDate()) );
}