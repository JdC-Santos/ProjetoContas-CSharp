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
    }
}
