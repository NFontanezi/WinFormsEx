namespace Calculadoras
{
    partial class FrmIMC2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIMC2));
            this.lblResultado3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblMetros = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblKg = new System.Windows.Forms.Label();
            this.tbxAltura = new System.Windows.Forms.TextBox();
            this.tbxPeso = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblResultado3
            // 
            this.lblResultado3.AutoSize = true;
            this.lblResultado3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultado3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblResultado3.Location = new System.Drawing.Point(308, 264);
            this.lblResultado3.Name = "lblResultado3";
            this.lblResultado3.Size = new System.Drawing.Size(0, 25);
            this.lblResultado3.TabIndex = 17;
            this.lblResultado3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(259, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Historic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTitulo.Location = new System.Drawing.Point(259, 73);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(133, 20);
            this.lblTitulo.TabIndex = 15;
            this.lblTitulo.Text = "Calculadora IMC";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(158, 176);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(45, 15);
            this.lblAltura.TabIndex = 11;
            this.lblAltura.Text = "Altura: ";
            // 
            // lblMetros
            // 
            this.lblMetros.AutoSize = true;
            this.lblMetros.Location = new System.Drawing.Point(429, 176);
            this.lblMetros.Name = "lblMetros";
            this.lblMetros.Size = new System.Drawing.Size(30, 15);
            this.lblMetros.TabIndex = 12;
            this.lblMetros.Text = "Mts.";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(158, 149);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(38, 15);
            this.lblPeso.TabIndex = 13;
            this.lblPeso.Text = "Peso: ";
            // 
            // lblKg
            // 
            this.lblKg.AutoSize = true;
            this.lblKg.Location = new System.Drawing.Point(429, 149);
            this.lblKg.Name = "lblKg";
            this.lblKg.Size = new System.Drawing.Size(26, 15);
            this.lblKg.TabIndex = 14;
            this.lblKg.Text = "Kgs";
            // 
            // tbxAltura
            // 
            this.tbxAltura.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxAltura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxAltura.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxAltura.Location = new System.Drawing.Point(207, 173);
            this.tbxAltura.Name = "tbxAltura";
            this.tbxAltura.Size = new System.Drawing.Size(216, 18);
            this.tbxAltura.TabIndex = 9;
            // 
            // tbxPeso
            // 
            this.tbxPeso.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxPeso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxPeso.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxPeso.Location = new System.Drawing.Point(207, 149);
            this.tbxPeso.Name = "tbxPeso";
            this.tbxPeso.Size = new System.Drawing.Size(216, 18);
            this.tbxPeso.TabIndex = 10;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpar.Location = new System.Drawing.Point(312, 216);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(103, 32);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalcular.Location = new System.Drawing.Point(203, 216);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(103, 32);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click_1);
            // 
            // FrmIMC2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(617, 361);
            this.Controls.Add(this.lblResultado3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblMetros);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblKg);
            this.Controls.Add(this.tbxAltura);
            this.Controls.Add(this.tbxPeso);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Name = "FrmIMC2";
            this.Text = "FrmIMC2";
            this.Load += new System.EventHandler(this.FrmIMC2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblResultado3;
        private PictureBox pictureBox1;
        private Label lblTitulo;
        private Label lblAltura;
        private Label lblMetros;
        private Label lblPeso;
        private Label lblKg;
        private TextBox tbxAltura;
        private TextBox tbxPeso;
        private Button btnLimpar;
        private Button btnCalcular;
    }
}