namespace SistemaConservadora
{
    partial class FormCadMoradores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadMoradores));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIdentificacao = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboCondominios = new System.Windows.Forms.ComboBox();
            this.btnAddCondominio = new System.Windows.Forms.Button();
            this.TabelaCondominioData = new System.Windows.Forms.DataGridView();
            this.btnRmvCondominio = new System.Windows.Forms.Button();
            this.TabManutencao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FonteDeDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaCondominioData)).BeginInit();
            this.SuspendLayout();
            // 
            // TabManutencao
            // 
            this.TabManutencao.Controls.Add(this.btnRmvCondominio);
            this.TabManutencao.Controls.Add(this.TabelaCondominioData);
            this.TabManutencao.Controls.Add(this.btnAddCondominio);
            this.TabManutencao.Controls.Add(this.comboCondominios);
            this.TabManutencao.Controls.Add(this.label4);
            this.TabManutencao.Controls.Add(this.txtLogin);
            this.TabManutencao.Controls.Add(this.label3);
            this.TabManutencao.Controls.Add(this.txtCPF);
            this.TabManutencao.Controls.Add(this.label2);
            this.TabManutencao.Controls.Add(this.txtNome);
            this.TabManutencao.Controls.Add(this.label1);
            this.TabManutencao.Controls.Add(this.lblIdentificacao);
            this.TabManutencao.Controls.Add(this.lblID);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(136, 71);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(277, 20);
            this.txtNome.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome :";
            // 
            // lblIdentificacao
            // 
            this.lblIdentificacao.AutoSize = true;
            this.lblIdentificacao.Location = new System.Drawing.Point(136, 39);
            this.lblIdentificacao.Name = "lblIdentificacao";
            this.lblIdentificacao.Size = new System.Drawing.Size(76, 13);
            this.lblIdentificacao.TabIndex = 7;
            this.lblIdentificacao.Text = "{Identificação}";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(56, 39);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(74, 13);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "Identificação :";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(136, 97);
            this.txtCPF.MaxLength = 50;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(277, 20);
            this.txtCPF.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "CPF :";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(136, 123);
            this.txtLogin.MaxLength = 50;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(277, 20);
            this.txtLogin.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Login :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Condomínios :";
            // 
            // comboCondominios
            // 
            this.comboCondominios.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboCondominios.FormattingEnabled = true;
            this.comboCondominios.Location = new System.Drawing.Point(136, 171);
            this.comboCondominios.Name = "comboCondominios";
            this.comboCondominios.Size = new System.Drawing.Size(277, 21);
            this.comboCondominios.TabIndex = 15;
            this.comboCondominios.SelectedIndexChanged += new System.EventHandler(this.comboCondominios_SelectedIndexChanged);
            // 
            // btnAddCondominio
            // 
            this.btnAddCondominio.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCondominio.Image")));
            this.btnAddCondominio.Location = new System.Drawing.Point(419, 166);
            this.btnAddCondominio.Name = "btnAddCondominio";
            this.btnAddCondominio.Size = new System.Drawing.Size(35, 28);
            this.btnAddCondominio.TabIndex = 16;
            this.btnAddCondominio.UseVisualStyleBackColor = true;
            this.btnAddCondominio.Click += new System.EventHandler(this.btnAddCondominio_Click);
            // 
            // TabelaCondominioData
            // 
            this.TabelaCondominioData.AllowUserToAddRows = false;
            this.TabelaCondominioData.AllowUserToDeleteRows = false;
            this.TabelaCondominioData.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(250)))), ((int)(((byte)(220)))));
            this.TabelaCondominioData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TabelaCondominioData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelaCondominioData.Location = new System.Drawing.Point(59, 198);
            this.TabelaCondominioData.Name = "TabelaCondominioData";
            this.TabelaCondominioData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TabelaCondominioData.Size = new System.Drawing.Size(593, 150);
            this.TabelaCondominioData.TabIndex = 17;
            // 
            // btnRmvCondominio
            // 
            this.btnRmvCondominio.Image = ((System.Drawing.Image)(resources.GetObject("btnRmvCondominio.Image")));
            this.btnRmvCondominio.Location = new System.Drawing.Point(657, 198);
            this.btnRmvCondominio.Name = "btnRmvCondominio";
            this.btnRmvCondominio.Size = new System.Drawing.Size(35, 28);
            this.btnRmvCondominio.TabIndex = 18;
            this.btnRmvCondominio.UseVisualStyleBackColor = true;
            this.btnRmvCondominio.Click += new System.EventHandler(this.btnRmvCondominio_Click);
            // 
            // FormCadMoradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 440);
            this.Name = "FormCadMoradores";
            this.Text = "Cadastro de Moradores";
            this.TabManutencao.ResumeLayout(false);
            this.TabManutencao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FonteDeDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaCondominioData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIdentificacao;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddCondominio;
        private System.Windows.Forms.ComboBox comboCondominios;
        private System.Windows.Forms.Button btnRmvCondominio;
        private System.Windows.Forms.DataGridView TabelaCondominioData;
    }
}