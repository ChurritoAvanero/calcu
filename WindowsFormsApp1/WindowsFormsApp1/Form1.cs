using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double x, y, z;
        string op;
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "8";
        }

        private void Dos_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "2";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "3";
        }

        private void Cuatro_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "4";
        }

        private void Cinco_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "5";
        }

        private void Seis_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "6";
        }

        private void Nueve_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "9";
        }

        private void Multi_Click(object sender, EventArgs e)
        {
            op = "*";
            x = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void Cero_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "0";
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            op = "/";
            x = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            op = "+";
            x = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            op = "-";
            x = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void Button7_Click_1(object sender, EventArgs e)
        {
            Pantalla.Clear();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text.Substring(0, Pantalla.Text.Count() - 1);
        }

        private void Result_Click(object sender, EventArgs e)
        {
            y = double.Parse(Pantalla.Text);
            switch (op)
            {
                case "+":
                    z = x + y;
                    Pantalla.Text = z.ToString();
                    break;
                case "-":
                    z = x - y;
                    Pantalla.Text = z.ToString();
                    break;
                case "/":
                    z = x / y;
                    Pantalla.Text = z.ToString();
                    break;
                case "*":
                    z = x * y;
                    Pantalla.Text = z.ToString();
                    break;
                case "%":
                    z = (x / 100) * y;
                    Pantalla.Text = z.ToString();
                    break;
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (this.Pantalla.Text.Contains('.') == false)
            {
                this.Pantalla.Text = this.Pantalla.Text + ".";
            }
        }

        private void Porce_Click(object sender, EventArgs e)
        {
            op = "%";
            x = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "7";
        }

        private void Uno_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "1";
        }
    }
}
