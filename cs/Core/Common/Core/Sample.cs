using System.Data;

namespace Common.Core
{
  public class Sample
  {
    public static string GetMessage()
    {
      return "Hello World!";
    }

    public static string GetMessage(string name)
    {
      return $"Hello {name}!";
    }

    public static int Add(int number1, int number2)
    {
      return number1 + number2;
    }

    public static void CreateDataTable()
    {
      DataTable dt = new DataTable();
      DataColumn dc1 = new DataColumn("Name", typeof(string));
      DataColumn dc2 = new DataColumn("Age", typeof(int));
      dt.Columns.Add(dc1);
      dt.Columns.Add(dc2);
      dt.Rows.Add("Sanjeevi", 29);
      dt.Rows.Add("Prasanna", 31);

      foreach (DataRow row in dt.Rows)
      {
        //row["Age"]
      }
    }
  }
}