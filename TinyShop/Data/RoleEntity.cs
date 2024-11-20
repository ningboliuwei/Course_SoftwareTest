#region

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

#endregion

namespace TinyShop.Data {
    [Table("Identity_Roles")]
    public class RoleEntity : IdentityRole<long> {
        // 角色描述
        [StringLength(100)] public string Description { get; set; }
    }
}