namespace CalculadoraSimples
{
    partial class frmNotas
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboCarregaEstados = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCarregaEstados
            // 
            this.btnCarregaEstados.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregaEstados.Location = new System.Drawing.Point(83, 404);
            this.btnCarregaEstados.Name = "btnCarregaEstados";
            this.btnCarregaEstados.Size = new System.Drawing.Size(303, 92);
            this.btnCarregaEstados.TabIndex = 0;
            this.btnCarregaEstados.Text = "Carrega Estados";
            this.btnCarregaEstados.UseVisualStyleBackColor = true;
            this.btnCarregaEstados.Click += new System.EventHandler(this.btnCarregaEstados_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Estados";
            // 
            // cboCarregaEstados
            // 
            this.cboCarregaEstados.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCarregaEstados.FormattingEnabled = true;
            this.cboCarregaEstados.Location = new System.Drawing.Point(83, 80);
            this.cboCarregaEstados.Name = "cboCarregaEstados";
            this.cboCarregaEstados.Size = new System.Drawing.Size(236, 44);
            this.cboCarregaEstados.TabIndex = 2;
            // 
            // frmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 565);
            this.Controls.Add(this.cboCarregaEstados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCarregaEstados);
            this.Name = "frmNotas";
            this.Text = "frmNotas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCarregaEstados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCarregaEstados;
    }
}