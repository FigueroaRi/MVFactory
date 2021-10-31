using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVFactory.Aplicacion.DTO
{
    public class FaultDetail
    {
        public string ErrorType { get; set; }
        public int Code { get; set; }
        public string Key { get; set; }
        public string Description { get; set; }
        public string Description2 { get; set; }
    }
}
