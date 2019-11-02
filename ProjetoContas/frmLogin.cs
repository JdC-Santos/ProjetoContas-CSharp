﻿using System;
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
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }
        
        public bool validaCampos()
        {
            bool camposValidados = true;

            string msg = "";
            if (txtLogin.Text.Count() == 0)
            {
                msg += "Digite o LOGIN\n";
                camposValidados = false;
            }

            if (txtPw.Text.Count() == 0)
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
            if (validaCampos())
            {
                if (txtLogin.Text == "adm" && txtPw.Text == "123")
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

        }
    }
}
