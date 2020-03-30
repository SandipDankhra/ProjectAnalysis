using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Scaffold_TestApp.Models
{
    public partial class Users
    {
        public Users()
        {
            UserDetails = new HashSet<UserDetails>();
        }

        [Key]
        public int UserId { get; set; }
        [StringLength(50)]
        public string UserName { get; set; }

        [InverseProperty("User")]
        public virtual ICollection<UserDetails> UserDetails { get; set; }
    }
}
