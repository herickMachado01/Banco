namespace SistemaBanco
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_C1_saldo = new System.Windows.Forms.Label();
            this.lbl_C1_titula = new System.Windows.Forms.Label();
            this.lbl_C1_numero = new System.Windows.Forms.Label();
            this.btn_C1_transferir = new System.Windows.Forms.Button();
            this.btn_C1_depositar = new System.Windows.Forms.Button();
            this.btn_C1_sacar = new System.Windows.Forms.Button();
            this.txt_C1_valor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_C2_saldo = new System.Windows.Forms.Label();
            this.lbl_C2_titular = new System.Windows.Forms.Label();
            this.lbl_C2_numero = new System.Windows.Forms.Label();
            this.btn_C2_transferir = new System.Windows.Forms.Button();
            this.btn_C2_depositar = new System.Windows.Forms.Button();
            this.btn_C2_sacar = new System.Windows.Forms.Button();
            this.txt_C2_valor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_C1_saldo);
            this.groupBox1.Controls.Add(this.lbl_C1_titula);
            this.groupBox1.Controls.Add(this.lbl_C1_numero);
            this.groupBox1.Controls.Add(this.btn_C1_transferir);
            this.groupBox1.Controls.Add(this.btn_C1_depositar);
            this.groupBox1.Controls.Add(this.btn_C1_sacar);
            this.groupBox1.Controls.Add(this.txt_C1_valor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 364);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conta 1";
            // 
            // lbl_C1_saldo
            // 
            this.lbl_C1_saldo.AutoSize = true;
            this.lbl_C1_saldo.Location = new System.Drawing.Point(149, 162);
            this.lbl_C1_saldo.Name = "lbl_C1_saldo";
            this.lbl_C1_saldo.Size = new System.Drawing.Size(79, 29);
            this.lbl_C1_saldo.TabIndex = 9;
            this.lbl_C1_saldo.Text = "label6";
            // 
            // lbl_C1_titula
            // 
            this.lbl_C1_titula.AutoSize = true;
            this.lbl_C1_titula.Location = new System.Drawing.Point(149, 102);
            this.lbl_C1_titula.Name = "lbl_C1_titula";
            this.lbl_C1_titula.Size = new System.Drawing.Size(79, 29);
            this.lbl_C1_titula.TabIndex = 8;
            this.lbl_C1_titula.Text = "label5";
            // 
            // lbl_C1_numero
            // 
            this.lbl_C1_numero.AutoSize = true;
            this.lbl_C1_numero.Location = new System.Drawing.Point(149, 42);
            this.lbl_C1_numero.Name = "lbl_C1_numero";
            this.lbl_C1_numero.Size = new System.Drawing.Size(79, 29);
            this.lbl_C1_numero.TabIndex = 7;
            this.lbl_C1_numero.Text = "label4";
            // 
            // btn_C1_transferir
            // 
            this.btn_C1_transferir.Location = new System.Drawing.Point(256, 284);
            this.btn_C1_transferir.Name = "btn_C1_transferir";
            this.btn_C1_transferir.Size = new System.Drawing.Size(126, 44);
            this.btn_C1_transferir.TabIndex = 6;
            this.btn_C1_transferir.Text = "Transferir";
            this.btn_C1_transferir.UseVisualStyleBackColor = true;
            this.btn_C1_transferir.Click += new System.EventHandler(this.btn_C1_transferir_Click);
            // 
            // btn_C1_depositar
            // 
            this.btn_C1_depositar.Location = new System.Drawing.Point(122, 284);
            this.btn_C1_depositar.Name = "btn_C1_depositar";
            this.btn_C1_depositar.Size = new System.Drawing.Size(128, 44);
            this.btn_C1_depositar.TabIndex = 5;
            this.btn_C1_depositar.Text = "Depositar";
            this.btn_C1_depositar.UseVisualStyleBackColor = true;
            this.btn_C1_depositar.Click += new System.EventHandler(this.btn_C1_depositar_Click);
            // 
            // btn_C1_sacar
            // 
            this.btn_C1_sacar.Location = new System.Drawing.Point(32, 284);
            this.btn_C1_sacar.Name = "btn_C1_sacar";
            this.btn_C1_sacar.Size = new System.Drawing.Size(84, 44);
            this.btn_C1_sacar.TabIndex = 4;
            this.btn_C1_sacar.Text = "Sacar";
            this.btn_C1_sacar.UseVisualStyleBackColor = true;
            this.btn_C1_sacar.Click += new System.EventHandler(this.btn_C1_sacar_Click);
            // 
            // txt_C1_valor
            // 
            this.txt_C1_valor.Location = new System.Drawing.Point(32, 232);
            this.txt_C1_valor.Name = "txt_C1_valor";
            this.txt_C1_valor.Size = new System.Drawing.Size(350, 35);
            this.txt_C1_valor.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saldo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titular:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_C2_saldo);
            this.groupBox2.Controls.Add(this.lbl_C2_titular);
            this.groupBox2.Controls.Add(this.lbl_C2_numero);
            this.groupBox2.Controls.Add(this.btn_C2_transferir);
            this.groupBox2.Controls.Add(this.btn_C2_depositar);
            this.groupBox2.Controls.Add(this.btn_C2_sacar);
            this.groupBox2.Controls.Add(this.txt_C2_valor);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(464, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 364);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Conta 2";
            // 
            // lbl_C2_saldo
            // 
            this.lbl_C2_saldo.AutoSize = true;
            this.lbl_C2_saldo.Location = new System.Drawing.Point(149, 162);
            this.lbl_C2_saldo.Name = "lbl_C2_saldo";
            this.lbl_C2_saldo.Size = new System.Drawing.Size(79, 29);
            this.lbl_C2_saldo.TabIndex = 9;
            this.lbl_C2_saldo.Text = "label6";
            // 
            // lbl_C2_titular
            // 
            this.lbl_C2_titular.AutoSize = true;
            this.lbl_C2_titular.Location = new System.Drawing.Point(149, 102);
            this.lbl_C2_titular.Name = "lbl_C2_titular";
            this.lbl_C2_titular.Size = new System.Drawing.Size(79, 29);
            this.lbl_C2_titular.TabIndex = 8;
            this.lbl_C2_titular.Text = "label5";
            // 
            // lbl_C2_numero
            // 
            this.lbl_C2_numero.AutoSize = true;
            this.lbl_C2_numero.Location = new System.Drawing.Point(149, 42);
            this.lbl_C2_numero.Name = "lbl_C2_numero";
            this.lbl_C2_numero.Size = new System.Drawing.Size(79, 29);
            this.lbl_C2_numero.TabIndex = 7;
            this.lbl_C2_numero.Text = "label4";
            // 
            // btn_C2_transferir
            // 
            this.btn_C2_transferir.Location = new System.Drawing.Point(256, 284);
            this.btn_C2_transferir.Name = "btn_C2_transferir";
            this.btn_C2_transferir.Size = new System.Drawing.Size(126, 44);
            this.btn_C2_transferir.TabIndex = 6;
            this.btn_C2_transferir.Text = "Transferir";
            this.btn_C2_transferir.UseVisualStyleBackColor = true;
            // 
            // btn_C2_depositar
            // 
            this.btn_C2_depositar.Location = new System.Drawing.Point(122, 284);
            this.btn_C2_depositar.Name = "btn_C2_depositar";
            this.btn_C2_depositar.Size = new System.Drawing.Size(128, 44);
            this.btn_C2_depositar.TabIndex = 5;
            this.btn_C2_depositar.Text = "Depositar";
            this.btn_C2_depositar.UseVisualStyleBackColor = true;
            // 
            // btn_C2_sacar
            // 
            this.btn_C2_sacar.Location = new System.Drawing.Point(32, 284);
            this.btn_C2_sacar.Name = "btn_C2_sacar";
            this.btn_C2_sacar.Size = new System.Drawing.Size(84, 44);
            this.btn_C2_sacar.TabIndex = 4;
            this.btn_C2_sacar.Text = "Sacar";
            this.btn_C2_sacar.UseVisualStyleBackColor = true;
            // 
            // txt_C2_valor
            // 
            this.txt_C2_valor.Location = new System.Drawing.Point(32, 232);
            this.txt_C2_valor.Name = "txt_C2_valor";
            this.txt_C2_valor.Size = new System.Drawing.Size(350, 35);
            this.txt_C2_valor.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 29);
            this.label7.TabIndex = 2;
            this.label7.Text = "Saldo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 29);
            this.label8.TabIndex = 1;
            this.label8.Text = "Titular:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "Número:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 425);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_C1_sacar;
        private System.Windows.Forms.TextBox txt_C1_valor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_C1_saldo;
        private System.Windows.Forms.Label lbl_C1_titula;
        private System.Windows.Forms.Label lbl_C1_numero;
        private System.Windows.Forms.Button btn_C1_transferir;
        private System.Windows.Forms.Button btn_C1_depositar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_C2_saldo;
        private System.Windows.Forms.Label lbl_C2_titular;
        private System.Windows.Forms.Label lbl_C2_numero;
        private System.Windows.Forms.Button btn_C2_transferir;
        private System.Windows.Forms.Button btn_C2_depositar;
        private System.Windows.Forms.Button btn_C2_sacar;
        private System.Windows.Forms.TextBox txt_C2_valor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

