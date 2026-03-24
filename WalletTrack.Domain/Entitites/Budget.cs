using WalletTrack.Domain.Enums;

namespace WalletTrack.Domain.Entitites;

public class Budget
{
    public Guid Id {  get; set; }
    public string Name { get; set; } = null!;
    public Month Month { get; set; }
    public int Year { get; set; }
    public Guid UserId { get; set; }
    public User User { get; set; } = null!;
    public bool IsFinished { get; set; }
    public bool IsDeleted { get; set; }
}
