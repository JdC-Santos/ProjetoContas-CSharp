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
    public partial class frmPesquisaClienteFornecedor : Form
    {
        static public string tipo = "";
        public frmPesquisaClienteFornecedor(string tp)
        {
            InitializeComponent();
            tipo = tp;
        }

        private void tb_usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contasDataSet);

        }

        private void frmPesquisaClienteFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet.tb_usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_usuarioTableAdapter.Fill(this.contasDataSet.tb_usuario);
            this.tb_usuarioBindingSource.Filter = "sg_tipo = '" + tipo + "'";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                string nome = "%%";
                tb_usuarioTableAdapter.FillByNome(contasDataSet.tb_usuario, nome, tipo);
            }
            else
            {
                string nome = "%" + txtNome.Text + "%";
                tb_usuarioTableAdapter.FillByNome(contasDataSet.tb_usuario, nome, tipo);
            }
        }
    }
}
