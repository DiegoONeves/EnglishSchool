using System;
using System.Collections.Generic;

namespace DN.EnglishSchool.Domain.Entities
{
    public class User
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public ICollection<Student> Studenties { get; set; } = new List<Student>();
        public ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();

        public override string ToString()
        {
            return Email;
        }

    }
}
