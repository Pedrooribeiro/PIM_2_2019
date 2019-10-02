namespace PrototipoTelas
{
    partial class CadastrarVeiculo
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.txtMotorizacao = new System.Windows.Forms.TextBox();
            this.txtTipoCombustivel = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cor";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Placa";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // txtCor
            // 
            this.txtCor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtCor.Location = new System.Drawing.Point(184, 73);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(100, 20);
            this.txtCor.TabIndex = 2;
            this.txtCor.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Modelo";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Marca";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ano";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Motorização";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tipo Combustível";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // txtModelo
            // 
            this.txtModelo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtModelo.Location = new System.Drawing.Point(184, 143);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 4;
            this.txtModelo.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // txtMarca
            // 
            this.txtMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtMarca.Location = new System.Drawing.Point(184, 180);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 5;
            this.txtMarca.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
            // 
            // txtAno
            // 
            this.txtAno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtAno.Location = new System.Drawing.Point(184, 218);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(100, 20);
            this.txtAno.TabIndex = 6;
            this.txtAno.TextChanged += new System.EventHandler(this.TextBox5_TextChanged);
            // 
            // txtMotorizacao
            // 
            this.txtMotorizacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtMotorizacao.Location = new System.Drawing.Point(184, 254);
            this.txtMotorizacao.Name = "txtMotorizacao";
            this.txtMotorizacao.Size = new System.Drawing.Size(100, 20);
            this.txtMotorizacao.TabIndex = 7;
            this.txtMotorizacao.TextChanged += new System.EventHandler(this.TextBox6_TextChanged);
            // 
            // txtTipoCombustivel
            // 
            this.txtTipoCombustivel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtTipoCombustivel.Location = new System.Drawing.Point(184, 289);
            this.txtTipoCombustivel.Name = "txtTipoCombustivel";
            this.txtTipoCombustivel.Size = new System.Drawing.Size(100, 20);
            this.txtTipoCombustivel.TabIndex = 8;
            this.txtTipoCombustivel.TextChanged += new System.EventHandler(this.TextBox7_TextChanged);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCadastrar.Location = new System.Drawing.Point(52, 345);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(79, 30);
            this.btnCadastrar.TabIndex = 9;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelar.Location = new System.Drawing.Point(205, 345);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(79, 30);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(69, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "Cadastrar Veículo";
            this.label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtPlaca.Location = new System.Drawing.Point(184, 108);
            this.txtPlaca.Mask = "aaa-0000";
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(100, 20);
            this.txtPlaca.TabIndex = 3;
            // 
            // CadastrarVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(311, 406);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtTipoCombustivel);
            this.Controls.Add(this.txtMotorizacao);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastrarVeiculo";
            this.Text = "CadastrarVeiculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.TextBox txtMotorizacao;
        private System.Windows.Forms.TextBox txtTipoCombustivel;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtPlaca;
    }
}