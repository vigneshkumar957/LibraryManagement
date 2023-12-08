using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS.DataAccess.Entities
{
    public class User : RentParticipant
    {                
        public string Password { get; set; }
        public virtual ICollection<Role> Roles { get; set; }              
    }
}
