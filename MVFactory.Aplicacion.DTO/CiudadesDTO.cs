using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVFactory.Aplicacion.DTO
{
   public class CiudadesDTO
    {
        public int IdCiudad { get; set; }
        public int Codigo { get; set; }
        public PaisDTO Pais { get; set; }
        public string NombreCiudad { get; set; }
    }
}
