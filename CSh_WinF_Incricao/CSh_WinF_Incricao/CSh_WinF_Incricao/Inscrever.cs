﻿using System;
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
        public Inscrever()
        {
            InitializeComponent();
            btn_inserir.Enabled = false;
        }

        public static List<Concorrente> listaConcorrentes = new List<Concorrente>();
        private string curso;
        private string tempoDia;
        private string nome;
        private DateTime dataNasc;
        private string loc;
        private string sexo;

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            curso = txt_curso.Text;
            if (rdb_diurno.Checked)
            {
                tempoDia = "Diurno";
            }else if (rdb_nocturno.Checked)
            {
                tempoDia = "Nocturno";
            }
            nome = txt_nome.Text;
            dataNasc = DateTime.Parse(dt_dataNasc.Text);
            loc = txt_loca.Text;
            if (rdb_masculino.Checked)
            {
                sexo = "Masculino";
            }else if (rdb_feminino.Checked)
            {
                sexo = "Feminino";
            }
            Concorrente concorrente = new Concorrente(curso, tempoDia, nome, dataNasc, loc, sexo);
            listaConcorrentes.Add(concorrente);
            MessageBox.Show(concorrente.ToString());
            txt_curso.Text = "";
            rdb_diurno.Checked = false;
            rdb_nocturno.Checked = false;
            txt_nome.Text = "";
            dt_dataNasc.Text = "";
            txt_loca.Text = "";
            rdb_feminino.Checked = false;
            rdb_masculino.Checked = false;
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_curso.Text = "";
            rdb_diurno.Checked = false;
            rdb_nocturno.Checked = false;
            txt_nome.Text = "";
            dt_dataNasc.Text = "";
            txt_loca.Text = "";
            rdb_feminino.Checked = false;
            rdb_masculino.Checked = false;
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu mainMenu = new Menu();
            mainMenu.Show();
        }


        //Verificacion of Inputs
        private void Txt_curso_TextChanged(object sender, EventArgs e)
        {
            btn_inserir.Enabled = txt_curso.Text != "" && txt_nome.Text != "" && txt_loca.Text != "";
        }

        private void Txt_nome_TextChanged(object sender, EventArgs e)
        {
            btn_inserir.Enabled = txt_curso.Text != "" && txt_nome.Text != "" && txt_loca.Text != "";
        }

        private void Txt_loca_TextChanged(object sender, EventArgs e)
        {
            btn_inserir.Enabled = txt_curso.Text != "" && txt_nome.Text != "" && txt_loca.Text != "";
        }


    }
}
