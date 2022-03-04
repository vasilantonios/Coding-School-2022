using System;

namespace Session_02b
{
    class MainClass
    {
        public static void Main(string[] args)
        {   // 1.
            Console.WriteLine("Hello Antonios!");

            //2.

            double num_1 = 2;
            double num_2 = 5;
            double total;
            double divi;
            Console.WriteLine(total = num_1 + num_2);
            Console.WriteLine(divi = num_1 / num_2);

            //3.
            int a = -1;
            int b = 5;
            int c = 6;
            Console.WriteLine(a+(b*c));

            int d = 38;
            int e = 5;
            int f = 7;

            Console.WriteLine(d + (e%f));

            Console.WriteLine(14 + (-3*6)/7);
            Console.WriteLine(2 + (13/6) * 6 + Math.Sqrt(7));
            Console.WriteLine((Math.Pow(6,4) + Math.Pow(5, 7)) / 9%4);

          


            //4.

            int age = 28;
            string gender = "female";

            Console.WriteLine("You are " + gender +" and your age is " +age);


            //5

            int seconds = 23455555;

            Console.WriteLine(seconds /(decimal)60);
            Console.WriteLine(seconds / ((decimal)60 * 60));
            Console.WriteLine(seconds / ((decimal)60 * 60 * 24));
            Console.WriteLine(seconds / ((decimal)60 * 60 * 24 * 365));

            //6

            TimeSpan t = TimeSpan.FromSeconds(seconds);

            

            Console.WriteLine(t.TotalMinutes);
            Console.WriteLine(t.TotalHours);
            Console.WriteLine(t.TotalDays);
            //Console.WriteLine(t.TotalYears);
            Console.WriteLine(t.TotalDays / 365);
            // Sto library den brika pouthena xrono kai den moy eftane to deadline gia na to psakso
            //to ekana etsi alla brika alla apotelesmata

            //7

            double celcius = 26;

            Console.WriteLine(celcius + 273.15);

            Console.WriteLine((celcius * 9 / 5) + 32);

        }
    }
}
