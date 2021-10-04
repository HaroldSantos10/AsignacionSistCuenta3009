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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cuenta cuenta = new Cuenta();
                cuenta.numero = 0101010101;
            cuenta.interes = 0.03F;
            cuenta.titular = "Harold Enoc Santos Morillo";
            cuenta.saldo = cuenta.ingreso() + cuenta.ingresoInteresmes();

            lbNumeroCtn.Text = cuenta.numero.ToString();
            lbNombreCtn.Text = cuenta.titular.ToString();
            lbSaldoCtn.Text = cuenta.saldo.ToString();

            lbIngresoCtn.Text = cuenta.ingreso().ToString();
            lbIngreMesCtn.Text = cuenta.ingresoInteresmes().ToString();

            lbLimiteCtn.Text = cuenta.transferirHasta().ToString();
            lbInteresCtn.Text = (cuenta.interes*100).ToString()+"%";
            lbResumenCtn.Text = cuenta.leerSaldo();

            //vencimiento de la cuenta
            CuentaAhorroPFijo cuentaPfijo = new CuentaAhorroPFijo();
            cuentaPfijo.vencimiento =new DateTime(2021,10,10);

            lbFechaCtn.Text = cuentaPfijo.vencimiento.ToString();
        }

        private void btnPension_Click(object sender, EventArgs e)
        {
            PlanPenForm Pen = new PlanPenForm();
            Pen.Show();
        }

        private void btnTransac_Click(object sender, EventArgs e)
        {
            TransaccionReti trans = new TransaccionReti();
            trans.Show();
        }
    }
}
