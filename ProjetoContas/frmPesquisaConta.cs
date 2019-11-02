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
    public partial class frmPesquisaConta : Form
    {
        static public string tipo;
        public frmPesquisaConta(string tp)
        {
            InitializeComponent();
            tipo = tp;

        }

        private void tb_contaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_contaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contasDataSet);

        }

        private void frmPesquisaConta_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet.tb_conta'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_contaTableAdapter.Fill(this.contasDataSet.tb_conta);
            this.tb_contaBindingSource.Filter = "ds_tipo = '" + tipo + "'";

            if (tipo == "receber")
            {
                this.Text = "Lista de contas a receber";
            }
            else
            {
                this.Text = "Lista de contas a pagar";
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (dtEmissao.Text == "")
            {
                tb_contaTableAdapter.Fill(contasDataSet.tb_conta);
            }
            else
            {
                string dt = dtEmissao.Text;
                tb_contaTableAdapter.FillByDtEmissao(contasDataSet.tb_conta, dt, tipo);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
