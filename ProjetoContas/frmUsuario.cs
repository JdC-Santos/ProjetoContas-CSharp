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
        private void Habilita()
        {
            //txtbox
            cd_administradorTextBox.Enabled = false;
            nm_administradorTextBox.Enabled = true;
            sg_nivelTextBox.Enabled = true;
            nm_loginTextBox.Enabled = true;
            cd_senhaTextBox.Enabled = true;

            btnAnterior.Enabled = false;
            btnProximo.Enabled = false;
            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;

            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;

            btnPesquisar.Enabled = false;
            btnImprimir.Enabled = false;
            btnSair.Enabled = false;

        }

        private void Desabilita()
        {
            //txtbox
            cd_administradorTextBox.Enabled = false;
            nm_administradorTextBox.Enabled = false;
            sg_nivelTextBox.Enabled = false;
            nm_loginTextBox.Enabled = false;
            cd_senhaTextBox.Enabled = false;

            btnAnterior.Enabled = true;
            btnProximo.Enabled = true;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;

            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;

            btnPesquisar.Enabled = true;
            btnImprimir.Enabled = true;
            btnSair.Enabled = true;

        }

        public frmUsuario()
        {
            InitializeComponent();
            Desabilita();
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet.tb_administrador'. Você pode movê-la ou removê-la conforme necessário.
            //this.tb_administradorTableAdapter.Fill(this.contasDataSet.tb_administrador);

        }

        private void btnCancelarCadastro_Click(object sender, EventArgs e)
        {
            Close();
            Desabilita();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tb_administradorBindingSource.AddNew();
            Habilita();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Validate();
            tb_administradorBindingSource.EndEdit();
            tb_administradorTableAdapter.Update(contasDataSet.tb_administrador);
            Desabilita();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tb_administradorBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tb_administradorBindingSource.MoveNext();
        }

        private void tb_administradorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_administradorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contasDataSet);

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Habilita();
        }
    }
}
