using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVFactory.Aplicacion.DTO
{
    public class StatusResponse
    {
        public bool Ok { get; set; }
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public string Service { get; set; }
        public FaultDetail FaultDatail { get; set; }

    }
}
