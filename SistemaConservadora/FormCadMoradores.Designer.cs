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
            this.btnRmvCondominio = new System.Windows.Forms.Button();
            this.idcondominiosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entityKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabelaData = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidmoradores = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcpf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidcondominios = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnome1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FonteDeDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paginas)).BeginInit();
            this.Paginas.SuspendLayout();
            this.TabAcesso.SuspendLayout();
            this.TabManutencao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // FonteDeDados
            // 
            this.FonteDeDados.DataSource = typeof(SistemaConservadora.MoradoresWeb.condominio);
            // 
            // BDS
            // 
            this.BDS.DataSource = typeof(SistemaConservadora.MoradoresWeb.moradores);
            // 
            // Paginas
            // 
            this.Paginas.SelectedTabPage = this.TabAcesso;
            this.Paginas.ShowHeaderFocus = DevExpress.Utils.DefaultBoolean.False;
            this.Paginas.Size = new System.Drawing.Size(703, 374);
            // 
            // TabAcesso
            // 
            this.TabAcesso.Controls.Add(this.TabelaData);
            this.TabAcesso.Size = new System.Drawing.Size(697, 368);
            // 
            // TabManutencao
            // 
            this.TabManutencao.Appearance.PageClient.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TabManutencao.Appearance.PageClient.Options.UseBackColor = true;
            this.TabManutencao.Controls.Add(this.button1);
            this.TabManutencao.Controls.Add(this.txtemail);
            this.TabManutencao.Controls.Add(this.label5);
            this.TabManutencao.Controls.Add(this.gridControl1);
            this.TabManutencao.Controls.Add(this.btnRmvCondominio);
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
            this.TabManutencao.Size = new System.Drawing.Size(697, 368);
            this.TabManutencao.Paint += new System.Windows.Forms.PaintEventHandler(this.TabManutencao_Paint);
            // 
            // txtNome
            // 
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BDS, "nome", true));
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
            this.lblIdentificacao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BDS, "idmoradores", true));
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
            this.txtCPF.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BDS, "cpf", true));
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
            this.txtLogin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BDS, "login", true));
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
            this.label4.Location = new System.Drawing.Point(55, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Condomínios :";
            // 
            // comboCondominios
            // 
            this.comboCondominios.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboCondominios.FormattingEnabled = true;
            this.comboCondominios.Location = new System.Drawing.Point(136, 175);
            this.comboCondominios.Name = "comboCondominios";
            this.comboCondominios.Size = new System.Drawing.Size(277, 21);
            this.comboCondominios.TabIndex = 15;
            this.comboCondominios.SelectedIndexChanged += new System.EventHandler(this.comboCondominios_SelectedIndexChanged);
            // 
            // btnAddCondominio
            // 
            this.btnAddCondominio.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCondominio.Image")));
            this.btnAddCondominio.Location = new System.Drawing.Point(422, 170);
            this.btnAddCondominio.Name = "btnAddCondominio";
            this.btnAddCondominio.Size = new System.Drawing.Size(35, 28);
            this.btnAddCondominio.TabIndex = 16;
            this.btnAddCondominio.UseVisualStyleBackColor = true;
            this.btnAddCondominio.Click += new System.EventHandler(this.btnAddCondominio_Click);
            // 
            // btnRmvCondominio
            // 
            this.btnRmvCondominio.Image = ((System.Drawing.Image)(resources.GetObject("btnRmvCondominio.Image")));
            this.btnRmvCondominio.Location = new System.Drawing.Point(618, 329);
            this.btnRmvCondominio.Name = "btnRmvCondominio";
            this.btnRmvCondominio.Size = new System.Drawing.Size(35, 28);
            this.btnRmvCondominio.TabIndex = 18;
            this.btnRmvCondominio.UseVisualStyleBackColor = true;
            this.btnRmvCondominio.Click += new System.EventHandler(this.btnRmvCondominio_Click);
            // 
            // idcondominiosDataGridViewTextBoxColumn
            // 
            this.idcondominiosDataGridViewTextBoxColumn.DataPropertyName = "idcondominios";
            this.idcondominiosDataGridViewTextBoxColumn.HeaderText = "idcondominios";
            this.idcondominiosDataGridViewTextBoxColumn.Name = "idcondominiosDataGridViewTextBoxColumn";
            this.idcondominiosDataGridViewTextBoxColumn.Width = 99;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.Width = 58;
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "endereco";
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            this.enderecoDataGridViewTextBoxColumn.Width = 77;
            // 
            // entityKeyDataGridViewTextBoxColumn
            // 
            this.entityKeyDataGridViewTextBoxColumn.DataPropertyName = "EntityKey";
            this.entityKeyDataGridViewTextBoxColumn.HeaderText = "EntityKey";
            this.entityKeyDataGridViewTextBoxColumn.Name = "entityKeyDataGridViewTextBoxColumn";
            this.entityKeyDataGridViewTextBoxColumn.Width = 76;
            // 
            // TabelaData
            // 
            this.TabelaData.DataSource = this.BDS;
            this.TabelaData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabelaData.Location = new System.Drawing.Point(0, 0);
            this.TabelaData.MainView = this.gridView1;
            this.TabelaData.Margin = new System.Windows.Forms.Padding(0);
            this.TabelaData.Name = "TabelaData";
            this.TabelaData.Size = new System.Drawing.Size(697, 368);
            this.TabelaData.TabIndex = 1;
            this.TabelaData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidmoradores,
            this.colnome,
            this.colcpf});
            this.gridView1.GridControl = this.TabelaData;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colidmoradores
            // 
            this.colidmoradores.Caption = "Id";
            this.colidmoradores.FieldName = "idmoradores";
            this.colidmoradores.Name = "colidmoradores";
            this.colidmoradores.Visible = true;
            this.colidmoradores.VisibleIndex = 0;
            // 
            // colnome
            // 
            this.colnome.Caption = "Nome";
            this.colnome.FieldName = "nome";
            this.colnome.Name = "colnome";
            this.colnome.Visible = true;
            this.colnome.VisibleIndex = 1;
            // 
            // colcpf
            // 
            this.colcpf.Caption = "CPF";
            this.colcpf.FieldName = "cpf";
            this.colcpf.Name = "colcpf";
            this.colcpf.Visible = true;
            this.colcpf.VisibleIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.FonteDeDados;
            this.gridControl1.Location = new System.Drawing.Point(58, 199);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(0);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControl1.Size = new System.Drawing.Size(595, 127);
            this.gridControl1.TabIndex = 19;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidcondominios,
            this.colnome1});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.GroupPanelText = "Condomínios";
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent;
            this.gridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            // 
            // colidcondominios
            // 
            this.colidcondominios.Caption = "Id";
            this.colidcondominios.FieldName = "idcondominios";
            this.colidcondominios.Name = "colidcondominios";
            this.colidcondominios.Visible = true;
            this.colidcondominios.VisibleIndex = 0;
            this.colidcondominios.Width = 26;
            // 
            // colnome1
            // 
            this.colnome1.Caption = "Nome";
            this.colnome1.FieldName = "nome";
            this.colnome1.Name = "colnome1";
            this.colnome1.Visible = true;
            this.colnome1.VisibleIndex = 1;
            this.colnome1.Width = 551;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // txtemail
            // 
            this.txtemail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BDS, "email", true));
            this.txtemail.Location = new System.Drawing.Point(136, 149);
            this.txtemail.MaxLength = 50;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(277, 20);
            this.txtemail.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Email :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(419, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Resetar Senha";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormCadMoradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 413);
            this.Name = "FormCadMoradores";
            this.Text = "Cadastro de Moradores";
            ((System.ComponentModel.ISupportInitialize)(this.FonteDeDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paginas)).EndInit();
            this.Paginas.ResumeLayout(false);
            this.TabAcesso.ResumeLayout(false);
            this.TabManutencao.ResumeLayout(false);
            this.TabManutencao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idcondominiosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entityKeyDataGridViewTextBoxColumn;
        private DevExpress.XtraGrid.GridControl TabelaData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colidmoradores;
        private DevExpress.XtraGrid.Columns.GridColumn colnome;
        private DevExpress.XtraGrid.Columns.GridColumn colcpf;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colidcondominios;
        private DevExpress.XtraGrid.Columns.GridColumn colnome1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}