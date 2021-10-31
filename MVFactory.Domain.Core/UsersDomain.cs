using System;
using MVFactory.Domain.Entity;
using MVFactory.Domain.Interface;
using MVFactory.Infraestructura.Interfaces;

namespace MVFactory.Domain.Core
{
    public class UsersDomain : IUsersDomain
    {
        private readonly IUsersRepository _usersRepository;
        public UsersDomain(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }
        public Users Authenticate(string userName, string password)
        {
            return _usersRepository.Authenticate(userName, password);
        }
    }
}
