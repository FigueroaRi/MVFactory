using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVFactory.Aplicacion.DTO;

namespace MVFactory.Aplicacion.Interface
{
    public  interface IClimasAplicacion
    {
        RootDTO getClimas(string ciudad);
    }
}
