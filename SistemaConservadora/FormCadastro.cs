using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaConservadora
{
    public enum Estado { Editar, Adicionar, Closed };
    public partial class FormCadastro : Form
    {
        protected Estado State;

        public FormCadastro()
        {
            InitializeComponent();
            Paginas.SelectedTabPage = TabAcesso;
            State = Estado.Closed;
            Paginas_SelectedIndexChanged(null, new EventArgs());     
        }

        public virtual void ClearFields(){}
        public virtual void Populate(){}

        public virtual void Excluir(int id)
        {
            Paginas.SelectedTabPage = TabAcesso;
        }

        public virtual void Adicionar()
        {
            Paginas.SelectedTabPage = TabAcesso;
        }

        public virtual void Atualizar(int id)
        {
            Paginas.SelectedTabPage = TabAcesso;
        }
        

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            BDS.AddNew();
            ClearFields();
            Paginas.SelectedTabPage = TabManutencao;
            State = Estado.Adicionar;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Populate();
            Paginas.SelectedTabPage = TabManutencao;
            State = Estado.Editar;
        }

        protected virtual void Paginas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Excluir(0);
            BindGrid();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            BDS.MovePrevious();          
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (State == Estado.Adicionar)
            {
                Adicionar();
                BindGrid();
            }
            else {
                Atualizar(0);
                BindGrid();
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            BDS.MoveNext();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            State = Estado.Closed;
            BDS.CancelEdit();
            Paginas.SelectedTabPage = TabAcesso;
        }

        private void TabelaData_CellDoubleClick(object sender, EventArgs e)
        {
            btnEditar_Click(sender, e);
        }

        private void txtPesquisar_Click(object sender, EventArgs e)
        {
            
        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {

        }

        private void FormCadastro_Click(object sender, EventArgs e)
        {
           
        }

        public virtual void BindGrid()
        { 
        
        }

        private void Paginas_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (Paginas.SelectedTabPage == TabAcesso)
            {
                btnAdicionar.Enabled = true;
                btnEditar.Enabled = true;
                btnApagar.Enabled = true;
                btnAnterior.Enabled = false;
                btnProximo.Enabled = false;
            ;
                btnGravar.Enabled = false;
                btnCancelar.Enabled = false;
            }
            else
            {

                btnAdicionar.Enabled = false;
                btnEditar.Enabled = false;
                btnApagar.Enabled = true;
                btnAnterior.Enabled = true;
                btnProximo.Enabled = true;
           
                btnGravar.Enabled = true;
                btnCancelar.Enabled = true;

            }
        }

        private void FormCadastro_ControlAdded(object sender, ControlEventArgs e)
        {
           
        }

        private void TabManutencao_ControlAdded(object sender, ControlEventArgs e)
        {
           
        }

        private void Paginas_ControlAdded(object sender, ControlEventArgs e)
        {
            
        }

        private void TabAcesso_ControlAdded(object sender, ControlEventArgs e)
        {
            if (e.Control is DevExpress.XtraGrid.GridControl)
                (e.Control as DevExpress.XtraGrid.GridControl).DoubleClick += this.TabelaData_CellDoubleClick;
        }       
    }
}
