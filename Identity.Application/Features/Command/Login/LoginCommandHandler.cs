using Identity.Application.Mapper;
using Identity.Core.Entities;
using Identity.Core.Repositories;
using MediatR;
using System.Security.Claims;

namespace Identity.Application.Features.Command.Login
{
    public class LoginCommandHandler : IRequestHandler<LoginCommandRequest, LoginCommandResponse>
    {
        private readonly IUserRepository _userRepository;

        public LoginCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<LoginCommandResponse> Handle(LoginCommandRequest request, CancellationToken cancellationToken)
        {
            var userCredentials = Mapping.Mapper.Map<User>(request);
            if (userCredentials == null)
            {
                throw new ApplicationException("Issue with mapper");
            }
            var user = await _userRepository.GetUser(userCredentials);
            if (user != null)
            {
                var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.Username),
                    new Claim(ClaimTypes.Role, "User")
                };

                return new LoginCommandResponse() { Authclaims = authClaims };
            }

            throw new Exception("Incorrect credentials");
        }
    }
}
