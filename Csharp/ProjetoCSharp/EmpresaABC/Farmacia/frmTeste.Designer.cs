namespace Farmacia
{
    partial class frmTeste
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
            this.btnAcao = new System.Windows.Forms.Button();
            this.txtAcao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAcao
            // 
            this.btnAcao.Location = new System.Drawing.Point(51, 153);
            this.btnAcao.Name = "btnAcao";
            this.btnAcao.Size = new System.Drawing.Size(520, 162);
            this.btnAcao.TabIndex = 0;
            this.btnAcao.Text = "Realizar Ação";
            this.btnAcao.UseVisualStyleBackColor = true;
            this.btnAcao.Click += new System.EventHandler(this.btnAcao_Click);
            // 
            // txtAcao
            // 
            this.txtAcao.Location = new System.Drawing.Point(46, 45);
            this.txtAcao.Name = "txtAcao";
            this.txtAcao.Size = new System.Drawing.Size(315, 22);
            this.txtAcao.TabIndex = 1;
            // 
            // frmTeste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 623);
            this.Controls.Add(this.txtAcao);
            this.Controls.Add(this.btnAcao);
            this.Name = "frmTeste";
            this.Text = "frmTeste";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAcao;
        private System.Windows.Forms.TextBox txtAcao;
    }
}