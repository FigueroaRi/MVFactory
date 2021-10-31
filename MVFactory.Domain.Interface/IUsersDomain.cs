using MVFactory.Domain.Entity;

namespace MVFactory.Domain.Interface
{
 public   interface IUsersDomain
    {
        Users Authenticate(string username, string password);
    }
}
