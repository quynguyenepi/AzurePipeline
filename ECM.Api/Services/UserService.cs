using ECM.Api.Authorization;
using ECM.Api.Models;
using ECM.Repo.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECM.Repo.Services
{
    public interface IUserService
    {
        AuthenticateResponse? Authenticate(AuthenticateRequest model);
        IEnumerable<User> GetAll();
        User? GetById(Guid id);
    }
    public class UserService : IUserService
    {
        private readonly IJwtUtils _jwtUtils;
        public UserService(IJwtUtils jwtUtils)
        {
            _jwtUtils = jwtUtils;
        }
        private List<User> _users = new List<User>
        {
            new User { Id = new Guid("92175b58-de83-4b0b-894d-92dafc3293b6"), FirstName = "Test", LastName = "User", Username = "test", Password = "test" }
        };


        public AuthenticateResponse? Authenticate(AuthenticateRequest model)
        {
            var user = _users.SingleOrDefault(x=>x.Username == model.Username && x.Password== model.Password);
            if (user == null) { return null; }
            var token = _jwtUtils.GenerateJwtToken(user);
            return new AuthenticateResponse(user, token);
        }

        public IEnumerable<User> GetAll()
        {
            return _users;
        }

        public User? GetById(Guid id)
        {
            return _users.FirstOrDefault(x => x.Id == id);
        }
    }


}
