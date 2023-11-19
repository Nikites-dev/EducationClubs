using System;
using EducationClubs.ScaffoldedModels;

namespace EducationClubs.Services
{
    public class AppGeneralSettings
    {
        public Account? authAccount { get; set; }
        public Tutor? AuthTutor { get; set; }
        public bool Edit { get; set; }
    }
}