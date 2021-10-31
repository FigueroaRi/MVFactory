using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVFactory.Aplicacion.DTO
{
    public class ClimasDTO : ClimaResponse<RootDTO>
    {
        public RootDTO climas { get; set; }
      

    }
}
