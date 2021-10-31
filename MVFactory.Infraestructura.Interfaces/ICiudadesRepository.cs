using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVFactory.Domain.Entity;

namespace MVFactory.Infraestructura.Interfaces
{
    public interface ICiudadesRepository
    {
        #region Métodos Asíncronos
        Task<IEnumerable<Ciudades>> GetAllAsync();
        #endregion
    }
}
