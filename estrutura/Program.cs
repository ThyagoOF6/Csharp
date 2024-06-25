using System;

namespace estrutura
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var p1 = new Product("Laptop", 1000.0, 5);
            var p2 = new Product("Headphones", 200.0, 2);

            var total1 = p1.total;
            var total2 = p2.total;

            Console.WriteLine(p1);
            Console.WriteLine(p2);  

            p1.updatePrice(10.0);
            Console.WriteLine(p1.Price);
        }
    }
}