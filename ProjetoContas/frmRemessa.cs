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
    public partial class frmRemessa : Form
    {
        public frmRemessa()
        {
            InitializeComponent();
        }

        private void tb_contaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_contaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contasDataSet);

        }

        private void frmRemessa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet.tb_usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_usuarioTableAdapter.Fill(this.contasDataSet.tb_usuario);
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet.tb_conta'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_contaTableAdapter.Fill(this.contasDataSet.tb_conta);

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Remessa Objremessa = new Remessa();

            string nossoNumero;
            int remessa = 1, linha = 1;
            string dtInicial, dtHoje;
            dtInicial = dtpInicial.Text;
            dtHoje = DateTime.Now.ToShortDateString();
            dtHoje = dtHoje.Substring(0, 2) + dtHoje.Substring(3, 2) + dtHoje.Substring(8, 2);

            tb_contaBindingSource.Filter = "dt_emissao >= '" + dtInicial + "'";
            tb_contaTableAdapter.Fill(contasDataSet.tb_conta);

            StreamWriter arq = new StreamWriter(@"C:\bradesco\cb"+dtHoje.PadLeft(4) + "01.rem");

            Objremessa.setCodEmpresa("123456");
            Objremessa.setNmEmpresa("ETEC ITANHAEM");
            Objremessa.setNrRemessa(remessa);
            Objremessa.setLinha(linha);

            string cabecalho = Objremessa.getCabecalho();

            arq.WriteLine(cabecalho);

            while (tb_contaBindingSource.Position < tb_contaBindingSource.Count)
            {
                linha++;
                
                nossoNumero = contasDataSet.tb_conta.Rows[tb_contaBindingSource.Position][contasDataSet.tb_conta.cd_contaColumn].ToString().PadLeft(11,'0');
                //criar classe para validacoes
                string DV = "0";
                //agencia de debito
                //
                string item = "1";
                string cd_conta = contasDataSet.tb_conta.Rows[tb_contaBindingSource.Position][contasDataSet.tb_conta.cd_contaColumn].ToString();
                item += "00000 000000000000 00190161000012345" + cd_conta.PadRight(25);
                item += "23720200"+nossoNumero+DV;

                arq.WriteLine(item);
            }            
        }
    }
}
