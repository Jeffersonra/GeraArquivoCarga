using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.IO;
using System.Windows.Forms;

namespace ProcessaPreIndexacao
{
    class ProcessaDiario
    {
        public void Inicia()
        {

            try
            {
                frmProcesaDiario formtxt = new frmProcesaDiario();
                OracleCommand oComando = new OracleCommand();
                oComando.Connection = new OracleConnection("Data Source=xxx;Persist Security Info=True;User ID=xxxx;Password=xxxx"); //xxx
                oComando.CommandText = "SELECT DISTINCT COD_SUB_CLI FROM TAB_MIGRACAO_IRON_DIARIO";
                oComando.CommandType = System.Data.CommandType.Text;
                oComando.Connection.Open();

                OracleDataReader ler = oComando.ExecuteReader();

                while (ler.Read())
                    {
                    int codCliente = Convert.ToInt16(ler[0]);
                    string statusProcessa = "";
                    string path = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
                    string nomeArquivo = path + @"\Log\LOG_" + codCliente + "_Carga_Mov_Diaria_" + DateTime.Now.ToString("dd_MM_yyyy") + ".txt";
                    string nomeCarga = path + @"\Carga\COS_" + codCliente + "_Carga_Mov_Diaria_" + DateTime.Now.ToString("dd_MM_yyyy") + ".txt";
                    StreamWriter writer = new StreamWriter(nomeArquivo);
                    writer.WriteLine("Inicio Processamento : " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + " Cliente: " + codCliente);

                    GeraDiario gera = new GeraDiario();
                    if (gera.geraDiario(codCliente))
                    {         
                        EnviaArquivo copy = new EnviaArquivo();
                        copy.CopiaBKP(nomeCarga, path + @"\BACKUP\COS_" + codCliente + "_Carga_Mov_Diaria_" + DateTime.Now.ToString("dd_MM_yyyy") + ".txt");
                        statusProcessa = "Processado com Sucesso!";
                    }
                    else
                    {
                        statusProcessa = "Falha no Processamento";
                    }

                    writer.WriteLine("Status Processamento : " + statusProcessa);
                    writer.WriteLine("Termino do processamento : " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    writer.Close();
                    }
            }
            catch
            {
                string path = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
                string nomeArquivo = path + @"\Log\LOG_ERROR_Carga_Mov_Diaria_" + DateTime.Now.ToString("dd_MM_yyyy") + ".txt";

                StreamWriter writer = new StreamWriter(nomeArquivo);
                writer.WriteLine("Inicio Processamento : " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                writer.WriteLine("Status Processamento : Erro Classe ProcessaDiario");
                writer.WriteLine("Termino do processamento : " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                writer.Close();
            }

            
        }
    }
}
