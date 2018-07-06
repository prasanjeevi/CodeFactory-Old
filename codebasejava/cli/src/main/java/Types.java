import java.text.DecimalFormat;
import static java.lang.System.out;

public class Types {
    public void print() {
        out.println("| Name | MinValue | MaxValue | Type |");
        out.println("| --- | --- | --- | --- |");
        out.println("| byte | " + Byte.MIN_VALUE + " | " + Byte.MAX_VALUE + " | " + Byte.class + " |");
        out.println("| short | " + Short.MIN_VALUE + " | " + Short.MAX_VALUE + " | " + Short.class + " |");
        out.println("| int | " + Integer.MIN_VALUE + " | " + Integer.MAX_VALUE + " | " + Integer.class + " |");
        out.println("| long | " + Long.MIN_VALUE + " | " + Long.MAX_VALUE + " | " + Long.class + " |");
        out.println("| float | " + Float.MIN_VALUE + " | " + Float.MAX_VALUE + " | " + Float.class + " |");
        out.println("| double | " + Double.MIN_VALUE + " | " + Double.MAX_VALUE + " | " + Double.class + " |");
        printWithoutENotation(Float.MAX_VALUE);
        printWithoutENotation(Double.MAX_VALUE);
    }

    public void printWithoutENotation(Object o)
    {
        DecimalFormat df = new DecimalFormat("#");
        out.println(o + " = " + df.format(o));
    }
}
