using System;

class CurrencyConverter
{
    static void Main()
    {
        Console.Write("Enter amount in USD: ");
        double amountUSD = double.Parse(Console.ReadLine()!);

        Console.Write("Enter exchange rate from USD to EUR: ");
        double exchangeRate = double.Parse(Console.ReadLine()!);

        double amountEUR = amountUSD * exchangeRate;

        Console.WriteLine("Amount in EUR: " + amountEUR.ToString("F2"));
    }
}