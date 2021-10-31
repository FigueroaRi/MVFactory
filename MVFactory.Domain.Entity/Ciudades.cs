using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVFactory.Domain.Entity
{
    public class Ciudades
    {
        public int IdCiudad { get; set; }
        public int Codigo{ get; set; }
        public Pais Pais { get; set; }
        public string NombreCiudad { get; set; }
     
    }
}
