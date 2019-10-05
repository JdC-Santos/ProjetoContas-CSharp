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
    public partial class frmContasPagar : Form
    {
        static public string tipoConta = "";
        public void Habilita()
        {
            cd_contaTextBox.Enabled = false;
            dt_emissaoDateTimePicker.Enabled = true;
            dt_vencimentoDateTimePicker.Enabled = true;
            vl_compraTextBox.Enabled = true;
            id_usuarioTextBox.Enabled = true;
            dt_pagamentoDateTimePicker.Enabled = true;
            vl_pagoTextBox.Enabled = true;
            ds_obsTextBox.Enabled = true;
            ds_tipoTextBox.Text = tipoConta;
            ds_tipoTextBox.Visible = false;


        }

        public void Desabilita()
        {
            cd_contaTextBox.Enabled = false;
            dt_emissaoDateTimePicker.Enabled = false;
            dt_vencimentoDateTimePicker.Enabled = false;
            vl_compraTextBox.Enabled = false;
            id_usuarioTextBox.Enabled = false;
            dt_pagamentoDateTimePicker.Enabled = false;
            vl_pagoTextBox.Enabled = false;
            ds_obsTextBox.Enabled = false;

            ds_tipoTextBox.Text = tipoConta;
            ds_tipoTextBox.Visible = false;
        }

        public frmContasPagar(string tipo)
        {
            InitializeComponent();
            tipoConta = tipo;

            if (tipo  == "pagar")
            {
                this.Text = "Contas a pagar";
            }
            else
            {
                this.Text = "Contas a receber";
            }
        }

        private void tb_contaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_contaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contasDataSet);

        }

        private void frmContasPagar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet.tb_conta'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_contaTableAdapter.Fill(this.contasDataSet.tb_conta);
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet.tb_conta'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_contaTableAdapter.Fill(this.contasDataSet.tb_conta);
            Desabilita();
           
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmPrincipal fp = new frmPrincipal();
            fp.Show();
            Close();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tb_contaBindingSource.MovePrevious();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tb_contaBindingSource.CancelEdit();
            Desabilita();

        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tb_contaBindingSource.MoveNext();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tb_contaBindingSource.AddNew();
            Habilita();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tb_contaBindingSource.Count > 0)
            {
                tb_contaBindingSource.RemoveCurrent();
               tb_contaTableAdapter.Update(contasDataSet.tb_conta);
                MessageBox.Show("Registro excluido com sucesso!");
            }
            else
            {
                MessageBox.Show("Não há registros para excluir!");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (tb_contaBindingSource.Count > 0)
            {
                Habilita();
            }
            else
            {
                MessageBox.Show("Não há registros para alterar!");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_contaBindingSource.EndEdit();
            this.tb_contaTableAdapter.Update(this.contasDataSet.tb_conta);
            Desabilita();
        }

        private void tb_contaBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_contaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contasDataSet);

        }
    }
}
