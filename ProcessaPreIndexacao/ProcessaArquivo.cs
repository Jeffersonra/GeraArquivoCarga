using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProcessaPreIndexacao
{
    class ProcessaArquivo
    {
        public void processar(string caminho)
        {

            string[] array = File.ReadAllLines(caminho, Encoding.Default);

            for (int i = 0; i < array.Length; i++)
            {
                //quebra o arquivo pelo separador "|"
                string[] auxiliar = array[i].Split('|');

                Conecta cnDb = new Conecta();
                cnDb.queryString = "INSERT INTO TB_PRE_INDEXACAO VALUES(" + auxiliar[0] + ",'" + auxiliar[1] + "','" + auxiliar[2] + "','" + auxiliar[3] + "','" + auxiliar[4] + "','" +
                                                                        auxiliar[5] + "','" + auxiliar[6] + "','" + auxiliar[7] + "','" + auxiliar[8] + "','" + auxiliar[9] + "','" +
                                                                        auxiliar[10] + "','" + auxiliar[11] + "','" + auxiliar[12] + "','" + auxiliar[13] + "','" + auxiliar[14] + "',sysdate, null)";
                cnDb.executaQuery();
            }
        }
    }
}
