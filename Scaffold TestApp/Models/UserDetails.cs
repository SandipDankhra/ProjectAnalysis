using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Scaffold_TestApp.Models
{
    public partial class UserDetails
    {
        [Key]
        public int UserDetailId { get; set; }
        [Required]
        [StringLength(50)]
        public string UserCity { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        [Required]
        [StringLength(50)]
        public string Passowrd { get; set; }
        public int UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(Users.UserDetails))]
        public virtual Users User { get; set; }
    }
}
