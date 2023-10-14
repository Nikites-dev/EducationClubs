namespace EducationClubs.ScaffoldedModels;

public partial class Role
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();
}