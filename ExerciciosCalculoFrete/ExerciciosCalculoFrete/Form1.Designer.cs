namespace ExerciciosCalculoFrete
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimparCampos = new System.Windows.Forms.Button();
            this.btnCalcularFrete = new System.Windows.Forms.Button();
            this.cbxUf = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFrete = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblValorCompra = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(50, 32);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(175, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(50, 62);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(117, 20);
            this.txtValor.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(9, 39);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(9, 65);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 3;
            this.lblValor.Text = "Valor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimparCampos);
            this.groupBox1.Controls.Add(this.btnCalcularFrete);
            this.groupBox1.Controls.Add(this.cbxUf);
            this.groupBox1.Controls.Add(this.lblEstado);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.lblValor);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.txtValor);
            this.groupBox1.Location = new System.Drawing.Point(28, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 172);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da Entrega";
            // 
            // btnLimparCampos
            // 
            this.btnLimparCampos.Location = new System.Drawing.Point(170, 130);
            this.btnLimparCampos.Name = "btnLimparCampos";
            this.btnLimparCampos.Size = new System.Drawing.Size(93, 36);
            this.btnLimparCampos.TabIndex = 7;
            this.btnLimparCampos.Text = "Limpar";
            this.btnLimparCampos.UseVisualStyleBackColor = true;
            this.btnLimparCampos.Click += new System.EventHandler(this.btnLimparCampos_Click);
            // 
            // btnCalcularFrete
            // 
            this.btnCalcularFrete.Location = new System.Drawing.Point(37, 130);
            this.btnCalcularFrete.Name = "btnCalcularFrete";
            this.btnCalcularFrete.Size = new System.Drawing.Size(95, 36);
            this.btnCalcularFrete.TabIndex = 6;
            this.btnCalcularFrete.Text = "Calcular";
            this.btnCalcularFrete.UseVisualStyleBackColor = true;
            this.btnCalcularFrete.Click += new System.EventHandler(this.btnCalcularFrete_Click);
            // 
            // cbxUf
            // 
            this.cbxUf.FormattingEnabled = true;
            this.cbxUf.Items.AddRange(new object[] {
            "SP",
            "RJ",
            "AM",
            "RS",
            "SC"});
            this.cbxUf.Location = new System.Drawing.Point(50, 90);
            this.cbxUf.Name = "cbxUf";
            this.cbxUf.Size = new System.Drawing.Size(117, 21);
            this.cbxUf.TabIndex = 5;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(7, 93);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Estado";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblValorCompra);
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.lblFrete);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(28, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 116);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Valores Calculados";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Frete";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Valor da Compra";
            // 
            // lblFrete
            // 
            this.lblFrete.AutoSize = true;
            this.lblFrete.Location = new System.Drawing.Point(124, 56);
            this.lblFrete.Name = "lblFrete";
            this.lblFrete.Size = new System.Drawing.Size(43, 13);
            this.lblFrete.TabIndex = 4;
            this.lblFrete.Text = "______";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(124, 87);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(43, 13);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "______";
            // 
            // lblValorCompra
            // 
            this.lblValorCompra.AutoSize = true;
            this.lblValorCompra.Location = new System.Drawing.Point(124, 25);
            this.lblValorCompra.Name = "lblValorCompra";
            this.lblValorCompra.Size = new System.Drawing.Size(43, 13);
            this.lblValorCompra.TabIndex = 6;
            this.lblValorCompra.Text = "______";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 381);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Cálculo de Frete";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimparCampos;
        private System.Windows.Forms.Button btnCalcularFrete;
        private System.Windows.Forms.ComboBox cbxUf;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblValorCompra;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblFrete;
    }
}

