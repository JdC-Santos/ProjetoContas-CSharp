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
        private ClassValidacao valida = new ClassValidacao();
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

            int remessa = 1, linha = 1;
            string dtInicial, dtHoje;
            DateTime time = DateTime.Now;

            dtInicial = dtpInicial.Text;
            dtHoje = time.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);           
            
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

            DataRowView drc, drcr;
            if (tb_contaBindingSource.Count > 0)
            {
                while (linha <= tb_contaBindingSource.Count)
                {
                    linha++;
                    tb_contaBindingSource.Position = ( linha -1 );

                    drcr = (DataRowView)tb_contaBindingSource.Current;
                    string cd_conta = drcr["cd_conta"].ToString().PadRight(25);

                    drc = (DataRowView)tb_usuarioBindingSource.Current;
                    int cd_usuario = int.Parse(drcr["id_usuario"].ToString());

                    int reg = tb_usuarioBindingSource.Find("cd_usuario", cd_usuario);
                    tb_usuarioBindingSource.Position = reg;

                    Objremessa.Reg_id = "1";
                    Objremessa.Reg_agencia_debito = "00000";
                    Objremessa.Reg_digito_agencia_debito = " ";
                    Objremessa.Reg_razao_cc = "00000";
                    Objremessa.Reg_cc = "".PadLeft(7,'0');
                    Objremessa.Reg_dgt_cc = " ";
                    Objremessa.Reg_id_emp_benef_bnc = "00190161000012345";
                    Objremessa.Reg_nr_ctrl_participante = "".PadLeft(25);
                    Objremessa.Reg_cd_bnc_debitado_cmr_compensacao = "237";
                    Objremessa.Reg_multa = "2";
                    Objremessa.Reg_percent_multa = "0200";
                    Objremessa.Reg_id_titulo_banco = "".PadLeft(11, '0');
                    Objremessa.Reg_dgt_auto_conf_nr_banc = Objremessa.Reg_id_titulo_banco;
                    Objremessa.Reg_desc_bonif_dia = "".PadLeft(10, '0');
                    Objremessa.Reg_cond_emissao_pap_cobranca = "2"; // fixo
                    Objremessa.Reg_id_deb_automatico = "N"; // fixo?
                    Objremessa.Reg_ic_rateio_credito = " ";
                    Objremessa.Reg_end_avs_deb_automatico = "0";
                    Objremessa.Reg_qtd_pag = "  ";
                    Objremessa.Reg_id_ocorrencia = "01";
                    Objremessa.Reg_nr_doc = "".PadRight(10);
                    Objremessa.Reg_dt_venc_titulo = drcr["dt_vencimento"].ToString();
                    Objremessa.Reg_vl_titulo = drcr["vl_compra"].ToString();
                    Objremessa.Reg_bnc_encarr_cobr = "".PadRight(3);
                    Objremessa.Reg_agnc_depos = "".PadRight(5);
                    Objremessa.Reg_espec_ttl = "99";
                    Objremessa.Reg_identificacao = "N";
                    Objremessa.Reg_dt_emi_ttl = drcr["dt_emissao"].ToString();
                    Objremessa.Reg_1_instr = "00";
                    Objremessa.Reg_2_instr = "00";
                    Objremessa.Reg_vl_cobr_dia_atraso = "".PadLeft(13, '0');
                    Objremessa.Reg_dt_lmt_conces_desc = drcr["dt_vencimento"].ToString();
                    Objremessa.Reg_vl_desc = "".PadLeft(13, '0');
                    Objremessa.Reg_vl_IOF = "".PadLeft(13, '0');
                    Objremessa.Reg_vl_abat_conc_canc = "".PadLeft(13, '0');

                    if (drc["ds_usuario"].ToString() == "f")
                    {
                        Objremessa.Reg_id_tp_inscr_pag = "1";
                        Objremessa.Reg_inscr_pag = drc["cd_cpf"].ToString().PadLeft(14, '0');
                    }
                    else
                    {
                        Objremessa.Reg_id_tp_inscr_pag = "2";
                        Objremessa.Reg_inscr_pag = drc["cd_cnpj"].ToString().PadLeft(14, '0');
                    }

                    Objremessa.Reg_nm_pagador = drc["nm_usuario"].ToString().PadRight(40);
                    Objremessa.Reg_endereco_compl = drc["ds_endereco"].ToString().PadRight(40);
                    Objremessa.Reg_1_msg = "".PadRight(12);
                    Objremessa.Reg_CEP = drc["cd_cep"].ToString().Substring(0, 5);
                    Objremessa.Reg_sufixo_CEP = drc["cd_cep"].ToString().Substring(5, 3);
                    Objremessa.Reg_sac_avalista = "".PadRight(60);
                    Objremessa.Reg_nr_sequ_reg = linha.ToString();

                    string registro = Objremessa.getRegistro();
                    arq.WriteLine(registro);
                   
                }
            }

            linha++;

            string rodape;
            rodape = "9";
            rodape += "".PadRight(393);
            rodape += linha.ToString().PadLeft(6,'0');
            arq.WriteLine(rodape);
            arq.Close();

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
