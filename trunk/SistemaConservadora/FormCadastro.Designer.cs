namespace SistemaConservadora
{
    partial class FormCadastro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastro));
            this.Menu = new System.Windows.Forms.ToolStrip();
            this.btnAdicionar = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnApagar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAnterior = new System.Windows.Forms.ToolStripButton();
            this.btnProximo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnGravar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.FonteDeDados = new System.Windows.Forms.BindingSource(this.components);
            this.BDS = new System.Windows.Forms.BindingSource(this.components);
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.Paginas = new DevExpress.XtraTab.XtraTabControl();
            this.TabAcesso = new DevExpress.XtraTab.XtraTabPage();
            this.TabManutencao = new DevExpress.XtraTab.XtraTabPage();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FonteDeDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDS)).BeginInit();
            this.pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Paginas)).BeginInit();
            this.Paginas.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Menu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdicionar,
            this.btnEditar,
            this.btnApagar,
            this.toolStripSeparator1,
            this.btnAnterior,
            this.btnProximo,
            this.toolStripSeparator2,
            this.btnGravar,
            this.btnCancelar});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(652, 39);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "toolStrip1";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdicionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(94, 36);
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(73, 36);
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Image = ((System.Drawing.Image)(resources.GetObject("btnApagar.Image")));
            this.btnApagar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(81, 36);
            this.btnApagar.Text = "Apagar";
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
            this.btnAnterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(86, 36);
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Image = ((System.Drawing.Image)(resources.GetObject("btnProximo.Image")));
            this.btnProximo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(87, 36);
            this.btnProximo.Text = "Próximo";
            this.btnProximo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // btnGravar
            // 
            this.btnGravar.Image = ((System.Drawing.Image)(resources.GetObject("btnGravar.Image")));
            this.btnGravar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(77, 36);
            this.btnGravar.Text = "Gravar";
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 36);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlPrincipal.Controls.Add(this.Paginas);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 39);
            this.pnlPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(652, 268);
            this.pnlPrincipal.TabIndex = 1;
            // 
            // Paginas
            // 
            this.Paginas.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.Paginas.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.Paginas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Paginas.Location = new System.Drawing.Point(0, 0);
            this.Paginas.Margin = new System.Windows.Forms.Padding(0);
            this.Paginas.Name = "Paginas";
            this.Paginas.SelectedTabPage = this.TabAcesso;
            this.Paginas.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.Paginas.Size = new System.Drawing.Size(652, 268);
            this.Paginas.TabIndex = 0;
            this.Paginas.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabAcesso,
            this.TabManutencao});
            this.Paginas.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.Paginas_SelectedPageChanged);
            this.Paginas.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.Paginas_ControlAdded);
            // 
            // TabAcesso
            // 
            this.TabAcesso.Margin = new System.Windows.Forms.Padding(0);
            this.TabAcesso.Name = "TabAcesso";
            this.TabAcesso.Size = new System.Drawing.Size(646, 262);
            this.TabAcesso.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.TabAcesso_ControlAdded);
            // 
            // TabManutencao
            // 
            this.TabManutencao.Appearance.PageClient.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TabManutencao.Appearance.PageClient.Options.UseBackColor = true;
            this.TabManutencao.Name = "TabManutencao";
            this.TabManutencao.Size = new System.Drawing.Size(646, 262);
            this.TabManutencao.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.TabManutencao_ControlAdded);
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 307);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCadastro";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro do Sistema - {Nome Cadastro}";
            this.Load += new System.EventHandler(this.FormCadastro_Load);
            this.Click += new System.EventHandler(this.FormCadastro_Click);
            this.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.FormCadastro_ControlAdded);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FonteDeDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDS)).EndInit();
            this.pnlPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Paginas)).EndInit();
            this.Paginas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.ToolStrip Menu;
        private System.Windows.Forms.ToolStripButton btnAdicionar;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnApagar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnAnterior;
        private System.Windows.Forms.ToolStripButton btnProximo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnGravar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        protected System.Windows.Forms.BindingSource FonteDeDados;
        public System.Windows.Forms.BindingSource BDS;
        private System.Windows.Forms.Panel pnlPrincipal;
        public DevExpress.XtraTab.XtraTabControl Paginas;
        public DevExpress.XtraTab.XtraTabPage TabAcesso;
        public DevExpress.XtraTab.XtraTabPage TabManutencao;
    }
}