using System;
using System.Collections.Generic;

namespace WiseFinance
{
    public class Wallet
    {
        public Guid Id { get; private set; }
        public Guid OwnerId { get; private set; }
        public string Currency { get; private set; }
        
        public decimal Balance { get; private set; } = 0;

        private readonly List<Event> _changes = new();

        private Wallet() { }

        public static Wallet Create(Guid ownerId, string currency)
        {
            var wallet = new Wallet();
            
            var evt = new WalletCreated(Guid.NewGuid(), ownerId, currency);
            
            // TODO: logika nakladania zdarzenia
            wallet.Id = evt.WalletId;
            wallet.OwnerId = evt.OwnerId;
            wallet.Currency = evt.Currency;
            
            wallet._changes.Add(evt);
            return wallet;
        }

        public IEnumerable<Event> GetChanges() => _changes;
    }
}