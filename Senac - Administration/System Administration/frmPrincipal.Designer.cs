namespace System_Administration
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnVoltarFprincipal = new System.Windows.Forms.Button();
            this.picAdminPrincipal = new System.Windows.Forms.PictureBox();
            this.btnGerFunc = new System.Windows.Forms.Button();
            this.btnGerProd = new System.Windows.Forms.Button();
            this.btnGerForne = new System.Windows.Forms.Button();
            this.btnGerUsu = new System.Windows.Forms.Button();
            this.pnlUm = new System.Windows.Forms.Panel();
            this.pnlDois = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picAdminPrincipal)).BeginInit();
            this.pnlUm.SuspendLayout();
            this.pnlDois.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVoltarFprincipal
            // 
            this.btnVoltarFprincipal.BackColor = System.Drawing.Color.DarkRed;
            this.btnVoltarFprincipal.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F);
            this.btnVoltarFprincipal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVoltarFprincipal.Location = new System.Drawing.Point(245, 310);
            this.btnVoltarFprincipal.Name = "btnVoltarFprincipal";
            this.btnVoltarFprincipal.Size = new System.Drawing.Size(103, 38);
            this.btnVoltarFprincipal.TabIndex = 5;
            this.btnVoltarFprincipal.Text = "&Voltar";
            this.btnVoltarFprincipal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVoltarFprincipal.UseVisualStyleBackColor = false;
            // 
            // picAdminPrincipal
            // 
            this.picAdminPrincipal.Cursor = System.Windows.Forms.Cursors.Default;
            this.picAdminPrincipal.Image = ((System.Drawing.Image)(resources.GetObject("picAdminPrincipal.Image")));
            this.picAdminPrincipal.Location = new System.Drawing.Point(167, 41);
            this.picAdminPrincipal.Name = "picAdminPrincipal";
            this.picAdminPrincipal.Size = new System.Drawing.Size(260, 263);
            this.picAdminPrincipal.TabIndex = 9;
            this.picAdminPrincipal.TabStop = false;
            // 
            // btnGerFunc
            // 
            this.btnGerFunc.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F);
            this.btnGerFunc.Location = new System.Drawing.Point(12, 25);
            this.btnGerFunc.Name = "btnGerFunc";
            this.btnGerFunc.Size = new System.Drawing.Size(102, 58);
            this.btnGerFunc.TabIndex = 1;
            this.btnGerFunc.Text = "&Gerenciar Funcionarios";
            this.btnGerFunc.UseVisualStyleBackColor = true;
            // 
            // btnGerProd
            // 
            this.btnGerProd.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F);
            this.btnGerProd.Location = new System.Drawing.Point(12, 170);
            this.btnGerProd.Name = "btnGerProd";
            this.btnGerProd.Size = new System.Drawing.Size(103, 60);
            this.btnGerProd.TabIndex = 2;
            this.btnGerProd.Text = "&Gerenciar Produtos";
            this.btnGerProd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGerProd.UseVisualStyleBackColor = true;
            // 
            // btnGerForne
            // 
            this.btnGerForne.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F);
            this.btnGerForne.Location = new System.Drawing.Point(17, 25);
            this.btnGerForne.Name = "btnGerForne";
            this.btnGerForne.Size = new System.Drawing.Size(96, 58);
            this.btnGerForne.TabIndex = 3;
            this.btnGerForne.Text = "&Gerenciar Fornecedores";
            this.btnGerForne.UseVisualStyleBackColor = true;
            // 
            // btnGerUsu
            // 
            this.btnGerUsu.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F);
            this.btnGerUsu.Location = new System.Drawing.Point(17, 170);
            this.btnGerUsu.Name = "btnGerUsu";
            this.btnGerUsu.Size = new System.Drawing.Size(96, 60);
            this.btnGerUsu.TabIndex = 4;
            this.btnGerUsu.Text = "&Gerenciar Usuários";
            this.btnGerUsu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGerUsu.UseVisualStyleBackColor = true;
            // 
            // pnlUm
            // 
            this.pnlUm.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlUm.Controls.Add(this.btnGerFunc);
            this.pnlUm.Controls.Add(this.btnGerProd);
            this.pnlUm.Location = new System.Drawing.Point(12, 26);
            this.pnlUm.Name = "pnlUm";
            this.pnlUm.Size = new System.Drawing.Size(129, 281);
            this.pnlUm.TabIndex = 14;
            // 
            // pnlDois
            // 
            this.pnlDois.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlDois.Controls.Add(this.btnGerForne);
            this.pnlDois.Controls.Add(this.btnGerUsu);
            this.pnlDois.Location = new System.Drawing.Point(451, 26);
            this.pnlDois.Name = "pnlDois";
            this.pnlDois.Size = new System.Drawing.Size(130, 281);
            this.pnlDois.TabIndex = 15;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 360);
            this.Controls.Add(this.pnlDois);
            this.Controls.Add(this.pnlUm);
            this.Controls.Add(this.picAdminPrincipal);
            this.Controls.Add(this.btnVoltarFprincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.picAdminPrincipal)).EndInit();
            this.pnlUm.ResumeLayout(false);
            this.pnlDois.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoltarFprincipal;
        private System.Windows.Forms.PictureBox picAdminPrincipal;
        private System.Windows.Forms.Button btnGerFunc;
        private System.Windows.Forms.Button btnGerProd;
        private System.Windows.Forms.Button btnGerForne;
        private System.Windows.Forms.Button btnGerUsu;
        private System.Windows.Forms.Panel pnlUm;
        private System.Windows.Forms.Panel pnlDois;
    }
}