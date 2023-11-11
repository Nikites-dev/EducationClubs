using System;
using System.Collections.Generic;

namespace EducationClubs.ScaffoldedModels;

public partial class Student
{
    public int Id { get; set; }

    public string? Surname { get; set; }

    public string? Name { get; set; }

    public string? Patronymic { get; set; }

    public virtual ICollection<Attendence> Attendences { get; set; } = new List<Attendence>();

    public virtual ICollection<Record> Records { get; set; } = new List<Record>();
}
