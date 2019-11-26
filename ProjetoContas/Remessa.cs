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
    }
}
