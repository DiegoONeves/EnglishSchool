using DN.EnglishSchool.Domain.ValueObjects;
using System;
using System.Collections.Generic;

namespace DN.EnglishSchool.Domain.Entities
{
    public class SchoolClass
    {
        public Guid SchoolClassId { get; set; }
        public string ClassName { get; set; }
        public Teacher Teacher { get; set; }
        public ICollection<Student> Studenties { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public StatusClass StatusClass { get; set; }


        public override string ToString()
        {
            return ClassName;
        }

    }
}
