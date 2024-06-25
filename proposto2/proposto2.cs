using System;
using System.Globalization

namespace proposto2 {
    class Program {
        static void Main(string[] args) {

           double Raio, Area, pi = 3.14159;

            Console.WriteLine("Digite o valor do raio: ");
            Raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Area = (pi * Math.Sqrt(raio));

            Console.WriteLine("A = " + Area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}