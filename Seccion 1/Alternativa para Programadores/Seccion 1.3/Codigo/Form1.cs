using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TautologiaContingenciaContradiccion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rb12_CheckedChanged(object sender, EventArgs e)
        {
            lbl11.Visible = true;
            lbl12.Visible = true;
            lbl21.Visible = false;
            lbl22.Visible = false;
        }

        private void rb23_CheckedChanged(object sender, EventArgs e)
        {
            lbl11.Visible = false;
            lbl12.Visible = false;
            lbl21.Visible = true;
            lbl22.Visible = true;
        }

        private void rbNo_CheckedChanged(object sender, EventArgs e)
        {
            lbl11.Visible = false;
            lbl12.Visible = false;
            lbl21.Visible = false;
            lbl22.Visible = false;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
                lblP.Text =(checkBox1.Checked) ? "np" : "p";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            lblQ.Text = (checkBox2.Checked) ? "nq" : "q";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            lblR.Text = (checkBox3.Checked) ? "nr" : "r";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbP.SelectedIndex = 0;
            cbQ.SelectedIndex = 0;
            cbR.SelectedIndex = 0;
            cbOperacion1.SelectedIndex = 0;
            cbOperacion2.SelectedIndex = 0;
        }

        private void Operar_Click(object sender, EventArgs e)
        {
            Operaciones operaciones = new Operaciones();
            Variable P = new Variable(checkBox1.Checked, cbP.Text);
            Variable Q = new Variable(checkBox2.Checked, cbQ.Text);
            Variable R = new Variable(checkBox3.Checked, cbR.Text);
            Variable Resultado = new Variable(false);
            if (rb12.Checked)
                Resultado = operaciones.DevolverParentesis(
                    operaciones.DevolverParentesis(P, Q, cbOperacion1.SelectedIndex), R, cbOperacion2.SelectedIndex);
            if (rb23.Checked)
                Resultado = operaciones.DevolverParentesis(P,
                    operaciones.DevolverParentesis(Q, R, cbOperacion2.SelectedIndex), cbOperacion1.SelectedIndex);
            if(rbNo.Checked)
                Resultado = operaciones.DevolverParentesis(
                    operaciones.DevolverParentesis(P, Q, cbOperacion1.SelectedIndex), R, cbOperacion2.SelectedIndex);
            if(Resultado.Retorno())
                MessageBox.Show("Verdadero!");
            else
                MessageBox.Show("Falso!");
        }
    }
}
