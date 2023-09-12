using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plantilla_Practica5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btoper_Click(object sender, EventArgs e)
        {
            double x, r;
            x = double.Parse(tBx.Text); //Convierte el texto ingresado en el TextBox a tipo Double
            r = Math.Exp(x); //Eleva al cuadrado el valor de X y lo guarda en r
            lBsalida.Items.Add(r); //Manda el resultado al ListBox
        }

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("");
            lBsalida.Items.Add("Hola");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
