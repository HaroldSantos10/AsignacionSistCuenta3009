using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsignacionSistCuenta3009
{
    class CuentaAhorroPFijo: Cuenta
    {
        Cuenta cuenta = new Cuenta();
        public DateTime vencimiento { get; set; }

        //private float ingresoMes()
        //{
        //    float ingresoMensual = cuenta;


        //    return ingresoMensual;
        //}

    }
}
