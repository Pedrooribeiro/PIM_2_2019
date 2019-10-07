namespace PrototipoTelas
{
    partial class ConsultarAbastecimento
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConsultar = new System.Windows.Forms.Button();
            this.txtPlacaConsultada = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(81, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 24);
            this.label6.TabIndex = 55;
            this.label6.Text = "Consultar Abastecimento";
            // 
            // txtCancelar
            // 
            this.txtCancelar.Location = new System.Drawing.Point(232, 213);
            this.txtCancelar.Name = "txtCancelar";
            this.txtCancelar.Size = new System.Drawing.Size(91, 31);
            this.txtCancelar.TabIndex = 54;
            this.txtCancelar.Text = "Cancelar";
            this.txtCancelar.UseVisualStyleBackColor = true;
            this.txtCancelar.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 46;
            this.label2.Text = "Placa";
            // 
            // txtConsultar
            // 
            this.txtConsultar.Location = new System.Drawing.Point(84, 213);
            this.txtConsultar.Name = "txtConsultar";
            this.txtConsultar.Size = new System.Drawing.Size(91, 31);
            this.txtConsultar.TabIndex = 44;
            this.txtConsultar.Text = "Consultar";
            this.txtConsultar.UseVisualStyleBackColor = true;
            this.txtConsultar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtPlacaConsultada
            // 
            this.txtPlacaConsultada.Location = new System.Drawing.Point(226, 122);
            this.txtPlacaConsultada.Mask = "aaa-0000";
            this.txtPlacaConsultada.Name = "txtPlacaConsultada";
            this.txtPlacaConsultada.Size = new System.Drawing.Size(100, 20);
            this.txtPlacaConsultada.TabIndex = 43;
            // 
            // ConsultarAbastecimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(385, 304);
            this.Controls.Add(this.txtPlacaConsultada);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtConsultar);
            this.Name = "ConsultarAbastecimento";
            this.Text = "ConsultarAbastecimento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button txtCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button txtConsultar;
        private System.Windows.Forms.MaskedTextBox txtPlacaConsultada;
    }
}