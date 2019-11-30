using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoContas
{
    class ClassValidacao
    {
        public bool validarCPF(string cpf)
        {
            int[] nr = new int[11];
            int cont = 0, tot = 0, dv1 = 0, dv2 = 0;

            for (int i = 0; i <= 10; i++)
            {
                nr[i] = int.Parse(cpf.Substring(i, 1));
            }

            //VALIDA O PRIMEIRO NUMERO
            for (int i = 10; i >= 2; i--)
            {
                tot += nr[cont] * i;
                cont++;
            }

            dv1 = 11 - tot % 11;
            dv1 = dv1 > 9 ? 0 : dv1;

            //VERIFICA O PRIMEIRO DIGITO
            if (nr[9] == dv1)
            {
                //VALIDA O PRIMEIRO NUMERO
                cont = 0;
                tot = 0;

                for (int i = 11; i >= 2; i--)
                {
                    tot += nr[cont] * i;
                    cont++;
                }

                dv2 = 11 - tot % 11;
                dv2 = dv2 > 9 ? 0 : dv2;
                //VERIFICA O SEGUNDO DIGITO
                bool ret = nr[10] == dv2 ? true : false;
                return ret;
            }
            else
            {
                return false;
            }
        }

        public bool TclPadrao(int c)
        {
            if (c == 32 || c == 8)
            {
                return true;
            }
            return false;
        }

        public bool TclLetra(int c)
        {
            if ((c >= 65 && c <= 90) || (c >= 97 && c <= 122))
            {
                return true;
            }
            return false;
        }

        public bool TclNumero(int c)
        {
            if ((c >= 48 && c <= 57))
            {
                return true;
            }
            return false;
        }
    }
}
