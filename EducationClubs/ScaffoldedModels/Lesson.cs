﻿namespace EducationClubs.ScaffoldedModels;

public partial class Lesson
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public TimeSpan? TimeStart { get; set; }

    public TimeSpan? TimeFinish { get; set; }

    public int? AdditionalClassId { get; set; }

    public int? DayOfWeekId { get; set; }

    public virtual AdditionalClass? AdditionalClass { get; set; }

    public virtual ICollection<Attendence> Attendences { get; set; } = new List<Attendence>();

    public virtual DayOfWeek? DayOfWeek { get; set; }
}
