namespace PrototipoTelas
{
    partial class ResultadoConsultaEntrada
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
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEntrada = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSaida = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaida)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(133, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Resultado Consulta";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.Location = new System.Drawing.Point(353, 557);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 49);
            this.button2.TabIndex = 26;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "ENTRADA:";
            // 
            // dgvEntrada
            // 
            this.dgvEntrada.AllowUserToAddRows = false;
            this.dgvEntrada.AllowUserToDeleteRows = false;
            this.dgvEntrada.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntrada.Location = new System.Drawing.Point(12, 118);
            this.dgvEntrada.Name = "dgvEntrada";
            this.dgvEntrada.ReadOnly = true;
            this.dgvEntrada.Size = new System.Drawing.Size(452, 195);
            this.dgvEntrada.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "SAÍDA:";
            // 
            // dgvSaida
            // 
            this.dgvSaida.AllowUserToAddRows = false;
            this.dgvSaida.AllowUserToDeleteRows = false;
            this.dgvSaida.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvSaida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaida.Location = new System.Drawing.Point(12, 356);
            this.dgvSaida.Name = "dgvSaida";
            this.dgvSaida.ReadOnly = true;
            this.dgvSaida.Size = new System.Drawing.Size(452, 195);
            this.dgvSaida.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Location = new System.Drawing.Point(12, 557);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 49);
            this.button1.TabIndex = 25;
            this.button1.Text = "Finalizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ResultadoConsultaEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(474, 611);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvSaida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvEntrada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Name = "ResultadoConsultaEntrada";
            this.Text = "ResultadoConsultaEntrada";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvEntrada;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dgvSaida;
        private System.Windows.Forms.Button button1;
    }
}