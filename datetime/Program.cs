using System;
using System.Globalization;

namespace datetime {
    class Program {
        static void Main(string[] args) {

            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);

            DateTime d2 = new DateTime(2000, 8, 15);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);
            DateTime d4 = new DateTime(2000, 8, 15, 13, 5, 58, 275);

            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);

            DateTime d5 = DateTime.Now;
            DateTime d6 = DateTime.UtcNow;
            DateTime d7 = DateTime.Today;

            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);

            DateTime d8 = DateTime.Parse("2000-08-15");
            DateTime d9 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d10 = DateTime.Parse("15/08/2000");
            DateTime d11 = DateTime.Parse("15/08/2000 13:05:58");

            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);
            Console.WriteLine(d11);

            DateTime d12 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);

            DateTime d13 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(d12);
            Console.WriteLine(d13);

        }
    }
}