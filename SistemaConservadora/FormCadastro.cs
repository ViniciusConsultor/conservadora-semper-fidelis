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
            Paginas.SelectTab(0);
            State = Estado.Closed;
            Paginas_SelectedIndexChanged(null, new EventArgs());

        }

        public virtual void ClearFields(){}
        public virtual void Populate(){}

        public virtual void Excluir(int id)
        {
            Paginas.SelectTab(0);
        }

        public virtual void Adicionar()
        {
            Paginas.SelectTab(0);
        }

        public virtual void Atualizar(int id)
        {
            Paginas.SelectTab(0);
        }
        

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            ClearFields();
            Paginas.SelectTab(1);
            State = Estado.Adicionar;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Populate();
            Paginas.SelectTab(1);
            State = Estado.Editar;
        }

        protected virtual void Paginas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Paginas.SelectedIndex == 0)
            {
                btnAdicionar.Enabled = true;
                btnEditar.Enabled = true;
                btnApagar.Enabled = true;
                btnAnterior.Enabled = false;
                btnProximo.Enabled = false;
                btnPesquisar.Enabled = true;
                txtPesquisar.Enabled = true;
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
                btnPesquisar.Enabled = false;
                txtPesquisar.Enabled = false;
                btnGravar.Enabled = true;
                btnCancelar.Enabled = true;
            
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Excluir(Convert.ToInt32(Convert.ToInt32(TabelaData.SelectedRows[0].Cells[0].Value)));
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {

            if (TabelaData.SelectedRows[0].Index > 0)
            {
                TabelaData.Rows[TabelaData.SelectedRows[0].Index - 1].Selected = true;
                btnEditar_Click(sender, e);
            }

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (State == Estado.Adicionar)
                Adicionar();
            else
                Atualizar(Convert.ToInt32(Convert.ToInt32(TabelaData.SelectedRows[0].Cells[0].Value)));
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (TabelaData.Rows.Count - 1 > TabelaData.SelectedRows[0].Index)
            {
                TabelaData.Rows[TabelaData.SelectedRows[0].Index + 1].Selected = true;
                btnEditar_Click(sender, e);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            State = Estado.Closed;
            ClearFields();
            Paginas.SelectTab(0);
        }

        private void TabelaData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar_Click(sender, e);
        }

        private void txtPesquisar_Click(object sender, EventArgs e)
        {
            
        }
        
    }
}
