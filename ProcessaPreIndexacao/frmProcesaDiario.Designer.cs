namespace ProcessaPreIndexacao
{
    partial class frmProcesaDiario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcesaDiario));
            this.btnExecutarManual = new System.Windows.Forms.Button();
            this.lblStatusProcessa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboTimer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExecutarManual
            // 
            this.btnExecutarManual.Location = new System.Drawing.Point(35, 158);
            this.btnExecutarManual.Name = "btnExecutarManual";
            this.btnExecutarManual.Size = new System.Drawing.Size(83, 34);
            this.btnExecutarManual.TabIndex = 0;
            this.btnExecutarManual.Text = "Executar Manual";
            this.btnExecutarManual.UseVisualStyleBackColor = true;
            this.btnExecutarManual.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblStatusProcessa
            // 
            this.lblStatusProcessa.AutoSize = true;
            this.lblStatusProcessa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusProcessa.Location = new System.Drawing.Point(31, 104);
            this.lblStatusProcessa.Name = "lblStatusProcessa";
            this.lblStatusProcessa.Size = new System.Drawing.Size(171, 24);
            this.lblStatusProcessa.TabIndex = 1;
            this.lblStatusProcessa.Text = "Processo inciado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = " Integração IronMontain ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gera Carga de Movimentação Diária";
            // 
            // comboTimer
            // 
            this.comboTimer.DisplayMember = "17:40";
            this.comboTimer.FormattingEnabled = true;
            this.comboTimer.Items.AddRange(new object[] {
            "1:30",
            "2:00",
            "2:30",
            "3:00",
            "3:30",
            "6:10"});
            this.comboTimer.Location = new System.Drawing.Point(311, 165);
            this.comboTimer.Name = "comboTimer";
            this.comboTimer.Size = new System.Drawing.Size(77, 21);
            this.comboTimer.TabIndex = 4;
            this.comboTimer.Text = "1:30";
            this.comboTimer.SelectedIndexChanged += new System.EventHandler(this.comboTimer_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(142, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Proxima execução em: ";
            // 
            // frmProcesaDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 220);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboTimer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStatusProcessa);
            this.Controls.Add(this.btnExecutarManual);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmProcesaDiario";
            this.Text = "Processamento Arquivo Diário - Integração IronMontain";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExecutarManual;
        public System.Windows.Forms.Label lblStatusProcessa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboTimer;
        private System.Windows.Forms.Label label3;
    }
}

