namespace AppExemplo2.Formularios
{
    partial class FormExemploRotulos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPercentual = new System.Windows.Forms.TextBox();
            this.LbResultado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btNovo = new System.Windows.Forms.Button();
            this.btCalcular = new System.Windows.Forms.Button();
            this.txtSalarioAtual = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(553, 46);
            this.label1.TabIndex = 14;
            this.label1.Text = "Reajuste Salarial";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.IndianRed;
            this.label2.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(8, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(562, 52);
            this.label2.TabIndex = 13;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPercentual
            // 
            this.txtPercentual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercentual.Location = new System.Drawing.Point(53, 227);
            this.txtPercentual.Name = "txtPercentual";
            this.txtPercentual.Size = new System.Drawing.Size(155, 26);
            this.txtPercentual.TabIndex = 31;
            // 
            // LbResultado
            // 
            this.LbResultado.AutoSize = true;
            this.LbResultado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbResultado.Location = new System.Drawing.Point(56, 363);
            this.LbResultado.Name = "LbResultado";
            this.LbResultado.Size = new System.Drawing.Size(156, 21);
            this.LbResultado.TabIndex = 30;
            this.LbResultado.Text = "Salario Reajustado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 21);
            this.label3.TabIndex = 29;
            this.label3.Text = "Perc(%) Reajuste:";
            // 
            // btNovo
            // 
            this.btNovo.BackColor = System.Drawing.Color.Firebrick;
            this.btNovo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btNovo.Location = new System.Drawing.Point(189, 287);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(76, 39);
            this.btNovo.TabIndex = 28;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = false;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btCalcular
            // 
            this.btCalcular.BackColor = System.Drawing.Color.IndianRed;
            this.btCalcular.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCalcular.Location = new System.Drawing.Point(55, 287);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(128, 39);
            this.btCalcular.TabIndex = 27;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = false;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // txtSalarioAtual
            // 
            this.txtSalarioAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioAtual.Location = new System.Drawing.Point(53, 153);
            this.txtSalarioAtual.Name = "txtSalarioAtual";
            this.txtSalarioAtual.Size = new System.Drawing.Size(155, 26);
            this.txtSalarioAtual.TabIndex = 25;
            this.txtSalarioAtual.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSalarioAtual_KeyDown);
            this.txtSalarioAtual.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSalarioAtual_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "Salario Atual:";
            // 
            // FormExemploRotulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(578, 450);
            this.Controls.Add(this.txtPercentual);
            this.Controls.Add(this.LbResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.txtSalarioAtual);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "FormExemploRotulos";
            this.Text = "FormExemploRotulos";
            this.Load += new System.EventHandler(this.FormExemploRotulos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPercentual;
        private System.Windows.Forms.Label LbResultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.TextBox txtSalarioAtual;
        private System.Windows.Forms.Label label4;
    }
}