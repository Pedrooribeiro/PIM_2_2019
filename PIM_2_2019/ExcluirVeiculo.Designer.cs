namespace PrototipoTelas
{
    partial class ExcluirVeiculo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtPlacaConsultada = new System.Windows.Forms.MaskedTextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtTipoCombustivel = new System.Windows.Forms.MaskedTextBox();
            this.txtMotorizacao = new System.Windows.Forms.MaskedTextBox();
            this.txtAno = new System.Windows.Forms.MaskedTextBox();
            this.txtMarca = new System.Windows.Forms.MaskedTextBox();
            this.txtModelo = new System.Windows.Forms.MaskedTextBox();
            this.txtPlaca = new System.Windows.Forms.MaskedTextBox();
            this.txtCor = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Placa";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(115, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Excluir Veículo";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExcluir.Location = new System.Drawing.Point(68, 431);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(83, 32);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelar.Location = new System.Drawing.Point(236, 431);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 32);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.Button2_Click);
            // 
            // txtPlacaConsultada
            // 
            this.txtPlacaConsultada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtPlacaConsultada.Location = new System.Drawing.Point(196, 64);
            this.txtPlacaConsultada.Mask = "aaa-0000";
            this.txtPlacaConsultada.Name = "txtPlacaConsultada";
            this.txtPlacaConsultada.Size = new System.Drawing.Size(123, 20);
            this.txtPlacaConsultada.TabIndex = 9;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConsultar.Location = new System.Drawing.Point(150, 106);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(83, 32);
            this.btnConsultar.TabIndex = 10;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtTipoCombustivel
            // 
            this.txtTipoCombustivel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtTipoCombustivel.Location = new System.Drawing.Point(196, 371);
            this.txtTipoCombustivel.Name = "txtTipoCombustivel";
            this.txtTipoCombustivel.ReadOnly = true;
            this.txtTipoCombustivel.Size = new System.Drawing.Size(123, 20);
            this.txtTipoCombustivel.TabIndex = 54;
            // 
            // txtMotorizacao
            // 
            this.txtMotorizacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtMotorizacao.Location = new System.Drawing.Point(196, 336);
            this.txtMotorizacao.Name = "txtMotorizacao";
            this.txtMotorizacao.ReadOnly = true;
            this.txtMotorizacao.Size = new System.Drawing.Size(123, 20);
            this.txtMotorizacao.TabIndex = 53;
            // 
            // txtAno
            // 
            this.txtAno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtAno.Location = new System.Drawing.Point(196, 300);
            this.txtAno.Name = "txtAno";
            this.txtAno.ReadOnly = true;
            this.txtAno.Size = new System.Drawing.Size(123, 20);
            this.txtAno.TabIndex = 52;
            // 
            // txtMarca
            // 
            this.txtMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtMarca.Location = new System.Drawing.Point(196, 262);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.ReadOnly = true;
            this.txtMarca.Size = new System.Drawing.Size(123, 20);
            this.txtMarca.TabIndex = 51;
            // 
            // txtModelo
            // 
            this.txtModelo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtModelo.Location = new System.Drawing.Point(196, 225);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.ReadOnly = true;
            this.txtModelo.Size = new System.Drawing.Size(123, 20);
            this.txtModelo.TabIndex = 50;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtPlaca.Location = new System.Drawing.Point(196, 190);
            this.txtPlaca.Mask = "aaa-0000";
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.ReadOnly = true;
            this.txtPlaca.Size = new System.Drawing.Size(123, 20);
            this.txtPlaca.TabIndex = 49;
            // 
            // txtCor
            // 
            this.txtCor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtCor.Location = new System.Drawing.Point(196, 155);
            this.txtCor.Name = "txtCor";
            this.txtCor.ReadOnly = true;
            this.txtCor.Size = new System.Drawing.Size(123, 20);
            this.txtCor.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(65, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 17);
            this.label7.TabIndex = 47;
            this.label7.Text = "Tipo Combustível";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(65, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 46;
            this.label6.Text = "Motorização";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 45;
            this.label5.Text = "Ano";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 44;
            this.label2.Text = "Marca";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 43;
            this.label3.Text = "Modelo";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(65, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 17);
            this.label8.TabIndex = 42;
            this.label8.Text = "Placa";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(65, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 17);
            this.label9.TabIndex = 41;
            this.label9.Text = "Cor";
            // 
            // ExcluirVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(368, 488);
            this.Controls.Add(this.txtTipoCombustivel);
            this.Controls.Add(this.txtMotorizacao);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtPlacaConsultada);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "ExcluirVeiculo";
            this.Text = "Cor";
            this.Load += new System.EventHandler(this.ExcluirVeiculo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.MaskedTextBox txtPlacaConsultada;
        public System.Windows.Forms.MaskedTextBox txtTipoCombustivel;
        public System.Windows.Forms.MaskedTextBox txtMotorizacao;
        public System.Windows.Forms.MaskedTextBox txtAno;
        public System.Windows.Forms.MaskedTextBox txtMarca;
        public System.Windows.Forms.MaskedTextBox txtModelo;
        public System.Windows.Forms.MaskedTextBox txtPlaca;
        public System.Windows.Forms.MaskedTextBox txtCor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnConsultar;
    }
}