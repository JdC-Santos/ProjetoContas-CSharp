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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string str,ds_conta;

            Graphics objImpressao = e.Graphics;

            if (ds_tipoTextBox.Text == "pagar")
            {
                ds_conta = "PAGAR";
            }
            else
            {
                ds_conta = "RECEBER";
            }

            str = "FICHA DE CONTA A "+ds_conta+"\n\n";

            str += "CÓDIGO DA CONTA: " + cd_contaTextBox.Text + "\n";
            str += "DATA DE EMISSÃO: " + dt_emissaoDateTimePicker.Text + "\n";
            str += "DATA DE VENCIMENTO: " + dt_vencimentoDateTimePicker.Text + "\n";
            str += "VALOR DA COMPRA: " + vl_compraTextBox.Text + "\n";
            str += "VALOR PAGO: " + vl_pagoTextBox.Text + "\n";
            str += "OBS.: " + ds_obsTextBox.Text + "\n";
            str += "USUÁRIO: " + id_usuarioTextBox.Text + "\n";

            Font fonte = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
            objImpressao.DrawString(str, fonte, Brushes.Black, 50, 50);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisaConta fpc = new frmPesquisaConta(tipoConta);
            fpc.Show();
        }
    }
}
