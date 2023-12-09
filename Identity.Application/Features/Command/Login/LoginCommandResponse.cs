using System.Security.Claims;

namespace Identity.Application.Features.Command.Login
{
    public class LoginCommandResponse
    {
        public List<Claim> Authclaims { get; set; }
    }
}
