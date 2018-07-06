using System;
using static System.Console;

namespace Cli
{
    class Types
    {
      internal void Print()
      {
          WriteLine($"| Name | MinValue | MaxValue | Type |");
          WriteLine($"| --- | --- | --- | --- |");
          WriteLine($"| sbyte | {sbyte.MinValue} | {sbyte.MaxValue} | {typeof(sbyte)} |");
          WriteLine($"| byte | {byte.MinValue} | {byte.MaxValue} | {typeof(byte)} |");
          WriteLine($"| short | {short.MinValue} | {short.MaxValue} | {typeof(short)} |");
          WriteLine($"| ushort | {ushort.MinValue} | {ushort.MaxValue} | {typeof(ushort)} |");
          WriteLine($"| int | {int.MinValue} | {int.MaxValue} | {typeof(int)} |");
          WriteLine($"| uint | {uint.MinValue} | {uint.MaxValue} | {typeof(uint)} |");
          WriteLine($"| long | {long.MinValue} | {long.MaxValue} | {typeof(long)} |");
          WriteLine($"| ulong | {ulong.MinValue} | {ulong.MaxValue} | {typeof(ulong)} |");
          WriteLine($"| float | {float.MinValue} | {float.MaxValue} | {typeof(float)} |");
          WriteLine($"| double | {double.MinValue} | {double.MaxValue} | {typeof(double)} |");
          WriteLine($"| decimal | {decimal.MinValue} | {decimal.MaxValue} | {typeof(decimal)} |");
          PrintWithoutENotation(float.MaxValue);;
          PrintWithoutENotation(double.MaxValue);
      }

      internal void PrintWithoutENotation(object o)
      {
        WriteLine($"{o} = {o:#}");
      }
    }
}
