using System;
using System.Text;

namespace Common.Core
{
  public class DateFormat
  {
    public static string Print()
    {
      StringBuilder sb = new StringBuilder();
      DateTimeOffset dateTimeOffset = new DateTimeOffset(DateTime.Now);
      DateTime dateTime = DateTime.Now;

      sb.AppendLine("# C# Date & Time");
      sb.AppendLine("## DateTime vs DateTimeOffset");
      sb.AppendLine("| DateTime | DateTimeOffset |");
      sb.AppendLine("|---|---|");
      sb.AppendLine("| absolute time - ambiguous | instantaneous time - unambiguous");
      sb.AppendLine("| " + dateTime.ToString() + "| " + dateTimeOffset.ToString() + "|");

      // Date time formatting
      string[] standardSpecifiers = {
          "d", //short date
          "D", //long date
          "f", //full date short time
          "F", //full date full time
          "g", //general date short time
          "G", //general date long time
          "m", //month-day
          "M", //month-day
          "o", //round-trip
          "O", //round-trip
          "r", //RFC1123
          "R", //RFC1123
          "s", //sortable
          "t", //short time
          "T", //long time
          "u", //universal shortable
          "y", //year-month
          "Y", //year-month
      };

      string[] customSpecifiers = {
          "d", //day
          "dd", //day-zero pad
          "ddd",
          "dddd",
          "f", //milliseconds
          "ff",
          "fff",
          "ffff",
          "fffff",
          "ffffff",
          "F", //milliseconds-non-zero
          "FF",
          "FFF",
          "FFFF",
          "FFFFF",
          "FFFFFF",
          "g", //period/era
          "h",
          "hh",
          "H",
          "HH",
          "K", //time zone
          "m", //minute
          "mm",
          "M", //month
          "MM",
          "MMM",
          "MMMM",
          "s", //seconds
          "ss",
          "t", //A/P
          "tt", //AM/PM
          "y", //year
          "yy",
          "yyy",
          "yyyy",
          "yyyyy",
          "z",
          "zz",
          "zzz"
      };
      sb.AppendLine();

      sb.AppendLine("## Standard Formatting");
      sb.AppendLine("| Specifier | Value |");
      sb.AppendLine("|---|---|");
      foreach (string s in standardSpecifiers)
          sb.AppendLine("| " + s + " | " + dateTimeOffset.ToString(s) + " |");
      sb.AppendLine();
      
      sb.AppendLine("## Custom Formatting");
      sb.AppendLine("| Specifier | Value |");
      sb.AppendLine("|---|---|");
      foreach (string s in customSpecifiers)
          sb.AppendLine("| " + s + " | " + dateTimeOffset.ToString(" "+s ) + " |");

      return sb.ToString();
    }
  }
}