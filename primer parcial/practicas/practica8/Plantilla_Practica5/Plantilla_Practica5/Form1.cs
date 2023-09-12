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
        Calculadora operacion = new Calculadora();
        public Form1()
        {
            InitializeComponent();
        }

        private void btoper_Click(object sender, EventArgs e)
        {
            double r = operacion.calcularExponencial(tBx.Text);
            lBsalida.Items.Add("e^x = "+r);
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
            double r = operacion.calcularSeno(tBx.Text);
            lBsalida.Items.Add("Seno = " + r);
        }

        private void btcoseno_Click(object sender, EventArgs e)
        {
            double r = operacion.calcularCoseno(tBx.Text); 
            lBsalida.Items.Add("Coseno = "+r);
        }

        private void bttangente_Click(object sender, EventArgs e)
        {
            double r = operacion.calcularTangente(tBx.Text);
            lBsalida.Items.Add("Tangente = "+r);
        }

        private void btaseno_Click(object sender, EventArgs e)
        {
            double r = operacion.calcularASeno(tBx.Text);
            lBsalida.Items.Add("Seno^-1 = "+r);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btacoseno_Click(object sender, EventArgs e)
        {
            double r = operacion.calcularACoseno(tBx.Text);
            lBsalida.Items.Add("Coseno^-1 = " + r);
        }

        private void btatangente_Click(object sender, EventArgs e)
        {
            double r = operacion.calcularATangente(tBx.Text);
            lBsalida.Items.Add("Tangente^-1 = " + r);
        }

        private void btsenoh_Click(object sender, EventArgs e)
        {
            double r = operacion.calcularSenoH(tBx.Text);
            lBsalida.Items.Add("SenoH = " + r);
        }

        private void btcosenoh_Click(object sender, EventArgs e)
        {
            double r =operacion.calcularCosenoH(tBx.Text);
            lBsalida.Items.Add("CosenoH = " + r);
        }

        private void bttangenteh_Click(object sender, EventArgs e)
        {
            double r = operacion.calcularTangenteH(tBx.Text);
            lBsalida.Items.Add("TangenteH = " + r);
        }

        private void btlog_Click(object sender, EventArgs e)
        {
            double r = operacion.calcularLogaritmoDiez(tBx.Text);
            lBsalida.Items.Add("Logaritmo10 = " + r);
        }

        private void btlogN_Click(object sender, EventArgs e)
        {
            double r = operacion.calcularLogaritmoN(tBx.Text);
            lBsalida.Items.Add("LogaritmoN = " + r);
        }

        private void btpotencia_Click(object sender, EventArgs e)
        {
            double r = operacion.calcularPotencia(tBx.Text,tBy.Text);
            lBsalida.Items.Add(operacion.x+"^"+operacion.y +" = " + r);
        }

        private void btsuma_Click(object sender, EventArgs e)
        {
            double  r = operacion.calcularSuma(tBx.Text,tBy.Text);
            lBsalida.Items.Add(operacion.x + " + " + operacion.y + " = " + r);
        }

        private void btresta_Click(object sender, EventArgs e)
        {
            double r = operacion.calcularResta(tBx.Text, tBy.Text);
            lBsalida.Items.Add(operacion.x + " - " + operacion.y + " = " + r);
        }

        private void btmulti_Click(object sender, EventArgs e)
        {
            double r = operacion.calcularMulti(tBx.Text, tBy.Text);
            lBsalida.Items.Add(operacion.x + " * " + operacion.y + " = " + r);
        }

        private void btdivision_Click(object sender, EventArgs e)
        {
            double r = operacion.calcularDivision(tBx.Text, tBy.Text);
            lBsalida.Items.Add(operacion.x + " / " + operacion.y + " = " + r);
        }

        private void btmodulo_Click(object sender, EventArgs e)
        {
            double r = operacion.calcularMod(tBx.Text, tBy.Text);
            lBsalida.Items.Add(operacion.x + " % " + operacion.y + " = " + r);
        }
    }
}
