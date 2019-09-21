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
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelarCadastro_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrarAdmin_Click(object sender, EventArgs e)
        {
            string nome  = txtNome.Text;
            string nivel = txtNivel.Text;
            string login = txtCadLogin.Text;
            string senha = txtSenha.Text;

            if (nome != "" && senha != "" && nivel != "" && login != "")
            {
                MessageBox.Show("usuário cadastrado com suceso!");
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            
        }
    }
}
