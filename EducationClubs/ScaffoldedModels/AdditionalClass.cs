namespace EducationClubs.ScaffoldedModels;

public partial class AdditionalClass
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public bool? IsActive { get; set; }

    public int? TutorId { get; set; }

    public virtual ICollection<Lesson> Lessons { get; set; } = new List<Lesson>();

    public virtual ICollection<Record> Records { get; set; } = new List<Record>();

    public virtual Tutor? Tutor { get; set; }
}