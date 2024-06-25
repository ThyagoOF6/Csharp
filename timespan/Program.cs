using System;

namespace timespan {
    class Program {
        static void Main(string[] args) {

            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(900000000L);
            TimeSpan t3 = new TimeSpan(2, 11, 21);
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);
            TimeSpan t6 = new TimeSpan.FromDays(1.5);
            TimeSpan t7 = new TimeSpan.FromHours(1.5);
            TimeSpan t8 = new TimeSpan.FromMinutes(1.5);
            TimeSpan t9 = new TimeSpan.FromSeconds(1.5);
            TimeSpan t10 = new TimeSpan.FromMilliseconds(1);
            TimeSpan t11 = new TimeSpan.FromTicks(900000000L);

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);
            Console.WriteLine(t7);
            Console.WriteLine(t8);
            Console.WriteLine(t9);
            Console.WriteLine(t10);
            Console.WriteLine(t11);
        }
    }
}