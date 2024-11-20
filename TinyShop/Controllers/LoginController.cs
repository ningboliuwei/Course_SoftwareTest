#region

using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TinyShop.Data;

#endregion

namespace TinyShop.Controllers {
    public class LoginController : Controller {
        private readonly SignInManager<UserEntity> _signInManager;
        private readonly UserManager<UserEntity> _userManager;

        public LoginController(SignInManager<UserEntity> signInManager, UserManager<UserEntity> userManager) {
            this._signInManager = signInManager;
            this._userManager = userManager;
        }

        // 判断用户是否已登录
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult> CheckLoginStatus() {
            // 获取当前用户
            var userName = this.User.Identity?.Name;

            if (userName == null) {
                return this.Json(new {
                    code = "fail"
                });
            }

            var user = await this._userManager.FindByNameAsync(userName);

            if (user != null) {
                // 获取用户角色
                var role = this._userManager.GetRolesAsync(user).Result[0];

                return this.Json(new {
                    code = "success",
                    data = new {
                        userName = user.UserName,
                        role
                    }
                });
            }

            return this.Json(new {
                code = "fail"
            });
        }

        public ActionResult Index() {
            return this.View();
        }

        // 额外的代码写在后面
        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> SignIn([FromBody] UserEntity entity) {
            var user = await this._userManager.FindByNameAsync(entity.UserName);

            try {
                if (user == null || !await this._userManager.CheckPasswordAsync(user, entity.PasswordPlain)) {
                    return this.Json(new {
                            code = "fail",
                            message = "错误的用户名或密码"
                        }
                    );
                }

                var result =
                    await this._signInManager.PasswordSignInAsync(user.UserName, entity.PasswordPlain, false, false);

                if (result.Succeeded) {
                    var signedUser = await this._signInManager.UserManager.FindByNameAsync(entity.UserName);
                    await this._signInManager.CreateUserPrincipalAsync(signedUser);

                    return this.Json(new {
                        code = "success"
                    });
                }

                return this.Json(new {
                    code = "fail"
                });
            }
            catch (Exception ex) {
                return this.Json(new {
                    code = "fail",
                    message = ex.Message
                });
            }
        }

        [HttpPost]
        [Authorize]
        public new async Task<ActionResult> SignOut() {
            try {
                await this._signInManager.SignOutAsync();

                return this.Json(new {
                        code = "success"
                    }
                );
            }
            catch (Exception ex) {
                return this.Json(new {
                    code = "fail",
                    message = ex.Message
                });
            }
        }
    }
}