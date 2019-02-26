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
            this.cboCarregaEstados = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCarregaEstados = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ltbListaEstado = new System.Windows.Forms.ListBox();
            this.btnCarregaLista = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCarregaLabel = new System.Windows.Forms.Label();
            this.btnCarregaLabel = new System.Windows.Forms.Button();
            this.lblCarregalista = new System.Windows.Forms.Label();
            this.gpbSexo = new System.Windows.Forms.GroupBox();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFeminino = new System.Windows.Forms.RadioButton();
            this.lblRetorno = new System.Windows.Forms.Label();
            this.gpbEscolha = new System.Windows.Forms.GroupBox();
            this.ckbmanha = new System.Windows.Forms.CheckBox();
            this.ckbtarde = new System.Windows.Forms.CheckBox();
            this.ckbnoite = new System.Windows.Forms.CheckBox();
            this.btnEscolha = new System.Windows.Forms.Button();
            this.gpbSexo.SuspendLayout();
            this.gpbEscolha.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboCarregaEstados
            // 
            this.cboCarregaEstados.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCarregaEstados.FormattingEnabled = true;
            this.cboCarregaEstados.Location = new System.Drawing.Point(33, 58);
            this.cboCarregaEstados.Margin = new System.Windows.Forms.Padding(2);
            this.cboCarregaEstados.Name = "cboCarregaEstados";
            this.cboCarregaEstados.Size = new System.Drawing.Size(147, 30);
            this.cboCarregaEstados.TabIndex = 5;
            this.cboCarregaEstados.SelectedIndexChanged += new System.EventHandler(this.cboCarregaEstados_SelectedIndexChanged);
            this.cboCarregaEstados.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cboCarregaEstados_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Estados";
            // 
            // btnCarregaEstados
            // 
            this.btnCarregaEstados.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregaEstados.Location = new System.Drawing.Point(33, 103);
            this.btnCarregaEstados.Margin = new System.Windows.Forms.Padding(2);
            this.btnCarregaEstados.Name = "btnCarregaEstados";
            this.btnCarregaEstados.Size = new System.Drawing.Size(147, 67);
            this.btnCarregaEstados.TabIndex = 3;
            this.btnCarregaEstados.Text = "Carrega Estados";
            this.btnCarregaEstados.UseVisualStyleBackColor = true;
            this.btnCarregaEstados.Click += new System.EventHandler(this.btnCarregaEstados_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(242, 331);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 71);
            this.button1.TabIndex = 6;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ltbListaEstado
            // 
            this.ltbListaEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbListaEstado.FormattingEnabled = true;
            this.ltbListaEstado.ItemHeight = 22;
            this.ltbListaEstado.Location = new System.Drawing.Point(242, 84);
            this.ltbListaEstado.Margin = new System.Windows.Forms.Padding(2);
            this.ltbListaEstado.Name = "ltbListaEstado";
            this.ltbListaEstado.Size = new System.Drawing.Size(148, 136);
            this.ltbListaEstado.TabIndex = 7;
            this.ltbListaEstado.SelectedIndexChanged += new System.EventHandler(this.ltbListaEstado_SelectedIndexChanged);
            // 
            // btnCarregaLista
            // 
            this.btnCarregaLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregaLista.Location = new System.Drawing.Point(33, 174);
            this.btnCarregaLista.Margin = new System.Windows.Forms.Padding(2);
            this.btnCarregaLista.Name = "btnCarregaLista";
            this.btnCarregaLista.Size = new System.Drawing.Size(147, 67);
            this.btnCarregaLista.TabIndex = 8;
            this.btnCarregaLista.Text = "Carrega Lista";
            this.btnCarregaLista.UseVisualStyleBackColor = true;
            this.btnCarregaLista.Click += new System.EventHandler(this.btnCarregaLista_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Estados";
            // 
            // lblCarregaLabel
            // 
            this.lblCarregaLabel.AutoSize = true;
            this.lblCarregaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lblCarregaLabel.Location = new System.Drawing.Point(50, 275);
            this.lblCarregaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCarregaLabel.Name = "lblCarregaLabel";
            this.lblCarregaLabel.Size = new System.Drawing.Size(0, 24);
            this.lblCarregaLabel.TabIndex = 10;
            this.lblCarregaLabel.Click += new System.EventHandler(this.lblCarregaLabel_Click);
            // 
            // btnCarregaLabel
            // 
            this.btnCarregaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.btnCarregaLabel.Location = new System.Drawing.Point(37, 331);
            this.btnCarregaLabel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCarregaLabel.Name = "btnCarregaLabel";
            this.btnCarregaLabel.Size = new System.Drawing.Size(145, 68);
            this.btnCarregaLabel.TabIndex = 11;
            this.btnCarregaLabel.Text = "Carrega Label";
            this.btnCarregaLabel.UseVisualStyleBackColor = true;
            this.btnCarregaLabel.Click += new System.EventHandler(this.btnCarregaLabel_Click);
            // 
            // lblCarregalista
            // 
            this.lblCarregalista.AutoSize = true;
            this.lblCarregalista.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lblCarregalista.Location = new System.Drawing.Point(249, 275);
            this.lblCarregalista.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCarregalista.Name = "lblCarregalista";
            this.lblCarregalista.Size = new System.Drawing.Size(0, 24);
            this.lblCarregalista.TabIndex = 12;
            // 
            // gpbSexo
            // 
            this.gpbSexo.Controls.Add(this.rdbFeminino);
            this.gpbSexo.Controls.Add(this.rdbMasculino);
            this.gpbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.gpbSexo.Location = new System.Drawing.Point(463, 20);
            this.gpbSexo.Name = "gpbSexo";
            this.gpbSexo.Size = new System.Drawing.Size(236, 121);
            this.gpbSexo.TabIndex = 13;
            this.gpbSexo.TabStop = false;
            this.gpbSexo.Text = "Sexo:";
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(7, 38);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(114, 28);
            this.rdbMasculino.TabIndex = 0;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            this.rdbMasculino.CheckedChanged += new System.EventHandler(this.rdbMasculino_CheckedChanged);
            // 
            // rdbFeminino
            // 
            this.rdbFeminino.AutoSize = true;
            this.rdbFeminino.Location = new System.Drawing.Point(7, 83);
            this.rdbFeminino.Name = "rdbFeminino";
            this.rdbFeminino.Size = new System.Drawing.Size(108, 28);
            this.rdbFeminino.TabIndex = 1;
            this.rdbFeminino.TabStop = true;
            this.rdbFeminino.Text = "Feminino";
            this.rdbFeminino.UseVisualStyleBackColor = true;
            this.rdbFeminino.CheckedChanged += new System.EventHandler(this.rdbFeminino_CheckedChanged);
            // 
            // lblRetorno
            // 
            this.lblRetorno.AutoSize = true;
            this.lblRetorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lblRetorno.Location = new System.Drawing.Point(463, 174);
            this.lblRetorno.Name = "lblRetorno";
            this.lblRetorno.Size = new System.Drawing.Size(208, 24);
            this.lblRetorno.TabIndex = 14;
            this.lblRetorno.Text = "Retorno do radio button";
            this.lblRetorno.Click += new System.EventHandler(this.lblRetorno_Click);
            // 
            // gpbEscolha
            // 
            this.gpbEscolha.Controls.Add(this.ckbnoite);
            this.gpbEscolha.Controls.Add(this.ckbtarde);
            this.gpbEscolha.Controls.Add(this.ckbmanha);
            this.gpbEscolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.gpbEscolha.Location = new System.Drawing.Point(463, 253);
            this.gpbEscolha.Name = "gpbEscolha";
            this.gpbEscolha.Size = new System.Drawing.Size(236, 146);
            this.gpbEscolha.TabIndex = 15;
            this.gpbEscolha.TabStop = false;
            this.gpbEscolha.Text = "Escolha:";
            // 
            // ckbmanha
            // 
            this.ckbmanha.AutoSize = true;
            this.ckbmanha.Location = new System.Drawing.Point(4, 44);
            this.ckbmanha.Name = "ckbmanha";
            this.ckbmanha.Size = new System.Drawing.Size(87, 28);
            this.ckbmanha.TabIndex = 0;
            this.ckbmanha.Text = "Manhã";
            this.ckbmanha.UseVisualStyleBackColor = true;
            // 
            // ckbtarde
            // 
            this.ckbtarde.AutoSize = true;
            this.ckbtarde.Location = new System.Drawing.Point(4, 78);
            this.ckbtarde.Name = "ckbtarde";
            this.ckbtarde.Size = new System.Drawing.Size(79, 28);
            this.ckbtarde.TabIndex = 1;
            this.ckbtarde.Text = "Tarde";
            this.ckbtarde.UseVisualStyleBackColor = true;
            // 
            // ckbnoite
            // 
            this.ckbnoite.AutoSize = true;
            this.ckbnoite.Location = new System.Drawing.Point(4, 112);
            this.ckbnoite.Name = "ckbnoite";
            this.ckbnoite.Size = new System.Drawing.Size(73, 28);
            this.ckbnoite.TabIndex = 2;
            this.ckbnoite.Text = "Noite";
            this.ckbnoite.UseVisualStyleBackColor = true;
            // 
            // btnEscolha
            // 
            this.btnEscolha.Location = new System.Drawing.Point(463, 217);
            this.btnEscolha.Name = "btnEscolha";
            this.btnEscolha.Size = new System.Drawing.Size(75, 23);
            this.btnEscolha.TabIndex = 16;
            this.btnEscolha.Text = "escolha";
            this.btnEscolha.UseVisualStyleBackColor = true;
            this.btnEscolha.Click += new System.EventHandler(this.btnEscolha_Click);
            // 
            // frmEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 449);
            this.Controls.Add(this.btnEscolha);
            this.Controls.Add(this.gpbEscolha);
            this.Controls.Add(this.lblRetorno);
            this.Controls.Add(this.gpbSexo);
            this.Controls.Add(this.lblCarregalista);
            this.Controls.Add(this.btnCarregaLabel);
            this.Controls.Add(this.lblCarregaLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCarregaLista);
            this.Controls.Add(this.ltbListaEstado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboCarregaEstados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCarregaEstados);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmEstados";
            this.Text = "frmEstados";
            this.Load += new System.EventHandler(this.frmEstados_Load);
            this.gpbSexo.ResumeLayout(false);
            this.gpbSexo.PerformLayout();
            this.gpbEscolha.ResumeLayout(false);
            this.gpbEscolha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCarregaEstados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCarregaEstados;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox ltbListaEstado;
        private System.Windows.Forms.Button btnCarregaLista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCarregaLabel;
        private System.Windows.Forms.Button btnCarregaLabel;
        private System.Windows.Forms.Label lblCarregalista;
        private System.Windows.Forms.GroupBox gpbSexo;
        private System.Windows.Forms.RadioButton rdbFeminino;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.Label lblRetorno;
        private System.Windows.Forms.GroupBox gpbEscolha;
        private System.Windows.Forms.CheckBox ckbnoite;
        private System.Windows.Forms.CheckBox ckbtarde;
        private System.Windows.Forms.CheckBox ckbmanha;
        private System.Windows.Forms.Button btnEscolha;
    }
}