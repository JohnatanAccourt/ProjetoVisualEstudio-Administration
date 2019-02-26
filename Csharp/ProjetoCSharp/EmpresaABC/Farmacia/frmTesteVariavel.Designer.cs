namespace Farmacia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTesteVariavel));
            this.btnMostar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblMostrar = new System.Windows.Forms.Label();
            this.lblNCompleto = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnBandeira = new System.Windows.Forms.Button();
            this.lblBandeira = new System.Windows.Forms.Label();
            this.btnTrocar = new System.Windows.Forms.Button();
            this.lblNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMostar
            // 
            this.btnMostar.Location = new System.Drawing.Point(39, 66);
            this.btnMostar.Name = "btnMostar";
            this.btnMostar.Size = new System.Drawing.Size(148, 89);
            this.btnMostar.TabIndex = 0;
            this.btnMostar.Text = "&Mostar";
            this.btnMostar.UseVisualStyleBackColor = true;
            this.btnMostar.Click += new System.EventHandler(this.btnMostar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(39, 196);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(148, 89);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sai&r";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblMostrar
            // 
            this.lblMostrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMostrar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrar.Location = new System.Drawing.Point(216, 66);
            this.lblMostrar.Name = "lblMostrar";
            this.lblMostrar.Size = new System.Drawing.Size(420, 94);
            this.lblMostrar.TabIndex = 2;
            this.lblMostrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNCompleto
            // 
            this.lblNCompleto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNCompleto.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNCompleto.Location = new System.Drawing.Point(219, 196);
            this.lblNCompleto.Name = "lblNCompleto";
            this.lblNCompleto.Size = new System.Drawing.Size(420, 94);
            this.lblNCompleto.TabIndex = 3;
            this.lblNCompleto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(738, 35);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(146, 89);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnBandeira
            // 
            this.btnBandeira.Location = new System.Drawing.Point(39, 351);
            this.btnBandeira.Name = "btnBandeira";
            this.btnBandeira.Size = new System.Drawing.Size(195, 71);
            this.btnBandeira.TabIndex = 5;
            this.btnBandeira.Text = "Bandeira";
            this.btnBandeira.UseVisualStyleBackColor = true;
            this.btnBandeira.Click += new System.EventHandler(this.btnBandeira_Click);
            // 
            // lblBandeira
            // 
            this.lblBandeira.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBandeira.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBandeira.Location = new System.Drawing.Point(252, 328);
            this.lblBandeira.Name = "lblBandeira";
            this.lblBandeira.Size = new System.Drawing.Size(420, 94);
            this.lblBandeira.TabIndex = 6;
            this.lblBandeira.Text = "False";
            this.lblBandeira.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTrocar
            // 
            this.btnTrocar.Location = new System.Drawing.Point(713, 328);
            this.btnTrocar.Name = "btnTrocar";
            this.btnTrocar.Size = new System.Drawing.Size(195, 71);
            this.btnTrocar.TabIndex = 7;
            this.btnTrocar.Text = "Trocar";
            this.btnTrocar.UseVisualStyleBackColor = true;
            this.btnTrocar.Click += new System.EventHandler(this.btnTrocar_Click);
            // 
            // lblNum
            // 
            this.lblNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNum.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.Location = new System.Drawing.Point(738, 185);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(146, 100);
            this.lblNum.TabIndex = 8;
            this.lblNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmTesteVariavel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 472);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.btnTrocar);
            this.Controls.Add(this.lblBandeira);
            this.Controls.Add(this.btnBandeira);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblNCompleto);
            this.Controls.Add(this.lblMostrar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnMostar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTesteVariavel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teste Variável";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblMostrar;
        private System.Windows.Forms.Label lblNCompleto;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnBandeira;
        private System.Windows.Forms.Label lblBandeira;
        private System.Windows.Forms.Button btnTrocar;
        private System.Windows.Forms.Label lblNum;
    }
}