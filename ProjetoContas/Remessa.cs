using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProjetoContas
{
    class Remessa
    {
        //cabecalho
        private string cabecalho;
        private string cbc_id_registro = "0";
        private string cbc_arq_remessa = "1";
        private string cbc_lit_remessa = "REMESSA";
        private string cbc_cod_servico = "01";
        private string cbc_cod_empresa;
        private string cbc_nm_empresa;
        private string cbc_nr_bradesco = "237";
        private string cbc_nm_bradesco = "BRADESCO";
        private string cbc_dt_gravacao = "DDMMAA";
        private string cbc_branco8; //8 espaços em branco
        private string cbc_id_sistema = "MX";
        private string cbc_nr_seq_remessa = "0000000";
        private string cbc_branco277;
        private string linha = "000000";

        //registro de transação - tipo 1
        private string reg = "";
        private string reg_id = "1";
        private string reg_agencia_debito = "00000";
        private string reg_digito_agencia_debito = " ";
        private string reg_razao_cc = "00000";
        private string reg_cc = "0000000";
        private string reg_dgt_cc = " ";
        private string reg_id_emp_benef_bnc = "00190161000012345";
        private string reg_nr_ctrl_participante = "";
        private string reg_cd_bnc_debitado_cmr_compensacao = "237";
        private string reg_multa = "2";
        private string reg_percent_multa = "0200";
        private string reg_id_titulo_banco;
        private string reg_dgt_auto_conf_nr_banc;
        private string reg_desc_bonif_dia;
        private string reg_cond_emissao_pap_cobranca;
        private string reg_id_deb_automatico;
        private string reg_id_operacao_bnc;
        private string reg_ic_rateio_credito;
        private string reg_end_avs_deb_automatico;
        private string reg_qtd_pag;
        private string reg_id_ocorrencia;
        private string reg_nr_doc;
        private string reg_dt_venc_titulo;
        private string reg_vl_titulo;
        private string reg_bnc_encarr_cobr;
        private string reg_agnc_depos;
        private string reg_espec_ttl;
        private string reg_identificacao;
        private string reg_dt_emi_ttl;
        private string reg_1_instr;
        private string reg_2_instr;
        private string reg_vl_cobr_dia_atraso;
        private string reg_dt_lmt_conces_desc;
        private string reg_vl_desc;
        private string reg_vl_IOF;
        private string reg_vl_abat_conc_canc;
        private string reg_id_tp_inscr_pag;
        private string reg_nm_pagador;
        private string reg_endereco_compl;
        private string reg_1_msg;
        private string reg_CEP;
        private string reg_sufixo_CEP;
        private string reg_sac_avalista;
        private string reg_nr_sequ_reg;


        public string getRegistro()
        {
            reg += Reg_id + Reg_agencia_debito + Reg_razao_cc + Reg_cc + Reg_dgt_cc + Reg_id_emp_benef_bnc;
            reg += Reg_nr_ctrl_participante + Reg_cd_bnc_debitado_cmr_compensacao + Reg_cd_bnc_debitado_cmr_compensacao;
            reg += Reg_multa + Reg_percent_multa + Reg_id_titulo_banco + Reg_dgt_auto_conf_nr_banc + Reg_desc_bonif_dia;
            reg += Reg_cond_emissao_pap_cobranca + Reg_id_deb_automatico + Reg_id_operacao_bnc + Reg_ic_rateio_credito;
            reg += Reg_end_avs_deb_automatico + Reg_qtd_pag + Reg_id_ocorrencia + Reg_nr_doc + Reg_dt_venc_titulo;
            reg += Reg_vl_titulo + Reg_bnc_encarr_cobr + Reg_agnc_depos + Reg_espec_ttl + Reg_identificacao + Reg_dt_emi_ttl;
            reg += Reg_1_instr + Reg_2_instr + Reg_vl_cobr_dia_atraso + Reg_dt_lmt_conces_desc + Reg_vl_desc + Reg_vl_IOF;
            reg += Reg_vl_abat_conc_canc + Reg_id_tp_inscr_pag + Reg_nm_pagador + Reg_endereco_compl + Reg_1_msg;
            reg += Reg_CEP + Reg_sufixo_CEP + Reg_sac_avalista + Reg_nr_sequ_reg;
            return reg;
        }

        public string Reg_id { get => reg_id; }

        public string Reg_agencia_debito { get => reg_agencia_debito; set => reg_agencia_debito = value; }
        public string Reg_digito_agencia_debito { get => reg_digito_agencia_debito; set => reg_digito_agencia_debito = value; }
        public string Reg_razao_cc { get => reg_razao_cc; set => reg_razao_cc = value; }
        public string Reg_cc { get => reg_cc; set => reg_cc = value; }
        public string Reg_dgt_cc { get => reg_dgt_cc; set => reg_dgt_cc = value; }
        public string Reg_id_emp_benef_bnc { get => reg_id_emp_benef_bnc; set => reg_id_emp_benef_bnc = value; }
        public string Reg_nr_ctrl_participante { get => reg_nr_ctrl_participante.PadRight(25); set => reg_nr_ctrl_participante = value; }
        public string Reg_cd_bnc_debitado_cmr_compensacao { get => reg_cd_bnc_debitado_cmr_compensacao; set => reg_cd_bnc_debitado_cmr_compensacao = value; }
        public string Reg_multa { get => reg_multa; set => reg_multa = value; }
        public string Reg_percent_multa { get => reg_percent_multa; set => reg_percent_multa = value; }
        public string Reg_id_titulo_banco { get => reg_id_titulo_banco; set => reg_id_titulo_banco = value.PadLeft(11,'0'); }
        public string Reg_dgt_auto_conf_nr_banc {
            get => NossoNumero();
        }
        public string Reg_desc_bonif_dia { get => reg_desc_bonif_dia; set => reg_desc_bonif_dia = value; }
        public string Reg_cond_emissao_pap_cobranca { get => reg_cond_emissao_pap_cobranca; set => reg_cond_emissao_pap_cobranca = value; }
        public string Reg_id_deb_automatico { get => reg_id_deb_automatico; set => reg_id_deb_automatico = value; }
        public string Reg_id_operacao_bnc { get => reg_id_operacao_bnc; set => reg_id_operacao_bnc = value; }
        public string Reg_ic_rateio_credito { get => reg_ic_rateio_credito; set => reg_ic_rateio_credito = value; }
        public string Reg_end_avs_deb_automatico { get => reg_end_avs_deb_automatico; set => reg_end_avs_deb_automatico = value; }
        public string Reg_qtd_pag { get => reg_qtd_pag; set => reg_qtd_pag = value; }
        public string Reg_id_ocorrencia { get => reg_id_ocorrencia; set => reg_id_ocorrencia = value; }
        public string Reg_nr_doc { get => reg_nr_doc; set => reg_nr_doc = value; }
        public string Reg_dt_venc_titulo { get => reg_dt_venc_titulo; set => reg_dt_venc_titulo = value; }
        public string Reg_vl_titulo { get => reg_vl_titulo; set => reg_vl_titulo = value; }
        public string Reg_bnc_encarr_cobr { get => reg_bnc_encarr_cobr; set => reg_bnc_encarr_cobr = value; }
        public string Reg_agnc_depos { get => reg_agnc_depos; set => reg_agnc_depos = value; }
        public string Reg_espec_ttl { get => reg_espec_ttl; set => reg_espec_ttl = value; }
        public string Reg_identificacao { get => reg_identificacao; set => reg_identificacao = value; }
        public string Reg_dt_emi_ttl { get => reg_dt_emi_ttl; set => reg_dt_emi_ttl = value; }
        public string Reg_1_instr { get => reg_1_instr; set => reg_1_instr = value; }
        public string Reg_2_instr { get => reg_2_instr; set => reg_2_instr = value; }
        public string Reg_vl_cobr_dia_atraso { get => reg_vl_cobr_dia_atraso; set => reg_vl_cobr_dia_atraso = value; }
        public string Reg_dt_lmt_conces_desc { get => reg_dt_lmt_conces_desc; set => reg_dt_lmt_conces_desc = value; }
        public string Reg_vl_desc { get => reg_vl_desc; set => reg_vl_desc = value; }
        public string Reg_vl_IOF { get => reg_vl_IOF; set => reg_vl_IOF = value; }
        public string Reg_vl_abat_conc_canc { get => reg_vl_abat_conc_canc; set => reg_vl_abat_conc_canc = value; }
        public string Reg_id_tp_inscr_pag { get => reg_id_tp_inscr_pag; set => reg_id_tp_inscr_pag = value; }
        public string Reg_nm_pagador { get => reg_nm_pagador; set => reg_nm_pagador = value; }
        public string Reg_endereco_compl { get => reg_endereco_compl; set => reg_endereco_compl = value; }
        public string Reg_1_msg { get => reg_1_msg; set => reg_1_msg = value; }
        public string Reg_CEP { get => reg_CEP; set => reg_CEP = value; }
        public string Reg_sufixo_CEP { get => reg_sufixo_CEP; set => reg_sufixo_CEP = value; }
        public string Reg_sac_avalista { get => reg_sac_avalista; set => reg_sac_avalista = value; }
        public string Reg_nr_sequ_reg { get => reg_nr_sequ_reg; set => reg_nr_sequ_reg = value; }

        public string getCabecalho()
        {
            cabecalho  = cbc_id_registro;       //fixo
            cabecalho += getCbc_arq_remessa();  //fixo
            cabecalho += cbc_lit_remessa;       //fixo
            cabecalho += cbc_cod_servico;       //fixo
            cabecalho += getCodEmpresa();       //variavel
            cabecalho += getNmEmpresa();        //variavel
            cabecalho += cbc_nr_bradesco;       //fixo
            cabecalho += getNmBradesco();       //fixo
            cabecalho += getDtGravacao();       //variavel - gerado pelo sistema
            cabecalho += getBranco8();          //fixo
            cabecalho += cbc_id_sistema;        //fixo
            cabecalho += getNrRemessa();        //variavel
            cabecalho += getBranco277();        //fixo
            cabecalho += getLinha();            //varivel

            return cabecalho;
        }

        public string getCbc_arq_remessa()
        {
            return cbc_arq_remessa;
        }

        public string getCodEmpresa()
        {
            return cbc_cod_empresa;
        }

        public void setCodEmpresa(string cd_empresa)
        {
            cbc_cod_empresa = cd_empresa.PadRight(20);
        }

        public string getNmEmpresa()
        {
            return cbc_nm_empresa;
        }

        public void setNmEmpresa(string nm_empresa)
        {
            cbc_nm_empresa = nm_empresa.PadRight(30);
        }

        public string getNmBradesco()
        {
            cbc_nm_bradesco = cbc_nm_bradesco.PadRight(30);
            return cbc_nm_bradesco;
        }

        private string getDtGravacao()
        {
            string dtHoje; 
            dtHoje = DateTime.Now.ToShortDateString();
            dtHoje = dtHoje.Substring(0, 2) + dtHoje.Substring(3, 2) + dtHoje.Substring(8, 2);
            return dtHoje;
        }
        
        private string getBranco8()
        {
            return cbc_branco8.PadRight(8);
        }

        public string getNrRemessa()
        {
            return cbc_nr_seq_remessa;
        }

        public void setNrRemessa(int nr)
        {
            cbc_nr_seq_remessa = nr.ToString("0000000");
        }

        private string getBranco277()
        {
            return cbc_branco277.PadRight(277);
        }

        public string getLinha()
        {
            return linha;
        }

        public void setLinha(int l)
        {
            linha = l.ToString("000000");
        }

        private string NossoNumero()
        {
            int[] nr = new int[11];
            int cont = 0, tot = 0, dv = 0;

            for (int i = 0; i <= 10; i++)
            {
                nr[i] = int.Parse(reg_id_titulo_banco.Substring(i, 1));
            }

            //VALIDA O PRIMEIRO NUMERO
            cont = 0;
            tot = 0;

            for (int i = 11; i >= 2; i--)
            {
                tot += nr[cont] * i;
                cont++;
            }

            dv = 11 - tot % 11;
            if (dv >= 10)
            {
                return "P";
            }
            return dv.ToString();
        }
    }
}
