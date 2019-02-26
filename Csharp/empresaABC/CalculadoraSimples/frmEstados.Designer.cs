namespace CalculadoraSimples
{
    partial class frmEstados
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
            this.btnCarregaEstados = new System.Windows.Forms.Button();
            this.lblEstados = new System.Windows.Forms.Label();
            this.cboEstados = new System.Windows.Forms.ComboBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnLista = new System.Windows.Forms.Button();
            this.ltbLista = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblReceber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCarregaEstados
            // 
            this.btnCarregaEstados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregaEstados.Location = new System.Drawing.Point(23, 141);
            this.btnCarregaEstados.Name = "btnCarregaEstados";
            this.btnCarregaEstados.Size = new System.Drawing.Size(105, 50);
            this.btnCarregaEstados.TabIndex = 5;
            this.btnCarregaEstados.Text = "Carrega Estados";
            this.btnCarregaEstados.UseVisualStyleBackColor = true;
            this.btnCarregaEstados.Click += new System.EventHandler(this.btnCarregaEstados_Click);
            // 
            // lblEstados
            // 
            this.lblEstados.AutoSize = true;
            this.lblEstados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstados.Location = new System.Drawing.Point(31, 9);
            this.lblEstados.Name = "lblEstados";
            this.lblEstados.Size = new System.Drawing.Size(97, 25);
            this.lblEstados.TabIndex = 4;
            this.lblEstados.Text = "Estados";
            // 
            // cboEstados
            // 
            this.cboEstados.FormattingEnabled = true;
            this.cboEstados.Location = new System.Drawing.Point(23, 53);
            this.cboEstados.Name = "cboEstados";
            this.cboEstados.Size = new System.Drawing.Size(105, 21);
            this.cboEstados.TabIndex = 3;
            this.cboEstados.SelectedIndexChanged += new System.EventHandler(this.cboEstados_SelectedIndexChanged);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(395, 248);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(105, 50);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnLista
            // 
            this.btnLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLista.Location = new System.Drawing.Point(23, 248);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(105, 50);
            this.btnLista.TabIndex = 7;
            this.btnLista.Text = "Carrega Lista";
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // ltbLista
            // 
            this.ltbLista.FormattingEnabled = true;
            this.ltbLista.Location = new System.Drawing.Point(380, 53);
            this.ltbLista.Name = "ltbLista";
            this.ltbLista.Size = new System.Drawing.Size(120, 95);
            this.ltbLista.TabIndex = 8;
            this.ltbLista.SelectedIndexChanged += new System.EventHandler(this.ltb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(391, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Estados";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(206, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 50);
            this.button1.TabIndex = 10;
            this.button1.Text = "Carrega Label";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblReceber
            // 
            this.lblReceber.AutoSize = true;
            this.lblReceber.Location = new System.Drawing.Point(206, 177);
            this.lblReceber.Name = "lblReceber";
            this.lblReceber.Size = new System.Drawing.Size(35, 13);
            this.lblReceber.TabIndex = 11;
            this.lblReceber.Text = "label2";
            // 
            // frmEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 338);
            this.Controls.Add(this.lblReceber);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ltbLista);
            this.Controls.Add(this.btnLista);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCarregaEstados);
            this.Controls.Add(this.lblEstados);
            this.Controls.Add(this.cboEstados);
            this.Name = "frmEstados";
            this.Text = "frmEstados";
            this.Load += new System.EventHandler(this.frmEstados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCarregaEstados;
        private System.Windows.Forms.Label lblEstados;
        private System.Windows.Forms.ComboBox cboEstados;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.ListBox ltbLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblReceber;
    }
}