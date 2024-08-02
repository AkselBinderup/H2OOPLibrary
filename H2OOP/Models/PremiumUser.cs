namespace H2OOP.Models;
public class PremiumUser : User
{
    public PremiumUser(string? name) : base(name)
    {
        MaximumAllowedBooks = ushort.MaxValue;
    }
}
