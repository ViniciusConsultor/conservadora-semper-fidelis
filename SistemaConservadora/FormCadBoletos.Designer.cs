namespace SistemaConservadora
{
    partial class FormCadBoletos
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
            this.cmbMorador = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtReferenteA = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIdentificacao = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblCaminhoArquivo = new System.Windows.Forms.Label();
            this.lblDownload = new System.Windows.Forms.LinkLabel();
            this.cmbSituacao = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SalvarArquivo = new System.Windows.Forms.SaveFileDialog();
            this.TabManutencao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FonteDeDados)).BeginInit();
            this.SuspendLayout();
            // 
            // TabManutencao
            // 
            this.TabManutencao.Controls.Add(this.label4);
            this.TabManutencao.Controls.Add(this.cmbSituacao);
            this.TabManutencao.Controls.Add(this.lblDownload);
            this.TabManutencao.Controls.Add(this.lblCaminhoArquivo);
            this.TabManutencao.Controls.Add(this.lblIdentificacao);
            this.TabManutencao.Controls.Add(this.lblID);
            this.TabManutencao.Controls.Add(this.label3);
            this.TabManutencao.Controls.Add(this.dtReferenteA);
            this.TabManutencao.Controls.Add(this.label2);
            this.TabManutencao.Controls.Add(this.cmbMorador);
            this.TabManutencao.Controls.Add(this.btnUpload);
            this.TabManutencao.Controls.Add(this.btnLocalizar);
            this.TabManutencao.Controls.Add(this.label1);
            this.TabManutencao.Controls.Add(this.txtArquivo);
            // 
            // txtArquivo
            // 
            this.txtArquivo.Location = new System.Drawing.Point(127, 59);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(282, 20);
            this.txtArquivo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Arquivo PDF :";
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Location = new System.Drawing.Point(415, 57);
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
            this.btnUpload.Location = new System.Drawing.Point(496, 57);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 6;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // cmbMorador
            // 
            this.cmbMorador.FormattingEnabled = true;
            this.cmbMorador.Location = new System.Drawing.Point(127, 133);
            this.cmbMorador.Name = "cmbMorador";
            this.cmbMorador.Size = new System.Drawing.Size(444, 21);
            this.cmbMorador.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Morador :";
            // 
            // dtReferenteA
            // 
            this.dtReferenteA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtReferenteA.Location = new System.Drawing.Point(127, 33);
            this.dtReferenteA.Name = "dtReferenteA";
            this.dtReferenteA.Size = new System.Drawing.Size(444, 20);
            this.dtReferenteA.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Referente à:";
            // 
            // lblIdentificacao
            // 
            this.lblIdentificacao.AutoSize = true;
            this.lblIdentificacao.Location = new System.Drawing.Point(128, 17);
            this.lblIdentificacao.Name = "lblIdentificacao";
            this.lblIdentificacao.Size = new System.Drawing.Size(76, 13);
            this.lblIdentificacao.TabIndex = 12;
            this.lblIdentificacao.Text = "{Identificação}";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(48, 17);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(74, 13);
            this.lblID.TabIndex = 11;
            this.lblID.Text = "Identificação :";
            // 
            // lblCaminhoArquivo
            // 
            this.lblCaminhoArquivo.Location = new System.Drawing.Point(127, 102);
            this.lblCaminhoArquivo.Name = "lblCaminhoArquivo";
            this.lblCaminhoArquivo.Size = new System.Drawing.Size(383, 13);
            this.lblCaminhoArquivo.TabIndex = 13;
            // 
            // lblDownload
            // 
            this.lblDownload.AutoSize = true;
            this.lblDownload.Location = new System.Drawing.Point(516, 102);
            this.lblDownload.Name = "lblDownload";
            this.lblDownload.Size = new System.Drawing.Size(55, 13);
            this.lblDownload.TabIndex = 14;
            this.lblDownload.TabStop = true;
            this.lblDownload.Text = "Download";
            this.lblDownload.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblDownload_LinkClicked);
            // 
            // cmbSituacao
            // 
            this.cmbSituacao.FormattingEnabled = true;
            this.cmbSituacao.Items.AddRange(new object[] {
            "Aberto",
            "Quitado"});
            this.cmbSituacao.Location = new System.Drawing.Point(127, 160);
            this.cmbSituacao.Name = "cmbSituacao";
            this.cmbSituacao.Size = new System.Drawing.Size(121, 21);
            this.cmbSituacao.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Situação :";
            // 
            // SalvarArquivo
            // 
            this.SalvarArquivo.Filter = "PDF Filer | *.pdf";
            // 
            // FormCadBoletos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(702, 338);
            this.Name = "FormCadBoletos";
            this.Text = "Cadastro de Boletos";
            this.TabManutencao.ResumeLayout(false);
            this.TabManutencao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FonteDeDados)).EndInit();
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
        private System.Windows.Forms.ComboBox cmbMorador;
        private System.Windows.Forms.LinkLabel lblDownload;
        private System.Windows.Forms.Label lblCaminhoArquivo;
        private System.Windows.Forms.Label lblIdentificacao;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbSituacao;
        private System.Windows.Forms.SaveFileDialog SalvarArquivo;
    }
}
