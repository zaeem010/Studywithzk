using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Studywithzk.Models
{
    public class RoleClaim : IdentityRoleClaim<int>
    {
        public string Description { get; set; }
        public string Group { get; set; }
        [ForeignKey("RoleId")]
        public Role Role { get; set; }
       
        [NotMapped]
        public bool Selected { get; set; }
    }
}
