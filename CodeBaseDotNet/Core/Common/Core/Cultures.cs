using System.Globalization;
using System.Text;

namespace Common.Core
{
  public class Cultures
  {
    public static string Print()
    {
      int i = 1;
      StringBuilder sb = new StringBuilder();
      sb.AppendLine("| # | English Name | Name |");
      sb.AppendLine("|---|---|---|");
      foreach(var ci in CultureInfo.GetCultures(CultureTypes.AllCultures&~CultureTypes.NeutralCultures))
      {
        sb.AppendLine($"| {i++} | {ci.EnglishName} | {ci.Name} |");
      }
      return sb.ToString();
    }

    public static string FormatToIndianCurrency(decimal amount)
    {
      //var enIndia = new CultureInfo("en-IN");
      var enIndia = CultureInfo.GetCultureInfo("en-IN");
      return string.Format(enIndia, "{0:c}", amount);
    }
  }
}