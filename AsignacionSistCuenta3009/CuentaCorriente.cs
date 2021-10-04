using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsignacionSistCuenta3009
{
    class CuentaCorriente: Cuenta
    {
        
       public float reIntegro(float ingreso, float monto)
        {// cantidad de dinero que se retira de la cuenta
            float saldo = ingreso-monto;
            return saldo;
        }
    }
}
