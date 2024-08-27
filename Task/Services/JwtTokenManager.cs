using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;

namespace TaskAnswer.Services
{
    public class JwtTokenManager : IJwtTokenManager
    {
        private readonly IConfiguration configuration;

        public JwtTokenManager(IConfiguration _configuration)
        {
            configuration = _configuration;
        }
        public string AuthenticateUser(string username, string password)
        {
            var key = configuration.GetValue<string>("JwtConfig:Key");
            var keyBytes = Encoding.ASCII.GetBytes(key!);

            var tokenHandler = new System.IdentityModel.Tokens.Jwt.JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(new Claim[]{
                    new Claim(ClaimTypes.Name, username),
                    }),
                Expires = DateTime.Now.AddMinutes(300),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(keyBytes), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
