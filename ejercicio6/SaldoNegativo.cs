using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    public class SaldoNegativo : AdministradorCuentaException
    {
        //Este es el constructor de la excepcion, esta excepcion se lanza cuando el saldo a acreditar es un valor negativo.
        public SaldoNegativo() { }
    }
}
