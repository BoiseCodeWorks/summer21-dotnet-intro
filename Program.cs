using System;
using System.Collections.Generic;
using Intro.Utils;

namespace Intro
{

    class Cat
    {
        public string Name { get; set; }
        public Cat(string name)
        {
            Name = name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            // var cats = new List<Cat>();
            // var garfield = new Cat("Garfield");
            // cats.Add(garfield);
            // cats.Remove(garfield);
            // cats.RemoveAt(0);
            // var cats = []


            var users = new Dictionary<string, string>();

            users.Add("joverall", "testing123!");
            users.Add("jimmyTester", "!notTesting1");


            // { joverall: 'testing123!', jimmyTester: "!notTesting1" }


            System.Console.WriteLine("welcome please login");
            var username = Console.ReadLine();

            if (users.ContainsKey(username))
            {
                System.Console.WriteLine("What is your password? ");
                var password = Console.ReadLine();

                users.TryGetValue(username, out string savedPassword);

                if (savedPassword == password)
                {
                    System.Console.WriteLine("welcome you have succesfully logged in");
                }
                else
                {
                    System.Console.WriteLine("Wrong password");
                }
            }
            else
            {
                System.Console.WriteLine("invalid username");
            }




        }

        private static void StartGame()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Clear();
            var g = new Game();
            g.Start();
            Console.ResetColor();
            Console.Clear();
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
