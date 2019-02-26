namespace FolhaDePagamento
{
    partial class frmFolha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFolha));
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtSalarioLiquido = new System.Windows.Forms.TextBox();
            this.txtimpostoRenda = new System.Windows.Forms.TextBox();
            this.txtSalariofolha = new System.Windows.Forms.TextBox();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.lblImpostoRenda = new System.Windows.Forms.Label();
            this.lblSalarioFolha = new System.Windows.Forms.Label();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.cboClubeLazer = new System.Windows.Forms.ComboBox();
            this.lblClubeLazer = new System.Windows.Forms.Label();
            this.chk = new System.Windows.Forms.CheckBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblDataFolha = new System.Windows.Forms.Label();
            this.dtpDataFolha = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(16, 133);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 28;
            this.txtSalario.TextChanged += new System.EventHandler(this.txtSalario_TextChanged);
            // 
            // txtSalarioLiquido
            // 
            this.txtSalarioLiquido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioLiquido.Location = new System.Drawing.Point(412, 195);
            this.txtSalarioLiquido.Name = "txtSalarioLiquido";
            this.txtSalarioLiquido.Size = new System.Drawing.Size(100, 29);
            this.txtSalarioLiquido.TabIndex = 27;
            // 
            // txtimpostoRenda
            // 
            this.txtimpostoRenda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtimpostoRenda.Location = new System.Drawing.Point(412, 156);
            this.txtimpostoRenda.Name = "txtimpostoRenda";
            this.txtimpostoRenda.Size = new System.Drawing.Size(100, 29);
            this.txtimpostoRenda.TabIndex = 26;
            // 
            // txtSalariofolha
            // 
            this.txtSalariofolha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalariofolha.Location = new System.Drawing.Point(412, 117);
            this.txtSalariofolha.Name = "txtSalariofolha";
            this.txtSalariofolha.Size = new System.Drawing.Size(100, 29);
            this.txtSalariofolha.TabIndex = 25;
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioLiquido.Location = new System.Drawing.Point(265, 203);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(117, 21);
            this.lblSalarioLiquido.TabIndex = 24;
            this.lblSalarioLiquido.Text = "Salário Liquido:";
            // 
            // lblImpostoRenda
            // 
            this.lblImpostoRenda.AutoSize = true;
            this.lblImpostoRenda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpostoRenda.Location = new System.Drawing.Point(267, 159);
            this.lblImpostoRenda.Name = "lblImpostoRenda";
            this.lblImpostoRenda.Size = new System.Drawing.Size(139, 21);
            this.lblImpostoRenda.TabIndex = 23;
            this.lblImpostoRenda.Text = "Imposto de Renda:";
            // 
            // lblSalarioFolha
            // 
            this.lblSalarioFolha.AutoSize = true;
            this.lblSalarioFolha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioFolha.Location = new System.Drawing.Point(267, 120);
            this.lblSalarioFolha.Name = "lblSalarioFolha";
            this.lblSalarioFolha.Size = new System.Drawing.Size(103, 21);
            this.lblSalarioFolha.TabIndex = 22;
            this.lblSalarioFolha.Text = "Salário Folha:";
            // 
            // btnCalcula
            // 
            this.btnCalcula.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcula.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcula.Image")));
            this.btnCalcula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcula.Location = new System.Drawing.Point(282, 52);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(111, 32);
            this.btnCalcula.TabIndex = 21;
            this.btnCalcula.Text = "Calcula";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // cboClubeLazer
            // 
            this.cboClubeLazer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboClubeLazer.FormattingEnabled = true;
            this.cboClubeLazer.Location = new System.Drawing.Point(12, 259);
            this.cboClubeLazer.Name = "cboClubeLazer";
            this.cboClubeLazer.Size = new System.Drawing.Size(180, 29);
            this.cboClubeLazer.TabIndex = 20;
            this.cboClubeLazer.SelectedIndexChanged += new System.EventHandler(this.cboClubeLazer_SelectedIndexChanged);
            // 
            // lblClubeLazer
            // 
            this.lblClubeLazer.AutoSize = true;
            this.lblClubeLazer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClubeLazer.Location = new System.Drawing.Point(12, 232);
            this.lblClubeLazer.Name = "lblClubeLazer";
            this.lblClubeLazer.Size = new System.Drawing.Size(116, 21);
            this.lblClubeLazer.TabIndex = 19;
            this.lblClubeLazer.Text = "Clube do Lazer:";
            // 
            // chk
            // 
            this.chk.AutoSize = true;
            this.chk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk.Location = new System.Drawing.Point(12, 173);
            this.chk.Name = "chk";
            this.chk.Size = new System.Drawing.Size(136, 25);
            this.chk.TabIndex = 18;
            this.chk.Text = "Plano de Saúde";
            this.chk.UseVisualStyleBackColor = true;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(12, 108);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(61, 21);
            this.lblSalario.TabIndex = 17;
            this.lblSalario.Text = "Salário:";
            // 
            // lblDataFolha
            // 
            this.lblDataFolha.AutoSize = true;
            this.lblDataFolha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataFolha.Location = new System.Drawing.Point(12, 25);
            this.lblDataFolha.Name = "lblDataFolha";
            this.lblDataFolha.Size = new System.Drawing.Size(105, 21);
            this.lblDataFolha.TabIndex = 16;
            this.lblDataFolha.Text = "Data da folha:";
            // 
            // dtpDataFolha
            // 
            this.dtpDataFolha.AllowDrop = true;
            this.dtpDataFolha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataFolha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFolha.Location = new System.Drawing.Point(16, 55);
            this.dtpDataFolha.Name = "dtpDataFolha";
            this.dtpDataFolha.Size = new System.Drawing.Size(112, 29);
            this.dtpDataFolha.TabIndex = 15;
            // 
            // frmFolha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 415);
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
            this.Name = "frmFolha";
            this.Text = "frmFolha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtSalarioLiquido;
        private System.Windows.Forms.TextBox txtimpostoRenda;
        private System.Windows.Forms.TextBox txtSalariofolha;
        private System.Windows.Forms.Label lblSalarioLiquido;
        private System.Windows.Forms.Label lblImpostoRenda;
        private System.Windows.Forms.Label lblSalarioFolha;
        private System.Windows.Forms.Button btnCalcula;
        private System.Windows.Forms.ComboBox cboClubeLazer;
        private System.Windows.Forms.Label lblClubeLazer;
        private System.Windows.Forms.CheckBox chk;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblDataFolha;
        private System.Windows.Forms.DateTimePicker dtpDataFolha;
    }
}