using System;
using System.Collections.Generic;

namespace EducationClubs.ScaffoldedModels;

public partial class Record
{
    public int Id { get; set; }

    public bool? Active { get; set; }

    public int? AdditionalClassId { get; set; }

    public int? StudentId { get; set; }

    public virtual AdditionalClass? AdditionalClass { get; set; }

    public virtual Student? Student { get; set; }
}
