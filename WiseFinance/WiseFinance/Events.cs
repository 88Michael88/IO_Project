using System;

namespace WiseFinance
{
    public abstract record Event(Guid StreamId, DateTime OccurredOn);
    
    public record WalletCreated(
        Guid WalletId,
        Guid OwnerId,
        string Currency
    ) : Event(WalletId, DateTime.UtcNow);
    
    public record IncomeRecorded(
        Guid WalletId,
        decimal Amount,
        string Category,
        string Description
    ) : Event(WalletId, DateTime.UtcNow);
    
    public record ExpenseRecorded(
        Guid WalletId,
        decimal Amount,
        string Category,
        string Description
    ) : Event(WalletId, DateTime.UtcNow);
}