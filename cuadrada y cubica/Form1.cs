using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cuadrada_y_cubica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                double valor1;
                double resultado = 0;

                valor1 = Convert.ToDouble(textBox1.Text);

                resultado = Math.Sqrt(valor1);
                textBox3.Text = resultado.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("error");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double valor1;
                double resultado = 0;

                valor1 = Convert.ToDouble(textBox2.Text);

                resultado = Math.Pow(valor1, (1.0 / 3.0));
                textBox4.Text = resultado.ToString();
            }
             catch (Exception)
            {
                MessageBox.Show("error"); 
            }   
        }
    }
}
