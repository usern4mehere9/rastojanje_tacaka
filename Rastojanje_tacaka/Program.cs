using System;

namespace Rastojanje_tacaka
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2;
            double raz, Xaux, Yaux ,aux;

            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());

            Xaux = (x2 - x1) * (x2 - x1);
            Yaux = (y2 - y1) * (y2 - y1);
            aux = Yaux + Xaux;

            raz = Math.Sqrt(aux);

            Console.WriteLine(Math.Round(raz, 5));
        }
    }
}
