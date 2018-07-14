using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Compilar_Click(object sender, EventArgs e)
        {
            string Texto = txt_Texto.Text;
            Texto = BorrarEnters(Texto);
            for (int i = Texto.Length; i <= 0; i--)
            {
                string caracter = Texto.Substring(i-1, 1);
                if (caracter == " ")
                    Texto = Texto.Substring(0, i);
                else
                    break;
            }
            if (ValidarIfs(Texto))
                MessageBox.Show("Su codigo es perfectamente compilable", "Felicidades!");
            else
                MessageBox.Show("Su codigo no es compilable", "Error");
        }
        public string BorrarEnters(string Texto)
        {
            Texto = Texto.Replace(Environment.NewLine, " ");
            return Texto;
        }

        public bool ValidarIfs(string Texto)
        {
            if (Texto.StartsWith("IF "))
            {
                Texto = Texto.Substring(3, Texto.Length - 3);
                return ValidarOperacionLogica(Texto);
            }
            else
                return false;
        }

        public bool ValidarOperacionLogica(string Texto)
        {
            Inteligente inte = ValidarVariables(Texto);
            if (inte.LaVerdad)
            {
                Texto = inte.Texto;
                inte = ValidarOperadores(Texto);
                if (inte.LaVerdad)
                {
                    Texto = inte.Texto;
                    inte = ValidarVariables(Texto);
                    if (inte.LaVerdad)
                    {
                        Texto = inte.Texto;
                        return ValidarThen(Texto);
                    }
                }
            }
            return false;
        }
        public struct Inteligente
        {
            public string Texto;
            public bool LaVerdad;
        }
        public bool ValidarQueNoSeaEstructuraLogica(string Texto)
        {
            if(Texto.StartsWith("IF"))
                return false;
            if(Texto.StartsWith("ELSE"))
                return false;
            if (Texto.StartsWith("THEN"))
                return false;
            return true;
        }
        public bool ValidarQueNoSeaOperador(string Texto)
        {
            Inteligente inte = ValidarOperadores(Texto);
            if (inte.LaVerdad)
                return false;
            return true;
        }
        public Inteligente ValidarVariables(string Texto)
        {
            Inteligente inte;
            inte.Texto = "";
            if (ValidarQueNoSeaEstructuraLogica(Texto))
            {
                if (ValidarQueNoSeaOperador(Texto))
                {
                    int i = 0;
                    while (i < Texto.Length)
                    {
                        string caracter = Texto.Substring(i, 1);
                        i++;
                        if (caracter == " ")
                            break;
                        
                    }
                    inte.Texto = Texto.Substring(i, Texto.Length - i);
                    inte.LaVerdad = true;
                }
                else
                    inte.LaVerdad = false;
            }
            else
                inte.LaVerdad = false;
            return inte;
        }
        public bool ValidarQueSeaOperador(string Texto)
        {
            if (Texto.StartsWith("< "))
                return true;
            if (Texto.StartsWith("> "))
                return true;
            if (Texto.StartsWith("! "))
                return true;
            if (Texto.StartsWith("= "))
                return true;
            if (Texto.StartsWith("<= "))
                return true;
            if (Texto.StartsWith(">= "))
                return true;
            return false;
        }
        public Inteligente ValidarOperadores(string Texto)
        {
            Inteligente inte;
            inte.Texto = "";
            if (ValidarQueNoSeaEstructuraLogica(Texto))
            {
                if (ValidarQueSeaOperador(Texto))
                {
                    int i = 0;
                    while (i < Texto.Length)
                    {
                        string caracter = Texto.Substring(i, 1);
                        i++;
                        if (caracter == " ")
                            break;
                    }
                    inte.Texto = Texto.Substring(i, Texto.Length - i );
                    inte.LaVerdad = true;
                }
                else
                    inte.LaVerdad = false;
            }
            else
                inte.LaVerdad = false;
            return inte;
        }
        public bool ValidarElse(string Texto)
        {
            if (Texto.StartsWith("ELSE "))
            {
                Texto = Texto.Substring(5, Texto.Length - 5);
                if (Texto.StartsWith("IF"))
                    return ValidarIfs(Texto);
                Inteligente inte = ValidarVariables(Texto);
                if (inte.LaVerdad)
                {
                    Texto = inte.Texto;
                    if (ValidarQueTodaviaHayCodigo(Texto))
                    {
                        if (Texto.StartsWith("IF"))
                            return ValidarIfs(Texto);
                    }
                    return true;
                }
            }
            return false;

        }
        public bool ValidarQueTodaviaHayCodigo(string Texto)
        {
            if (Texto.Length == 0)
                return false;
            return true;
        }
        public bool ValidarThen(string Texto)
        {
            if (Texto.StartsWith("THEN "))
            {
                Texto = Texto.Substring(5, Texto.Length - 5);
                if (Texto.StartsWith("IF"))
                    return ValidarIfs(Texto);
                Inteligente inte = ValidarVariables(Texto);
                if (inte.LaVerdad)
                {
                    Texto = inte.Texto;
                    //MessageBox.Show(inte.Texto,inte.Texto.Length.ToString());
                    if (ValidarQueTodaviaHayCodigo(Texto))
                    {
                        if (Texto.StartsWith("IF"))
                            return ValidarIfs(Texto);
                        if (Texto.StartsWith("ELSE"))
                            return ValidarElse(Texto);
                    }
                    return true;
                }
            }
            return false;
        }


    }
}
