namespace Topics.Basics;

public static class Variables
{
    public static void Practice()
    {
        // VARIABLE DECLARATION
        var number = 0;
        var x = 10;
        x = number + x;
        Console.WriteLine("Number is: {0} and another number is {1}", number, x);

        var dNum = 5.2;
        var fNum = 2.3f;
        var isTrue = true;
        var ch = 'a';
        var str = "Hello";
        Console.WriteLine("{0} {1} {2} {3} {4} ", dNum, fNum, isTrue, ch, str);

        var age = 32;
        Console.WriteLine(age.GetType()); // shows the type of the variable
        // keywords can be usable with @ sign
        var @int = 100;
        Console.WriteLine("Keyword variable is: {0} \n", @int);

        // Type Ranges
        Console.WriteLine("Byte min max value: {0} {1}", byte.MinValue, byte.MaxValue);
        Console.WriteLine("Short min max value: {0} {1}", short.MinValue, short.MaxValue);
        Console.WriteLine("Long min max value: {0} {1}", long.MinValue, long.MaxValue);
        Console.WriteLine("Int min max value: {0} {1}", int.MinValue, int.MaxValue);
        Console.WriteLine("Boolean value: {0} {1}", bool.TrueString, bool.FalseString);

        // OVERFLOWING
        // checked
        // {
        //     byte num = 255;
        //     Console.WriteLine("byte: {0}", num);
        //     num++;
        //     Console.WriteLine("byte after (++): {0}", num);
        // }
        
        // CONVERSION
        byte smallNumber = 25;
        int intNumber = smallNumber; // implicit conversion
        Console.WriteLine("Byte -> Int: {0} {1}", intNumber, intNumber.GetType());
        smallNumber = 0;
        smallNumber = (byte)intNumber; // explicit conversion
        Console.WriteLine("Int -> Byte: {0} {1}", smallNumber, smallNumber.GetType());
        
        // Type conversion method
        int xx = 2;
        var yy = Convert.ToDouble(xx);
        Console.WriteLine("Converted value: {0} Type: {1}", yy, yy.GetType());

        int val = -10;
        var boolVal = Convert.ToBoolean(val);
        Console.WriteLine(boolVal);
        try
        {
            string strVal = "Hello";
            var input = Convert.ToInt32(strVal);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        // Continued after try-catch block
        Console.WriteLine("Continued");
        var str2 = "0";
        bool boolVal2 = Convert.ToBoolean(Int32.Parse(str2));
        Console.WriteLine(boolVal2);

        double a = 2.33445;
        int xxx = Convert.ToInt32(a);
        Console.WriteLine(xxx);
        
    }
}