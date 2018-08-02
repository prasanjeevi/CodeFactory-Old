import sys

print("| Name | MinValue | MaxValue | Type |")
print("| --- | --- | --- | --- |")
print(f"| int | {-sys.maxsize - 1} | {sys.maxsize} | {type(int)} |")
print(f"| float | {sys.float_info.min} | {sys.float_info.max} | {type(float)} |")