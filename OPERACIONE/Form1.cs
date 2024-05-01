using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjemploDLL;

namespace OPERACIONE
{
    public partial class Calculadora : Form
    {
        Operaciones operaciones = new Operaciones();
        public Calculadora()
        {
            InitializeComponent();
        }
          
        private void SUMA_Click(object sender, EventArgs e)
        {
            float N1 = float.Parse(textBoxN1.Text);
            float N2 = float.Parse(textBoxN2.Text);
            float R =operaciones.Suma(N1, N2);
            textBoxR.Text = R.ToString();
        }

        private void RESTA_Click(object sender, EventArgs e)
        {
            float N1 = float.Parse(textBoxN1.Text);
            float N2 = float.Parse(textBoxN2.Text);
            float R = operaciones.Resta(N1, N2);
            textBoxR.Text = R.ToString();
        }

        private void MULTIPLICACION_Click(object sender, EventArgs e)
        {
            float N1 = float.Parse(textBoxN1.Text);
            float N2 = float.Parse(textBoxN2.Text);
            float R = operaciones.Multiplicacion(N1, N2);
            textBoxR.Text = R.ToString();

        }

        private void DIVISION_Click(object sender, EventArgs e)
        {
            float N1 = float.Parse(textBoxN1.Text);
            float N2 = float.Parse(textBoxN2.Text);
            float R=operaciones.Division(N1, N2);
            textBoxR.Text=R.ToString();
        }
    }
}
