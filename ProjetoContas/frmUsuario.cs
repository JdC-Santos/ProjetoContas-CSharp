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
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet.tb_administrador'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_administradorTableAdapter.Fill(this.contasDataSet.tb_administrador);
            Desabilita();
        }

        private void btnCancelarCadastro_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmPrincipal fp = new frmPrincipal();
            fp.Show();
            Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tb_administradorBindingSource.AddNew();
            Habilita();
            nm_administradorTextBox.Focus();
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
            this.tb_administradorTableAdapter.Update(this.contasDataSet.tb_administrador);

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (tb_administradorBindingSource.Count > 0)
            {
                Habilita();
            }
            else
            {
                MessageBox.Show("Não há registros para alterar!");
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tb_administradorBindingSource.CancelEdit();
            Desabilita();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tb_administradorBindingSource.Count > 0)
            {
                tb_administradorBindingSource.RemoveCurrent();
                tb_administradorTableAdapter.Update(contasDataSet.tb_administrador);
                MessageBox.Show("Registro excluido com sucesso!");
            }
            else
            {
                MessageBox.Show("Não há registros para excluir!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisaUsuario fpu = new frmPesquisaUsuario();
            fpu.Show();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string str = "";
            Graphics objImpressao = e.Graphics;

            str += "FICHA DE ADMINISTRADOR\n\n";
            str += "Código: "+ cd_administradorTextBox.Text+"\n";
            str += "Nome: "+ nm_administradorTextBox.Text +"\n";
            str += "Nível: " + sg_nivelTextBox.Text + "\n";
            str += "Login: "+ nm_loginTextBox.Text+"\n";

            Font fonte = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
            objImpressao.DrawString(str, fonte, Brushes.Black, 50, 50);
        }
    }
}
