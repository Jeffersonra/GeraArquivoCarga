using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ProcessaPreIndexacao
{
    class EnviaArquivo
    {
        public void CopiaBKP(string localAtual, string destino)
        {
            try
            {
                File.Copy(localAtual, destino);
            }
            catch
            {
                string path = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
                string nomeArquivo = path + @"\Log\LOG_ERROR_Carga_Mov_Diaria_" + DateTime.Now.ToString("dd_MM_yyyy") + ".txt";

                StreamWriter writer = new StreamWriter(nomeArquivo);
                writer.WriteLine("Inicio Processamento : " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                writer.WriteLine("Status Processamento : CopiaArquivo");
                writer.WriteLine("Termino do processamento : " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                writer.Close();
            }
        }
    }
}
