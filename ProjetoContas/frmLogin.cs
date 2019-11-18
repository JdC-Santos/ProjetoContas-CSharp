using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ProjetoContas
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
            FormSplshScreen fss = new FormSplshScreen();
            fss.Show();
            Thread.Sleep(3000);
            fss.Close();
        }
        
        public bool validaCampos()
        {
            bool camposValidados = true;
            //MessageBox.Show(nm_loginTextBox.Text);

            string msg = "";
            if (txtLogin.TextLength == 0)
            {
                msg += "Digite o LOGIN\n";
                camposValidados = false;
            }

            if (txtPw.TextLength == 0)
            {
                msg += "Digite a SENHA";
                camposValidados = false;
            }

            if (!camposValidados)
            {
                MessageBox.Show(msg);
            }

            return camposValidados;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string query = "nm_login = '"+txtLogin.Text+"' AND cd_senha ='"+txtPw.Text+"' ";
            tb_administradorBindingSource.Filter = query;
            tb_administradorTableAdapter.Fill(contasDataSet.tb_administrador);

            int nrLinhas = tb_administradorBindingSource.Count;

            if (validaCampos())
            {
                if (txtLogin.Text == "adm" && txtPw.Text == "123" || nrLinhas > 0)
                {
                    frmPrincipal fp = new frmPrincipal();
                    fp.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Login ou senha incorretos");
                }
            }   
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void formLogin_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet.tb_administrador'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_administradorTableAdapter.Fill(this.contasDataSet.tb_administrador);
        }

        private void tb_administradorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_administradorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contasDataSet);

        }

        private void nm_administradorTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_administradorBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_administradorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contasDataSet);

        }
    }
}
