---
System.IO.FileLoadException: Could not load file or assembly 'System.Web.Mvc, Version=5.2.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35' or one of its dependencies. The located assembly's manifest definition does not match the assembly reference. (Exception from HRESULT: 0x80131040)

Update-Package Microsoft.AspNet.Mvc -reinstall
---
devaudit aspnet -r D:\DevAudit-2.2.0.3\DevAudit -c @web.config
---
1. Console applications can be hosted from PCF using the binary buildpack

2. it is possible to run .NET Core apps on Windows (CELL) by pre-publishing them and pushing them using the binary buildpack, which now supports Windows

dotnet publish --runtime win-x86 -c Release

https://github.com/cloudfoundry/hwc-buildpack/issues/3
---
combed

elastic resilient security serverless functional-programming DevOps CI/CD

aws>azure>   gcp>aws
bluemix pcf


security
iam
---
//
/*   */
/***
@author Sanjeevi
*/
 
Packages
Convension: All lowercase - uniqueness
Variables
 
$ _ alphabets & numeric
camelCase
Strongly typed
Primitive types
1.  Integer
2.  Floating point
3.  Character
4.  Boolean

Floating point IEEE 754

Postfix i++
2.  Prefix ++i
 
Compound Assignment Operator i += 50
Operator precedence L->R
 
3.  Multiplicative * / %
4.  Additive + -
 
Type conversion (cast)
Implicit - widening conversions
Explicit -  widening/narrowing
 
Logical
&
|
XOR ^
!
 
for(int i : arrayVals)
 
 
Encapsulation
What
How
 
 
Class name & file name should be same
Class = Fields + Methods

Initialization block
Parameter immutability
Variable number of parameters
---
https://serifandsemaphore.io/azure-cloud-functions-vs-aws-lambda-caf8a90605dd

https://www.cdnoverview.com/compare/microsoft-azure-vs-amazon-cloudfront/

http://deanhume.com/home/blogpost/content-delivery-networks--which-one-is-right-for-you-/7103

https://docs.microsoft.com/en-us/azure/traffic-manager/traffic-manager-overview#how-traffic-manager-works
---
In Azure there is limitation in URL path param. Azure accepts maximum of 260 chars.
curl -u $username:password https://sitename.scm.azurewebsites.net/api/logstream
---
Node.js
1.     Basic nodejs app (callbacks, EventEmitters, logging & debugging)
2.     express [module]
Basic express - Expose REST API
            Reading request
                        querystring
headers
params
                        body - bodyparser
            Writing middlewares
3.     request [module]
                        Consuming external services
4.     jsonwebtoken  [module]
5.     async [module]
                        waterfall
6.     mongoose [module]
7.     Promise (native)
 
12 factor app
CF basics
Adapter pattern
OAUTH basics
ES6
---
www.calculator.net/age-calculator.html
http://www.miniwebtool.com/
---
windows due to files with long file names 255 char
---
git clone --progress -v
-v --verbose
---
https://www.infoq.com/presentations/spring-12-factor-cloud-springone2016
http://jaketrent.com/post/mongoose-population/
http://norvig.com/spell-correct.html
http://www.anotherchris.net/csharp/how-to-write-a-spelling-corrector-in-csharp/
https://stoi.wordpress.com/2012/12/31/jspell/
http://adrianmejia.com/blog/2014/10/01/creating-a-restful-api-tutorial-with-nodejs-and-mongodb/
http://openmymind.net/mongodb.pdf
---
anger is one letter short of danger

::selection{
background:#3e4349
color:white
}
---
http://www.vikatan.com/news/article.php?module=news&aid=39351&utm_source=facebook&utm_medium=EMagazine&utm_campaign=1
http://ase.softmentor.ro/POO/Carti/AppliedMicrosoftNETFramework.pdf
http://www.dofactory.com/reference/csharp-coding-standards

birthdate

What's the difference between String and string?
string is an alias for System.String. So technically, there is no difference.
use string to refer objects
use String to refer class

object:  System.Object
string:  System.String
bool:    System.Boolean
byte:    System.Byte
sbyte:   System.SByte
short:   System.Int16
ushort:  System.UInt16
int:     System.Int32
uint:    System.UInt32
long:    System.Int64
ulong:   System.UInt64
float:   System.Single
double:  System.Double
decimal: System.Decimal
char:    System.Char

There is one circumstance in which you have to use the aliases: when explicitly specifying an enum's underlying type. For instance:

public enum Foo : UInt32 {} // Invalid
public enum Bar : uint   {} // Valid

You need to have a "using System;" statement. using "int" requires no using statement.


#03b194 rgb(3, 177, 148);

Framework Design Guidelines: Conventions, Idioms, and Patterns for Reusable .NET Libraries, 2nd Edition
https://msdn.microsoft.com/en-us/library/ms229042(v=vs.110).aspx
http://sourcemaking.com/design_patterns
---
http://ux.stackexchange.com/questions/53264/dark-or-white-color-theme-is-better-for-the-eyes
http://tutorials.jenkov.com/svg/path-element.html
http://en.wikipedia.org/wiki/Heptagon
---
கட்டாற்று வெள்ளத்தால்
தான்தோன்றீ
இதமான sulal
 
