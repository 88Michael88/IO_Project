using System;
using System.Collections.Generic;
using System.Linq;

namespace WiseFinance
{
    class Program
    {
        static readonly List<Event> _eventStore = new();

        static void Main(string[] args)
        {
            Console.WriteLine("= WISE FINANCE EVENT SOURCING =");
            
            var ownerId = Guid.NewGuid();
            var wallet = Wallet.Create(ownerId, "PLN");
            SaveToDatabase(wallet);

            Console.WriteLine("\nUżytkownik dodaje transakcje...");
            
            wallet.RegisterIncome(4500, "Wynagrodzenie", "Wypłata z korporacji");
            wallet.RegisterExpense(250, "Paliwo", "Tankowanie Orlen");
            wallet.RegisterExpense(40, "Rozrywka", "Kino z dziewczyną");
            
            SaveToDatabase(wallet);

            Console.WriteLine($"\nStan w pamięci (Przed usunięciem): {wallet.Balance} PLN");
            
            var walletId = wallet.Id;
            wallet = null; 
            
            Console.WriteLine("\n= RESTART SYSTEMU / CZYSZCZENIE PAMIĘCI =");
            Console.WriteLine("Obiekt 'wallet' jest teraz null.");
            
            Console.WriteLine("\nPobieranie historii zdarzeń z bazy...");

            var history = _eventStore
                .Where(e => e.StreamId == walletId)
                .OrderBy(e => e.OccurredOn)
                .ToList();

            var restoredWallet = Wallet.LoadFromHistory(history);

            Console.WriteLine("\n= ODTWORZONY PORTFEL =");
            Console.WriteLine($"ID Portfela: {restoredWallet.Id}");
            Console.WriteLine($"Właściciel: {restoredWallet.OwnerId}");
            Console.WriteLine($"Aktualne Saldo: {restoredWallet.Balance} {restoredWallet.Currency}");

            Console.WriteLine("\n-------- HISTORIA TRANSAKCJI -------");
            foreach (var evt in history)
            {
                if (evt is WalletCreated)
                    Console.WriteLine($"[{evt.OccurredOn:HH:mm:ss}] Utworzono portfel.");
                else if (evt is IncomeRecorded inc)
                    Console.WriteLine($"[{evt.OccurredOn:HH:mm:ss}] PRZYCHÓD: +{inc.Amount} ({inc.Category})");
                else if (evt is ExpenseRecorded exp)
                    Console.WriteLine($"[{evt.OccurredOn:HH:mm:ss}] WYDATEK:  -{exp.Amount} ({exp.Category})");
            }

            Console.ReadKey();
        }
        
        static void SaveToDatabase(Wallet wallet)
        {
            var changes = wallet.GetChanges().ToList(); 
    
            _eventStore.AddRange(changes);
            wallet.ClearChanges(); 
            
            Console.WriteLine($"Zapisano {changes.Count} nowych zdarzeń w bazie.");
        }
    }
}