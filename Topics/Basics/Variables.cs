namespace Topics.Basics;

public static class Variables
{
    public static void Practice()
    {
        // Literals();
        // Task2();
        // Task3();
    }

    static void Literals()
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
        var xx = 2;
        var yy = Convert.ToDouble(xx);
        Console.WriteLine("Converted value: {0} Type: {1}", yy, yy.GetType());
        
        var val = -10;
        var boolVal = Convert.ToBoolean(val);
        Console.WriteLine(boolVal);
        try
        {
            var strVal = "Hello";
            var input = Convert.ToInt32(strVal);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        
        // Continued after try-catch block
        Console.WriteLine("Continued");
        var str2 = "0";
        var boolVal2 = Convert.ToBoolean(int.Parse(str2));
        Console.WriteLine(boolVal2);

        int p = Convert.ToInt32("3");
        int y = p++;
        Console.WriteLine($"{p} {y}");
        
    }

    static void Task2()
    {
        var sisters = 4;
        int gatheredEggs, sisterEggs, duckbearEggs;
        
        Console.WriteLine("Enter number of collected eggs:");
        gatheredEggs = Convert.ToInt32(Console.ReadLine());
        sisterEggs = gatheredEggs / sisters;
        duckbearEggs = gatheredEggs % sisters;
        Console.WriteLine("Between {0} eggs Each sister got {1} & duckbear got {2} eggs\n", gatheredEggs, sisterEggs, duckbearEggs);
        
        for (var eggs = 0; eggs / sisters < sisters - 1; eggs++)
        {
            sisterEggs = eggs / sisters;
            duckbearEggs = eggs % sisters;
            if (sisterEggs < duckbearEggs)
            {
                Console.WriteLine("Between {0} eggs Each sister got {1} & duckbear got {2} eggs", eggs, sisterEggs, duckbearEggs);
                
            }
        }
    }

    static void Task3()
    {
        int melikTotalPoint, cesikTotalPoint, balikTotalPoint;
        int[] melik, cesik, balik;
        int estate = 1, duchies = 3, province = 6; // Valid: all are int
        melik = userInput("melik").Split(" ").Select(int.Parse).ToArray();
        cesik = userInput("cesik").Split(" ").Select(int.Parse).ToArray();
        balik = userInput("balik").Split(" ").Select(int.Parse).ToArray();
        melikTotalPoint = melik[0]*estate + melik[1]*duchies + melik[2]*province;
        cesikTotalPoint = cesik[0]*estate + cesik[1]*duchies + cesik[2]*province;
        balikTotalPoint = balik[0]*estate + balik[1]*duchies + balik[2]*province;
        if (melikTotalPoint > balikTotalPoint)
        {
            if (melikTotalPoint > cesikTotalPoint)
            {
                Console.WriteLine("Melik is the True king with point {0}", melikTotalPoint);
            }
            else
            {
                Console.WriteLine("Cesik is the True king with point {0}", cesikTotalPoint);
            }
        }else if (balikTotalPoint > cesikTotalPoint)
        {
            Console.WriteLine("Balik is the True king with point {0}", balikTotalPoint);
        }
        else
        {
            Console.WriteLine("Cesik is the True king with point {0}", cesikTotalPoint);
        }
        string userInput(string user)
        {
            Console.WriteLine("Enter {0}'s number of state, duchies and provice: ", user);
            string? input = Console.ReadLine();
            return input;
        }
    }

    
}