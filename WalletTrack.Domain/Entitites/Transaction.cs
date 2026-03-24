using WalletTrack.Domain.Enums;

namespace WalletTrack.Domain.Entitites;

public class Transaction
{
    public Guid Id { get;set; }
    public string Description { get; set; } = null!;
    public float Amount { get; set; }
    public DateOnly Date { get; set; }
    public MoneyType Type { get; set; }
    public Guid CategoryId { get; set; }
    public Category Category { get; set; } = null!;
    public Guid UserId { get; set; }
    public User User { get; set; } = null!;
    public Guid BudgetId { get; set; }
    public Budget Budget { get; set; } = null!;
    public bool IsDeleted { get; set; }
}
