#region

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

#endregion

namespace TinyShop.Data {
    [Table("Identity_Users")]
    public class UserEntity : IdentityUser<long> {
        public string Password { get; set; }

        // 明文密码（仅限于向 Controller 传值，不映射到数据库）
        [NotMapped] [StringLength(100)] public string PasswordPlain { get; set; }
    }
}