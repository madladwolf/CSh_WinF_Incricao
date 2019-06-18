namespace CSh_WinF_Incricao
{
    partial class Listar
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
            this.lsb_listar = new System.Windows.Forms.ListBox();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsb_listar
            // 
            this.lsb_listar.FormattingEnabled = true;
            this.lsb_listar.Location = new System.Drawing.Point(13, 13);
            this.lsb_listar.Name = "lsb_listar";
            this.lsb_listar.Size = new System.Drawing.Size(235, 264);
            this.lsb_listar.TabIndex = 0;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(13, 284);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(235, 23);
            this.btn_voltar.TabIndex = 1;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            // 
            // Listar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 329);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.lsb_listar);
            this.Name = "Listar";
            this.Text = "Listar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsb_listar;
        private System.Windows.Forms.Button btn_voltar;
    }
}