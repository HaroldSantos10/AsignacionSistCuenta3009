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
    public partial class TransaccionReti : Form
    {
        public TransaccionReti()
        {
            InitializeComponent();
        }

        private void TransaccionReti_Load(object sender, EventArgs e)
        {
            CuentaCorriente cuentaCorre = new CuentaCorriente();
            cuentaCorre.numero = 01010101010101010;
            cuentaCorre.titular = "Harold Enoc Santos Morillo";

            lbNumero.Text = cuentaCorre.numero.ToString();
            lbNombre.Text = cuentaCorre.titular;
            lbIngreso.Text = cuentaCorre.ingreso().ToString();
        }

        private void btnRealizar_Click(object sender, EventArgs e)
        {
            CuentaCorriente cuentaCorre = new CuentaCorriente();
            var monto = float.Parse(tbxMontRetirar.Text);
            var ingreso = cuentaCorre.ingreso();
            cuentaCorre.saldo = cuentaCorre.reIntegro(ingreso, monto);

            lbSaldo.Text = cuentaCorre.saldo.ToString();

        }
    }
}
