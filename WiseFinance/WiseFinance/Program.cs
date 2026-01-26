using System;

namespace WiseFinance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("= WISE FINANCE: TEST LOGIKI =");

            var wallet = Wallet.Create(Guid.NewGuid(), "PLN");
            Console.WriteLine($"Saldo początkowe: {wallet.Balance} {wallet.Currency}");
            
            Console.WriteLine("\n--> Dodaję wypłatę...");
            wallet.RegisterIncome(5000, "Wynagrodzenie", "Wypłata za styczeń");

            Console.WriteLine("--> Płacę za zakupy...");
            wallet.RegisterExpense(150.50m, "Jedzenie", "Zakupy w Biedronce");

            Console.WriteLine("--> Płacę czynsz...");
            wallet.RegisterExpense(2000, "Mieszkanie", "Czynsz + media");

            Console.WriteLine($"\nAKTUALNE SALDO: {wallet.Balance} {wallet.Currency}");
            Console.ReadKey();
        }
    }
}