using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.IO;


namespace ProcessaPreIndexacao
{
    class GeraDiario
    {
        public bool geraDiario(int codCliente)
        {

            try
            {
                Guid guid;
                guid = Guid.NewGuid();
                string path = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
                string nomeArquivo = path + @"\Carga\COS_" + codCliente + "_Carga_Mov_Diaria_" + DateTime.Now.ToString("dd_MM_yyyy") + ".txt";
                StreamWriter writer = new StreamWriter(nomeArquivo);
                writer.WriteLine("HEADER" + guid  + DateTime.Now.ToString("ddMMyyyy"));

                #region incluir metodo na classe Conecta
                OracleCommand oComando = new OracleCommand();
                oComando.Connection = new OracleConnection("Data Source=xxxx;Persist Security Info=True;User ID=xxxx;Password=xxxx"); //xxxx
                oComando.CommandText = "SELECT COD_SUB_CLI, " +
                                               "ENDERECO  NUM_CAIXA," +
                                               "NUM_DOC," +
                                               "NUM_DOC_AUX," +
                                               "COD_CPF," +
                                               "COD_SETOR," +
                                               "DESCRICAO_SETOR," +
                                               "DES_DOC," +
                                               "DES_TOTAL," +
                                               "DES_COD4," +
                                               "DES_COD5," +
                                               "DES_COD6," +
                                               "DES_COD7," +
                                               "COD_PADRAO," +
                                               "DES_IT_DOC," +
                                               "TIPO_DOCUMENTO," +
                                               "SEQ_SUB_ITEM_DOC," +
                                               "NUM_IT_DOC," +
                                               "SEQ_IT_DOC," +
                                               "REQUISITANTE," +
                                               "TITULO," +
                                               "DAT_INICIO," +
                                               "DAT_FINAL," +
                                               "DAT_DESTRUICAO " +
                                          "FROM TAB_MIGRACAO_IRON_DIARIO WHERE COD_SUB_CLI = " + codCliente;
                oComando.CommandType = System.Data.CommandType.Text;
                oComando.Connection.Open();
                #endregion

                #region Inclusão dos dados nos arquivos
                OracleDataReader ler = oComando.ExecuteReader();
                int  Lines = 0;
                while (ler.Read())
                {
                    string teste = Convert.ToString(ler[4]);
                    string teste2 = teste.Replace("\r\n", " ");
                    writer.WriteLine(ler[0]  + "|" + 
                                     ler[1]  + "|" + 
                                     ler[2]  + "|" + 
                                     ler[3]  + "|" + 
                                     ler[4]  + "|" +
                                     ler[5]  + "|" +
                                     ler[6]  + "|" +
                                     ler[7]  + "|" +
                                     ler[8]  + "|" +
                                     ler[9]  + "|" +
                                     ler[10] + "|" +
                                     ler[11] + "|" +
                                     ler[12] + "|" +
                                     ler[13] + "|" +
                                     ler[14] + "|" +
                                     ler[15] + "|" +
                                     ler[16] + "|" +
                                     ler[17] + "|" +
                                     ler[18] + "|" +
                                     ler[19] + "|" +
                                     ler[20] + "|" +
                                     ler[21] + "|" +
                                     ler[22] + "|" +
                                     ler[23]
                                     );
                    Lines++;
                }
               
                writer.WriteLine("TRAILLER  " + Lines);
                writer.Close();
                #endregion

                return true;
            }
            catch
            {
                return false;
            }

            

        }
    }
}
