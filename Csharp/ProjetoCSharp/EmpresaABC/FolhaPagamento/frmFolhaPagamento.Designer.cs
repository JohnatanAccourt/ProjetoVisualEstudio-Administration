namespace FolhaPagamento
{
    partial class frmFolhaPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFolhaPagamento));
            this.dtpDataFolha = new System.Windows.Forms.DateTimePicker();
            this.lblDataFolha = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.chk = new System.Windows.Forms.CheckBox();
            this.lblClubeLazer = new System.Windows.Forms.Label();
            this.cboClubeLazer = new System.Windows.Forms.ComboBox();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.lblSalarioFolha = new System.Windows.Forms.Label();
            this.lblImpostoRenda = new System.Windows.Forms.Label();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.txtSalariofolha = new System.Windows.Forms.TextBox();
            this.txtimpostoRenda = new System.Windows.Forms.TextBox();
            this.txtSalarioLiquido = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dtpDataFolha
            // 
            this.dtpDataFolha.AllowDrop = true;
            this.dtpDataFolha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataFolha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFolha.Location = new System.Drawing.Point(37, 43);
            this.dtpDataFolha.Name = "dtpDataFolha";
            this.dtpDataFolha.Size = new System.Drawing.Size(112, 29);
            this.dtpDataFolha.TabIndex = 0;
            // 
            // lblDataFolha
            // 
            this.lblDataFolha.AutoSize = true;
            this.lblDataFolha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataFolha.Location = new System.Drawing.Point(33, 13);
            this.lblDataFolha.Name = "lblDataFolha";
            this.lblDataFolha.Size = new System.Drawing.Size(105, 21);
            this.lblDataFolha.TabIndex = 1;
            this.lblDataFolha.Text = "Data da folha:";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(33, 96);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(61, 21);
            this.lblSalario.TabIndex = 2;
            this.lblSalario.Text = "Salário:";
            // 
            // chk
            // 
            this.chk.AutoSize = true;
            this.chk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk.Location = new System.Drawing.Point(33, 161);
            this.chk.Name = "chk";
            this.chk.Size = new System.Drawing.Size(136, 25);
            this.chk.TabIndex = 4;
            this.chk.Text = "Plano de Saúde";
            this.chk.UseVisualStyleBackColor = true;
            // 
            // lblClubeLazer
            // 
            this.lblClubeLazer.AutoSize = true;
            this.lblClubeLazer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClubeLazer.Location = new System.Drawing.Point(33, 220);
            this.lblClubeLazer.Name = "lblClubeLazer";
            this.lblClubeLazer.Size = new System.Drawing.Size(116, 21);
            this.lblClubeLazer.TabIndex = 5;
            this.lblClubeLazer.Text = "Clube do Lazer:";
            // 
            // cboClubeLazer
            // 
            this.cboClubeLazer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboClubeLazer.FormattingEnabled = true;
            this.cboClubeLazer.Location = new System.Drawing.Point(33, 247);
            this.cboClubeLazer.Name = "cboClubeLazer";
            this.cboClubeLazer.Size = new System.Drawing.Size(180, 29);
            this.cboClubeLazer.TabIndex = 6;
            this.cboClubeLazer.SelectedIndexChanged += new System.EventHandler(this.cobClubeLazer_SelectedIndexChanged);
            // 
            // btnCalcula
            // 
            this.btnCalcula.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcula.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcula.Image")));
            this.btnCalcula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcula.Location = new System.Drawing.Point(303, 40);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(111, 32);
            this.btnCalcula.TabIndex = 7;
            this.btnCalcula.Text = "Calcula";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // lblSalarioFolha
            // 
            this.lblSalarioFolha.AutoSize = true;
            this.lblSalarioFolha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioFolha.Location = new System.Drawing.Point(288, 108);
            this.lblSalarioFolha.Name = "lblSalarioFolha";
            this.lblSalarioFolha.Size = new System.Drawing.Size(103, 21);
            this.lblSalarioFolha.TabIndex = 8;
            this.lblSalarioFolha.Text = "Salário Folha:";
            // 
            // lblImpostoRenda
            // 
            this.lblImpostoRenda.AutoSize = true;
            this.lblImpostoRenda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpostoRenda.Location = new System.Drawing.Point(288, 147);
            this.lblImpostoRenda.Name = "lblImpostoRenda";
            this.lblImpostoRenda.Size = new System.Drawing.Size(139, 21);
            this.lblImpostoRenda.TabIndex = 9;
            this.lblImpostoRenda.Text = "Imposto de Renda:";
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioLiquido.Location = new System.Drawing.Point(286, 191);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(117, 21);
            this.lblSalarioLiquido.TabIndex = 10;
            this.lblSalarioLiquido.Text = "Salário Liquido:";
            // 
            // txtSalariofolha
            // 
            this.txtSalariofolha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalariofolha.Location = new System.Drawing.Point(433, 105);
            this.txtSalariofolha.Name = "txtSalariofolha";
            this.txtSalariofolha.Size = new System.Drawing.Size(100, 29);
            this.txtSalariofolha.TabIndex = 11;
            // 
            // txtimpostoRenda
            // 
            this.txtimpostoRenda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtimpostoRenda.Location = new System.Drawing.Point(433, 144);
            this.txtimpostoRenda.Name = "txtimpostoRenda";
            this.txtimpostoRenda.Size = new System.Drawing.Size(100, 29);
            this.txtimpostoRenda.TabIndex = 12;
            // 
            // txtSalarioLiquido
            // 
            this.txtSalarioLiquido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioLiquido.Location = new System.Drawing.Point(433, 183);
            this.txtSalarioLiquido.Name = "txtSalarioLiquido";
            this.txtSalarioLiquido.Size = new System.Drawing.Size(100, 29);
            this.txtSalarioLiquido.TabIndex = 13;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(33, 130);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 14;
            this.txtSalario.TextChanged += new System.EventHandler(this.txtSalario_TextChanged_1);
            // 
            // frmFolhaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 437);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtSalarioLiquido);
            this.Controls.Add(this.txtimpostoRenda);
            this.Controls.Add(this.txtSalariofolha);
            this.Controls.Add(this.lblSalarioLiquido);
            this.Controls.Add(this.lblImpostoRenda);
            this.Controls.Add(this.lblSalarioFolha);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.cboClubeLazer);
            this.Controls.Add(this.lblClubeLazer);
            this.Controls.Add(this.chk);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblDataFolha);
            this.Controls.Add(this.dtpDataFolha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFolhaPagamento";
            this.Text = "frmFolhaPagamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDataFolha;
        private System.Windows.Forms.Label lblDataFolha;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.CheckBox chk;
        private System.Windows.Forms.Label lblClubeLazer;
        private System.Windows.Forms.ComboBox cboClubeLazer;
        private System.Windows.Forms.Button btnCalcula;
        private System.Windows.Forms.Label lblSalarioFolha;
        private System.Windows.Forms.Label lblImpostoRenda;
        private System.Windows.Forms.Label lblSalarioLiquido;
        private System.Windows.Forms.TextBox txtSalariofolha;
        private System.Windows.Forms.TextBox txtimpostoRenda;
        private System.Windows.Forms.TextBox txtSalarioLiquido;
        private System.Windows.Forms.TextBox txtSalario;
    }
}