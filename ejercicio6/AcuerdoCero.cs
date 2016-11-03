using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    public class AcuerdoCero : AdministradorCuentaException
    {
        //Este es el constructor de esta excepcion, esta es lanzada en el caso de que el acuerdo sea igual a 0
        public AcuerdoCero() { }
    }
}
