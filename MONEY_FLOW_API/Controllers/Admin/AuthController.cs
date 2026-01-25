using MONEY_FLOW_API.IService;
using MONEY_FLOW_API.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MONEY_FLOW_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly IConfiguration _config;
        public AuthController(IAuthService authService, IConfiguration config)
        {
            _authService = authService;
            _config = config;
        }

        #region # LOG IN METHOD
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Authentication(UserCredential userCredential)
        {
            if (userCredential.UserName != null && userCredential.Password != null)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(new { status = "error", message = "Invalid request data." });
                }

                //====================================================================//
                // STEP 1 : GET USER DETAILS
                //====================================================================//

                var ValidateUser = await _authService.User_Validate(userCredential.UserName);
                var user = ValidateUser.FirstOrDefault();

                //====================================================================//
                // STEP 2 : INVALID USERNAME
                //====================================================================//

                if (user == null)
                {
                    await _authService.User_Activity(null, "FAIL_INVALID_USER");
                    return Ok(new { status = "error", message = "Invalid username." });
                }

                //====================================================================//
                // STEP 3 : CHECK INACTIVE ACCOUNT
                //====================================================================//

                if (user.IsActive == false)
                {
                    await _authService.User_Activity(user.UserId, "FAIL_INACTIVE_ACCOUNT");
                    return Ok(new { status = "info", message = "Account is inactive. Contact administrator." });
                }

                //====================================================================//
                // STEP 4 : CHECK ACCOUNT LOCKED
                //====================================================================//

                if (user.IsLocked == true)
                {
                    await _authService.User_Activity(user.UserId, "FAIL_ACCOUNT_LOCKED");
                    return Ok(new { status = "warn", message = "Account is locked due to failed login attempts." });
                }

                //====================================================================//
                // STEP 5 : VERIFY PASSWORD
                //====================================================================//

                if (userCredential.Password != user.Password)
                {
                    await _authService.User_Activity(user.UserId, "FAIL_WRONG_PASSWORD");
                    return Ok(new { status = "error", message = "Invalid password." });
                }

                //====================================================================//
                // STEP 6 : LOG IN SUCCESSFULLY
                //====================================================================//

                await _authService.User_Activity(user.UserId, "LOGIN_SUCCESS");

                var token = GenerateJwtToken(user);

                return Ok(new
                {
                    status = "success",
                    message = "Login successful!",
                    token,
                    user = new
                    {
                        user.UserId,
                        user.UserDisplayName,
                        user.UserType
                    }
                });
            }

            return BadRequest(new { status = "error", message = "Username and password are required." });
        }
        #endregion

        #region # LOG OUT METHOD
        [HttpGet]
        public async Task<IActionResult> Log_Out(int id)
        {
            await _authService.User_Activity(id, "LOGOUT_SUCCESS");
            return Ok(new { status = "success", message = "Log out successfully!" });
        }
        #endregion

        #region # GENERATE JWT
        private string GenerateJwtToken(dynamic user)
        {
            var jwtSettings = _config.GetSection("JWT");

            // Read secret key
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings["Secret"]));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            // Token expiry handling
            int tokenMinutes = int.TryParse(jwtSettings["TokenExpireTime"], out int t) && t > 0
                ? t
                : 60;

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.UserId.ToString()),
                new Claim(ClaimTypes.Name, user.UserDisplayName ?? user.UserName),
                new Claim(ClaimTypes.Role, user.UserType ?? "User")
            };

            var token = new JwtSecurityToken(
                issuer: jwtSettings["Issuer"],
                audience: jwtSettings["Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(tokenMinutes),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        #endregion
    }
}
