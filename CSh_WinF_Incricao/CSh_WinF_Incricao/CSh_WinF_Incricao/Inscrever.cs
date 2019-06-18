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
    public partial class Inscrever : Form
    {
        public static List<Concorrente> listaConcorrentes = new List<Concorrente>(); //Tem de ser static para poder ser acedido noutras classes
        public Inscrever()
        {
            InitializeComponent();
            Dictionary<string, string> test = new Dictionary<string, string>();
            test.Add("1", "Eletronica");
            test.Add("2", "Informatica");
            test.Add("3", "Mecanica");
            cbx_cruso.DataSource = new BindingSource(test, null);
            cbx_cruso.DisplayMember = "Value";
            cbx_cruso.ValueMember = "Key";

            // Get combobox selection (in handler)
            curso = ((KeyValuePair<string, string>)cbx_cruso.SelectedItem).Value;

            rdb_feminino.Checked = true;
        }

        
        private string curso;
        private string tempoDia;
        private string nome;
        private string dataNasc;
        private string loc;
        private string sexo;

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            curso = cbx_cruso.Text;
            if (rdb_diurno.Checked)
            {
                tempoDia = "Diurno";
            }else if (rdb_nocturno.Checked)
            {
                tempoDia = "Nocturno";
            }
            nome = txt_nome.Text;
            dataNasc = dt_dataNasc.Value.ToString("yyyy-MM-dd");
            loc = txt_loca.Text;
            if (rdb_masculino.Checked)
            {
                sexo = "Masculino";
            }else if (rdb_feminino.Checked)
            {
                sexo = "Feminino";
            }
            Concorrente c = new Concorrente(curso, tempoDia, nome, dataNasc, loc, sexo);
            listaConcorrentes.Add(c);
            MessageBox.Show(c.ToString());
            btn_limpar_Click(sender, e);
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            cbx_cruso.Text = "";
            rdb_diurno.Checked = true;
            rdb_nocturno.Checked = false;
            txt_nome.Text = "";
            dt_dataNasc.Text = "";
            txt_loca.Text = "";
            rdb_feminino.Checked = true;
            rdb_masculino.Checked = false;
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu mainMenu = new Menu();
            mainMenu.Show();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
