namespace Calculadorasimples
{
    partial class frmCalculadoraSimples
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.lblProdutoCalculo = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnSomar = new System.Windows.Forms.Button();
            this.txtSegundoNumero = new System.Windows.Forms.TextBox();
            this.lblSegundoNumero = new System.Windows.Forms.Label();
            this.txtPrimeiroNumero = new System.Windows.Forms.TextBox();
            this.lblprimeiroNumero = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDividir);
            this.groupBox1.Controls.Add(this.btnMultiplicar);
            this.groupBox1.Controls.Add(this.btnSubtrair);
            this.groupBox1.Controls.Add(this.lblProdutoCalculo);
            this.groupBox1.Controls.Add(this.lblResultado);
            this.groupBox1.Controls.Add(this.btnSomar);
            this.groupBox1.Controls.Add(this.txtSegundoNumero);
            this.groupBox1.Controls.Add(this.lblSegundoNumero);
            this.groupBox1.Controls.Add(this.txtPrimeiroNumero);
            this.groupBox1.Controls.Add(this.lblprimeiroNumero);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 403);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnDividir
            // 
            this.btnDividir.BackColor = System.Drawing.Color.Purple;
            this.btnDividir.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDividir.ForeColor = System.Drawing.Color.White;
            this.btnDividir.Location = new System.Drawing.Point(355, 258);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(136, 35);
            this.btnDividir.TabIndex = 9;
            this.btnDividir.Text = "Dividir";
            this.btnDividir.UseVisualStyleBackColor = false;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnMultiplicar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicar.Location = new System.Drawing.Point(355, 210);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(136, 42);
            this.btnMultiplicar.TabIndex = 8;
            this.btnMultiplicar.Text = "Multiplicar";
            this.btnMultiplicar.UseVisualStyleBackColor = false;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.BackColor = System.Drawing.Color.DarkRed;
            this.btnSubtrair.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtrair.ForeColor = System.Drawing.Color.White;
            this.btnSubtrair.Location = new System.Drawing.Point(355, 164);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(136, 40);
            this.btnSubtrair.TabIndex = 7;
            this.btnSubtrair.Text = "Subtrair";
            this.btnSubtrair.UseVisualStyleBackColor = false;
            this.btnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
            // 
            // lblProdutoCalculo
            // 
            this.lblProdutoCalculo.AutoSize = true;
            this.lblProdutoCalculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutoCalculo.Location = new System.Drawing.Point(150, 337);
            this.lblProdutoCalculo.Name = "lblProdutoCalculo";
            this.lblProdutoCalculo.Size = new System.Drawing.Size(20, 24);
            this.lblProdutoCalculo.TabIndex = 6;
            this.lblProdutoCalculo.Text = "0";
            this.lblProdutoCalculo.Click += new System.EventHandler(this.lblProdutoCalculo_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(58, 341);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(86, 20);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resultado:";
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // btnSomar
            // 
            this.btnSomar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSomar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSomar.ForeColor = System.Drawing.Color.White;
            this.btnSomar.Location = new System.Drawing.Point(355, 113);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(136, 45);
            this.btnSomar.TabIndex = 4;
            this.btnSomar.Text = "Somar";
            this.btnSomar.UseVisualStyleBackColor = false;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // txtSegundoNumero
            // 
            this.txtSegundoNumero.Location = new System.Drawing.Point(62, 197);
            this.txtSegundoNumero.Name = "txtSegundoNumero";
            this.txtSegundoNumero.Size = new System.Drawing.Size(130, 20);
            this.txtSegundoNumero.TabIndex = 3;
            // 
            // lblSegundoNumero
            // 
            this.lblSegundoNumero.AutoSize = true;
            this.lblSegundoNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoNumero.Location = new System.Drawing.Point(58, 164);
            this.lblSegundoNumero.Name = "lblSegundoNumero";
            this.lblSegundoNumero.Size = new System.Drawing.Size(134, 20);
            this.lblSegundoNumero.TabIndex = 2;
            this.lblSegundoNumero.Text = "Segundo Número";
            // 
            // txtPrimeiroNumero
            // 
            this.txtPrimeiroNumero.Location = new System.Drawing.Point(62, 113);
            this.txtPrimeiroNumero.Name = "txtPrimeiroNumero";
            this.txtPrimeiroNumero.Size = new System.Drawing.Size(128, 20);
            this.txtPrimeiroNumero.TabIndex = 1;
            // 
            // lblprimeiroNumero
            // 
            this.lblprimeiroNumero.AutoSize = true;
            this.lblprimeiroNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprimeiroNumero.Location = new System.Drawing.Point(58, 76);
            this.lblprimeiroNumero.Name = "lblprimeiroNumero";
            this.lblprimeiroNumero.Size = new System.Drawing.Size(126, 20);
            this.lblprimeiroNumero.TabIndex = 0;
            this.lblprimeiroNumero.Text = "Primeiro Número";
            // 
            // frmCalculadoraSimples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmCalculadoraSimples";
            this.Text = "Calculadora Simples";
            this.Load += new System.EventHandler(this.frmCalculadoraSimples_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPrimeiroNumero;
        private System.Windows.Forms.Label lblprimeiroNumero;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.TextBox txtSegundoNumero;
        private System.Windows.Forms.Label lblSegundoNumero;
        private System.Windows.Forms.Label lblProdutoCalculo;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnDividir;
    }
}

