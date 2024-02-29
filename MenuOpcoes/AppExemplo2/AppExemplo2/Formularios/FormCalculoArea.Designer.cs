namespace AppExemplo2.Formularios
{
    partial class FormCalculoArea
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
            this.txtCatetoB = new System.Windows.Forms.TextBox();
            this.LbPercentual = new System.Windows.Forms.Label();
            this.txtCatetoA = new System.Windows.Forms.TextBox();
            this.cbTipoCalculo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btNovo = new System.Windows.Forms.Button();
            this.btCalcular = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHipotenusa = new System.Windows.Forms.TextBox();
            this.lbHipotenusa = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.LbArea = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCatetoB
            // 
            this.txtCatetoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCatetoB.Location = new System.Drawing.Point(51, 266);
            this.txtCatetoB.Name = "txtCatetoB";
            this.txtCatetoB.Size = new System.Drawing.Size(177, 26);
            this.txtCatetoB.TabIndex = 53;
            // 
            // LbPercentual
            // 
            this.LbPercentual.AutoSize = true;
            this.LbPercentual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPercentual.Location = new System.Drawing.Point(52, 248);
            this.LbPercentual.Name = "LbPercentual";
            this.LbPercentual.Size = new System.Drawing.Size(127, 21);
            this.LbPercentual.TabIndex = 52;
            this.LbPercentual.Text = "Lado B (Cateto)";
            // 
            // txtCatetoA
            // 
            this.txtCatetoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCatetoA.Location = new System.Drawing.Point(49, 208);
            this.txtCatetoA.Name = "txtCatetoA";
            this.txtCatetoA.Size = new System.Drawing.Size(177, 26);
            this.txtCatetoA.TabIndex = 51;
            // 
            // cbTipoCalculo
            // 
            this.cbTipoCalculo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTipoCalculo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTipoCalculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoCalculo.FormattingEnabled = true;
            this.cbTipoCalculo.Items.AddRange(new object[] {
            "Calcular Área",
            "Descobrir o Valor de (a)",
            "Descobrir o Valor de (b)",
            "Descobrir o Valor de (c)"});
            this.cbTipoCalculo.Location = new System.Drawing.Point(47, 135);
            this.cbTipoCalculo.Name = "cbTipoCalculo";
            this.cbTipoCalculo.Size = new System.Drawing.Size(275, 28);
            this.cbTipoCalculo.TabIndex = 50;
            this.cbTipoCalculo.SelectedIndexChanged += new System.EventHandler(this.cbTipoCalculo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 21);
            this.label3.TabIndex = 49;
            this.label3.Text = "Lado A (Cateto)";
            // 
            // btNovo
            // 
            this.btNovo.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btNovo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btNovo.Location = new System.Drawing.Point(459, 371);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(76, 39);
            this.btNovo.TabIndex = 48;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = false;
            // 
            // btCalcular
            // 
            this.btCalcular.BackColor = System.Drawing.Color.Green;
            this.btCalcular.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCalcular.Location = new System.Drawing.Point(325, 371);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(128, 39);
            this.btCalcular.TabIndex = 47;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = false;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 21);
            this.label4.TabIndex = 46;
            this.label4.Text = "Selecione o Tipo de Calculo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Coral;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(134, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 100);
            this.label1.TabIndex = 45;
            this.label1.Text = "Calculo Triangulo Retangulo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Coral;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(-36, -19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(697, 115);
            this.label2.TabIndex = 44;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtHipotenusa
            // 
            this.txtHipotenusa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHipotenusa.Location = new System.Drawing.Point(51, 327);
            this.txtHipotenusa.Name = "txtHipotenusa";
            this.txtHipotenusa.Size = new System.Drawing.Size(177, 26);
            this.txtHipotenusa.TabIndex = 55;
            // 
            // lbHipotenusa
            // 
            this.lbHipotenusa.AutoSize = true;
            this.lbHipotenusa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHipotenusa.Location = new System.Drawing.Point(51, 307);
            this.lbHipotenusa.Name = "lbHipotenusa";
            this.lbHipotenusa.Size = new System.Drawing.Size(165, 21);
            this.lbHipotenusa.TabIndex = 54;
            this.lbHipotenusa.Text = "Lado C (Hipotenusa)";
            // 
            // txtArea
            // 
            this.txtArea.BackColor = System.Drawing.Color.FloralWhite;
            this.txtArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArea.Location = new System.Drawing.Point(49, 384);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(174, 26);
            this.txtArea.TabIndex = 57;
            // 
            // LbArea
            // 
            this.LbArea.AutoSize = true;
            this.LbArea.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbArea.Location = new System.Drawing.Point(52, 365);
            this.LbArea.Name = "LbArea";
            this.LbArea.Size = new System.Drawing.Size(82, 21);
            this.LbArea.TabIndex = 56;
            this.LbArea.Text = "Area (m²)";
            // 
            // FormCalculoArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(659, 449);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.LbArea);
            this.Controls.Add(this.txtHipotenusa);
            this.Controls.Add(this.lbHipotenusa);
            this.Controls.Add(this.txtCatetoB);
            this.Controls.Add(this.LbPercentual);
            this.Controls.Add(this.txtCatetoA);
            this.Controls.Add(this.cbTipoCalculo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "FormCalculoArea";
            this.Text = "FormCalculoArea";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCatetoB;
        private System.Windows.Forms.Label LbPercentual;
        private System.Windows.Forms.TextBox txtCatetoA;
        private System.Windows.Forms.ComboBox cbTipoCalculo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHipotenusa;
        private System.Windows.Forms.Label lbHipotenusa;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label LbArea;
    }
}