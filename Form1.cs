using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSueldoNeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                double sueldo = double.Parse(txtSueldo.Text);
                int hijos = int.Parse(txtnumerodehijos.Text);

                // Calcular incentivos
                double incentivoPorHijo = 500;
                double totalIncentivos = sueldo + (incentivoPorHijo * hijos);

                // Calcular descuentos
                double descuentoAFP = totalIncentivos * 0.0287;
                double descuentoSFS = totalIncentivos * 0.0304;
                double totalDescuentos = descuentoAFP + descuentoSFS;

                // Calcular sueldo neto
                double sueldoNeto = totalIncentivos - totalDescuentos;

                // Mostrar resultados
                txtsueldobruto.Text = totalIncentivos.ToString("F2");
                txtafp.Text = descuentoAFP.ToString("F2");
                txtsfs.Text = descuentoSFS.ToString("F2");
                txtdescuento.Text = totalDescuentos.ToString("F2");
                txtneto.Text = sueldoNeto.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor ingrese valores válidos", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtSueldo.Text = "";
            txtnumerodehijos.Text = "";
            txtsueldobruto.Text = "";
            txtafp.Text = "";
            txtsfs.Text = "";
            txtdescuento.Text = "";
            txtneto.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
