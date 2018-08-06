# C# Date & Time
## DateTime vs DateTimeOffset
| DateTime | DateTimeOffset |
|---|---|
| absolute time - ambiguous | instantaneous time - unambiguous
| 06/08/2018 10:16:38| 06/08/2018 10:16:38 +05:30|

## Standard Formatting
| Specifier | Value |
|---|---|
| d | 06/08/2018 |
| D | Monday, 6 August 2018 |
| f | Monday, 6 August 2018 10:16 |
| F | Monday, 6 August 2018 10:16:38 |
| g | 06/08/2018 10:16 |
| G | 06/08/2018 10:16:38 |
| m | 6 August |
| M | 6 August |
| o | 2018-08-06T10:16:38.0569290+05:30 |
| O | 2018-08-06T10:16:38.0569290+05:30 |
| r | Mon, 06 Aug 2018 04:46:38 GMT |
| R | Mon, 06 Aug 2018 04:46:38 GMT |
| s | 2018-08-06T10:16:38 |
| t | 10:16 |
| T | 10:16:38 |
| u | 2018-08-06 04:46:38Z |
| y | August 2018 |
| Y | August 2018 |

## Custom Formatting
| Specifier | Value |
|---|---|
| d |  6 |
| dd |  06 |
| ddd |  Mon |
| dddd |  Monday |
| f |  0 |
| ff |  05 |
| fff |  056 |
| ffff |  0569 |
| fffff |  05692 |
| ffffff |  056929 |
| F |   |
| FF |  05 |
| FFF |  056 |
| FFFF |  0569 |
| FFFFF |  05692 |
| FFFFFF |  056929 |
| g |  AD |
| h |  10 |
| hh |  10 |
| H |  10 |
| HH |  10 |
| K |  +05:30 |
| m |  16 |
| mm |  16 |
| M |  8 |
| MM |  08 |
| MMM |  Aug |
| MMMM |  August |
| s |  38 |
| ss |  38 |
| t |  a |
| tt |  am |
| y |  18 |
| yy |  18 |
| yyy |  2018 |
| yyyy |  2018 |
| yyyyy |  02018 |
| z |  +5 |
| zz |  +05 |
| zzz |  +05:30 |
