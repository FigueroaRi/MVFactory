using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVFactory.Domain.Entity
{
    public class ClimasHistorico
    {
        public int Id { get; set; }
        public Ciudades Ciudad { get; set; }

        //public string NombreCiudad { get; set; }
        //public string NombrePais { get; set; }

        public string Clima { get; set; }
        public string SenacionTerminca { get; set; }
        public DateTime FechaAlta { get; set; }
    }
}
