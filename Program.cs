using System;
using Intro.Utils;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Clear();
            var g = new Game();
            g.Start();
        }

        private static void IntroDemo()
        {
            var sp = new ScreenPrinter();

            sp.print("Hello World!");

            var x = 7.02802380493288432m;
            var y = x / 2;
            decimal z = x / 2.0m;

            x = 8.0m;

            // for number types
            // int
            // decimal
            // ---use these ^^^^ --- not those vvv -----------------
            // int16
            // int32
            // int64
            // uint
            // long
            // ulong
            // tinyint bool 
            // float === number in unity
            // double

            // $ = string interpolation
            // @ = multiline
            sp.print($@"
                z: {z} 
                y: {y}
            ");

            sp.print("y: " + y);
            sp.print(z.ToString());

            var calc = new Calculator();
            var a = calc.Add((int)z, 10);
            sp.print($"a: {a}");

            // for (int i = 1; i <= 10; i++)
            // {
            //     sp.print(i);
            // }

            Console.Clear();
            Console.WriteLine("Okay.... bye Felicia");
        }
    }
}
