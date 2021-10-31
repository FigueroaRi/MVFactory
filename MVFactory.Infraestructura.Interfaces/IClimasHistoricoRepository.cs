using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVFactory.Domain.Entity;

namespace MVFactory.Infraestructura.Interfaces
{
 public   interface IClimasHistoricoRepository
    {
        #region Métodos Asíncronos
        Task<bool> InsertAsync(ClimasHistorico pClimasHistorico);
     

        Task<IEnumerable<ClimaHistoricoGrilla>> GetByCiudadAsync(string ciudadID);
        #endregion
    }
}
