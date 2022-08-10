namespace Calculadoras
{
    partial class FrmCalculadora
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txbTela = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnVirgula = new System.Windows.Forms.Button();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.pnlModulra = new System.Windows.Forms.Panel();
            this.pnlModulra.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitulo.Location = new System.Drawing.Point(57, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(161, 19);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Calculadora Simples";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // txbTela
            // 
            this.txbTela.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbTela.Location = new System.Drawing.Point(15, 45);
            this.txbTela.Name = "txbTela";
            this.txbTela.Size = new System.Drawing.Size(239, 23);
            this.txbTela.TabIndex = 1;
            this.txbTela.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn1.Location = new System.Drawing.Point(15, 161);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(56, 35);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn4.Location = new System.Drawing.Point(15, 120);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(56, 35);
            this.btn4.TabIndex = 2;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn7.Location = new System.Drawing.Point(15, 79);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(56, 35);
            this.btn7.TabIndex = 2;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn8.Location = new System.Drawing.Point(81, 79);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(56, 35);
            this.btn8.TabIndex = 2;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn5.Location = new System.Drawing.Point(81, 120);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(56, 35);
            this.btn5.TabIndex = 2;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn2.Location = new System.Drawing.Point(81, 161);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(56, 35);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn9.Location = new System.Drawing.Point(147, 79);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(56, 35);
            this.btn9.TabIndex = 2;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnSoma
            // 
            this.btnSoma.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSoma.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSoma.Location = new System.Drawing.Point(220, 79);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(34, 35);
            this.btnSoma.TabIndex = 2;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMenos.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnMenos.Location = new System.Drawing.Point(220, 120);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(34, 35);
            this.btnMenos.TabIndex = 2;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // btnMult
            // 
            this.btnMult.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMult.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnMult.Location = new System.Drawing.Point(220, 161);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(34, 35);
            this.btnMult.TabIndex = 2;
            this.btnMult.Text = "*";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDiv.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnDiv.Location = new System.Drawing.Point(220, 202);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(34, 35);
            this.btnDiv.TabIndex = 2;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn6.Location = new System.Drawing.Point(147, 120);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(56, 35);
            this.btn6.TabIndex = 2;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn3.Location = new System.Drawing.Point(147, 161);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(56, 35);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCalcular.Location = new System.Drawing.Point(15, 240);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(239, 35);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpa
            // 
            this.btnLimpa.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpa.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLimpa.Location = new System.Drawing.Point(15, 202);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(56, 35);
            this.btnLimpa.TabIndex = 2;
            this.btnLimpa.Text = "Limpa";
            this.btnLimpa.UseVisualStyleBackColor = true;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn0.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn0.Location = new System.Drawing.Point(81, 202);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(56, 35);
            this.btn0.TabIndex = 2;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnVirgula
            // 
            this.btnVirgula.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVirgula.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnVirgula.Location = new System.Drawing.Point(147, 202);
            this.btnVirgula.Name = "btnVirgula";
            this.btnVirgula.Size = new System.Drawing.Size(56, 35);
            this.btnVirgula.TabIndex = 3;
            this.btnVirgula.Text = ",";
            this.btnVirgula.UseVisualStyleBackColor = true;
            this.btnVirgula.Click += new System.EventHandler(this.btnVirgula_Click);
            // 
            // lblOperacao
            // 
            this.lblOperacao.AutoSize = true;
            this.lblOperacao.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblOperacao.Location = new System.Drawing.Point(15, 48);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(43, 15);
            this.lblOperacao.TabIndex = 0;
            this.lblOperacao.Text = "xxxxxx";
            // 
            // pnlModulra
            // 
            this.pnlModulra.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlModulra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlModulra.Controls.Add(this.btnVirgula);
            this.pnlModulra.Controls.Add(this.btn0);
            this.pnlModulra.Controls.Add(this.btnLimpa);
            this.pnlModulra.Controls.Add(this.btnCalcular);
            this.pnlModulra.Controls.Add(this.btn3);
            this.pnlModulra.Controls.Add(this.btn6);
            this.pnlModulra.Controls.Add(this.btnDiv);
            this.pnlModulra.Controls.Add(this.btnMult);
            this.pnlModulra.Controls.Add(this.btnMenos);
            this.pnlModulra.Controls.Add(this.btnSoma);
            this.pnlModulra.Controls.Add(this.btn9);
            this.pnlModulra.Controls.Add(this.btn2);
            this.pnlModulra.Controls.Add(this.btn5);
            this.pnlModulra.Controls.Add(this.btn8);
            this.pnlModulra.Controls.Add(this.btn7);
            this.pnlModulra.Controls.Add(this.btn4);
            this.pnlModulra.Controls.Add(this.btn1);
            this.pnlModulra.Controls.Add(this.lblOperacao);
            this.pnlModulra.Controls.Add(this.txbTela);
            this.pnlModulra.Controls.Add(this.lblTitulo);
            this.pnlModulra.Location = new System.Drawing.Point(29, 27);
            this.pnlModulra.Name = "pnlModulra";
            this.pnlModulra.Size = new System.Drawing.Size(273, 295);
            this.pnlModulra.TabIndex = 3;
            this.pnlModulra.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlModulra_Paint);
            // 
            // FrmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(329, 334);
            this.Controls.Add(this.pnlModulra);
            this.Name = "FrmCalculadora";
            this.Text = "FrmCalculadora";
            this.Load += new System.EventHandler(this.FrmCalculadora_Load);
            this.pnlModulra.ResumeLayout(false);
            this.pnlModulra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblTitulo;
        private TextBox txbTela;
        private Button btn1;
        private Button btn4;
        private Button btn7;
        private Button btn8;
        private Button btn5;
        private Button btn2;
        private Button btn9;
        private Button btnSoma;
        private Button btnMenos;
        private Button btnMult;
        private Button btnDiv;
        private Button btn6;
        private Button btn3;
        private Button btnCalcular;
        private Button btnLimpa;
        private Button btn0;
        private Button btnVirgula;
        private Label lblOperacao;
        private Panel pnlModulra;
    }
}