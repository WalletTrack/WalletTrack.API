using System.Data;
using WalletTrack.Domain.Enums;

namespace WalletTrack.Domain.Entitites;

public class User
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Username { get; set; } = null!;
    public string Email { get; set; } = null!;
    public DateOnly BirthDate { get; set; }
    public byte[] PasswordHash { get; set; } = [];
    public byte[] PasswordSalt { get; set; } = [];
    public Gender Gender { get; set; }
    public bool IsDeleted { get; set; }
}

