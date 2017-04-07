using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
        //llamado al metodo Limpiar por medio del boton btnLimpiar.
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        //llamado al metodo Operar por medio del boton btnOperar.
        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado;

            Numero numero1 = new Numero(txtNumero1.Text);
            Numero numero2 = new Numero(txtNumero2.Text);

            resultado = Calculadora.Operar(numero1, numero2, cmbOperacion.Text);

            lblResultado.Text = resultado.ToString();
        }

        //metodo para limpiar los valores ingresados y/o generados.
        private void Limpiar()
        {
            lblResultado.Text = "";
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            cmbOperacion.SelectedIndex = 0;
        }
    }
}
