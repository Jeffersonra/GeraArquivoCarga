using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using Oracle.ManagedDataAccess.Client;

namespace ProcessaPreIndexacao
{
    class Conecta
    {
        //dados de conexão ao banco
        public string stringConexao = "Data Source=xxxx;Persist Security Info=True;User ID=xxxx;Password=xxxx";
        //Variavel Consulta/Procedure
        public string queryString = "";

        // Conecta ao banco Oracle
        public bool conecta()
        {
            try
            {
                OracleCommand oComando = new OracleCommand();
                oComando.Connection = new OracleConnection(stringConexao);
                oComando.Connection.Open();
                return true;
            }
            catch
            {
                return false;
            }
           
        }

        //Executa querys sem retorno
        public bool executaQuery()
        {
            try
            {
                OracleCommand oComando = new OracleCommand();
                oComando.Connection = new OracleConnection(stringConexao);
                oComando.CommandText = queryString;
                oComando.CommandType = System.Data.CommandType.Text;
                oComando.Connection.Open();
                oComando.ExecuteNonQuery();
                //oComando.Connection.Clone();

                return true;
            }
            catch
            {
                return false;
            }
        }

        //Executa procedure sem Retorno
        public bool executaProc()
        {
            try
            {
                OracleCommand oComando = new OracleCommand();
                oComando.Connection = new OracleConnection(stringConexao);
                oComando.CommandText = queryString;
                oComando.CommandType = System.Data.CommandType.StoredProcedure;
                oComando.Connection.Open();
                oComando.ExecuteNonQuery();
                //oComando.Connection.Clone();

                return true;
            }
            catch
            {
                return false;
            }
        }

        //public string  retornaQuery()
        //{
        //    //OracleCommand oComando = new OracleCommand();
        //    //oComando.Connection = new OracleConnection(stringConexao);
        //    //oComando.CommandText = queryString;
        //    //oComando.CommandType = System.Data.CommandType.Text;
        //    //oComando.Connection.Open();

        //    //OracleDataReader ler = oComando.ExecuteReader();

        //    //// OracleCommand oComando = new OracleCommand();
        //    ////    oComando.Connection = new OracleConnection("Data Source=xxx;Persist Security Info=True;User ID=xxx;Password=xxxx"); //xxxxx
        //    ////    oComando.CommandText = queryString;
        //    ////    oComando.CommandType = System.Data.CommandType.Text;
        //    ////    oComando.Connection.Open();

        //    //// OracleDataReader ler = oComando.ExecuteReader();
        //    //// string teste = Convert.ToString(ler[0]);

        //    ////return Convert.ToString(ler[0]);//Convert.ToInt32(ler[0]);
        //}
    }
}
