using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVFactory.Aplicacion.DTO
{    public class ClimaResponse<T1>
    {
        public StatusResponse Status { get; set; }
        public T1 Data { get; set; }
    }

}
