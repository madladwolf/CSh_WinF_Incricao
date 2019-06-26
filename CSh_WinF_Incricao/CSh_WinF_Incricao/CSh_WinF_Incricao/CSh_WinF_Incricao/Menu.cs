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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_inscrever_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inscrever inscrever = new Inscrever();
            inscrever.Show();
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Listar listar = new Listar();
            listar.Show();
        }

        //Close when X pressed
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
