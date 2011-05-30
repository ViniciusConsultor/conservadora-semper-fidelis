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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            TemporizadorHoras.Start();
        }

        private void TemporizadorHoras_Tick(object sender, EventArgs e)
        {
            lblHoras.Text = Convert.ToString(DateTime.Now);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void btnCondominio_Click(object sender, EventArgs e)
        {
            FormCadCondominio cad = new FormCadCondominio();
            cad.ShowDialog();
        }

        private void btnMoradores_Click(object sender, EventArgs e)
        {
            FormCadMoradores cad = new FormCadMoradores();
            cad.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormCadBoletos cad = new FormCadBoletos();
            cad.ShowDialog();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.btnCondominio_Click(sender, null);
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.btnMoradores_Click(sender, null);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormCadRecados cad = new FormCadRecados();
            cad.ShowDialog();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormCadBalancetes cad = new FormCadBalancetes();
            cad.ShowDialog();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormCadBoletos cad = new FormCadBoletos();
            cad.ShowDialog();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormCadAtas cad = new FormCadAtas();
            cad.ShowDialog();
        }
    }
}
