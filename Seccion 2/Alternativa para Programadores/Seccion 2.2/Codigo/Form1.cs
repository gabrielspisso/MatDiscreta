using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Discreta2Ejercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] vector = new int[10];
        public void CargarVec(string Conjunto)
        {
            
            bool numeroEnProceso = false;
            int contVector = 0;
            string numero="";
            for (int i = 0; i < Conjunto.Length; i++)
            {
                string caracter = Conjunto.Substring(i, 1).ToString();
                if (caracter == "," || caracter == "}")
                {
                    int aux;
                    if (int.TryParse(numero, out aux))
                    {
                        vector[contVector] = aux;
                        contVector++;
                    }
                    else
                    {
                        MessageBox.Show("Error","El conjunto ingresado no es correcto");
                        break;
                    }
                    numeroEnProceso = false;
                }
                if (caracter != "{")
                {
                    if (caracter != "," && caracter != "}")
                    {
                        if (numeroEnProceso)
                            numero += caracter;
                        else
                        {
                            numeroEnProceso = true;
                            numero = caracter;
                            //MessageBox.Show(numero, "numero");
                        }
                    }
                }
                //MessageBox.Show("", caracter);                
            }
            //MessageBox.Show(contVector.ToString(),"cantidad de elementos");
            if (contVector == 10)
                Ordenar();
            else
                MessageBox.Show("Error", "Se deben ingresar 10 elementos");
        }
        public void Ordenar()
        {
            int aux;
            int contador = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (vector[j] < vector[i])
                    {
                        aux = vector[j];
                        vector[j] = vector[i];
                        vector[i] = vector[j];
                        vector[i] = aux;
                        contador++;
                    }
                }
            }
            Mostrar(contador);
        }
        public void Mostrar(int contador)
        {
            string aux = "{";
            for (int i = 0; i < 9; i++)
			    aux+=vector[i].ToString() + ",";
            aux+=vector[9].ToString() + "}";
            label3.Text=aux;
            label3.Visible=true;
            label6.Text = "Cantidad de pasos: " + contador.ToString();
            label6.Visible = true;
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',') return;
            if (Char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarVec("{" + textBox1.Text + "}");
        }
    }
}
