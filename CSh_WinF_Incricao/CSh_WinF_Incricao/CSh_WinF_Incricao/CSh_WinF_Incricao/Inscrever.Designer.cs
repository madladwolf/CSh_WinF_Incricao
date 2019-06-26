namespace CSh_WinF_Incricao
{
    partial class Inscrever
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbx_cruso = new System.Windows.Forms.ComboBox();
            this.rdb_nocturno = new System.Windows.Forms.RadioButton();
            this.rdb_diurno = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dt_dataNasc = new System.Windows.Forms.DateTimePicker();
            this.txt_loca = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.rdb_feminino = new System.Windows.Forms.RadioButton();
            this.rdb_masculino = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inscrever em:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbx_cruso);
            this.groupBox1.Controls.Add(this.rdb_nocturno);
            this.groupBox1.Controls.Add(this.rdb_diurno);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Curso";
            // 
            // cbx_cruso
            // 
            this.cbx_cruso.FormattingEnabled = true;
            this.cbx_cruso.Location = new System.Drawing.Point(79, 28);
            this.cbx_cruso.Name = "cbx_cruso";
            this.cbx_cruso.Size = new System.Drawing.Size(188, 21);
            this.cbx_cruso.TabIndex = 6;
            // 
            // rdb_nocturno
            // 
            this.rdb_nocturno.AutoSize = true;
            this.rdb_nocturno.Location = new System.Drawing.Point(141, 68);
            this.rdb_nocturno.Name = "rdb_nocturno";
            this.rdb_nocturno.Size = new System.Drawing.Size(69, 17);
            this.rdb_nocturno.TabIndex = 5;
            this.rdb_nocturno.TabStop = true;
            this.rdb_nocturno.Text = "Nocturno";
            this.rdb_nocturno.UseVisualStyleBackColor = true;
            // 
            // rdb_diurno
            // 
            this.rdb_diurno.AutoSize = true;
            this.rdb_diurno.Location = new System.Drawing.Point(9, 68);
            this.rdb_diurno.Name = "rdb_diurno";
            this.rdb_diurno.Size = new System.Drawing.Size(56, 17);
            this.rdb_diurno.TabIndex = 4;
            this.rdb_diurno.TabStop = true;
            this.rdb_diurno.Text = "Diurno";
            this.rdb_diurno.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Curso:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dt_dataNasc);
            this.groupBox2.Controls.Add(this.txt_loca);
            this.groupBox2.Controls.Add(this.txt_nome);
            this.groupBox2.Controls.Add(this.rdb_feminino);
            this.groupBox2.Controls.Add(this.rdb_masculino);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 148);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Pessoais";
            // 
            // dt_dataNasc
            // 
            this.dt_dataNasc.Location = new System.Drawing.Point(82, 46);
            this.dt_dataNasc.MaxDate = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.dt_dataNasc.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dt_dataNasc.Name = "dt_dataNasc";
            this.dt_dataNasc.Size = new System.Drawing.Size(189, 20);
            this.dt_dataNasc.TabIndex = 10;
            // 
            // txt_loca
            // 
            this.txt_loca.Location = new System.Drawing.Point(82, 72);
            this.txt_loca.Name = "txt_loca";
            this.txt_loca.Size = new System.Drawing.Size(189, 20);
            this.txt_loca.TabIndex = 9;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(82, 20);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(189, 20);
            this.txt_nome.TabIndex = 7;
            // 
            // rdb_feminino
            // 
            this.rdb_feminino.AutoSize = true;
            this.rdb_feminino.Location = new System.Drawing.Point(144, 115);
            this.rdb_feminino.Name = "rdb_feminino";
            this.rdb_feminino.Size = new System.Drawing.Size(67, 17);
            this.rdb_feminino.TabIndex = 6;
            this.rdb_feminino.TabStop = true;
            this.rdb_feminino.Text = "Feminino";
            this.rdb_feminino.UseVisualStyleBackColor = true;
            // 
            // rdb_masculino
            // 
            this.rdb_masculino.AutoSize = true;
            this.rdb_masculino.Location = new System.Drawing.Point(12, 115);
            this.rdb_masculino.Name = "rdb_masculino";
            this.rdb_masculino.Size = new System.Drawing.Size(73, 17);
            this.rdb_masculino.TabIndex = 5;
            this.rdb_masculino.TabStop = true;
            this.rdb_masculino.Text = "Masculino";
            this.rdb_masculino.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Localização:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "DataNasc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nome:";
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(15, 285);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(82, 35);
            this.btn_limpar.TabIndex = 3;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_inserir
            // 
            this.btn_inserir.Location = new System.Drawing.Point(207, 285);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(82, 35);
            this.btn_inserir.TabIndex = 4;
            this.btn_inserir.Text = "Inserir";
            this.btn_inserir.UseVisualStyleBackColor = true;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(15, 326);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(274, 21);
            this.btn_voltar.TabIndex = 5;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // Inscrever
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 353);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_inserir);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Inscrever";
            this.Text = "Inscrever";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdb_nocturno;
        private System.Windows.Forms.RadioButton rdb_diurno;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_loca;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.RadioButton rdb_feminino;
        private System.Windows.Forms.RadioButton rdb_masculino;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.DateTimePicker dt_dataNasc;
        private System.Windows.Forms.ComboBox cbx_cruso;
    }
}