using System;
using System.Collections.Generic;
using System.Text;

namespace DN.EnglishSchool.Domain.Entities
{
    public class User
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return Email;
        }

    }
}
