namespace System_Administration
{
    partial class frmGerPro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerPro));
            this.picGerProd = new System.Windows.Forms.PictureBox();
            this.btnApagarFprodutos = new System.Windows.Forms.Button();
            this.btnAlterarFprodutos = new System.Windows.Forms.Button();
            this.btnCadastrarFprodutos = new System.Windows.Forms.Button();
            this.btnNovoFprodutos = new System.Windows.Forms.Button();
            this.btnBuscarFprodutos = new System.Windows.Forms.Button();
            this.txtProcurarFprodutos = new System.Windows.Forms.TextBox();
            this.lblProcurarFprodutos = new System.Windows.Forms.Label();
            this.dgvGerFuncFprodutos = new System.Windows.Forms.DataGridView();
            this.txtValorFprodutos = new System.Windows.Forms.TextBox();
            this.txtQuantidadeFprodutos = new System.Windows.Forms.TextBox();
            this.txtNomeFprodutos = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblValorFprodutos = new System.Windows.Forms.Label();
            this.lblQuantidadeFprodutos = new System.Windows.Forms.Label();
            this.lblNomeFprodutos = new System.Windows.Forms.Label();
            this.lblCodigoFprodutos = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVoltarFprodutos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picGerProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGerFuncFprodutos)).BeginInit();
            this.SuspendLayout();
            // 
            // picGerProd
            // 
            this.picGerProd.Image = ((System.Drawing.Image)(resources.GetObject("picGerProd.Image")));
            this.picGerProd.Location = new System.Drawing.Point(467, 22);
            this.picGerProd.Name = "picGerProd";
            this.picGerProd.Size = new System.Drawing.Size(170, 147);
            this.picGerProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGerProd.TabIndex = 34;
            this.picGerProd.TabStop = false;
            // 
            // btnApagarFprodutos
            // 
            this.btnApagarFprodutos.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagarFprodutos.Image = ((System.Drawing.Image)(resources.GetObject("btnApagarFprodutos.Image")));
            this.btnApagarFprodutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApagarFprodutos.Location = new System.Drawing.Point(475, 450);
            this.btnApagarFprodutos.Name = "btnApagarFprodutos";
            this.btnApagarFprodutos.Size = new System.Drawing.Size(162, 34);
            this.btnApagarFprodutos.TabIndex = 10;
            this.btnApagarFprodutos.Text = "&Apagar";
            this.btnApagarFprodutos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnApagarFprodutos.UseVisualStyleBackColor = true;
            // 
            // btnAlterarFprodutos
            // 
            this.btnAlterarFprodutos.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarFprodutos.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarFprodutos.Image")));
            this.btnAlterarFprodutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarFprodutos.Location = new System.Drawing.Point(475, 386);
            this.btnAlterarFprodutos.Name = "btnAlterarFprodutos";
            this.btnAlterarFprodutos.Size = new System.Drawing.Size(162, 34);
            this.btnAlterarFprodutos.TabIndex = 9;
            this.btnAlterarFprodutos.Text = "&Alterar";
            this.btnAlterarFprodutos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAlterarFprodutos.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarFprodutos
            // 
            this.btnCadastrarFprodutos.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarFprodutos.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarFprodutos.Image")));
            this.btnCadastrarFprodutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarFprodutos.Location = new System.Drawing.Point(475, 321);
            this.btnCadastrarFprodutos.Name = "btnCadastrarFprodutos";
            this.btnCadastrarFprodutos.Size = new System.Drawing.Size(162, 34);
            this.btnCadastrarFprodutos.TabIndex = 8;
            this.btnCadastrarFprodutos.Text = "  &Cadastrar";
            this.btnCadastrarFprodutos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadastrarFprodutos.UseVisualStyleBackColor = true;
            // 
            // btnNovoFprodutos
            // 
            this.btnNovoFprodutos.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoFprodutos.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoFprodutos.Image")));
            this.btnNovoFprodutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoFprodutos.Location = new System.Drawing.Point(475, 257);
            this.btnNovoFprodutos.Name = "btnNovoFprodutos";
            this.btnNovoFprodutos.Size = new System.Drawing.Size(162, 34);
            this.btnNovoFprodutos.TabIndex = 7;
            this.btnNovoFprodutos.Text = "  &Novo";
            this.btnNovoFprodutos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNovoFprodutos.UseVisualStyleBackColor = true;
            // 
            // btnBuscarFprodutos
            // 
            this.btnBuscarFprodutos.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarFprodutos.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarFprodutos.Image")));
            this.btnBuscarFprodutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarFprodutos.Location = new System.Drawing.Point(285, 146);
            this.btnBuscarFprodutos.Name = "btnBuscarFprodutos";
            this.btnBuscarFprodutos.Size = new System.Drawing.Size(167, 34);
            this.btnBuscarFprodutos.TabIndex = 6;
            this.btnBuscarFprodutos.Text = "&Buscar";
            this.btnBuscarFprodutos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscarFprodutos.UseVisualStyleBackColor = true;
            // 
            // txtProcurarFprodutos
            // 
            this.txtProcurarFprodutos.Location = new System.Drawing.Point(104, 153);
            this.txtProcurarFprodutos.Name = "txtProcurarFprodutos";
            this.txtProcurarFprodutos.Size = new System.Drawing.Size(159, 20);
            this.txtProcurarFprodutos.TabIndex = 5;
            // 
            // lblProcurarFprodutos
            // 
            this.lblProcurarFprodutos.AutoSize = true;
            this.lblProcurarFprodutos.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F);
            this.lblProcurarFprodutos.Location = new System.Drawing.Point(12, 153);
            this.lblProcurarFprodutos.Name = "lblProcurarFprodutos";
            this.lblProcurarFprodutos.Size = new System.Drawing.Size(68, 21);
            this.lblProcurarFprodutos.TabIndex = 32;
            this.lblProcurarFprodutos.Text = "Procurar";
            // 
            // dgvGerFuncFprodutos
            // 
            this.dgvGerFuncFprodutos.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvGerFuncFprodutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGerFuncFprodutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.Cargo,
            this.Empresa});
            this.dgvGerFuncFprodutos.GridColor = System.Drawing.SystemColors.GrayText;
            this.dgvGerFuncFprodutos.Location = new System.Drawing.Point(10, 200);
            this.dgvGerFuncFprodutos.Name = "dgvGerFuncFprodutos";
            this.dgvGerFuncFprodutos.Size = new System.Drawing.Size(440, 300);
            this.dgvGerFuncFprodutos.TabIndex = 18;
            this.dgvGerFuncFprodutos.TabStop = false;
            // 
            // txtValorFprodutos
            // 
            this.txtValorFprodutos.Location = new System.Drawing.Point(104, 108);
            this.txtValorFprodutos.Name = "txtValorFprodutos";
            this.txtValorFprodutos.Size = new System.Drawing.Size(159, 20);
            this.txtValorFprodutos.TabIndex = 4;
            // 
            // txtQuantidadeFprodutos
            // 
            this.txtQuantidadeFprodutos.Location = new System.Drawing.Point(104, 61);
            this.txtQuantidadeFprodutos.Name = "txtQuantidadeFprodutos";
            this.txtQuantidadeFprodutos.Size = new System.Drawing.Size(159, 20);
            this.txtQuantidadeFprodutos.TabIndex = 2;
            // 
            // txtNomeFprodutos
            // 
            this.txtNomeFprodutos.Location = new System.Drawing.Point(150, 22);
            this.txtNomeFprodutos.Name = "txtNomeFprodutos";
            this.txtNomeFprodutos.Size = new System.Drawing.Size(300, 20);
            this.txtNomeFprodutos.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(368, 61);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(82, 20);
            this.txtID.TabIndex = 3;
            // 
            // lblValorFprodutos
            // 
            this.lblValorFprodutos.AutoSize = true;
            this.lblValorFprodutos.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F);
            this.lblValorFprodutos.Location = new System.Drawing.Point(12, 101);
            this.lblValorFprodutos.Name = "lblValorFprodutos";
            this.lblValorFprodutos.Size = new System.Drawing.Size(48, 21);
            this.lblValorFprodutos.TabIndex = 25;
            this.lblValorFprodutos.Text = "Valor:";
            // 
            // lblQuantidadeFprodutos
            // 
            this.lblQuantidadeFprodutos.AutoSize = true;
            this.lblQuantidadeFprodutos.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F);
            this.lblQuantidadeFprodutos.Location = new System.Drawing.Point(12, 54);
            this.lblQuantidadeFprodutos.Name = "lblQuantidadeFprodutos";
            this.lblQuantidadeFprodutos.Size = new System.Drawing.Size(89, 21);
            this.lblQuantidadeFprodutos.TabIndex = 23;
            this.lblQuantidadeFprodutos.Text = "Quantidade:";
            // 
            // lblNomeFprodutos
            // 
            this.lblNomeFprodutos.AutoSize = true;
            this.lblNomeFprodutos.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F);
            this.lblNomeFprodutos.Location = new System.Drawing.Point(12, 15);
            this.lblNomeFprodutos.Name = "lblNomeFprodutos";
            this.lblNomeFprodutos.Size = new System.Drawing.Size(137, 21);
            this.lblNomeFprodutos.TabIndex = 20;
            this.lblNomeFprodutos.Text = "Nome do Produto:";
            // 
            // lblCodigoFprodutos
            // 
            this.lblCodigoFprodutos.AutoSize = true;
            this.lblCodigoFprodutos.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F);
            this.lblCodigoFprodutos.Location = new System.Drawing.Point(300, 60);
            this.lblCodigoFprodutos.Name = "lblCodigoFprodutos";
            this.lblCodigoFprodutos.Size = new System.Drawing.Size(62, 21);
            this.lblCodigoFprodutos.TabIndex = 19;
            this.lblCodigoFprodutos.Text = "Código:";
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Cargo
            // 
            this.Cargo.HeaderText = "Quantidade";
            this.Cargo.Name = "Cargo";
            // 
            // Empresa
            // 
            this.Empresa.HeaderText = "Valor";
            this.Empresa.Name = "Empresa";
            // 
            // btnVoltarFprodutos
            // 
            this.btnVoltarFprodutos.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarFprodutos.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltarFprodutos.Image")));
            this.btnVoltarFprodutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltarFprodutos.Location = new System.Drawing.Point(10, 513);
            this.btnVoltarFprodutos.Name = "btnVoltarFprodutos";
            this.btnVoltarFprodutos.Size = new System.Drawing.Size(106, 34);
            this.btnVoltarFprodutos.TabIndex = 11;
            this.btnVoltarFprodutos.Text = "  &voltar";
            this.btnVoltarFprodutos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVoltarFprodutos.UseVisualStyleBackColor = true;
            // 
            // frmGerPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 559);
            this.Controls.Add(this.btnVoltarFprodutos);
            this.Controls.Add(this.picGerProd);
            this.Controls.Add(this.btnApagarFprodutos);
            this.Controls.Add(this.btnAlterarFprodutos);
            this.Controls.Add(this.btnCadastrarFprodutos);
            this.Controls.Add(this.btnNovoFprodutos);
            this.Controls.Add(this.btnBuscarFprodutos);
            this.Controls.Add(this.txtProcurarFprodutos);
            this.Controls.Add(this.lblProcurarFprodutos);
            this.Controls.Add(this.dgvGerFuncFprodutos);
            this.Controls.Add(this.txtValorFprodutos);
            this.Controls.Add(this.txtQuantidadeFprodutos);
            this.Controls.Add(this.txtNomeFprodutos);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblValorFprodutos);
            this.Controls.Add(this.lblQuantidadeFprodutos);
            this.Controls.Add(this.lblNomeFprodutos);
            this.Controls.Add(this.lblCodigoFprodutos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGerPro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Produtos";
            this.Load += new System.EventHandler(this.frmGerPro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picGerProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGerFuncFprodutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picGerProd;
        private System.Windows.Forms.Button btnApagarFprodutos;
        private System.Windows.Forms.Button btnAlterarFprodutos;
        private System.Windows.Forms.Button btnCadastrarFprodutos;
        private System.Windows.Forms.Button btnNovoFprodutos;
        private System.Windows.Forms.Button btnBuscarFprodutos;
        private System.Windows.Forms.TextBox txtProcurarFprodutos;
        private System.Windows.Forms.Label lblProcurarFprodutos;
        private System.Windows.Forms.DataGridView dgvGerFuncFprodutos;
        private System.Windows.Forms.TextBox txtValorFprodutos;
        private System.Windows.Forms.TextBox txtQuantidadeFprodutos;
        private System.Windows.Forms.TextBox txtNomeFprodutos;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblValorFprodutos;
        private System.Windows.Forms.Label lblQuantidadeFprodutos;
        private System.Windows.Forms.Label lblNomeFprodutos;
        private System.Windows.Forms.Label lblCodigoFprodutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
        private System.Windows.Forms.Button btnVoltarFprodutos;
    }
}