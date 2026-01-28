using System;
using System.Collections.Generic;

namespace WiseFinance
{
    public class Wallet
    {
        public Guid Id { get; private set; }
        public Guid OwnerId { get; private set; }
        public decimal Balance { get; private set; }
        public string Currency { get; private set; }

        private readonly List<Event> _changes = new();

        private Wallet() { }

        public IEnumerable<Event> GetChanges() => _changes;
        public void ClearChanges() => _changes.Clear();

        public static Wallet Create(Guid ownerId, string currency)
        {
            var wallet = new Wallet();
            var evt = new WalletCreated(Guid.NewGuid(), ownerId, currency);
            wallet.Apply(evt);
            wallet._changes.Add(evt);
            return wallet;
        }
        
        public static Wallet LoadFromHistory(IEnumerable<Event> history)
        {
            var wallet = new Wallet();
            foreach (var evt in history)
            {
                wallet.Apply(evt);
            }
            return wallet;
        }

        public void RegisterIncome(decimal amount, string category, string description)
        {
            if (amount <= 0) throw new ArgumentException("Kwota musi być dodatnia.");
            var evt = new IncomeRecorded(Id, amount, category, description);
            Apply(evt);
            _changes.Add(evt);
        }

        public void RegisterExpense(decimal amount, string category, string description)
        {
            if (amount <= 0) throw new ArgumentException("Kwota musi być dodatnia.");
            var evt = new ExpenseRecorded(Id, amount, category, description);
            Apply(evt);
            _changes.Add(evt);
        }

        private void Apply(Event evt)
        {
            switch (evt)
            {
                case WalletCreated e:
                    Id = e.WalletId;
                    OwnerId = e.OwnerId;
                    Currency = e.Currency;
                    Balance = 0;
                    break;
                case IncomeRecorded e:
                    Balance += e.Amount;
                    break;
                case ExpenseRecorded e:
                    Balance -= e.Amount;
                    break;
            }
        }
    }
}