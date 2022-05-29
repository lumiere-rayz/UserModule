using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserModule.Authorization.Users
{
    public class ExtendedUser : User
    {
        public virtual string Phone { get; set; }
        public virtual string Gender { get; set; }
        public virtual DateTime DateOfBirth { get; set; }
        public virtual string Nationality { get; set; }
    }
}
