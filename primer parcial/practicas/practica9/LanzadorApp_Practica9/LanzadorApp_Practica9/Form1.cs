using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanzadorApp_Practica9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Proyecto1.exe");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pBcalculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void pBword_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WINWORD.EXE");
        }

        private void pBexcel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("EXCEL.EXE");
        }

        private void pBpp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("POWERPNT.EXE");
        }

        private void pBvideos_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("wmplayer.exe");
        }

        private void pBfotos_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ms-photos:");
        }

        private void pBbloc_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }

        private void pBedge_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("msedge.exe");
        }

        private void pBvisual_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe");
        }

        private void pBreloj_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ms-clock:");
        }
    }
}
