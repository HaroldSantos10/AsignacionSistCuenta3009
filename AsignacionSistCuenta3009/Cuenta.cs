using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsignacionSistCuenta3009
{
    class Cuenta
    {
        public long numero { get; set; }
        public string titular { get; set; }
        public float saldo { get; set; }
        public float interes { get; set; }

        
     
        public int ingreso()
        {//ingreso que se deposita en la cuenta

            return 300;
        }
        public float ingresoInteresmes()
        {//la cuenta tiene un ingreso de interés del 3% mensual sobre el ingreso
            //Cuenta cuenta = new Cuenta();
            //cuenta.interes = 10/100;
            //interes del 10%
            var monto = ingreso();

            var inter = monto * interes;
            return inter;

        }

        public string leerSaldo()
        {//muestra el saldo de la cuenta
            return "El ingreso fue de $" + ingreso() + " mas $" + ingresoInteresmes() + " en interes, " +
                "Saldo final de: $"+(ingreso()+ ingresoInteresmes());
        }

        public float transferirHasta()
        {// la cuenta no puede tener menos de $100
            
            var canTrasferible = saldo - 100;


            return canTrasferible;
        }

    }
}
