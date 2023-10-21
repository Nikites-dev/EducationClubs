using System;
using System.Collections.Generic;

namespace EducationClubs.TestModels;

public partial class Student
{
    public int Id { get; set; }

    public string? Surname { get; set; }

    public string? Name { get; set; }

    public string? Patronymic { get; set; }

    public virtual ICollection<Attendence> Attendences { get; set; } = new List<Attendence>();
}
