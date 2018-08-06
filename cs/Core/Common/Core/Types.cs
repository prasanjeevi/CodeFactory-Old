using System;
using System.Text;

namespace Common.Core
{
  public class Types
  {
    public static string Print()
    {
      StringBuilder sb = new StringBuilder();
      // Numeric
      sb.AppendLine("| Name | MinValue | MaxValue | Type |");
      sb.AppendLine("|---|---|---|---|");
      sb.AppendLine($"| sbyte | {sbyte.MinValue} | {sbyte.MaxValue} | {typeof(sbyte)} |");
      sb.AppendLine($"| byte | {byte.MinValue} | {byte.MaxValue} | {typeof(byte)} |");
      sb.AppendLine($"| short | {short.MinValue} | {short.MaxValue} | {typeof(short)} |");
      sb.AppendLine($"| ushort | {ushort.MinValue} | {ushort.MaxValue} | {typeof(ushort)} |");
      sb.AppendLine($"| int | {int.MinValue} | {int.MaxValue} | {typeof(int)} |");
      sb.AppendLine($"| uint | {uint.MinValue} | {uint.MaxValue} | {typeof(uint)} |");
      sb.AppendLine($"| long | {long.MinValue} | {long.MaxValue} | {typeof(long)} |");
      sb.AppendLine($"| ulong | {ulong.MinValue} | {ulong.MaxValue} | {typeof(ulong)} |");
      // Floating point
      sb.AppendLine($"| decimal | {decimal.MinValue} | {decimal.MaxValue} | {typeof(decimal)} |");
      sb.AppendLine($"| float | {float.MinValue} | {float.MaxValue} | {typeof(float)} |");
      sb.AppendLine($"| double | {double.MinValue} | {double.MaxValue} | {typeof(double)} |");
      // Non-Numeric
      sb.AppendLine($"| bool | {bool.FalseString} | {bool.TrueString} | {typeof(bool)} |");
      sb.AppendLine($"| char |  |  | {typeof(char)} |");

      sb.AppendLine($"| string |  |  | {typeof(string)} |");
      sb.AppendLine($"| object |  |  | {typeof(object)} |");
      sb.AppendLine("| dynamic |  |  |  |");
      sb.AppendLine();
      sb.AppendLine(PrintWithoutENotation(float.MaxValue));
      sb.AppendLine(PrintWithoutENotation(double.MaxValue));

      return sb.ToString();
    }

    public static string PrintWithoutENotation(object o) => $"{o} = {o:#}";
  }
}
