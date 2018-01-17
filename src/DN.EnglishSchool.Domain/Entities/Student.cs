using DN.EnglishSchool.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace DN.EnglishSchool.Domain.Entities
{
    public class Student
    {
        public Guid StudentId { get; set; }
        public string RegisterNumber { get; set; }
        public string Name { get; set; }
        public User User { get; set; }
        public StatusStudent StatusStudent { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
