using System;
using System.Collections.Generic;
using System.Text;

namespace Remainder1
{
    class Denomination
    {
        public decimal InitialAmount { get; set; } = 1234.56m;

        public decimal RemainingAmount { get; set; }

        public decimal Operand { get; set; }

        public decimal OperandCount { get; set; }

        public decimal ThousandBill { get; set; }

        public decimal FiveHundredBill { get; set; }

        public decimal TwoHundredBill { get; set; }

        public decimal HundredBill { get; set; }

        public decimal FiftyBill { get; set; }

        public decimal TwentyBill { get; set; }

        public decimal TenCoin { get; set; }

        public decimal FiveCoin { get; set; }

        public decimal TwoCoin { get; set; }

        public decimal OneCoin { get; set; }

        public void CalculateDenomination(decimal denominationParameter)
        {
            decimal denominationAmount = Math.Round(denominationParameter);
            decimal operand;
            decimal remainder;

            decimal thousandBill;
            decimal fiveHundredBill;
            decimal twoHundredBill;
            decimal hundredBill;
            decimal fiftyBill;
            decimal twentyBill;
            decimal tenCoin;
            decimal fiveCoin;
            decimal twoCoin;
            decimal oneCoin;

            Console.WriteLine($"denominationAmount: {denominationAmount}");

            // Calculate how many 1000 bills.
            remainder = denominationAmount % 1000;
            operand = denominationAmount - remainder;
            denominationAmount = remainder;
            thousandBill = Math.Round(operand, 0) / 1000;
            Console.WriteLine($"denominationAmount: {denominationAmount} thousandBill: {thousandBill} operand: {operand} reminder: {remainder}");

            // Calculate how many 500 bills.
            remainder = denominationAmount % 500;
            operand = denominationAmount - remainder;
            denominationAmount = remainder;
            fiveHundredBill = Math.Round(operand, 0) / 500;
            Console.WriteLine($"denominationAmount: {denominationAmount} fiveHundredBill: {fiveHundredBill} operand: {operand} reminder: {remainder}");

            // Calculate how many 200 bills.
            remainder = denominationAmount % 200;
            operand = denominationAmount - remainder;
            denominationAmount = remainder;
            twoHundredBill = Math.Round(operand, 0) / 200;
            Console.WriteLine($"denominationAmount: {denominationAmount} twoHundredBill: {twoHundredBill} operand: {operand} reminder: {remainder}");

            // Calculate how many 100 bills.
            remainder = denominationAmount % 100;
            operand = denominationAmount - remainder;
            denominationAmount = remainder;
            hundredBill = Math.Round(operand, 0) / 100;
            Console.WriteLine($"denominationAmount: {denominationAmount} hundredBill: {hundredBill} operand: {operand} reminder: {remainder}");

            // Calculate how many 50 bills.
            remainder = denominationAmount % 50;
            operand = denominationAmount - remainder;
            denominationAmount = remainder;
            fiftyBill = Math.Round(operand, 0) / 50;
            Console.WriteLine($"denominationAmount: {denominationAmount} fiftyBill: {fiftyBill} operand: {operand} reminder: {remainder}");

            // Calculate how many 20 bills.
            remainder = denominationAmount % 20;
            operand = denominationAmount - remainder;
            denominationAmount = remainder;
            twentyBill = Math.Round(operand, 0) / 20;
            Console.WriteLine($"denominationAmount: {denominationAmount} twentyBill: {twentyBill} operand: {operand} reminder: {remainder}");

            // Calculate how many 10 coins.
            remainder = denominationAmount % 10;
            operand = denominationAmount - remainder;
            denominationAmount = remainder;
            tenCoin = Math.Round(operand, 0) / 10;
            Console.WriteLine($"denominationAmount: {denominationAmount} tenCoin: {tenCoin} operand: {operand} reminder: {remainder}");

            // Calculate how many 5 coins.
            remainder = denominationAmount % 5;
            operand = denominationAmount - remainder;
            denominationAmount = remainder;
            fiveCoin = Math.Round(operand, 0) / 5;
            Console.WriteLine($"denominationAmount: {denominationAmount} fiveCoin: {fiveCoin} operand: {operand} reminder: {remainder}");

            // Calculate how many 2 coins.
            remainder = denominationAmount % 2;
            operand = denominationAmount - remainder;
            denominationAmount = remainder;
            twoCoin = Math.Round(operand, 0) / 2;
            Console.WriteLine($"denominationAmount: {denominationAmount} twoCoin: {twoCoin} operand: {operand} reminder: {remainder}");

            // Calculate how many 1 coins.
            remainder = denominationAmount % 1;
            operand = denominationAmount - remainder;
            denominationAmount = remainder;
            oneCoin = Math.Round(operand, 0) / 1;
            Console.WriteLine($"denominationAmount: {denominationAmount} oneCoin: {oneCoin} operand: {operand} reminder: {remainder}");
        }
    }
}
