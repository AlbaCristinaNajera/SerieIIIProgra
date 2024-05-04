using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularCuotas_Click(object sender, EventArgs e)
        {
            double montoInicial = double.Parse(txtmonto.Text.ToString());
            double interes = double.Parse(txtInteres.Text.ToString());
            double tiempo = double.Parse(txtPeriodoTiempo.Text.ToString());
            double interesMensual = interes / 12 / 100;

            double CalcularCuotas = (montoInicial * interesMensual) / (1 - Math.Pow(1 + interesMensual, -tiempo * 12));

            double totalInteresesMensuales = CalcularCuotas  * tiempo * 12 - montoInicial;

            double totalPagar = montoInicial + totalInteresesMensuales;

            txtResultado.Text = $"Las cuotas mensuales que debe de abonar serán de:  {CalcularCuotas:N2}";
            txtTotalIntereses.Text = $"Los intereses que debe de abonar serán de:  {totalInteresesMensuales:N2}";
            txtTotalAPagar.Text = $"El total que debe de abonar(capital+totalintereses) serán de:  {totalPagar:N2}";


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtmonto.Text = string.Empty;
            txtInteres.Text = string.Empty;
            txtPeriodoTiempo.Text = string.Empty;
            txtResultado.Text = string.Empty;
            txtTotalIntereses.Text = string.Empty;
            txtTotalAPagar.Text = string.Empty;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
