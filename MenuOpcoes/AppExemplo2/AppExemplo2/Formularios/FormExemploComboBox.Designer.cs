namespace AppExemplo2.Formularios
{
    partial class FormExemploComboBox
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
            this.label3 = new System.Windows.Forms.Label();
            this.btNovo = new System.Windows.Forms.Button();
            this.btCalcular = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTipoCliente = new System.Windows.Forms.ComboBox();
            this.txtValorCompra = new System.Windows.Forms.TextBox();
            this.txtPercDesconto = new System.Windows.Forms.TextBox();
            this.LbPercentual = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 21);
            this.label3.TabIndex = 36;
            this.label3.Text = "Valor da Compra:";
            // 
            // btNovo
            // 
            this.btNovo.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btNovo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btNovo.Location = new System.Drawing.Point(468, 357);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(76, 39);
            this.btNovo.TabIndex = 35;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = false;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btCalcular
            // 
            this.btCalcular.BackColor = System.Drawing.Color.Green;
            this.btCalcular.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCalcular.Location = new System.Drawing.Point(334, 357);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(128, 39);
            this.btCalcular.TabIndex = 34;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = false;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 21);
            this.label4.TabIndex = 32;
            this.label4.Text = "Selecione o tipo de cliente ";
            // 
            // cbTipoCliente
            // 
            this.cbTipoCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTipoCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTipoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoCliente.FormattingEnabled = true;
            this.cbTipoCliente.Items.AddRange(new object[] {
            "Cliente Diamente: 25%",
            "Cliente Ouro: 20%",
            "Cliente VIP: 15%",
            "Cliente Comum: 10%",
            "Cliente  Esporadico: 5%"});
            this.cbTipoCliente.Location = new System.Drawing.Point(66, 155);
            this.cbTipoCliente.Name = "cbTipoCliente";
            this.cbTipoCliente.Size = new System.Drawing.Size(205, 28);
            this.cbTipoCliente.TabIndex = 38;
            this.cbTipoCliente.SelectedIndexChanged += new System.EventHandler(this.cbTipoCliente_SelectedIndexChanged);
            // 
            // txtValorCompra
            // 
            this.txtValorCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorCompra.Location = new System.Drawing.Point(68, 241);
            this.txtValorCompra.Name = "txtValorCompra";
            this.txtValorCompra.Size = new System.Drawing.Size(155, 26);
            this.txtValorCompra.TabIndex = 39;
            // 
            // txtPercDesconto
            // 
            this.txtPercDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercDesconto.Location = new System.Drawing.Point(68, 306);
            this.txtPercDesconto.Name = "txtPercDesconto";
            this.txtPercDesconto.Size = new System.Drawing.Size(155, 26);
            this.txtPercDesconto.TabIndex = 41;
            // 
            // LbPercentual
            // 
            this.LbPercentual.AutoSize = true;
            this.LbPercentual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPercentual.Location = new System.Drawing.Point(68, 282);
            this.LbPercentual.Name = "LbPercentual";
            this.LbPercentual.Size = new System.Drawing.Size(142, 21);
            this.LbPercentual.TabIndex = 40;
            this.LbPercentual.Text = "Perc(%) Reajuste:";
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.FloralWhite;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(66, 370);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(205, 26);
            this.txtResultado.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(65, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 21);
            this.label6.TabIndex = 42;
            this.label6.Text = "Valor com Desconto:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Coral;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(121, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 100);
            this.label1.TabIndex = 47;
            this.label1.Text = "Sistema de Descontos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Coral;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(-60, -7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(697, 115);
            this.label2.TabIndex = 46;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormExemploComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(635, 449);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPercDesconto);
            this.Controls.Add(this.LbPercentual);
            this.Controls.Add(this.txtValorCompra);
            this.Controls.Add(this.cbTipoCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.label4);
            this.Name = "FormExemploComboBox";
            this.Text = "FormExemploComboBox";
            this.Load += new System.EventHandler(this.FormExemploComboBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTipoCliente;
        private System.Windows.Forms.TextBox txtValorCompra;
        private System.Windows.Forms.TextBox txtPercDesconto;
        private System.Windows.Forms.Label LbPercentual;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}