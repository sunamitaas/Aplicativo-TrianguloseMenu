namespace AppAvaliacaoAtividade2.Formularios
{
    partial class FormEquilatero
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
            this.desing_01 = new System.Windows.Forms.Label();
            this.txtTriangulo = new System.Windows.Forms.Label();
            this.desing = new System.Windows.Forms.Label();
            this.desing02 = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lbAltura = new System.Windows.Forms.Label();
            this.txtAreaEqui = new System.Windows.Forms.TextBox();
            this.lbAreaEqui = new System.Windows.Forms.Label();
            this.txtLadoTri = new System.Windows.Forms.TextBox();
            this.cbTipoCalculo = new System.Windows.Forms.ComboBox();
            this.lbLadoTri = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btCalcular = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // desing_01
            // 
            this.desing_01.BackColor = System.Drawing.Color.WhiteSmoke;
            this.desing_01.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desing_01.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.desing_01.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.desing_01.Location = new System.Drawing.Point(120, 18);
            this.desing_01.Name = "desing_01";
            this.desing_01.Size = new System.Drawing.Size(10, 122);
            this.desing_01.TabIndex = 96;
            this.desing_01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTriangulo
            // 
            this.txtTriangulo.BackColor = System.Drawing.Color.PaleVioletRed;
            this.txtTriangulo.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTriangulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTriangulo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txtTriangulo.Location = new System.Drawing.Point(116, 69);
            this.txtTriangulo.Name = "txtTriangulo";
            this.txtTriangulo.Size = new System.Drawing.Size(576, 71);
            this.txtTriangulo.TabIndex = 95;
            this.txtTriangulo.Text = "Calculadora para Triângulo Equilátero";
            this.txtTriangulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // desing
            // 
            this.desing.BackColor = System.Drawing.Color.PaleVioletRed;
            this.desing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desing.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.desing.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.desing.Location = new System.Drawing.Point(12, 18);
            this.desing.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.desing.Name = "desing";
            this.desing.Size = new System.Drawing.Size(700, 122);
            this.desing.TabIndex = 94;
            this.desing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // desing02
            // 
            this.desing02.BackColor = System.Drawing.SystemColors.ControlLight;
            this.desing02.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desing02.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.desing02.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.desing02.Location = new System.Drawing.Point(12, 18);
            this.desing02.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.desing02.Name = "desing02";
            this.desing02.Size = new System.Drawing.Size(700, 546);
            this.desing02.TabIndex = 93;
            this.desing02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAltura
            // 
            this.txtAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltura.Location = new System.Drawing.Point(71, 364);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(175, 26);
            this.txtAltura.TabIndex = 136;
            this.txtAltura.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAltura_KeyUp);
            // 
            // lbAltura
            // 
            this.lbAltura.AutoSize = true;
            this.lbAltura.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbAltura.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAltura.Location = new System.Drawing.Point(71, 344);
            this.lbAltura.Name = "lbAltura";
            this.lbAltura.Size = new System.Drawing.Size(158, 21);
            this.lbAltura.TabIndex = 135;
            this.lbAltura.Text = "Altura do Triangulo";
            // 
            // txtAreaEqui
            // 
            this.txtAreaEqui.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAreaEqui.Location = new System.Drawing.Point(71, 413);
            this.txtAreaEqui.Name = "txtAreaEqui";
            this.txtAreaEqui.Size = new System.Drawing.Size(175, 26);
            this.txtAreaEqui.TabIndex = 134;
            this.txtAreaEqui.TextChanged += new System.EventHandler(this.txtAreaEqui_TextChanged);
            this.txtAreaEqui.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAreaEqui_KeyUp);
            // 
            // lbAreaEqui
            // 
            this.lbAreaEqui.AutoSize = true;
            this.lbAreaEqui.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbAreaEqui.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAreaEqui.Location = new System.Drawing.Point(71, 393);
            this.lbAreaEqui.Name = "lbAreaEqui";
            this.lbAreaEqui.Size = new System.Drawing.Size(45, 21);
            this.lbAreaEqui.TabIndex = 133;
            this.lbAreaEqui.Text = "Area";
            this.lbAreaEqui.Click += new System.EventHandler(this.lbAreaEqui_Click);
            // 
            // txtLadoTri
            // 
            this.txtLadoTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLadoTri.Location = new System.Drawing.Point(71, 317);
            this.txtLadoTri.Name = "txtLadoTri";
            this.txtLadoTri.Size = new System.Drawing.Size(177, 26);
            this.txtLadoTri.TabIndex = 132;
            this.txtLadoTri.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtLadoTri_KeyUp);
            // 
            // cbTipoCalculo
            // 
            this.cbTipoCalculo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTipoCalculo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTipoCalculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoCalculo.FormattingEnabled = true;
            this.cbTipoCalculo.Items.AddRange(new object[] {
            "Calcular a área do triângulo equilátero",
            "Calcular a altura do triângulo equilátero",
            "Encontrar o lado do triângulo"});
            this.cbTipoCalculo.Location = new System.Drawing.Point(69, 212);
            this.cbTipoCalculo.Name = "cbTipoCalculo";
            this.cbTipoCalculo.Size = new System.Drawing.Size(275, 28);
            this.cbTipoCalculo.TabIndex = 131;
            this.cbTipoCalculo.SelectedIndexChanged += new System.EventHandler(this.cbTipoCalculo_SelectedIndexChanged);
            // 
            // lbLadoTri
            // 
            this.lbLadoTri.AutoSize = true;
            this.lbLadoTri.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbLadoTri.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLadoTri.Location = new System.Drawing.Point(72, 295);
            this.lbLadoTri.Name = "lbLadoTri";
            this.lbLadoTri.Size = new System.Drawing.Size(148, 21);
            this.lbLadoTri.TabIndex = 130;
            this.lbLadoTri.Text = "Lado do Triângulo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 21);
            this.label4.TabIndex = 129;
            this.label4.Text = "Selecione o Tipo de Calculo";
            // 
            // btCalcular
            // 
            this.btCalcular.BackColor = System.Drawing.Color.Green;
            this.btCalcular.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCalcular.Location = new System.Drawing.Point(454, 476);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(128, 39);
            this.btCalcular.TabIndex = 138;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = false;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // btNovo
            // 
            this.btNovo.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btNovo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btNovo.Location = new System.Drawing.Point(588, 476);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(76, 39);
            this.btNovo.TabIndex = 137;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = false;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // FormEquilatero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 582);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.lbAltura);
            this.Controls.Add(this.txtAreaEqui);
            this.Controls.Add(this.lbAreaEqui);
            this.Controls.Add(this.txtLadoTri);
            this.Controls.Add(this.cbTipoCalculo);
            this.Controls.Add(this.lbLadoTri);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.desing_01);
            this.Controls.Add(this.txtTriangulo);
            this.Controls.Add(this.desing);
            this.Controls.Add(this.desing02);
            this.Name = "FormEquilatero";
            this.Text = "FormEquilatero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label desing_01;
        private System.Windows.Forms.Label txtTriangulo;
        private System.Windows.Forms.Label desing;
        private System.Windows.Forms.Label desing02;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label lbAltura;
        private System.Windows.Forms.TextBox txtAreaEqui;
        private System.Windows.Forms.Label lbAreaEqui;
        private System.Windows.Forms.TextBox txtLadoTri;
        private System.Windows.Forms.ComboBox cbTipoCalculo;
        private System.Windows.Forms.Label lbLadoTri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Button btNovo;
    }
}