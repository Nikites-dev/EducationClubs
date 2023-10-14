namespace EducationClubs.ScaffoldedModels;

public partial class Tutor
{
    public int Id { get; set; }

    public string? Surname { get; set; }

    public string? Name { get; set; }

    public string? Patronymic { get; set; }

    public string? Image { get; set; }

    public bool? IsWorking { get; set; }

    public int? AccountId { get; set; }

    public virtual Account? Account { get; set; }

    public virtual ICollection<AdditionalClass> AdditionalClasses { get; set; } = new List<AdditionalClass>();
}