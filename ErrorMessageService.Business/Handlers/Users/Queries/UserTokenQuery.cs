using Core.Wrappers;
using ErrorMessageService.Business.Helper;
using ErrorMessageService.Data.Abstract;
using ErrorMessageService.Entities.Dto;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ErrorMessageService.Business.Handlers.Users.Queries
{
    public class UserTokenQuery : IRequest<IResponse>
    {
        public string userName { get; set; }

        public string Password { get; set; }
        public class UserTokenHandler : IRequestHandler<UserTokenQuery, IResponse>
        {
            private readonly IUserRepository _userRepository;
            private readonly IConfiguration _configuration;

            public UserTokenHandler(IUserRepository userRepository, IConfiguration configuration)
            {
                _userRepository = userRepository;
                _configuration = configuration;
            }

            public async Task<IResponse> Handle(UserTokenQuery request, CancellationToken cancellationToken)
            {
                var newUser = await _userRepository.GetAsync(x=>x.Username == request.userName);

                TokenDto newToken = new TokenDto();
                newToken.Token = CreateToken(newUser);
                return new Response<TokenDto>(newToken);
            }
            private string CreateToken(Entities.Concrete.User newUser)
            {
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Secret"]));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

                var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:ValidIssuer"],
                audience: _configuration["Jwt:ValidAudience"],
                claims: GetClaims(newUser),
                expires: DateTime.Now.AddMinutes(Convert.ToDouble(_configuration["Jwt:TokenValidityInMinutes"])),
                signingCredentials: creds);

                var jwt = new JwtSecurityTokenHandler().WriteToken(token);
                return jwt;
            }

            private IEnumerable<Claim> GetClaims(Entities.Concrete.User newUser)
            {
                var claims = new List<Claim>
                {
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.Name, newUser.Username),
                new Claim(ClaimTypes.Role,newUser.Title)
                };
                return claims;
            }
        }
    }
}
