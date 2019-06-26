using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSh_WinF_Incricao
{
    public partial class Listar : Form
    {
        public Listar()
        {
            InitializeComponent();
            PreencheLista();
        }

        private void Lsb_listar_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Btn_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu mainMenu = new Menu();
            mainMenu.Show();
        }

        private void PreencheLista()
        {
            foreach (Concorrente item in Inscrever.listaConcorrentes)
            {
                lsb_listar.Items.Add(item);
            }
            if (Inscrever.listaConcorrentes.Count == 0) lsb_listar.Items.Add("Sem Concorrentes");
        }

        private void Btn_export_Click(object sender, EventArgs e)
        {
            escreveFich();
            MessageBox.Show("Guardado");
        }

        public static void escreveFich()
        {
            StreamWriter wr = new StreamWriter(@"concorrentes.txt", true);
            foreach (Concorrente c in Inscrever.listaConcorrentes)
            {
                wr.WriteLine(c.toStringToFich());
            }
            wr.Close();
        }
    }
}
