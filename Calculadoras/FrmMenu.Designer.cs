namespace Calculadoras
{
    partial class FrmMenu
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
            this.btnMenuIMC = new System.Windows.Forms.Button();
            this.btnCalculadoraSimples = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMenuIMC
            // 
            this.btnMenuIMC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMenuIMC.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMenuIMC.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMenuIMC.Location = new System.Drawing.Point(83, 82);
            this.btnMenuIMC.Name = "btnMenuIMC";
            this.btnMenuIMC.Size = new System.Drawing.Size(139, 79);
            this.btnMenuIMC.TabIndex = 0;
            this.btnMenuIMC.Text = "Calculadora\r\nIMC";
            this.btnMenuIMC.UseVisualStyleBackColor = false;
            this.btnMenuIMC.Click += new System.EventHandler(this.btnMenuIMC_Click);
            // 
            // btnCalculadoraSimples
            // 
            this.btnCalculadoraSimples.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCalculadoraSimples.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCalculadoraSimples.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalculadoraSimples.Location = new System.Drawing.Point(262, 82);
            this.btnCalculadoraSimples.Name = "btnCalculadoraSimples";
            this.btnCalculadoraSimples.Size = new System.Drawing.Size(139, 79);
            this.btnCalculadoraSimples.TabIndex = 1;
            this.btnCalculadoraSimples.Text = "Calculadora\r\nSimples";
            this.btnCalculadoraSimples.UseVisualStyleBackColor = false;
            this.btnCalculadoraSimples.Click += new System.EventHandler(this.btnCalculadoraSimples_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(493, 252);
            this.Controls.Add(this.btnCalculadoraSimples);
            this.Controls.Add(this.btnMenuIMC);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnMenuIMC;
        private Button btnCalculadoraSimples;
    }
}