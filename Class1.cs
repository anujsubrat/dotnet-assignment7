using System;
using TaxLibrary;

class Program
{
    static void Main()
    {
        TaxCalculator obj = new TaxCalculator();

        double income = 1200000;

        double oldTax = obj.CalculateOldTax(income);
        double newTax = obj.CalculateNewTax(income);

        Console.WriteLine("Employee Income: " + income);

        Console.WriteLine("Old Regime Tax: " + oldTax);

        Console.WriteLine("New Regime Tax: " + newTax);

        Console.ReadLine();
    }
}