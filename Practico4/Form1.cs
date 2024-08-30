using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico4
{
    public partial class Form1 : Form
    {
        private bool isTextBox1MessageShown = false;
        private bool isTextBox2MessageShown = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Ambos campos deben estar llenos.");
                return;
            }

            if (!int.TryParse(textBox1.Text, out int startValue) || !int.TryParse(textBox2.Text, out int endValue))
            {
                MessageBox.Show("Ambos campos deben contener solo números.");
                return;
            }

           
            textBox3.Clear();
            chart1.Series["Series1"].Points.Clear();

            for (int i = startValue; i <= endValue; i++)
            {
                textBox3.AppendText(i.ToString() + Environment.NewLine);
                chart1.Series["Series1"].Points.AddXY(i, i); 
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out _))
            {
                if (!isTextBox1MessageShown)
                {
                    MessageBox.Show("Este campo solo acepta números.");
                    isTextBox1MessageShown = true; 
                }
                textBox1.Clear();
            }
            else
            {
                isTextBox1MessageShown = false; 
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox2.Text, out _))
            {
                if (!isTextBox2MessageShown)
                {
                    MessageBox.Show("Este campo solo acepta números.");
                    isTextBox2MessageShown = true; 
                }
                textBox2.Clear();
            }
            else
            {
                isTextBox2MessageShown = false; 
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void FunPar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Ambos campos deben estar llenos.");
                return;
            }

            if (!int.TryParse(textBox1.Text, out int startValue) || !int.TryParse(textBox2.Text, out int endValue))
            {
                MessageBox.Show("Ambos campos deben contener solo números.");
                return;
            }

            
            textBox3.Clear();
            chart1.Series["Series1"].Points.Clear();

          
            for (int i = startValue; i <= endValue; i++)
            {
                if (i % 2 == 0) 
                {
                    textBox3.AppendText(i.ToString() + Environment.NewLine);
                    chart1.Series["Series1"].Points.AddXY(i, i); 
                }
            }
        }

      
        private void FunImpar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Ambos campos deben estar llenos.");
                return;
            }

            if (!int.TryParse(textBox1.Text, out int startValue) || !int.TryParse(textBox2.Text, out int endValue))
            {
                MessageBox.Show("Ambos campos deben contener solo números.");
                return;
            }

            
            textBox3.Clear();
            chart1.Series["Series1"].Points.Clear();

            for (int i = startValue; i <= endValue; i++)
            {
                if (i % 2 != 0) /
                {
                    textBox3.AppendText(i.ToString() + Environment.NewLine);
                    chart1.Series["Series1"].Points.AddXY(i, i); 
                }
            }
        }

      
        private void FunPrim_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Ambos campos deben estar llenos.");
                return;
            }

        
            if (!int.TryParse(textBox1.Text, out int startValue) || !int.TryParse(textBox2.Text, out int endValue))
            {
                MessageBox.Show("Ambos campos deben contener solo números.");
                return;
            }

       
            textBox3.Clear();
            chart1.Series["Series1"].Points.Clear();

            for (int i = startValue; i <= endValue; i++)
            {
                if (IsPrime(i)) 
                {
                    textBox3.AppendText(i.ToString() + Environment.NewLine);
                    chart1.Series["Series1"].Points.AddXY(i, i); 
                }
            }
        }

        private bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        private void chart1_Click(object sender, EventArgs e)
        {
           
            chart1.Series["Series1"].Points.Clear(); 
            MessageBox.Show("Has hecho clic en el gráfico.", "Evento Click", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
