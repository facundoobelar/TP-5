using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio_4
{
    public class SaldoInsuficiente : AdministradorCuentaException
    {
        //Este es el constructor de esta excepcion, esta es lanzada cuando a la hora de debitar, el saldo mas el acuerdo con mayores que el monto a debitar.
        public SaldoInsuficiente() {}
    }
}
