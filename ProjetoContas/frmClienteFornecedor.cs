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
        ClassValidacao validar = new ClassValidacao();

        public frmClienteFornecedor(string tp)
        {
            this.tipo = tp;
            InitializeComponent();
            Desabilita();
        }

        public bool ValidarForm()
        {
            bool validado = true;
            string msg = "", tp = "cliente";

            if (tipo == "f")
            {
                tp = "fornecedor";
            }

            if (nm_usuarioTextBox.TextLength == 0)
            {
                msg += "Digite o nome do " + tp + "\n";
                validado = false;
            }

            if (ds_usuarioTextBox.TextLength == 0)
            {
                msg += "Digite o tipo do " + tp + "\n";
                validado = false;
            }

            if (ds_enderecoTextBox.TextLength == 0)
            {
                msg += "Digite o endereço do " + tp + "\n";
                validado = false;
            }

            if (nm_cidadeTextBox.TextLength == 0)
            {
                msg += "Digite a cidade do " + tp + "\n";
                validado = false;
            }

            if (nm_bairroTextBox.TextLength == 0)
            {
                msg += "Digite o bairro do " + tp + "\n";
                validado = false;
            }

            if (sg_estadoTextBox.TextLength == 0)
            {
                msg += "Digite o estado do " + tp + "\n";
                validado = false;
            }

            if (cd_cepTextBox.TextLength == 0)
            {
                msg += "Digite o cep do " + tp + "\n";
                validado = false;
            }

            if (ds_telefoneTextBox.TextLength == 0)
            {
                msg += "Digite o telefone do " + tp + "\n";
                validado = false;
            }

            if (ds_emailTextBox.TextLength == 0)
            {
                msg += "Digite o email do " + tp + "\n";
                validado = false;
            }

            if (cd_cpfTextBox.TextLength == 0)
            {
                msg += "Digite o CPF ou CNPJ do " + tp + "\n";
                validado = false;
            }
            else
            {
                if( !validar.validarCPF(cd_cpfTextBox.Text))
                {
                    msg += "CPF inválido \n";
                    validado = false;
                }
            }

            if (cd_rgTextBox.TextLength == 0)
            {
                msg += "Digite o RG do " + tp + "\n";
                validado = false;
            }

            if (ds_emailTextBox.TextLength == 0)
            {
                msg += "Digite a IE do " + tp +"\n";
                validado = false;
            }

            if (!validado)
            {
                MessageBox.Show(msg);
            }

            return validado;
        }

        public void Habilita()
        {
            cd_usuarioTextBox.Enabled = false;
            nm_usuarioTextBox.Enabled = true;
            ds_usuarioTextBox.Enabled = true;
            ds_enderecoTextBox.Enabled = true;
            nm_cidadeTextBox.Enabled = true;
            nm_bairroTextBox.Enabled = true;
            sg_estadoTextBox.Enabled = true;
            cd_cepTextBox.Enabled = true;
            ds_telefoneTextBox.Enabled = true;
            ds_emailTextBox.Enabled = true;
            sg_tipoTextBox.Enabled = false;
            cd_cpfTextBox.Enabled = false;
            cd_cnpjTextBox.Enabled = false;
            cd_rgTextBox.Enabled = false;
            cd_ieTextBox.Enabled = false;

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

        public void Desabilita()
        {
            cd_usuarioTextBox.Enabled = false;
            nm_usuarioTextBox.Enabled = false;
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
            this.tb_usuarioBindingSource.Filter = "sg_tipo = '"+this.tipo+"'";

            if (this.tipo == "f")
            {
                this.Text = "Fornecedores";
            }
            else
            {
                this.Text = "Clientes";
                labelTitle.Text = "Clientes";
            }
        }

        private void tb_usuarioBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            sg_tipoTextBox.Text = tipo;
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
                sg_tipoTextBox.Text = "f";
            }
            else
            {
                sg_tipoTextBox.Text = "c";
            }

            nm_usuarioTextBox.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarForm())
            {
                Validate();
                tb_usuarioBindingSource.EndEdit();
                tb_usuarioTableAdapter.Update(contasDataSet.tb_usuario);
                Desabilita();
            }
            
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
            if (!((e.KeyChar == 'f' || e.KeyChar == 'j') || validar.TclPadrao(e.KeyChar) ))
            {
                e.KeyChar = (char)0;
            }
            else
            {
                cd_cpfTextBox.Enabled = false;
                cd_rgTextBox.Enabled = false;
                cd_cnpjTextBox.Enabled = false;
                cd_ieTextBox.Enabled = false;

                if (e.KeyChar == 'f')
                {
                    cd_cpfTextBox.Enabled = true;
                    cd_rgTextBox.Enabled = true;
                }
                else if(e.KeyChar == 'j')
                {
                    cd_cnpjTextBox.Enabled = true;
                    cd_ieTextBox.Enabled = true;
                }
            }
        }

        private void validaEndereco(object sender, KeyPressEventArgs e)
        {
            if (!(validar.TclLetra(e.KeyChar) || validar.TclPadrao(e.KeyChar) ||
                validar.TclNumero(e.KeyChar) || e.KeyChar == ',' ))
            {
                e.KeyChar = (char)0;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisaClienteFornecedor fpcf = new frmPesquisaClienteFornecedor(this.tipo);
            fpcf.Show();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string str = "", ds_usu,tipoU;
            Graphics objImpressao = e.Graphics;

            if (ds_usuarioTextBox.Text == "f")
            {
                ds_usu = "Fisico";
            } else {
                ds_usu = "Juridico";
            }

            if (this.tipo == "c")
            {
                tipoU = "CLIENTE";
            }
            else
            {
                tipoU = "FORNECEDOR";
            }

            str += "FICHA DE "+tipoU+"\n\n";
            str += "Código: " + cd_usuarioTextBox.Text + "\n";
            str += "Nome: " + nm_usuarioTextBox.Text + "\n";
            str += "Tipo: "+ ds_usu +"\n";
            str += "Endereço: "+ ds_enderecoTextBox.Text +"\n";
            str += "Bairro: " + nm_bairroTextBox.Text + "\n";
            str += "Cidade: " + nm_cidadeTextBox.Text +"\n";
            str += "Estado: "+ sg_estadoTextBox.Text +"\n";
            str += "CEP: " + cd_cepTextBox.Text + "\n";
            str += "Telefone: " + ds_telefoneTextBox.Text + "\n";
            str += "E-mail: "+ ds_emailTextBox.Text + "\n";
            str += "CPF: " + cd_cpfTextBox.Text + "\n";
            str += "CNPJ: " + cd_cnpjTextBox.Text + "\n";
            str += "RG: "+ cd_rgTextBox.Text +"\n";
            str += "IE: " + cd_ieTextBox.Text + "\n";

            Font fonte = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
            objImpressao.DrawString(str, fonte , Brushes.Black,50,50);
        }

        private void validaNome(object sender, KeyPressEventArgs e)
        {
            if (!(validar.TclPadrao(e.KeyChar) || validar.TclLetra(e.KeyChar) ))
            {
                e.KeyChar = (char)0;
            }
        }

        private void validaCidade(object sender, KeyPressEventArgs e)
        {
            if (!(validar.TclPadrao(e.KeyChar) || validar.TclLetra(e.KeyChar)))
            {
                e.KeyChar = (char)0;
            }
        }

        private void ApenasNumeros(object sender, KeyPressEventArgs e)
        {
            if (!(validar.TclPadrao(e.KeyChar) || validar.TclNumero(e.KeyChar)))
            {
                e.KeyChar = (char)0;
            }
        }

        private void validaEmail(object sender, KeyPressEventArgs e)
        {
            if (!(validar.TclPadrao(e.KeyChar) || validar.TclLetra(e.KeyChar) || validar.TclNumero(e.KeyChar) || 
                e.KeyChar == 64 || e.KeyChar == 95 || e.KeyChar == 46) )
            {
                e.KeyChar = (char)0;
            }
        }
    }
}
