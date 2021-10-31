using MVFactory.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;



namespace MVFactory.Domain.Interface
{
  public  interface IClimasHistoricoDomain
    {
        #region Métodos Asíncronos
        Task<bool> InsertAsync(ClimasHistorico pClimasHistorico);

        Task<IEnumerable<ClimaHistoricoGrilla>> GetByCiudadAsync(string ciudadID);
        #endregion
    }
}
