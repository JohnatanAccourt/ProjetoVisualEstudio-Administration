namespace farmacia
{
    partial class frmTesteVariavel
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblMostrar = new System.Windows.Forms.Label();
            this.lblNCompleto = new System.Windows.Forms.Label();
            this.btnBandeira = new System.Windows.Forms.Button();
            this.lblBandeira = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(35, 41);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(93, 64);
            this.btnMostrar.TabIndex = 0;
            this.btnMostrar.Text = "&Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(35, 129);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(93, 64);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sai&r";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // lblMostrar
            // 
            this.lblMostrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMostrar.Location = new System.Drawing.Point(153, 41);
            this.lblMostrar.Name = "lblMostrar";
            this.lblMostrar.Size = new System.Drawing.Size(291, 64);
            this.lblMostrar.TabIndex = 2;
            this.lblMostrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMostrar.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNCompleto
            // 
            this.lblNCompleto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNCompleto.Location = new System.Drawing.Point(153, 129);
            this.lblNCompleto.Name = "lblNCompleto";
            this.lblNCompleto.Size = new System.Drawing.Size(291, 64);
            this.lblNCompleto.TabIndex = 3;
            this.lblNCompleto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNCompleto.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnBandeira
            // 
            this.btnBandeira.Location = new System.Drawing.Point(35, 236);
            this.btnBandeira.Name = "btnBandeira";
            this.btnBandeira.Size = new System.Drawing.Size(116, 54);
            this.btnBandeira.TabIndex = 4;
            this.btnBandeira.Text = "bandeira";
            this.btnBandeira.UseVisualStyleBackColor = true;
            this.btnBandeira.Click += new System.EventHandler(this.btnBandeira_Click);
            // 
            // lblBandeira
            // 
            this.lblBandeira.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBandeira.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBandeira.Location = new System.Drawing.Point(157, 226);
            this.lblBandeira.Name = "lblBandeira";
            this.lblBandeira.Size = new System.Drawing.Size(234, 64);
            this.lblBandeira.TabIndex = 5;
            this.lblBandeira.Text = "false";
            this.lblBandeira.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBandeira.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(421, 235);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(116, 54);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(470, 159);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(35, 13);
            this.lblNum.TabIndex = 7;
            this.lblNum.Text = "label1";
            // 
            // frmTesteVariavel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 321);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblBandeira);
            this.Controls.Add(this.btnBandeira);
            this.Controls.Add(this.lblNCompleto);
            this.Controls.Add(this.lblMostrar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnMostrar);
            this.Name = "frmTesteVariavel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTesteVariavel";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label lblMostrar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label lblNCompleto;
        private System.Windows.Forms.Label lblBandeira;
        private System.Windows.Forms.Button btnBandeira;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblNum;
    }
}