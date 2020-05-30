using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace klk
{
    public partial class Form1 : Form
    {
        double value = 0;
        string ops = "";
        bool op_pressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_click(object sender, EventArgs e)
        {
            if ((hasil.Text == "0") || (op_pressed))
            {
                hasil.Clear();
            }
            Button b = (Button)sender;
            hasil.Text = hasil.Text + b.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            ops = b.Text;
            value = Double.Parse(hasil.Text);

            op_pressed = true;
        }

        private void hitung(object sender, EventArgs e)
        {
            switch (ops)
            {
                case "+":
                    hasil.Text = (value + Double.Parse(hasil.Text)).ToString();
                    break;
                case "-":
                    hasil.Text = (value - Double.Parse(hasil.Text)).ToString();
                    break;
                case "x":
                    hasil.Text = (value * Double.Parse(hasil.Text)).ToString();
                    break;
                case "÷":
                    hasil.Text = (value / Double.Parse(hasil.Text)).ToString();
                    break;
            }
        }

        private void bersih(object sender, EventArgs e)
        {
            hasil.Text = "0";
        }

        private void bspace(object sender, EventArgs e)
        {
            hasil.Text = hasil.Text.Remove(hasil.Text.Length - 1, 1);
        }

        private void keluar(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void plusminus(object sender, EventArgs e)
        {
            if (hasil.Text.Contains("-"))

                hasil.Text = hasil.Text.Remove(0, 1);
            else

                hasil.Text = "-" + hasil.Text;
        }
    }
}
