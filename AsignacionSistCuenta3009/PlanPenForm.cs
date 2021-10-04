using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsignacionSistCuenta3009
{
    public partial class PlanPenForm : Form
    {
        public PlanPenForm()
        {
            InitializeComponent();
        }

        private void PlanPensiones_Load(object sender, EventArgs e)
        {
            PlanPenciones cuentaPencion = new PlanPenciones();
            PlanPenciones pencion = new PlanPenciones();
            cuentaPencion.numero = 010101010101;
            cuentaPencion.interes = 0.15F;
            cuentaPencion.titular = "Meylin Nohely Reyes Medina";
            //cuentaPencion.saldo = cuentaPencion.ingreso() - pencion.cotizacion;

            lbNumero.Text = cuentaPencion.numero.ToString();
            lbNombre.Text = cuentaPencion.titular.ToString();
            //IbSaldo.Text = cuentaPencion.saldo.ToString();

            lbIngreso.Text = cuentaPencion.ingreso().ToString();
            //IbIngreMes.Text = cuentaPencion.ingresoInteresmes().ToString();

            //IbLimite.Text = cuentaPencion.transferirHasta().ToString();
            lbPorcentCoti.Text = (cuentaPencion.interes * 100).ToString() + "%";
            //IbResumenCtn.Text = cuentaPencion.leerSaldo();

            //vencimiento de la cuenta
            pencion.vencimiento = new DateTime(2021, 10, 30);
            pencion.cotizacion = cuentaPencion.ingreso() * cuentaPencion.interes;
            lbMontoCoti.Text = pencion.cotizacion.ToString();

            cuentaPencion.saldo = cuentaPencion.ingreso() - pencion.cotizacion;
            lbSaldo.Text = cuentaPencion.saldo.ToString();

            pencion.vencimiento = new DateTime(2021, 10, 30);
            lbFecha.Text = pencion.vencimiento.ToString();
        }
    }
}
