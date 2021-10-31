using MVFactory.Aplicacion.DTO;
using MVFactory.Transversal.Common;

namespace MVFactory.Aplicacion.Interface
{
   public interface IUsersApplicacion
    {
        Response<UsersDto> Authenticate(string username, string password);
    }
}
