﻿using System;
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
    public partial class Menu : Form
    {
        private static bool flag = false;

        public Menu()
        {
            InitializeComponent();
            if (!flag)
            {
                lerFich();
                flag = true;
            }
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


        


        public static void lerFich()
        {
            if (File.Exists(@"concorrentes.txt"))
            {
                StreamReader sr = new StreamReader(@"concorrentes.txt");
                while (!sr.EndOfStream)
                {
                    string linha = sr.ReadLine();
                    string[] divisao = linha.Split('|');
                    Concorrente c = new Concorrente(divisao[0], divisao[1], divisao[2], DateTime.Parse(divisao[3]), divisao[4], divisao[5]);
                    Inscrever.listaConcorrentes.Add(c);
                }
                sr.Close();
            }
        }

        }
    }
