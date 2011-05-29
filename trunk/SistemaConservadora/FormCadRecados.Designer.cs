namespace SistemaConservadora
{
    partial class FormCadRecados
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
            this.lblIdentificacao = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.endereco = new System.Windows.Forms.Label();
            this.rchTexto = new System.Windows.Forms.RichTextBox();
            this.cmbCondominio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TabelaData = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidrecados = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTítulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTexto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.BDS.DataSource = typeof(SistemaConservadora.RecadosWeb.recado);
            // 
            // Paginas
            // 
            this.Paginas.SelectedTabPage = this.TabAcesso;
            this.Paginas.Size = new System.Drawing.Size(702, 337);
            // 
            // TabAcesso
            // 
            this.TabAcesso.Controls.Add(this.TabelaData);
            this.TabAcesso.Size = new System.Drawing.Size(696, 331);
            // 
            // TabManutencao
            // 
            this.TabManutencao.Appearance.PageClient.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TabManutencao.Appearance.PageClient.Options.UseBackColor = true;
            this.TabManutencao.Controls.Add(this.label2);
            this.TabManutencao.Controls.Add(this.cmbCondominio);
            this.TabManutencao.Controls.Add(this.rchTexto);
            this.TabManutencao.Controls.Add(this.endereco);
            this.TabManutencao.Controls.Add(this.txtTitulo);
            this.TabManutencao.Controls.Add(this.label1);
            this.TabManutencao.Controls.Add(this.lblIdentificacao);
            this.TabManutencao.Controls.Add(this.lblID);
            this.TabManutencao.Size = new System.Drawing.Size(696, 331);
            // 
            // lblIdentificacao
            // 
            this.lblIdentificacao.AutoSize = true;
            this.lblIdentificacao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BDS, "idrecados", true));
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
            this.label1.Text = "Título :";
            // 
            // txtTitulo
            // 
            this.txtTitulo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BDS, "Título", true));
            this.txtTitulo.Location = new System.Drawing.Point(136, 63);
            this.txtTitulo.MaxLength = 50;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(277, 20);
            this.txtTitulo.TabIndex = 5;
            // 
            // endereco
            // 
            this.endereco.AutoSize = true;
            this.endereco.Location = new System.Drawing.Point(56, 89);
            this.endereco.Name = "endereco";
            this.endereco.Size = new System.Drawing.Size(40, 13);
            this.endereco.TabIndex = 6;
            this.endereco.Text = "Texto :";
            // 
            // rchTexto
            // 
            this.rchTexto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BDS, "Texto", true));
            this.rchTexto.Location = new System.Drawing.Point(136, 89);
            this.rchTexto.Name = "rchTexto";
            this.rchTexto.Size = new System.Drawing.Size(517, 190);
            this.rchTexto.TabIndex = 7;
            this.rchTexto.Text = "";
            // 
            // cmbCondominio
            // 
            this.cmbCondominio.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.BDS, "idcondominios", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbCondominio.FormattingEnabled = true;
            this.cmbCondominio.Location = new System.Drawing.Point(136, 285);
            this.cmbCondominio.Name = "cmbCondominio";
            this.cmbCondominio.Size = new System.Drawing.Size(287, 21);
            this.cmbCondominio.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Condomínio :";
            // 
            // TabelaData
            // 
            this.TabelaData.DataSource = this.BDS;
            this.TabelaData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabelaData.Location = new System.Drawing.Point(0, 0);
            this.TabelaData.MainView = this.gridView1;
            this.TabelaData.Margin = new System.Windows.Forms.Padding(0);
            this.TabelaData.Name = "TabelaData";
            this.TabelaData.Size = new System.Drawing.Size(696, 331);
            this.TabelaData.TabIndex = 1;
            this.TabelaData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidrecados,
            this.colTítulo,
            this.colTexto,
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
            // colidrecados
            // 
            this.colidrecados.Caption = "Id";
            this.colidrecados.FieldName = "idrecados";
            this.colidrecados.Name = "colidrecados";
            this.colidrecados.Visible = true;
            this.colidrecados.VisibleIndex = 0;
            // 
            // colTítulo
            // 
            this.colTítulo.Caption = "Título";
            this.colTítulo.FieldName = "Título";
            this.colTítulo.Name = "colTítulo";
            this.colTítulo.Visible = true;
            this.colTítulo.VisibleIndex = 1;
            // 
            // colTexto
            // 
            this.colTexto.Caption = "Texto";
            this.colTexto.FieldName = "Texto";
            this.colTexto.Name = "colTexto";
            this.colTexto.Visible = true;
            this.colTexto.VisibleIndex = 2;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Condominio";
            this.gridColumn1.FieldName = "NomeCondominio";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            // 
            // FormCadRecados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 376);
            this.Name = "FormCadRecados";
            this.Text = "Cadastro de Recados";
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

        private System.Windows.Forms.Label lblIdentificacao;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label endereco;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCondominio;
        private System.Windows.Forms.RichTextBox rchTexto;
        private DevExpress.XtraGrid.GridControl TabelaData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colidrecados;
        private DevExpress.XtraGrid.Columns.GridColumn colTítulo;
        private DevExpress.XtraGrid.Columns.GridColumn colTexto;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}