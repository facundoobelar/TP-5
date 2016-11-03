using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    public class AdministradorCuentaException : ApplicationException
    {
        //Esta es la superClase de las excepciones de nuestra aplicación. Para darle una jerarquia a las excepciones.
        public AdministradorCuentaException() { }
        
    }
}
