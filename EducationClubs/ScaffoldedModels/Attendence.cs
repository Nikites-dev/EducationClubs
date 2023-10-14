using System;
using System.Collections.Generic;

namespace EducationClubs.ScaffoldedModels;

public partial class Attendence
{
    public int Id { get; set; }

    public bool? IsAttend { get; set; }

    public int? StudentId { get; set; }

    public int? LessonId { get; set; }

    public virtual Lesson? Lesson { get; set; }

    public virtual Student? Student { get; set; }
}
