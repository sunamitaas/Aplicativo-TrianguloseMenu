namespace AppAvaliacaoAtividade2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.desing = new System.Windows.Forms.Label();
            this.desing02 = new System.Windows.Forms.Label();
            this.btEquilatero = new System.Windows.Forms.Button();
            this.txtTriangulo = new System.Windows.Forms.Label();
            this.desing_01 = new System.Windows.Forms.Label();
            this.btRetangulo = new System.Windows.Forms.Button();
            this.btIsosceles = new System.Windows.Forms.Button();
            this.btAreaTriangulo = new System.Windows.Forms.Button();
            this.nomeSuna = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.desing.TabIndex = 70;
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
            this.desing02.TabIndex = 66;
            this.desing02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btEquilatero
            // 
            this.btEquilatero.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btEquilatero.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEquilatero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btEquilatero.Location = new System.Drawing.Point(182, 222);
            this.btEquilatero.Margin = new System.Windows.Forms.Padding(2);
            this.btEquilatero.Name = "btEquilatero";
            this.btEquilatero.Size = new System.Drawing.Size(359, 35);
            this.btEquilatero.TabIndex = 73;
            this.btEquilatero.Text = "Triângulo Equilátero";
            this.btEquilatero.UseVisualStyleBackColor = false;
            this.btEquilatero.Click += new System.EventHandler(this.btEquilatero_Click);
            // 
            // txtTriangulo
            // 
            this.txtTriangulo.BackColor = System.Drawing.Color.PaleVioletRed;
            this.txtTriangulo.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTriangulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTriangulo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txtTriangulo.Location = new System.Drawing.Point(117, 43);
            this.txtTriangulo.Name = "txtTriangulo";
            this.txtTriangulo.Size = new System.Drawing.Size(492, 71);
            this.txtTriangulo.TabIndex = 79;
            this.txtTriangulo.Text = "Cálculo de Formas Triângulares";
            this.txtTriangulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.desing_01.TabIndex = 81;
            this.desing_01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btRetangulo
            // 
            this.btRetangulo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btRetangulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRetangulo.ForeColor = System.Drawing.Color.Black;
            this.btRetangulo.Location = new System.Drawing.Point(183, 274);
            this.btRetangulo.Margin = new System.Windows.Forms.Padding(2);
            this.btRetangulo.Name = "btRetangulo";
            this.btRetangulo.Size = new System.Drawing.Size(359, 35);
            this.btRetangulo.TabIndex = 82;
            this.btRetangulo.Text = " Triângulo Retângulo";
            this.btRetangulo.UseVisualStyleBackColor = false;
            this.btRetangulo.Click += new System.EventHandler(this.btRetangulo_Click);
            // 
            // btIsosceles
            // 
            this.btIsosceles.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btIsosceles.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIsosceles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btIsosceles.Location = new System.Drawing.Point(183, 328);
            this.btIsosceles.Margin = new System.Windows.Forms.Padding(2);
            this.btIsosceles.Name = "btIsosceles";
            this.btIsosceles.Size = new System.Drawing.Size(359, 35);
            this.btIsosceles.TabIndex = 84;
            this.btIsosceles.Text = "Triângulo Isósceles";
            this.btIsosceles.UseVisualStyleBackColor = false;
            this.btIsosceles.Click += new System.EventHandler(this.btIsosceles_Click);
            // 
            // btAreaTriangulo
            // 
            this.btAreaTriangulo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btAreaTriangulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAreaTriangulo.ForeColor = System.Drawing.Color.Black;
            this.btAreaTriangulo.Location = new System.Drawing.Point(183, 379);
            this.btAreaTriangulo.Margin = new System.Windows.Forms.Padding(2);
            this.btAreaTriangulo.Name = "btAreaTriangulo";
            this.btAreaTriangulo.Size = new System.Drawing.Size(359, 35);
            this.btAreaTriangulo.TabIndex = 85;
            this.btAreaTriangulo.Text = "Área de Triângulos ";
            this.btAreaTriangulo.UseVisualStyleBackColor = false;
            this.btAreaTriangulo.Click += new System.EventHandler(this.btAreaTriangulo_Click);
            // 
            // nomeSuna
            // 
            this.nomeSuna.BackColor = System.Drawing.Color.White;
            this.nomeSuna.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeSuna.ForeColor = System.Drawing.Color.DimGray;
            this.nomeSuna.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.nomeSuna.Location = new System.Drawing.Point(543, 552);
            this.nomeSuna.Name = "nomeSuna";
            this.nomeSuna.Size = new System.Drawing.Size(169, 19);
            this.nomeSuna.TabIndex = 86;
            this.nomeSuna.Text = "Sunamita Santos";
            this.nomeSuna.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nome
            // 
            this.nome.BackColor = System.Drawing.Color.White;
            this.nome.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.nome.Location = new System.Drawing.Point(493, 552);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(47, 19);
            this.nome.TabIndex = 87;
            this.nome.Text = "Nome:";
            this.nome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 582);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.nomeSuna);
            this.Controls.Add(this.btAreaTriangulo);
            this.Controls.Add(this.btIsosceles);
            this.Controls.Add(this.btRetangulo);
            this.Controls.Add(this.desing_01);
            this.Controls.Add(this.txtTriangulo);
            this.Controls.Add(this.btEquilatero);
            this.Controls.Add(this.desing);
            this.Controls.Add(this.desing02);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label desing;
        private System.Windows.Forms.Label desing02;
        private System.Windows.Forms.Button btEquilatero;
        private System.Windows.Forms.Label txtTriangulo;
        private System.Windows.Forms.Label desing_01;
        private System.Windows.Forms.Button btRetangulo;
        private System.Windows.Forms.Button btIsosceles;
        private System.Windows.Forms.Button btAreaTriangulo;
        private System.Windows.Forms.Label nomeSuna;
        private System.Windows.Forms.Label nome;
    }
}

