using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            listarBox();
        }

        private void listarBox()
        {
            foreach (Concorrente c in Inscrever.listaConcorrentes)
            {
                lsb_listar.Items.Add(c.ToString2list());
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Btn_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu mainMenu = new Menu();
            mainMenu.Show();
        }
    }
}
