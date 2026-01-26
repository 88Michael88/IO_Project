using System;

namespace WiseFinance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" WISE FINANCE: START ");

            var ownerId = Guid.NewGuid();
            var wallet = Wallet.Create(ownerId, "PLN");

            Console.WriteLine($"Utworzono portfel o ID: {wallet.Id}");
            Console.WriteLine($"Właściciel: {wallet.OwnerId}");
            Console.WriteLine($"Waluta: {wallet.Currency}");
            
            Console.ReadKey();
        }
    }
}