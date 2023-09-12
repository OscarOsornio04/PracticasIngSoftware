namespace Plantilla_Practica5
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tBx = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btpotencia = new System.Windows.Forms.Button();
            this.btlogN = new System.Windows.Forms.Button();
            this.btlog = new System.Windows.Forms.Button();
            this.btatangente = new System.Windows.Forms.Button();
            this.btacoseno = new System.Windows.Forms.Button();
            this.btaseno = new System.Windows.Forms.Button();
            this.bttangente = new System.Windows.Forms.Button();
            this.btcoseno = new System.Windows.Forms.Button();
            this.btseno = new System.Windows.Forms.Button();
            this.btoper = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lBsalida = new System.Windows.Forms.ListBox();
            this.btsenoh = new System.Windows.Forms.Button();
            this.btcosenoh = new System.Windows.Forms.Button();
            this.bttangenteh = new System.Windows.Forms.Button();
            this.tBy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(997, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firmaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // firmaToolStripMenuItem
            // 
            this.firmaToolStripMenuItem.Name = "firmaToolStripMenuItem";
            this.firmaToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.firmaToolStripMenuItem.Text = "Firma";
            this.firmaToolStripMenuItem.Click += new System.EventHandler(this.firmaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tBy);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tBx);
            this.groupBox1.Location = new System.Drawing.Point(21, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 259);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tBx
            // 
            this.tBx.Location = new System.Drawing.Point(75, 87);
            this.tBx.Name = "tBx";
            this.tBx.Size = new System.Drawing.Size(100, 20);
            this.tBx.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bttangenteh);
            this.groupBox2.Controls.Add(this.btcosenoh);
            this.groupBox2.Controls.Add(this.btsenoh);
            this.groupBox2.Controls.Add(this.btpotencia);
            this.groupBox2.Controls.Add(this.btlogN);
            this.groupBox2.Controls.Add(this.btlog);
            this.groupBox2.Controls.Add(this.btatangente);
            this.groupBox2.Controls.Add(this.btacoseno);
            this.groupBox2.Controls.Add(this.btaseno);
            this.groupBox2.Controls.Add(this.bttangente);
            this.groupBox2.Controls.Add(this.btcoseno);
            this.groupBox2.Controls.Add(this.btseno);
            this.groupBox2.Controls.Add(this.btoper);
            this.groupBox2.Location = new System.Drawing.Point(273, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 352);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Proceso";
            // 
            // btpotencia
            // 
            this.btpotencia.Location = new System.Drawing.Point(290, 34);
            this.btpotencia.Name = "btpotencia";
            this.btpotencia.Size = new System.Drawing.Size(75, 23);
            this.btpotencia.TabIndex = 9;
            this.btpotencia.Text = "Potencia";
            this.btpotencia.UseVisualStyleBackColor = true;
            this.btpotencia.Click += new System.EventHandler(this.btpotencia_Click);
            // 
            // btlogN
            // 
            this.btlogN.Location = new System.Drawing.Point(169, 63);
            this.btlogN.Name = "btlogN";
            this.btlogN.Size = new System.Drawing.Size(75, 23);
            this.btlogN.TabIndex = 8;
            this.btlogN.Text = "LogNatural";
            this.btlogN.UseVisualStyleBackColor = true;
            this.btlogN.Click += new System.EventHandler(this.btlogN_Click);
            // 
            // btlog
            // 
            this.btlog.Location = new System.Drawing.Point(169, 34);
            this.btlog.Name = "btlog";
            this.btlog.Size = new System.Drawing.Size(75, 23);
            this.btlog.TabIndex = 7;
            this.btlog.Text = "Logaritmo10";
            this.btlog.UseVisualStyleBackColor = true;
            this.btlog.Click += new System.EventHandler(this.btlog_Click);
            // 
            // btatangente
            // 
            this.btatangente.Location = new System.Drawing.Point(27, 283);
            this.btatangente.Name = "btatangente";
            this.btatangente.Size = new System.Drawing.Size(75, 23);
            this.btatangente.TabIndex = 6;
            this.btatangente.Text = "ArcoTan";
            this.btatangente.UseVisualStyleBackColor = true;
            this.btatangente.Click += new System.EventHandler(this.btatangente_Click);
            // 
            // btacoseno
            // 
            this.btacoseno.Location = new System.Drawing.Point(27, 254);
            this.btacoseno.Name = "btacoseno";
            this.btacoseno.Size = new System.Drawing.Size(75, 23);
            this.btacoseno.TabIndex = 5;
            this.btacoseno.Text = "ArcoCoseno";
            this.btacoseno.UseVisualStyleBackColor = true;
            this.btacoseno.Click += new System.EventHandler(this.btacoseno_Click);
            // 
            // btaseno
            // 
            this.btaseno.Location = new System.Drawing.Point(27, 224);
            this.btaseno.Name = "btaseno";
            this.btaseno.Size = new System.Drawing.Size(75, 23);
            this.btaseno.TabIndex = 4;
            this.btaseno.Text = "ArcoSeno";
            this.btaseno.UseVisualStyleBackColor = true;
            this.btaseno.Click += new System.EventHandler(this.btaseno_Click);
            // 
            // bttangente
            // 
            this.bttangente.Location = new System.Drawing.Point(27, 194);
            this.bttangente.Name = "bttangente";
            this.bttangente.Size = new System.Drawing.Size(75, 23);
            this.bttangente.TabIndex = 3;
            this.bttangente.Text = "Tangente";
            this.bttangente.UseVisualStyleBackColor = true;
            this.bttangente.Click += new System.EventHandler(this.bttangente_Click);
            // 
            // btcoseno
            // 
            this.btcoseno.Location = new System.Drawing.Point(27, 165);
            this.btcoseno.Name = "btcoseno";
            this.btcoseno.Size = new System.Drawing.Size(75, 23);
            this.btcoseno.TabIndex = 2;
            this.btcoseno.Text = "Coseno";
            this.btcoseno.UseVisualStyleBackColor = true;
            this.btcoseno.Click += new System.EventHandler(this.btcoseno_Click);
            // 
            // btseno
            // 
            this.btseno.Location = new System.Drawing.Point(27, 135);
            this.btseno.Name = "btseno";
            this.btseno.Size = new System.Drawing.Size(75, 23);
            this.btseno.TabIndex = 1;
            this.btseno.Text = "Seno";
            this.btseno.UseVisualStyleBackColor = true;
            this.btseno.Click += new System.EventHandler(this.btseno_Click);
            // 
            // btoper
            // 
            this.btoper.Location = new System.Drawing.Point(27, 34);
            this.btoper.Name = "btoper";
            this.btoper.Size = new System.Drawing.Size(75, 23);
            this.btoper.TabIndex = 0;
            this.btoper.Text = "e^x";
            this.btoper.UseVisualStyleBackColor = true;
            this.btoper.Click += new System.EventHandler(this.btoper_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lBsalida);
            this.groupBox3.Location = new System.Drawing.Point(723, 50);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(243, 259);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Salida";
            // 
            // lBsalida
            // 
            this.lBsalida.FormattingEnabled = true;
            this.lBsalida.Location = new System.Drawing.Point(25, 51);
            this.lBsalida.Name = "lBsalida";
            this.lBsalida.Size = new System.Drawing.Size(197, 160);
            this.lBsalida.TabIndex = 0;
            // 
            // btsenoh
            // 
            this.btsenoh.Location = new System.Drawing.Point(121, 135);
            this.btsenoh.Name = "btsenoh";
            this.btsenoh.Size = new System.Drawing.Size(75, 23);
            this.btsenoh.TabIndex = 10;
            this.btsenoh.Text = "SenoH";
            this.btsenoh.UseVisualStyleBackColor = true;
            this.btsenoh.Click += new System.EventHandler(this.btsenoh_Click);
            // 
            // btcosenoh
            // 
            this.btcosenoh.Location = new System.Drawing.Point(121, 165);
            this.btcosenoh.Name = "btcosenoh";
            this.btcosenoh.Size = new System.Drawing.Size(75, 23);
            this.btcosenoh.TabIndex = 11;
            this.btcosenoh.Text = "CosenoH";
            this.btcosenoh.UseVisualStyleBackColor = true;
            this.btcosenoh.Click += new System.EventHandler(this.btcosenoh_Click);
            // 
            // bttangenteh
            // 
            this.bttangenteh.Location = new System.Drawing.Point(121, 194);
            this.bttangenteh.Name = "bttangenteh";
            this.bttangenteh.Size = new System.Drawing.Size(75, 23);
            this.bttangenteh.TabIndex = 12;
            this.bttangenteh.Text = "TangenteH";
            this.bttangenteh.UseVisualStyleBackColor = true;
            this.bttangenteh.Click += new System.EventHandler(this.bttangenteh_Click);
            // 
            // tBy
            // 
            this.tBy.Location = new System.Drawing.Point(75, 139);
            this.tBy.Name = "tBy";
            this.tBy.Size = new System.Drawing.Size(100, 20);
            this.tBy.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Y";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 416);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Plantilla Practica 5";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tBx;
        private System.Windows.Forms.Button btoper;
        private System.Windows.Forms.ListBox lBsalida;
        private System.Windows.Forms.Button btseno;
        private System.Windows.Forms.Button btatangente;
        private System.Windows.Forms.Button btacoseno;
        private System.Windows.Forms.Button btaseno;
        private System.Windows.Forms.Button bttangente;
        private System.Windows.Forms.Button btcoseno;
        private System.Windows.Forms.Button btpotencia;
        private System.Windows.Forms.Button btlogN;
        private System.Windows.Forms.Button btlog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttangenteh;
        private System.Windows.Forms.Button btcosenoh;
        private System.Windows.Forms.Button btsenoh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBy;
    }
}

