using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreProject.Models
{
    public class Dependent
    {
        public int DependentId { get; set; }
        public string DependentName { get; set; }
        public string DependentSex { get; set; }
        public string DependentBirthday { get; set; }
        public string DependentRelationship { get; set; }
    }
}
