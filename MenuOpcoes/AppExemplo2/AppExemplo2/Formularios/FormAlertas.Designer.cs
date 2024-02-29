namespace AppExemplo2.Formularios
{
    partial class FormAlertas
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
            this.btPergunta = new System.Windows.Forms.Button();
            this.btErro = new System.Windows.Forms.Button();
            this.btAtencao = new System.Windows.Forms.Button();
            this.btInformacao = new System.Windows.Forms.Button();
            this.btExemplo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(553, 46);
            this.label1.TabIndex = 12;
            this.label1.Text = "Alertas de Interação com o Usuário";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.IndianRed;
            this.label2.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(8, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(562, 52);
            this.label2.TabIndex = 11;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btPergunta
            // 
            this.btPergunta.BackColor = System.Drawing.Color.IndianRed;
            this.btPergunta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btPergunta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btPergunta.Location = new System.Drawing.Point(161, 273);
            this.btPergunta.Name = "btPergunta";
            this.btPergunta.Size = new System.Drawing.Size(250, 38);
            this.btPergunta.TabIndex = 10;
            this.btPergunta.Text = "Pergunta";
            this.btPergunta.UseVisualStyleBackColor = false;
            this.btPergunta.Click += new System.EventHandler(this.btPergunta_Click);
            // 
            // btErro
            // 
            this.btErro.BackColor = System.Drawing.Color.Salmon;
            this.btErro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btErro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btErro.Location = new System.Drawing.Point(161, 228);
            this.btErro.Name = "btErro";
            this.btErro.Size = new System.Drawing.Size(250, 38);
            this.btErro.TabIndex = 9;
            this.btErro.Text = "Erro";
            this.btErro.UseVisualStyleBackColor = false;
            this.btErro.Click += new System.EventHandler(this.btErro_Click);
            // 
            // btAtencao
            // 
            this.btAtencao.BackColor = System.Drawing.Color.LightCoral;
            this.btAtencao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btAtencao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAtencao.Location = new System.Drawing.Point(161, 179);
            this.btAtencao.Name = "btAtencao";
            this.btAtencao.Size = new System.Drawing.Size(250, 38);
            this.btAtencao.TabIndex = 8;
            this.btAtencao.Text = "Atenção";
            this.btAtencao.UseVisualStyleBackColor = false;
            this.btAtencao.Click += new System.EventHandler(this.btAtencao_Click);
            // 
            // btInformacao
            // 
            this.btInformacao.BackColor = System.Drawing.Color.IndianRed;
            this.btInformacao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btInformacao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btInformacao.Location = new System.Drawing.Point(161, 129);
            this.btInformacao.Name = "btInformacao";
            this.btInformacao.Size = new System.Drawing.Size(250, 38);
            this.btInformacao.TabIndex = 7;
            this.btInformacao.Text = "Informação";
            this.btInformacao.UseVisualStyleBackColor = false;
            this.btInformacao.Click += new System.EventHandler(this.btInformacao_Click);
            // 
            // btExemplo
            // 
            this.btExemplo.BackColor = System.Drawing.Color.LightCoral;
            this.btExemplo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btExemplo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btExemplo.Location = new System.Drawing.Point(161, 321);
            this.btExemplo.Name = "btExemplo";
            this.btExemplo.Size = new System.Drawing.Size(250, 38);
            this.btExemplo.TabIndex = 13;
            this.btExemplo.Text = "Exemplo";
            this.btExemplo.UseVisualStyleBackColor = false;
            this.btExemplo.Click += new System.EventHandler(this.btExemplo_Click);
            // 
            // FormAlertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(575, 450);
            this.Controls.Add(this.btExemplo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btPergunta);
            this.Controls.Add(this.btErro);
            this.Controls.Add(this.btAtencao);
            this.Controls.Add(this.btInformacao);
            this.Name = "FormAlertas";
            this.Text = "FormAlertas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btPergunta;
        private System.Windows.Forms.Button btErro;
        private System.Windows.Forms.Button btAtencao;
        private System.Windows.Forms.Button btInformacao;
        private System.Windows.Forms.Button btExemplo;
    }
}