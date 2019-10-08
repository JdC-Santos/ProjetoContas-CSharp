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
    public partial class frmClienteFornecedor : Form
    {
        private string tipo;
        public frmClienteFornecedor(string tipo)
        {
            this.tipo = tipo;
            InitializeComponent();
            Desabilita();
        }

        public void Habilita()
        {
            cd_usuarioTextBox.Enabled = false;
            ds_usuarioTextBox.Enabled = true;
            ds_enderecoTextBox.Enabled = true;
            nm_cidadeTextBox.Enabled = true;
            nm_bairroTextBox.Enabled = true;
            sg_estadoTextBox.Enabled = true;
            cd_cepTextBox.Enabled = true;
            ds_telefoneTextBox.Enabled = true;
            ds_emailTextBox.Enabled = true;
            sg_tipoTextBox.Enabled = false;
            cd_cpfTextBox.Enabled = true;
            cd_cnpjTextBox.Enabled = true;
            cd_rgTextBox.Enabled = true;
            cd_ieTextBox.Enabled = true;

        }

        public void Desabilita()
        {
            cd_usuarioTextBox.Enabled = false;
            ds_usuarioTextBox.Enabled = false;
            ds_enderecoTextBox.Enabled = false;
            nm_cidadeTextBox.Enabled = false;
            nm_bairroTextBox.Enabled = false;
            sg_estadoTextBox.Enabled = false;
            cd_cepTextBox.Enabled = false;
            ds_telefoneTextBox.Enabled = false;
            ds_emailTextBox.Enabled = false;
            sg_tipoTextBox.Enabled = false;
            cd_cpfTextBox.Enabled = false;
            cd_cnpjTextBox.Enabled = false;
            cd_rgTextBox.Enabled = false;
            cd_ieTextBox.Enabled = false;
        }

        private void tb_usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contasDataSet);

        }

        private void frmClienteFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet.tb_usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_usuarioTableAdapter.Fill(this.contasDataSet.tb_usuario);
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet.tb_usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_usuarioTableAdapter.Fill(this.contasDataSet.tb_usuario);

            if (this.tipo == "f")
            {
                sg_tipoTextBox.Text = "Fornecedor";
                this.Text = "Fornecedores";
            }
            else
            {
                this.Text = "Clientes";
                sg_tipoTextBox.Text = "Cliente";
                labelTitle.Text = "Clientes";
            }

        }

        private void tb_usuarioBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contasDataSet);
            Desabilita();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tb_usuarioBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tb_usuarioBindingSource.MoveNext();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tb_usuarioBindingSource.AddNew();
            Habilita();

            if (this.tipo == "f")
            {
                sg_tipoTextBox.Text = "Fornecedor";
            }
            else
            {
                sg_tipoTextBox.Text = "Cliente";
            }

            ds_usuarioTextBox.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Validate();
            tb_usuarioBindingSource.EndEdit();
            tb_usuarioTableAdapter.Update(contasDataSet.tb_usuario);
            Desabilita();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (tb_usuarioBindingSource.Count > 0)
            {
                Habilita();
            }
            else
            {
                MessageBox.Show("Não há registros para alterar!");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tb_usuarioBindingSource.Count > 0)
            {
                tb_usuarioBindingSource.RemoveCurrent();
                tb_usuarioTableAdapter.Update(contasDataSet.tb_usuario);
                MessageBox.Show("Registro excluido com sucesso!");
            }
            else
            {
                MessageBox.Show("Não há registros para excluir!");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tb_usuarioBindingSource.CancelEdit();
            Desabilita();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmPrincipal fp = new frmPrincipal();
            fp.Show();
            Close();
        }

        private void validaFisicoJuridico(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 'f' && e.KeyChar != 'j')
            {
                e.KeyChar = (char)0;
            }
        }

        private void validaEndereco(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9') && !(e.KeyChar >= 'a' && e.KeyChar <= 'z') && 
                e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)32)
            {
                e.KeyChar = (char)0;
            }
        }
    }
}
