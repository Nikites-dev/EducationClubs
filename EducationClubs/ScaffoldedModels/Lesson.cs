namespace EducationClubs.ScaffoldedModels;

public partial class Lesson
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? DateOfStart { get; set; }

    public string? DateOfFinish { get; set; }

    public int? AdditionalClassId { get; set; }

    public virtual AdditionalClass? AdditionalClass { get; set; }

    public virtual ICollection<Attendence> Attendences { get; set; } = new List<Attendence>();
}