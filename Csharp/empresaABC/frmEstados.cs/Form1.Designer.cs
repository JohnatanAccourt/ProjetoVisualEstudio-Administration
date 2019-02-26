namespace frmEstados.cs
{
    partial class Form1
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
            this.cboEstados = new System.Windows.Forms.ComboBox();
            this.lblEstados = new System.Windows.Forms.Label();
            this.btnCarregaEstados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboEstados
            // 
            this.cboEstados.FormattingEnabled = true;
            this.cboEstados.Location = new System.Drawing.Point(13, 50);
            this.cboEstados.Name = "cboEstados";
            this.cboEstados.Size = new System.Drawing.Size(121, 21);
            this.cboEstados.TabIndex = 0;
            // 
            // lblEstados
            // 
            this.lblEstados.AutoSize = true;
            this.lblEstados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstados.Location = new System.Drawing.Point(20, 9);
            this.lblEstados.Name = "lblEstados";
            this.lblEstados.Size = new System.Drawing.Size(97, 25);
            this.lblEstados.TabIndex = 1;
            this.lblEstados.Text = "Estados";
            // 
            // btnCarregaEstados
            // 
            this.btnCarregaEstados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregaEstados.Location = new System.Drawing.Point(25, 208);
            this.btnCarregaEstados.Name = "btnCarregaEstados";
            this.btnCarregaEstados.Size = new System.Drawing.Size(105, 50);
            this.btnCarregaEstados.TabIndex = 2;
            this.btnCarregaEstados.Text = "Carrega Estados";
            this.btnCarregaEstados.UseVisualStyleBackColor = true;
            this.btnCarregaEstados.Click += new System.EventHandler(this.btnCarregaEstados_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 270);
            this.Controls.Add(this.btnCarregaEstados);
            this.Controls.Add(this.lblEstados);
            this.Controls.Add(this.cboEstados);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboEstados;
        private System.Windows.Forms.Label lblEstados;
        private System.Windows.Forms.Button btnCarregaEstados;
    }
}

