using System;
using System.Collections.Generic;
using System.Text;

namespace DN.EnglishSchool.Domain.Entities
{
    public class Teacher
    {
        public Guid TeacherId { get; set; }
        public string Name { get; set; }
        public User User { get; set; }
    }
}
