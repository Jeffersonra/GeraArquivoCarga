using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using Oracle.ManagedDataAccess.Client;


namespace ProcessaPreIndexacao
{
    public partial class frmProcesaDiario : Form
    {
        public frmProcesaDiario()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            valorCombo = comboTimer.Text.ToString();
            Thread trd = new Thread(new ThreadStart(this.VerificarHorario));
            trd.IsBackground = true;
            trd.Start();
        }

        public string valorCombo = "";

        private void button1_Click(object sender, EventArgs e)
        {
            
            #region outros
            #region Passo 1 Instancia Classe ProcessaArquivo que realiza o processamento do txt (Incluir Verificação dos arquivos na pasta)
            //ProcessaArquivo procArqui = new ProcessaArquivo();
            //procArqui.processar(@"C:\Users\mt15160\Documents\visual studio 2013\Projects\ProcessaPreIndexacao\TesteArquivo\200_25_05_2017.txt");

            //MessageBox.Show("Processo txt realizado", "Processamento", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            
                #region pupulaVarial
                //a.COD_SUB_CLI = Convert.ToInt32(auxiliar[0]);
                //a.NUM_DOC = auxiliar[1];
                //a.NUM_DOC_AUX = auxiliar[2];
                //a.COD_CPF = Convert.ToInt32(auxiliar[3]);
                //a.COD_SETOR = auxiliar[4];
                //a.DESCRICAO_SETOR = auxiliar[5];
                //a.DES_DOC = auxiliar[6];
                //a.DES_TOTAL = auxiliar[7];
                //a.DES_COD7 = auxiliar[8];
                //a.COD_PADRAO = auxiliar[9];
                //a.DES_IT_DOC = auxiliar[10];
                //a.TIPO_DOCUMENTO = auxiliar[11];
                //a.TIPO_INDEXAÇÃO = auxiliar[12];
                //a.NUM_IT_DOC = Convert.ToInt32(auxiliar[13]);
                //a.REQUISITANTE = auxiliar[14];

                //MessageBox.Show(Convert.ToString(a.COD_SUB_CLI) +" / " + a.NUM_DOC +" / " + a.NUM_DOC_AUX +" / " + a.COD_CPF +" / " + a.COD_SETOR +" / " + a.DESCRICAO_SETOR +" / " + a.DES_TOTAL +" / " + Convert.ToString(a.DES_COD7) +" / " + a.COD_PADRAO +" / " + a.DES_IT_DOC +" / " + a.TIPO_DOCUMENTO +" / " + a.TIPO_INDEXAÇÃO +" / " + Convert.ToString(a.NUM_DOC_AUX) +" / " + a.REQUISITANTE);
                #endregion pupulaVarial

            #endregion 


            #region Passo 2 Rodar Procedure que realiza o Processamento

            ////Executa Procedure e valida se foi executado com sucesso!;
            //ProcessaIndexacao procIndex = new ProcessaIndexacao();
            //if (procIndex.executaProc())
            //{
            //    MessageBox.Show("executou", "Processamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    MessageBox.Show("Deu Ruim", "Processamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            #endregion
            #endregion

            IniciaProcessamento();
            this.lblStatusProcessa.Text = "Processo Executado em: " + DateTime.Now;
            MessageBox.Show("Termino do Processamento!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        public void IniciaProcessamento()
        {
            ProcessaDiario processa = new ProcessaDiario();
            processa.Inicia();
            
            Application.DoEvents();
            SetText("Processo Executado em: " + DateTime.Now);
        }

        protected void VerificarHorario()
        {
            while (true)
            {
                string date = DateTime.Now.Hour + ":" + DateTime.Now.Minute;
                if (date == valorCombo) 
                {
                    IniciaProcessamento();
                    SetText("Processo Executado em: " + DateTime.Now);
                }
                Thread.Sleep(30000); //3.600.000 milisegundos equivalem a 1 hora
            }
        }

        private void comboTimer_SelectedIndexChanged(object sender, EventArgs e)
        {
            valorCombo = comboTimer.Text.ToString();
            Thread trd = new Thread(new ThreadStart(this.VerificarHorario));
            trd.IsBackground = true;
            trd.Start();
        }

        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            if (this.lblStatusProcessa.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.lblStatusProcessa.Text = text;
            }
        }
    }
}
