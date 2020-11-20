using System;

namespace Remainder1
{
    class Program
    {
        static void Main(string[] args)
        {
            Denomination denomination = new Denomination();

            //Console.Write("Enter amount: ");
            //denomination.InitialAmount = Convert.ToDecimal(Console.ReadLine());

            //Console.WriteLine(denomination.InitialAmount);

            //decimal denominationArgument = 9876.54m;
            decimal denominationArgument = 1888;

            // TODO: Rounding check.
            //decimal denominationArgument = 0.5m; // 0
            //decimal denominationArgument = 1.5m; // 2
            //decimal denominationArgument = 2.5m; // 2
            //decimal denominationArgument = 3.5m; // 2
            //decimal denominationArgument = 4.5m; // 2
            //decimal denominationArgument = 5.5m; // 6

            denomination.CalculateDenomination(denominationArgument);
        }
    }
}
