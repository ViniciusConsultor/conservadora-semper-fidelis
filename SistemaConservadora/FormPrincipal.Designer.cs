namespace SistemaConservadora
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCondominio = new System.Windows.Forms.Button();
            this.btnMoradores = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnCondominio = new System.Windows.Forms.ToolStripMenuItem();
            this.registoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balanceteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boletosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.barStatus = new System.Windows.Forms.StatusStrip();
            this.lblHoras = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TemporizadorHoras = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.Menu.SuspendLayout();
            this.barStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnCondominio);
            this.panel1.Controls.Add(this.btnMoradores);
            this.panel1.Controls.Add(this.Menu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 122);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(451, 27);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 89);
            this.button4.TabIndex = 5;
            this.button4.Text = "Boletos";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(339, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 89);
            this.button3.TabIndex = 4;
            this.button3.Text = "Recados";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(227, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 89);
            this.button2.TabIndex = 3;
            this.button2.Text = "Balancete";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnCondominio
            // 
            this.btnCondominio.Image = ((System.Drawing.Image)(resources.GetObject("btnCondominio.Image")));
            this.btnCondominio.Location = new System.Drawing.Point(3, 27);
            this.btnCondominio.Name = "btnCondominio";
            this.btnCondominio.Size = new System.Drawing.Size(106, 89);
            this.btnCondominio.TabIndex = 2;
            this.btnCondominio.Text = "Condomínio";
            this.btnCondominio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCondominio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCondominio.UseVisualStyleBackColor = true;
            this.btnCondominio.Click += new System.EventHandler(this.btnCondominio_Click);
            // 
            // btnMoradores
            // 
            this.btnMoradores.Image = ((System.Drawing.Image)(resources.GetObject("btnMoradores.Image")));
            this.btnMoradores.Location = new System.Drawing.Point(115, 27);
            this.btnMoradores.Name = "btnMoradores";
            this.btnMoradores.Size = new System.Drawing.Size(106, 89);
            this.btnMoradores.TabIndex = 1;
            this.btnMoradores.Text = "Moradores";
            this.btnMoradores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMoradores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMoradores.UseVisualStyleBackColor = true;
            this.btnMoradores.Click += new System.EventHandler(this.btnMoradores_Click);
            // 
            // Menu
            // 
            this.Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.cadastroToolStripMenuItem,
            this.registoToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(782, 24);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "Menu";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moradorToolStripMenuItem,
            this.MnCondominio});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // moradorToolStripMenuItem
            // 
            this.moradorToolStripMenuItem.Name = "moradorToolStripMenuItem";
            this.moradorToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.moradorToolStripMenuItem.Text = "Morador";
            // 
            // MnCondominio
            // 
            this.MnCondominio.Name = "MnCondominio";
            this.MnCondominio.Size = new System.Drawing.Size(140, 22);
            this.MnCondominio.Text = "Condomínio";
            this.MnCondominio.Click += new System.EventHandler(this.btnCondominio_Click);
            // 
            // registoToolStripMenuItem
            // 
            this.registoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.balanceteToolStripMenuItem,
            this.recadosToolStripMenuItem,
            this.boletosToolStripMenuItem});
            this.registoToolStripMenuItem.Name = "registoToolStripMenuItem";
            this.registoToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.registoToolStripMenuItem.Text = "Registo";
            // 
            // balanceteToolStripMenuItem
            // 
            this.balanceteToolStripMenuItem.Name = "balanceteToolStripMenuItem";
            this.balanceteToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.balanceteToolStripMenuItem.Text = "Balancete";
            // 
            // recadosToolStripMenuItem
            // 
            this.recadosToolStripMenuItem.Name = "recadosToolStripMenuItem";
            this.recadosToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.recadosToolStripMenuItem.Text = "Recados";
            // 
            // boletosToolStripMenuItem
            // 
            this.boletosToolStripMenuItem.Name = "boletosToolStripMenuItem";
            this.boletosToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.boletosToolStripMenuItem.Text = "Boletos";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.sobreToolStripMenuItem.Text = "Sobre...";
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 122);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(782, 213);
            this.pnlPrincipal.TabIndex = 1;
            // 
            // barStatus
            // 
            this.barStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblHoras,
            this.toolStripStatusLabel1});
            this.barStatus.Location = new System.Drawing.Point(0, 313);
            this.barStatus.Name = "barStatus";
            this.barStatus.Size = new System.Drawing.Size(782, 22);
            this.barStatus.TabIndex = 2;
            // 
            // lblHoras
            // 
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(61, 17);
            this.lblHoras.Text = "{00:00:00}";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(109, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // TemporizadorHoras
            // 
            this.TemporizadorHoras.Tick += new System.EventHandler(this.TemporizadorHoras_Tick);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 335);
            this.Controls.Add(this.barStatus);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conservadora {Nome} - Sistema de Administração";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.barStatus.ResumeLayout(false);
            this.barStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.StatusStrip barStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblHoras;
        private System.Windows.Forms.Timer TemporizadorHoras;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnCondominio;
        private System.Windows.Forms.ToolStripMenuItem registoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balanceteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boletosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCondominio;
        private System.Windows.Forms.Button btnMoradores;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}