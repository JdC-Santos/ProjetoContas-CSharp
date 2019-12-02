using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjetoContas
{
    public partial class frmRetorno : Form
    {
        public frmRetorno()
        {
            InitializeComponent();
        }

        private void tb_contaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_contaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contasDataSet);

        }

        private void frmRetorno_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet.tb_conta'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_contaTableAdapter.Fill(this.contasDataSet.tb_conta);

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            StreamReader arq = new StreamReader(txtArquivo.Text);

            string linha;

            while (!arq.EndOfStream)
            {
                linha = arq.ReadLine();
                if (linha.Substring(0,1) == "1" && linha.Substring(108,2) == "06")
                {
                    string dtPag = linha.Substring(110,2) + "/"+ linha.Substring(112,2)+"/"+ linha.Substring(114,2);
                    decimal vlPag = decimal.Parse(linha.Substring(253,13)) / 100;
                    int cdDoc = int.Parse(linha.Substring(116,10));

                    tb_contaTableAdapter.BaixaPagamento(dtPag, vlPag, cdDoc);
                }
            }

            arq.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
