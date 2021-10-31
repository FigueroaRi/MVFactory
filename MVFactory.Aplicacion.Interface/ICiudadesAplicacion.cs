
using System;
using System.Collections.Generic;
using MVFactory.Aplicacion.DTO;
using MVFactory.Transversal.Common;
using System.Threading.Tasks;

namespace MVFactory.Aplicacion.Interface
{
    public interface ICiudadesAplicacion
    {

        #region Métodos Asíncronos    
        Task<Response<IEnumerable<CiudadesDTO>>> GetAllAsync();
        #endregion
    }
}
