using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsignacionSistCuenta3009
{
    class Cuenta
    {
        private long numero { get; set; }
        private string titular { get; set; }
        private float saldo { get; set; }
        private float interes { get; set; }

     
        public int ingreso()
        {
            return 100;
        }
        public double ingresoInteresmes()
        {
            Cuenta cuenta = new Cuenta();
            cuenta.interes = 10/100;
            //interes del 10%
            var monto = ingreso();

            var inter = monto * interes;
            return inter;

        }

        public string leerSaldo()
        {
            return "El ingreso fue de $" + ingreso() + " menos $" + ingresoInteresmes() + " en interes, " +
                " Saldo final de: $"+(ingreso()-ingresoInteresmes());
        }

        public string transferirHasta()
        {
            double canTrasferible;
            canTrasferible = ingreso() - ingresoInteresmes();


            return "La cantidad transferible es de: " + canTrasferible;
        }

    }
}
