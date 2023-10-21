using System;
using System.Collections.Generic;

namespace EducationClubs.TestModels;

public partial class DayOfWeek
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Lesson> Lessons { get; set; } = new List<Lesson>();
}
