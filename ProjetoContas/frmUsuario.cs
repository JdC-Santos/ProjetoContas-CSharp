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
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet1.tb_administrador'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_administradorTableAdapter.Fill(this.contasDataSet1.tb_administrador);
        }

        private void btnCancelarCadastro_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            bindingSource1.AddNew();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Validate();
            bindingSource1.EndEdit();
            tb_administradorTableAdapter.Update(this.contasDataSet1.tb_administrador);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            bindingSource1.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveNext();
        }
    }
}
