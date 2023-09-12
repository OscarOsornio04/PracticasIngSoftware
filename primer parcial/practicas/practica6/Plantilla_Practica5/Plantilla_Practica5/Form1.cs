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
            lBsalida.Items.Add("e^x = "+r); //Manda el resultado al ListBox
        }

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Proyecto1.exe");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btseno_Click(object sender, EventArgs e)
        {
            double x, r;
            x = double.Parse(tBx.Text); 
            r = Math.Sin(x); 
            lBsalida.Items.Add("Seno = "+r); 
        }

        private void btcoseno_Click(object sender, EventArgs e)
        {
            double x, r;
            x = double.Parse(tBx.Text); 
            r = Math.Cos(x); 
            lBsalida.Items.Add("Coseno = "+r);
        }

        private void bttangente_Click(object sender, EventArgs e)
        {
            double x, r;
            x = double.Parse(tBx.Text);
            r = Math.Tan(x);
            lBsalida.Items.Add("Tangente = "+r);
        }

        private void btaseno_Click(object sender, EventArgs e)
        {
            double x, r;
            x = double.Parse(tBx.Text);
            r = Math.Pow(Math.Sin(x),-1);
            lBsalida.Items.Add("Seno^-1 = "+r);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btacoseno_Click(object sender, EventArgs e)
        {
            double x, r;
            x = double.Parse(tBx.Text);
            r = Math.Pow(Math.Cos(x), -1);
            lBsalida.Items.Add("Coseno^-1 = " + r);
        }

        private void btatangente_Click(object sender, EventArgs e)
        {
            double x, r;
            x = double.Parse(tBx.Text);
            r = Math.Pow(Math.Tan(x), -1);
            lBsalida.Items.Add("Tangente^-1 = " + r);
        }

        private void btsenoh_Click(object sender, EventArgs e)
        {
            double x, r;
            x = double.Parse(tBx.Text);
            r = Math.Sinh(x);
            lBsalida.Items.Add("SenoH = " + r);
        }

        private void btcosenoh_Click(object sender, EventArgs e)
        {
            double x, r;
            x = double.Parse(tBx.Text);
            r = Math.Cosh(x);
            lBsalida.Items.Add("CosenoH = " + r);
        }

        private void bttangenteh_Click(object sender, EventArgs e)
        {
            double x, r;
            x = double.Parse(tBx.Text);
            r = Math.Tanh(x);
            lBsalida.Items.Add("TangenteH = " + r);
        }

        private void btlog_Click(object sender, EventArgs e)
        {
            double x, r;
            x = double.Parse(tBx.Text);
            r = Math.Log10(x);
            lBsalida.Items.Add("Logaritmo10 = " + r);
        }

        private void btlogN_Click(object sender, EventArgs e)
        {
            double x, r;
            x = double.Parse(tBx.Text);
            r = Math.Log(x);
            lBsalida.Items.Add("LogaritmoN = " + r);
        }

        private void btpotencia_Click(object sender, EventArgs e)
        {
            double x, r, y;
            x = double.Parse(tBx.Text);
            y = double.Parse(tBy.Text);
            r = Math.Pow(x,y);
            lBsalida.Items.Add(x+"^"+y +" = " + r);
        }
    }
}
