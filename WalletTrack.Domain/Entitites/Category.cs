using WalletTrack.Domain.Enums;

namespace WalletTrack.Domain.Entitites;

public class Category
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public MoneyType Type { get; set; }
    public bool IsDeleted { get; set; }
}
