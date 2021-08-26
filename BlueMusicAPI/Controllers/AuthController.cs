using BlueMusicAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;


namespace BlueMusicAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthController : ApiBaseController
    {
        IAuthService _service;

        public AuthController(IAuthService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("Register")]
        [AllowAnonymous]
        public IActionResult Register(IdentityUser identityUser)
        {
            try
            {
                IdentityResult result = _service.Create(identityUser).Result;
                if (!result.Succeeded)
                    throw new Exception();
                identityUser.PasswordHash = "";
                return ApiOk(identityUser);
            }
            catch
            {
                return ApiBadRequest("Erro ao tentar criar usuário!");
            }
        }
    }
}
