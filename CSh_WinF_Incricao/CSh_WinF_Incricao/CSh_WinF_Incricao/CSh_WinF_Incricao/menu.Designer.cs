namespace CSh_WinF_Incricao
{
    partial class Menu
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
            this.btn_inscrever = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_listar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_inscrever
            // 
            this.btn_inscrever.Location = new System.Drawing.Point(12, 12);
            this.btn_inscrever.Name = "btn_inscrever";
            this.btn_inscrever.Size = new System.Drawing.Size(139, 72);
            this.btn_inscrever.TabIndex = 0;
            this.btn_inscrever.Text = "Increver";
            this.btn_inscrever.UseVisualStyleBackColor = true;
            this.btn_inscrever.Click += new System.EventHandler(this.btn_inscrever_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(12, 204);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(139, 23);
            this.btn_sair.TabIndex = 2;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_listar
            // 
            this.btn_listar.Location = new System.Drawing.Point(12, 90);
            this.btn_listar.Name = "btn_listar";
            this.btn_listar.Size = new System.Drawing.Size(139, 72);
            this.btn_listar.TabIndex = 3;
            this.btn_listar.Text = "Listar";
            this.btn_listar.UseVisualStyleBackColor = true;
            this.btn_listar.Click += new System.EventHandler(this.btn_listar_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(166, 239);
            this.Controls.Add(this.btn_listar);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_inscrever);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_inscrever;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_listar;
    }
}

