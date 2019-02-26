namespace CalculadoraSimples
{
    partial class frmCalculadora
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
            this.gpbOperador = new System.Windows.Forms.GroupBox();
            this.rbdDivisao = new System.Windows.Forms.RadioButton();
            this.rbdMultiplicacao = new System.Windows.Forms.RadioButton();
            this.rbdSubtracao = new System.Windows.Forms.RadioButton();
            this.rdbAdicao = new System.Windows.Forms.RadioButton();
            this.lblVar1 = new System.Windows.Forms.Label();
            this.lblVar2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblResu = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gpbOperador.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbOperador
            // 
            this.gpbOperador.Controls.Add(this.rbdDivisao);
            this.gpbOperador.Controls.Add(this.rbdMultiplicacao);
            this.gpbOperador.Controls.Add(this.rbdSubtracao);
            this.gpbOperador.Controls.Add(this.rdbAdicao);
            this.gpbOperador.Location = new System.Drawing.Point(150, 27);
            this.gpbOperador.Name = "gpbOperador";
            this.gpbOperador.Size = new System.Drawing.Size(224, 228);
            this.gpbOperador.TabIndex = 0;
            this.gpbOperador.TabStop = false;
            this.gpbOperador.Text = "Operador";
            // 
            // rbdDivisao
            // 
            this.rbdDivisao.AutoSize = true;
            this.rbdDivisao.Location = new System.Drawing.Point(7, 182);
            this.rbdDivisao.Name = "rbdDivisao";
            this.rbdDivisao.Size = new System.Drawing.Size(74, 17);
            this.rbdDivisao.TabIndex = 3;
            this.rbdDivisao.TabStop = true;
            this.rbdDivisao.Text = "Divisão (/)";
            this.rbdDivisao.UseVisualStyleBackColor = true;
            // 
            // rbdMultiplicacao
            // 
            this.rbdMultiplicacao.AutoSize = true;
            this.rbdMultiplicacao.Location = new System.Drawing.Point(7, 135);
            this.rbdMultiplicacao.Name = "rbdMultiplicacao";
            this.rbdMultiplicacao.Size = new System.Drawing.Size(100, 17);
            this.rbdMultiplicacao.TabIndex = 2;
            this.rbdMultiplicacao.TabStop = true;
            this.rbdMultiplicacao.Text = "Multiplicação (*)";
            this.rbdMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // rbdSubtracao
            // 
            this.rbdSubtracao.AutoSize = true;
            this.rbdSubtracao.Location = new System.Drawing.Point(7, 87);
            this.rbdSubtracao.Name = "rbdSubtracao";
            this.rbdSubtracao.Size = new System.Drawing.Size(86, 17);
            this.rbdSubtracao.TabIndex = 1;
            this.rbdSubtracao.TabStop = true;
            this.rbdSubtracao.Text = "Subtração (-)";
            this.rbdSubtracao.UseVisualStyleBackColor = true;
            // 
            // rdbAdicao
            // 
            this.rdbAdicao.AutoSize = true;
            this.rdbAdicao.Location = new System.Drawing.Point(7, 40);
            this.rdbAdicao.Name = "rdbAdicao";
            this.rdbAdicao.Size = new System.Drawing.Size(73, 17);
            this.rdbAdicao.TabIndex = 0;
            this.rdbAdicao.TabStop = true;
            this.rdbAdicao.Text = "Adição (+)";
            this.rdbAdicao.UseVisualStyleBackColor = true;
            // 
            // lblVar1
            // 
            this.lblVar1.AutoSize = true;
            this.lblVar1.Location = new System.Drawing.Point(13, 30);
            this.lblVar1.Name = "lblVar1";
            this.lblVar1.Size = new System.Drawing.Size(54, 13);
            this.lblVar1.TabIndex = 1;
            this.lblVar1.Text = "Variável 1";
            // 
            // lblVar2
            // 
            this.lblVar2.AutoSize = true;
            this.lblVar2.Location = new System.Drawing.Point(13, 106);
            this.lblVar2.Name = "lblVar2";
            this.lblVar2.Size = new System.Drawing.Size(54, 13);
            this.lblVar2.TabIndex = 2;
            this.lblVar2.Text = "Variável 2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(60, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(73, 106);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(60, 20);
            this.textBox2.TabIndex = 4;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(401, 30);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resultado";
            // 
            // lblResu
            // 
            this.lblResu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResu.Location = new System.Drawing.Point(404, 63);
            this.lblResu.Name = "lblResu";
            this.lblResu.Size = new System.Drawing.Size(90, 63);
            this.lblResu.TabIndex = 6;
            this.lblResu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResu.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(50, 316);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(84, 69);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(213, 316);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(84, 69);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(372, 316);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(84, 69);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 420);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblResu);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblVar2);
            this.Controls.Add(this.lblVar1);
            this.Controls.Add(this.gpbOperador);
            this.Name = "frmCalculadora";
            this.Text = "frmCalculadora";
            this.gpbOperador.ResumeLayout(false);
            this.gpbOperador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbOperador;
        private System.Windows.Forms.RadioButton rbdDivisao;
        private System.Windows.Forms.RadioButton rbdMultiplicacao;
        private System.Windows.Forms.RadioButton rbdSubtracao;
        private System.Windows.Forms.RadioButton rdbAdicao;
        private System.Windows.Forms.Label lblVar1;
        private System.Windows.Forms.Label lblVar2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblResu;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}