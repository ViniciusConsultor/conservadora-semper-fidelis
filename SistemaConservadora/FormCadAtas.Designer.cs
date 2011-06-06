namespace SistemaConservadora
{
    partial class FormCadAtas
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
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.dlgArquivo = new System.Windows.Forms.OpenFileDialog();
            this.btnUpload = new System.Windows.Forms.Button();
            this.cmbCondominios = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtReferenteA = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIdentificacao = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblCaminhoArquivo = new System.Windows.Forms.Label();
            this.lblDownload = new System.Windows.Forms.LinkLabel();
            this.SalvarArquivo = new System.Windows.Forms.SaveFileDialog();
            this.TabelaData = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidata = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldata = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidcondominios = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcaminhoArquivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FonteDeDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paginas)).BeginInit();
            this.Paginas.SuspendLayout();
            this.TabAcesso.SuspendLayout();
            this.TabManutencao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BDS
            // 
            this.BDS.DataSource = typeof(SistemaConservadora.AtasWeb.ata);
            // 
            // Paginas
            // 
            this.Paginas.SelectedTabPage = this.TabManutencao;
            this.Paginas.Size = new System.Drawing.Size(702, 299);
            // 
            // TabAcesso
            // 
            this.TabAcesso.Controls.Add(this.TabelaData);
            this.TabAcesso.Size = new System.Drawing.Size(696, 293);
            // 
            // TabManutencao
            // 
            this.TabManutencao.Appearance.PageClient.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TabManutencao.Appearance.PageClient.Options.UseBackColor = true;
            this.TabManutencao.Controls.Add(this.label4);
            this.TabManutencao.Controls.Add(this.txtDescricao);
            this.TabManutencao.Controls.Add(this.lblDownload);
            this.TabManutencao.Controls.Add(this.lblCaminhoArquivo);
            this.TabManutencao.Controls.Add(this.lblIdentificacao);
            this.TabManutencao.Controls.Add(this.lblID);
            this.TabManutencao.Controls.Add(this.label3);
            this.TabManutencao.Controls.Add(this.dtReferenteA);
            this.TabManutencao.Controls.Add(this.label2);
            this.TabManutencao.Controls.Add(this.cmbCondominios);
            this.TabManutencao.Controls.Add(this.btnUpload);
            this.TabManutencao.Controls.Add(this.btnLocalizar);
            this.TabManutencao.Controls.Add(this.label1);
            this.TabManutencao.Controls.Add(this.txtArquivo);
            this.TabManutencao.Size = new System.Drawing.Size(696, 293);
            // 
            // txtArquivo
            // 
            this.txtArquivo.Location = new System.Drawing.Point(130, 137);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(282, 20);
            this.txtArquivo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Arquivo PDF :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Location = new System.Drawing.Point(418, 135);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(75, 23);
            this.btnLocalizar.TabIndex = 5;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // dlgArquivo
            // 
            this.dlgArquivo.Filter = "PDF Files|*.pdf";
            this.dlgArquivo.Title = "Selecione o boleto que deseja enviar ao servidor";
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(499, 135);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 6;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // cmbCondominios
            // 
            this.cmbCondominios.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.BDS, "idcondominios", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbCondominios.FormattingEnabled = true;
            this.cmbCondominios.Location = new System.Drawing.Point(130, 110);
            this.cmbCondominios.Name = "cmbCondominios";
            this.cmbCondominios.Size = new System.Drawing.Size(444, 21);
            this.cmbCondominios.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Condomínio :";
            // 
            // dtReferenteA
            // 
            this.dtReferenteA.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BDS, "data", true));
            this.dtReferenteA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtReferenteA.Location = new System.Drawing.Point(130, 84);
            this.dtReferenteA.Name = "dtReferenteA";
            this.dtReferenteA.Size = new System.Drawing.Size(444, 20);
            this.dtReferenteA.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Referente à :";
            // 
            // lblIdentificacao
            // 
            this.lblIdentificacao.AutoSize = true;
            this.lblIdentificacao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BDS, "idata", true));
            this.lblIdentificacao.Location = new System.Drawing.Point(130, 42);
            this.lblIdentificacao.Name = "lblIdentificacao";
            this.lblIdentificacao.Size = new System.Drawing.Size(76, 13);
            this.lblIdentificacao.TabIndex = 12;
            this.lblIdentificacao.Text = "{Identificação}";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(50, 42);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(74, 13);
            this.lblID.TabIndex = 11;
            this.lblID.Text = "Identificação :";
            // 
            // lblCaminhoArquivo
            // 
            this.lblCaminhoArquivo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BDS, "caminhoArquivo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblCaminhoArquivo.Location = new System.Drawing.Point(130, 180);
            this.lblCaminhoArquivo.Name = "lblCaminhoArquivo";
            this.lblCaminhoArquivo.Size = new System.Drawing.Size(383, 13);
            this.lblCaminhoArquivo.TabIndex = 13;
            // 
            // lblDownload
            // 
            this.lblDownload.AutoSize = true;
            this.lblDownload.Location = new System.Drawing.Point(519, 180);
            this.lblDownload.Name = "lblDownload";
            this.lblDownload.Size = new System.Drawing.Size(55, 13);
            this.lblDownload.TabIndex = 14;
            this.lblDownload.TabStop = true;
            this.lblDownload.Text = "Download";
            this.lblDownload.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblDownload_LinkClicked);
            // 
            // SalvarArquivo
            // 
            this.SalvarArquivo.Filter = "PDF Filer | *.pdf";
            // 
            // TabelaData
            // 
            this.TabelaData.DataSource = this.BDS;
            this.TabelaData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabelaData.Location = new System.Drawing.Point(0, 0);
            this.TabelaData.MainView = this.gridView1;
            this.TabelaData.Margin = new System.Windows.Forms.Padding(0);
            this.TabelaData.Name = "TabelaData";
            this.TabelaData.Size = new System.Drawing.Size(696, 293);
            this.TabelaData.TabIndex = 1;
            this.TabelaData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidata,
            this.coldata,
            this.colidcondominios,
            this.colcaminhoArquivo,
            this.gridColumn1});
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
            // colidata
            // 
            this.colidata.Caption = "Id";
            this.colidata.FieldName = "idata";
            this.colidata.Name = "colidata";
            this.colidata.Visible = true;
            this.colidata.VisibleIndex = 0;
            // 
            // coldata
            // 
            this.coldata.Caption = "Data";
            this.coldata.FieldName = "data";
            this.coldata.Name = "coldata";
            this.coldata.Visible = true;
            this.coldata.VisibleIndex = 1;
            // 
            // colidcondominios
            // 
            this.colidcondominios.Caption = "Condominio";
            this.colidcondominios.FieldName = "idcondominios";
            this.colidcondominios.Name = "colidcondominios";
            this.colidcondominios.Visible = true;
            this.colidcondominios.VisibleIndex = 3;
            // 
            // colcaminhoArquivo
            // 
            this.colcaminhoArquivo.Caption = "Caminho Do Arquivo";
            this.colcaminhoArquivo.FieldName = "caminhoArquivo";
            this.colcaminhoArquivo.Name = "colcaminhoArquivo";
            this.colcaminhoArquivo.Visible = true;
            this.colcaminhoArquivo.VisibleIndex = 4;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Descrição";
            this.gridColumn1.FieldName = "descricao";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            // 
            // txtDescricao
            // 
            this.txtDescricao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BDS, "descricao", true));
            this.txtDescricao.Location = new System.Drawing.Point(130, 58);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(444, 20);
            this.txtDescricao.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Descrição :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // FormCadAtas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(702, 338);
            this.Name = "FormCadAtas";
            this.Text = "Cadastro de Atas";
            ((System.ComponentModel.ISupportInitialize)(this.FonteDeDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paginas)).EndInit();
            this.Paginas.ResumeLayout(false);
            this.TabAcesso.ResumeLayout(false);
            this.TabManutencao.ResumeLayout(false);
            this.TabManutencao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArquivo;
        public System.Windows.Forms.OpenFileDialog dlgArquivo;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DateTimePicker dtReferenteA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCondominios;
        private System.Windows.Forms.LinkLabel lblDownload;
        private System.Windows.Forms.Label lblCaminhoArquivo;
        private System.Windows.Forms.Label lblIdentificacao;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.SaveFileDialog SalvarArquivo;
        private DevExpress.XtraGrid.GridControl TabelaData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colcaminhoArquivo;
        private DevExpress.XtraGrid.Columns.GridColumn coldata;
        private DevExpress.XtraGrid.Columns.GridColumn colidata;
        private DevExpress.XtraGrid.Columns.GridColumn colidcondominios;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescricao;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}
