﻿using System;
using System.Collections.Generic;

namespace EducationClubs.ScaffoldedModels;

public partial class Account
{
    public int Id { get; set; }

    public string? Login { get; set; }

    public string? Password { get; set; }

    public int? RoleId { get; set; }

    public virtual Role? Role { get; set; }

    public virtual ICollection<Tutor> Tutors { get; set; } = new List<Tutor>();
}
