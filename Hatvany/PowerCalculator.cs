using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatvany
{
    public class PowerCalculator
    {
        public double CalculatePower(int alap, int kitevo)
        {
            double szorzat = 1;
            int hatar = kitevo;

            if (kitevo < 0) hatar *= -1;

            for (int i = 0; i < hatar; i++) szorzat = szorzat * alap;

            if (kitevo < 0) szorzat = 1 / szorzat;

            return szorzat;
        }
        static void Main(string[] args)
        {
            Console.Write("Add meg az első számot: ");
            int alap = int.Parse(Console.ReadLine());

            Console.Write("Add meg a hatványt: ");
            int kitevo = int.Parse(Console.ReadLine());

            PowerCalculator kalkulator = new PowerCalculator();

            Console.WriteLine($"Az eredmény: {kalkulator.CalculatePower(alap, kitevo)}");

            Console.ReadKey();


        }
    }
}
