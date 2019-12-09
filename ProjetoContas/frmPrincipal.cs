using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoContas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void contasAReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContasPagar cp = new frmContasPagar("receber");
            cp.Show();
            Hide();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario fu = new frmUsuario();
            fu.Show();
            Hide();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClienteFornecedor fcf = new frmClienteFornecedor("f");
            fcf.Show();
            Hide();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClienteFornecedor fcf = new frmClienteFornecedor("c");
            fcf.Show();
            Hide();
        }

        private void contasAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContasPagar cp = new frmContasPagar("pagar");
            cp.Show();
            Hide();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void RemessasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRemessa frmRem = new frmRemessa();
            frmRem.Show();
        }

        private void retornoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRetorno fr = new frmRetorno();
            fr.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRelatorioCliente frc = new frmRelatorioCliente();
            frc.Show();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorioAdmin fra = new frmRelatorioAdmin();
            fra.Show();
        }

        private void fornecedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRelatorioFornecedor frf = new frmRelatorioFornecedor();
            frf.Show();
        }

        private void contasAReceberToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRelatorioContasPagar frcp = new frmRelatorioContasPagar();
            frcp.Show();
        }

        private void contasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorioContasReceber frcr = new frmRelatorioContasReceber();
            frcr.Show();
        }
    }
}
