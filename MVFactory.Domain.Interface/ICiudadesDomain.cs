using MVFactory.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace MVFactory.Domain.Interface
{
    public interface ICiudadesDomain
    {
        #region Métodos Asíncronos    
        Task<IEnumerable<Ciudades>> GetAllAsync();
        #endregion
    }
}
