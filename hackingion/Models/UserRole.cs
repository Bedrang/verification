using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace hackingion.Models
{
   /* [Table("UserRole")]
    public class UserRole : IdentityRole
    {

        /*[Key]
[DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
public string  Id { get; set; }
        [Display(Name = "Имя роли")]
        public string Rolename { get; set; }
        
    }
    [Table("UsersInRole")]
    public class UsersInRole
    {
        [Key, Column(Order = 0)]
        public string Id { get; set; }
        [Key, Column(Order = 1)]
        public string RoleId { get; set; }
        [ForeignKey("Id")]
        public virtual hackingion.Models.AppUser AppUsers { get; set; }
        [ForeignKey("RoleId")]
        public virtual UserRole Role { get; set; }
    }*/
    public class EditRole
    {
        [Key]
        public string UserId { get; set; }
        public string UserName { get; set; }
        public List<IdentityRole> AllRoles { get; set; }
        public IList<string> UserRoles { get; set; }
        public EditRole()
        {
            AllRoles = new List<IdentityRole>();
            UserRoles = new List<string>();
        }
    }
}
