using System;
using System.Collections.Generic;
using MVFactory.Aplicacion.DTO;
using MVFactory.Transversal.Common;
using System.Threading.Tasks;

namespace MVFactory.Aplicacion.Interface
{
    public interface IClimasHistoricoAplicacion
    {
        #region Métodos Asíncronos
        Task<Response<bool>> InsertAsync(ClimaHistoricoDTO pClimasHistorico);

        Task<Response<IEnumerable<ClimaHistoricoGrillaDTO>>> GetByCiudadAsync(string ciudadID);
        #endregion
    }
}
