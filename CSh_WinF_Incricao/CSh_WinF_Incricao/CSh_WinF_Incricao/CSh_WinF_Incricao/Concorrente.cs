using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSh_WinF_Incricao
{
    public class Concorrente
    {
        public string Curso { get; set; }
        public string ParteDia { get; set; }
        public string Nome { get; set; }
        public string DataNasc { get; set; }
        public string Loc { get; set; }
        public string Sexo { get; set; }

        public Concorrente() { }
        public Concorrente(string c, string p, string n, string dN, string l, string s)
        {
            Curso = c; ParteDia = p; Nome = n; DataNasc = dN; Loc = l; Sexo = s;
        }
        public Concorrente(Concorrente c)
        {
            Curso = c.Curso; ParteDia = c.ParteDia; Nome = c.Nome; DataNasc = c.DataNasc; Loc = c.Loc; Sexo = c.Sexo;
        }

        public override string ToString()
        {
            return Curso + " " + ParteDia + " " + Nome + " " + DataNasc + " " + Loc + " " + Sexo;
        }
        public string ToString2list()
        {
            return Nome + " | " + "Curso: " + Curso + " | " + "Parte do Dia: " + ParteDia + " | " + "Data Nascimento: " + DataNasc + " | " + "Localidade: " + Loc + " | " + "Sexo: " + Sexo;
        }
    }
}
