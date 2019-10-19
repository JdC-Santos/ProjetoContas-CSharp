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
    public partial class frmPesquisaUsuario : Form
    {
        public frmPesquisaUsuario()
        {
            InitializeComponent();
        }

        private void tb_administradorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_administradorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contasDataSet);

        }

        private void frmPesquisaUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet.tb_administrador'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_administradorTableAdapter.Fill(this.contasDataSet.tb_administrador);

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if(txtNome.Text == "")
            {
                tb_administradorTableAdapter.Fill(contasDataSet.tb_administrador);
            }
            else
            {
                string nome = "%" + txtNome.Text + "%";
                tb_administradorTableAdapter.FillByNome(contasDataSet.tb_administrador, nome);
            }
        }
    }
}
