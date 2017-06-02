using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessaPreIndexacao
{
    class ProcessaIndexacao
    {
        public bool executaProc()
        {
            //Executa Procedure e valida se foi executado com sucesso!;
            try
            {
                Conecta execProc = new Conecta();
                execProc.queryString = "PROC_TESTE_MIGRARECALL"; //Procedure para processamento
                execProc.executaProc();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
