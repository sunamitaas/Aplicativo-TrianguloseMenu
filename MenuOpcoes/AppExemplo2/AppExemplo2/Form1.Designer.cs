namespace AppExemplo2
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
            this.btAlertas = new System.Windows.Forms.Button();
            this.btExemploAlerta = new System.Windows.Forms.Button();
            this.btAlteracaoRotulo = new System.Windows.Forms.Button();
            this.btComboBox = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btAlertas
            // 
            this.btAlertas.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btAlertas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btAlertas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAlertas.Location = new System.Drawing.Point(193, 147);
            this.btAlertas.Name = "btAlertas";
            this.btAlertas.Size = new System.Drawing.Size(250, 38);
            this.btAlertas.TabIndex = 1;
            this.btAlertas.Text = "Alertas";
            this.btAlertas.UseVisualStyleBackColor = false;
            this.btAlertas.Click += new System.EventHandler(this.btAlertas_Click);
            // 
            // btExemploAlerta
            // 
            this.btExemploAlerta.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btExemploAlerta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btExemploAlerta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btExemploAlerta.Location = new System.Drawing.Point(193, 210);
            this.btExemploAlerta.Name = "btExemploAlerta";
            this.btExemploAlerta.Size = new System.Drawing.Size(250, 38);
            this.btExemploAlerta.TabIndex = 2;
            this.btExemploAlerta.Text = "Exemplo com Alerta";
            this.btExemploAlerta.UseVisualStyleBackColor = false;
            this.btExemploAlerta.Click += new System.EventHandler(this.btExemploAlerta_Click);
            // 
            // btAlteracaoRotulo
            // 
            this.btAlteracaoRotulo.BackColor = System.Drawing.Color.Salmon;
            this.btAlteracaoRotulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btAlteracaoRotulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAlteracaoRotulo.Location = new System.Drawing.Point(193, 273);
            this.btAlteracaoRotulo.Name = "btAlteracaoRotulo";
            this.btAlteracaoRotulo.Size = new System.Drawing.Size(250, 38);
            this.btAlteracaoRotulo.TabIndex = 3;
            this.btAlteracaoRotulo.Text = "Exemplo Alteração de Rótulo";
            this.btAlteracaoRotulo.UseVisualStyleBackColor = false;
            this.btAlteracaoRotulo.Click += new System.EventHandler(this.btAlteracaoRotulo_Click);
            // 
            // btComboBox
            // 
            this.btComboBox.BackColor = System.Drawing.Color.IndianRed;
            this.btComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btComboBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btComboBox.Location = new System.Drawing.Point(193, 336);
            this.btComboBox.Name = "btComboBox";
            this.btComboBox.Size = new System.Drawing.Size(250, 38);
            this.btComboBox.TabIndex = 4;
            this.btComboBox.Text = "Exemplo com Combobox";
            this.btComboBox.UseVisualStyleBackColor = false;
            this.btComboBox.Click += new System.EventHandler(this.btComboBox_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(193, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "Exemplo Calculo de Area\r\n";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Coral;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(133, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 100);
            this.label1.TabIndex = 49;
            this.label1.Text = "Menu de Opções";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Coral;
            this.label2.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(-21, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(697, 115);
            this.label2.TabIndex = 48;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(654, 481);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btComboBox);
            this.Controls.Add(this.btAlteracaoRotulo);
            this.Controls.Add(this.btExemploAlerta);
            this.Controls.Add(this.btAlertas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btAlertas;
        private System.Windows.Forms.Button btExemploAlerta;
        private System.Windows.Forms.Button btAlteracaoRotulo;
        private System.Windows.Forms.Button btComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

