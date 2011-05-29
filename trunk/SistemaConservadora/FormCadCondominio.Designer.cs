namespace SistemaConservadora
{
    partial class FormCadCondominio
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
            this.lblIdentificacao = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.endereco = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.idcondominiosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entityKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcondominiosDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entityKeyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idcondominiosDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entityKeyDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabelaData = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidcondominios = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colendereco = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.FonteDeDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paginas)).BeginInit();
            this.Paginas.SuspendLayout();
            this.TabAcesso.SuspendLayout();
            this.TabManutencao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BDS
            // 
            this.BDS.DataSource = typeof(SistemaConservadora.CondominioWeb.condominio);
            this.BDS.Sort = "";
            // 
            // Paginas
            // 
            this.Paginas.Size = new System.Drawing.Size(694, 288);
            // 
            // TabAcesso
            // 
            this.TabAcesso.Controls.Add(this.TabelaData);
            this.TabAcesso.Size = new System.Drawing.Size(688, 282);
            // 
            // TabManutencao
            // 
            this.TabManutencao.Appearance.PageClient.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TabManutencao.Appearance.PageClient.Options.UseBackColor = true;
            this.TabManutencao.Controls.Add(this.txtEndereco);
            this.TabManutencao.Controls.Add(this.endereco);
            this.TabManutencao.Controls.Add(this.txtNome);
            this.TabManutencao.Controls.Add(this.label1);
            this.TabManutencao.Controls.Add(this.lblIdentificacao);
            this.TabManutencao.Controls.Add(this.lblID);
            this.TabManutencao.Size = new System.Drawing.Size(688, 282);
            // 
            // lblIdentificacao
            // 
            this.lblIdentificacao.AutoSize = true;
            this.lblIdentificacao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BDS, "idcondominios", true));
            this.lblIdentificacao.Location = new System.Drawing.Point(136, 31);
            this.lblIdentificacao.Name = "lblIdentificacao";
            this.lblIdentificacao.Size = new System.Drawing.Size(76, 13);
            this.lblIdentificacao.TabIndex = 3;
            this.lblIdentificacao.Text = "{Identificação}";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(56, 31);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(74, 13);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "Identificação :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome :";
            // 
            // txtNome
            // 
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BDS, "nome", true));
            this.txtNome.Location = new System.Drawing.Point(136, 63);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(277, 20);
            this.txtNome.TabIndex = 5;
            // 
            // endereco
            // 
            this.endereco.AutoSize = true;
            this.endereco.Location = new System.Drawing.Point(56, 95);
            this.endereco.Name = "endereco";
            this.endereco.Size = new System.Drawing.Size(59, 13);
            this.endereco.TabIndex = 6;
            this.endereco.Text = "Endereço :";
            // 
            // txtEndereco
            // 
            this.txtEndereco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BDS, "endereco", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtEndereco.Location = new System.Drawing.Point(136, 92);
            this.txtEndereco.MaxLength = 100;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(277, 20);
            this.txtEndereco.TabIndex = 7;
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
            // idcondominiosDataGridViewTextBoxColumn1
            // 
            this.idcondominiosDataGridViewTextBoxColumn1.DataPropertyName = "idcondominios";
            this.idcondominiosDataGridViewTextBoxColumn1.HeaderText = "idcondominios";
            this.idcondominiosDataGridViewTextBoxColumn1.Name = "idcondominiosDataGridViewTextBoxColumn1";
            this.idcondominiosDataGridViewTextBoxColumn1.Width = 99;
            // 
            // nomeDataGridViewTextBoxColumn1
            // 
            this.nomeDataGridViewTextBoxColumn1.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn1.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn1.Name = "nomeDataGridViewTextBoxColumn1";
            this.nomeDataGridViewTextBoxColumn1.Width = 58;
            // 
            // enderecoDataGridViewTextBoxColumn1
            // 
            this.enderecoDataGridViewTextBoxColumn1.DataPropertyName = "endereco";
            this.enderecoDataGridViewTextBoxColumn1.HeaderText = "endereco";
            this.enderecoDataGridViewTextBoxColumn1.Name = "enderecoDataGridViewTextBoxColumn1";
            this.enderecoDataGridViewTextBoxColumn1.Width = 77;
            // 
            // entityKeyDataGridViewTextBoxColumn1
            // 
            this.entityKeyDataGridViewTextBoxColumn1.DataPropertyName = "EntityKey";
            this.entityKeyDataGridViewTextBoxColumn1.HeaderText = "EntityKey";
            this.entityKeyDataGridViewTextBoxColumn1.Name = "entityKeyDataGridViewTextBoxColumn1";
            this.entityKeyDataGridViewTextBoxColumn1.Width = 76;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle1.NullValue = "<Null>";
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcondominiosDataGridViewTextBoxColumn2,
            this.nomeDataGridViewTextBoxColumn2,
            this.enderecoDataGridViewTextBoxColumn2,
            this.entityKeyDataGridViewTextBoxColumn2});
            this.dataGridView1.DataSource = this.BDS;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(688, 281);
            this.dataGridView1.TabIndex = 1;
            // 
            // idcondominiosDataGridViewTextBoxColumn2
            // 
            this.idcondominiosDataGridViewTextBoxColumn2.DataPropertyName = "idcondominios";
            this.idcondominiosDataGridViewTextBoxColumn2.HeaderText = "idcondominios";
            this.idcondominiosDataGridViewTextBoxColumn2.Name = "idcondominiosDataGridViewTextBoxColumn2";
            this.idcondominiosDataGridViewTextBoxColumn2.Width = 99;
            // 
            // nomeDataGridViewTextBoxColumn2
            // 
            this.nomeDataGridViewTextBoxColumn2.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn2.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn2.Name = "nomeDataGridViewTextBoxColumn2";
            this.nomeDataGridViewTextBoxColumn2.Width = 58;
            // 
            // enderecoDataGridViewTextBoxColumn2
            // 
            this.enderecoDataGridViewTextBoxColumn2.DataPropertyName = "endereco";
            this.enderecoDataGridViewTextBoxColumn2.HeaderText = "endereco";
            this.enderecoDataGridViewTextBoxColumn2.Name = "enderecoDataGridViewTextBoxColumn2";
            this.enderecoDataGridViewTextBoxColumn2.Width = 77;
            // 
            // entityKeyDataGridViewTextBoxColumn2
            // 
            this.entityKeyDataGridViewTextBoxColumn2.DataPropertyName = "EntityKey";
            this.entityKeyDataGridViewTextBoxColumn2.HeaderText = "EntityKey";
            this.entityKeyDataGridViewTextBoxColumn2.Name = "entityKeyDataGridViewTextBoxColumn2";
            this.entityKeyDataGridViewTextBoxColumn2.Width = 76;
            // 
            // TabelaData
            // 
            this.TabelaData.DataSource = this.BDS;
            this.TabelaData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabelaData.Location = new System.Drawing.Point(0, 0);
            this.TabelaData.MainView = this.gridView1;
            this.TabelaData.Margin = new System.Windows.Forms.Padding(0);
            this.TabelaData.Name = "TabelaData";
            this.TabelaData.Size = new System.Drawing.Size(688, 282);
            this.TabelaData.TabIndex = 0;
            this.TabelaData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.TabelaData.DoubleClick += new System.EventHandler(this.TabelaData_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidcondominios,
            this.colnome,
            this.colendereco});
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
            // colidcondominios
            // 
            this.colidcondominios.Caption = "Id";
            this.colidcondominios.FieldName = "idcondominios";
            this.colidcondominios.Name = "colidcondominios";
            this.colidcondominios.Visible = true;
            this.colidcondominios.VisibleIndex = 0;
            this.colidcondominios.Width = 50;
            // 
            // colnome
            // 
            this.colnome.Caption = "Nome";
            this.colnome.FieldName = "nome";
            this.colnome.Name = "colnome";
            this.colnome.Visible = true;
            this.colnome.VisibleIndex = 1;
            this.colnome.Width = 313;
            // 
            // colendereco
            // 
            this.colendereco.Caption = "Endereço";
            this.colendereco.FieldName = "endereco";
            this.colendereco.Name = "colendereco";
            this.colendereco.Visible = true;
            this.colendereco.VisibleIndex = 2;
            this.colendereco.Width = 315;
            // 
            // FormCadCondominio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 327);
            this.Name = "FormCadCondominio";
            this.Text = "Cadastro de Condomínio";
            ((System.ComponentModel.ISupportInitialize)(this.FonteDeDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paginas)).EndInit();
            this.Paginas.ResumeLayout(false);
            this.TabAcesso.ResumeLayout(false);
            this.TabManutencao.ResumeLayout(false);
            this.TabManutencao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdentificacao;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label endereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcondominiosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entityKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcondominiosDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn entityKeyDataGridViewTextBoxColumn1;
        protected System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcondominiosDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn entityKeyDataGridViewTextBoxColumn2;
        private DevExpress.XtraGrid.GridControl TabelaData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colidcondominios;
        private DevExpress.XtraGrid.Columns.GridColumn colnome;
        private DevExpress.XtraGrid.Columns.GridColumn colendereco;
    }
}