சலசலப்பு
கமகமக்கும்
திருப்பரங்குன்றம், திருச்செந்தூர், பழநி, சுவாமிமலை, திருத்தணி, சோலைமலை
---
static string ReplaceHexadecimalSymbols(string txt)
    {
        string r = "[\x00-\x08\x0B\x0C\x0E-\x1F\x26]";
        return Regex.Replace(txt, r, "", RegexOptions.Compiled);
    }

input.Replace((char)(0x1F), ' ');

http://seattlesoftware.wordpress.com/2008/09/11/hexadecimal-value-0-is-an-invalid-character/
http://stackoverflow.com/questions/21053138/c-sharp-hexadecimal-value-0x12-is-an-invalid-character/
---
http://blogs.msdn.com/b/microsoft_press/archive/2012/05/04/free-ebooks-great-content-from-microsoft-press-that-won-t-cost-you-a-penny.aspx
http://www.youtube.com/watch?v=mhAhMwbI9rw
 
http://www.apptix.com/support/mobile/mobile-device-manager-(mdm)/mdm-windows8-user-guide.aspx
 
https://expertcentre.nokia.com/en/downloads/docs/Pages/Webinar-Mobile-Device-Management-(MDM)-for-Nokia-Lumia-Windows-Phone-8.aspx#.UidIWfmJW6M
 
http://blogs.msdn.com/b/jdupuy/archive/2013/03/11/windows-phone-8-company-hub-development.aspx
 
http://www.brianmadden.com/blogs/brianmadden/archive/2013/06/20/windows-8-1-will-add-mdm-based-management-options-confirming-active-directory-is-not-for-device-management-anymore.aspx
http://technet.microsoft.com/en-US/windows/dn140266.aspx
 
http://technet.microsoft.com/library/jj733640.aspx
http://technet.microsoft.com/en-us/library/jj884158.aspx
 
http://msdn.microsoft.com/en-us/library/windowsphone/develop/jj207248(v=vs.105).aspx
http://msdn.microsoft.com/en-us/library/windowsphone/develop/windows.applicationmodel.package.launch.aspx
http://msdn.microsoft.com/en-us/library/windowsphone/develop/jj206943(v=vs.105).aspx
http://msdn.microsoft.com/en-us/library/windowsphone/develop/jj720571(v=vs.105).aspx
http://technet.microsoft.com/en-us/library/jj884158.aspx
http://technet.microsoft.com/library/jj733640.aspx
 
http://msdn.microsoft.com/en-us/library/bb737226.aspx
 
http://msdn.microsoft.com/en-us/library/windowsphone/develop/jj206943(v=vs.105).aspx
---
05-Nov-2013

Protocol Version Issue
http://en.wikipedia.org/wiki/Exchange_ActiveSync
http://en.wikipedia.org/wiki/Comparison_of_Exchange_ActiveSync_clients

Protocol Support Powershell
Get-ExchangeServer
http://technet.microsoft.com/en-us/library/bb123873(v=exchg.150).aspx
http://www.computerperformance.co.uk/exchange2010/powershell_get_exchangeserver.htm
http://technet.microsoft.com/en-us/library/ee176949.aspx
https://www.simple-talk.com/sysadmin/exchange/identifying-exchange-activesync-users-with-powershell/
http://www.techrepublic.com/blog/10-things/10-fundamental-concepts-for-powershell-scripting/
http://help.outlook.com/en-us/140/Gg985420.aspx
http://technet.microsoft.com/en-us/magazine/hh528526.aspx
http://technet.microsoft.com/en-us/library/ee176830.aspx
---
http://gauntlt.org/
DevSecOps
https://ballerina.io
https://www.scmagazine.com/two-factor-authentication-hackable/article/765135/
https://dzone.com/articles/docker-is-dead
https://www.youtube.com/playlist?list=PLkA60AVN3hh-3AptxKmxEKGPjdfwa87mU
http://www.romanpichler.com/blog/10-tips-writing-good-user-stories/
http://cloud.rohitkelapure.com/2015/07/migrating-websphere-application-server.htm
https://github.com/Pivotal-Field-Engineering/DevNexus2017
https://github.com/Pivotal-Field-Engineering/pcf-workspace-devops
https://github.com/Pivotal-Field-Engineering/PCF-Ops-Workshop
https://github.com/Pivotal-Field-Engineering/cf-bosh-workshop
http://www.theverge.com/tldr/2016/5/4/11593084/dont-get-busted-copying-code-from-stack-overflow​
http://techcrunch.com/2014/02/27/apple-explains-exactly-how-secure-imessage-really-is/?ncid=rss
https://www.udacity.com/course/cs262?utm_source=sendgrid&utm_medium=email&utm_campaign=november
http://www.git-tower.com/learn/version-control-best-practices.html
HTTP_X_FORWARDED_FOR
https://github.com/VenkateshSrini

Goals
I will keep below as always
Passion about programming.
Quality coding.
Enthusiasm over exploring new technologies with research oriented mind.
Knowledge sharing and helping the team.
Ownership and responsibility on tasks.