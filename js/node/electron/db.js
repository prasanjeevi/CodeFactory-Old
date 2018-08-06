const sqlite3 = require('sqlite3').verbose();

// open database in memory
//let db = new sqlite3.Database(':memory:', (err) => {
  let db = new sqlite3.Database('/Users/sanjeevi/CodeFactory/CodeBaseDotNet/Core/Web/Api/account.db', sqlite3.OPEN_READWRITE, (err) => {
  if (err) {
    return console.error(err.message);
  }
  console.log('Connected to the SQlite database.');
});
 
const selectAll = 'SELECT * FROM Accounts';
 
db.all(selectAll, [], (err, rows) => {
  if (err) {
    throw err;
  }
  rows.forEach((row) => {
    console.log(row.Balance);
  });
});

db.run(`INSERT INTO Accounts(Id, BalanceOn, Balance) VALUES(?,?,?)`, [3, new Date(), 4000], function(err) {
  if (err) {
    return console.log(err.message);
  }
  // get the last insert id
  console.log(`A row has been inserted with rowid ${this.lastID}`);
});

db.run(`INSERT INTO Accounts(Id, BalanceOn, Balance) VALUES(?,?,?)`, [3, new Date(), 4000], function(err) {
  if (err) {
    return console.log(err.message);
  }
  // get the last insert id
  console.log(`A row has been inserted with rowid ${this.lastID}`);
});

// close the database connection
// db.close((err) => {
//   if (err) {
//     return console.error(err.message);
//   }
//   console.log('Close the database connection.');
// });