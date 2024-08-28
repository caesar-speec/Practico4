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
        // Variables para controlar si el mensaje ya fue mostrado
        private bool isTextBox1MessageShown = false;
        private bool isTextBox2MessageShown = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verificar que los campos no estén vacíos
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Ambos campos deben estar llenos.");
                return;
            }

            // Verificar que los valores sean numéricos
            if (!int.TryParse(textBox1.Text, out int startValue) || !int.TryParse(textBox2.Text, out int endValue))
            {
                MessageBox.Show("Ambos campos deben contener solo números.");
                return;
            }

            // Limpiar el textBox3 y el gráfico antes de agregar los números
            textBox3.Clear();
            chart1.Series["Series1"].Points.Clear();

            // Generar y mostrar los números en textBox3 y en el gráfico
            for (int i = startValue; i <= endValue; i++)
            {
                textBox3.AppendText(i.ToString() + Environment.NewLine);
                chart1.Series["Series1"].Points.AddXY(i, i); // Añade los números al gráfico
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Verificar que el campo solo contenga números
            if (!int.TryParse(textBox1.Text, out _))
            {
                if (!isTextBox1MessageShown)
                {
                    MessageBox.Show("Este campo solo acepta números.");
                    isTextBox1MessageShown = true; // Marcar que el mensaje ya fue mostrado
                }
                textBox1.Clear();
            }
            else
            {
                isTextBox1MessageShown = false; // Reiniciar la bandera si el valor es válido
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Verificar que el campo solo contenga números
            if (!int.TryParse(textBox2.Text, out _))
            {
                if (!isTextBox2MessageShown)
                {
                    MessageBox.Show("Este campo solo acepta números.");
                    isTextBox2MessageShown = true; // Marcar que el mensaje ya fue mostrado
                }
                textBox2.Clear();
            }
            else
            {
                isTextBox2MessageShown = false; // Reiniciar la bandera si el valor es válido
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Aquí podrías agregar lógica adicional para textBox3 si es necesario
        }

        // Función para mostrar solo los números pares
        private void FunPar_Click(object sender, EventArgs e)
        {
            // Verificar que los campos no estén vacíos
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Ambos campos deben estar llenos.");
                return;
            }

            // Verificar que los valores sean numéricos
            if (!int.TryParse(textBox1.Text, out int startValue) || !int.TryParse(textBox2.Text, out int endValue))
            {
                MessageBox.Show("Ambos campos deben contener solo números.");
                return;
            }

            // Limpiar el textBox3 y el gráfico antes de agregar los números
            textBox3.Clear();
            chart1.Series["Series1"].Points.Clear();

            // Generar y mostrar solo los números pares en textBox3 y en el gráfico
            for (int i = startValue; i <= endValue; i++)
            {
                if (i % 2 == 0) // Verifica si el número es par
                {
                    textBox3.AppendText(i.ToString() + Environment.NewLine);
                    chart1.Series["Series1"].Points.AddXY(i, i); // Añade los números pares al gráfico
                }
            }
        }

        // Función para mostrar solo los números impares
        private void FunImpar_Click(object sender, EventArgs e)
        {
            // Verificar que los campos no estén vacíos
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Ambos campos deben estar llenos.");
                return;
            }

            // Verificar que los valores sean numéricos
            if (!int.TryParse(textBox1.Text, out int startValue) || !int.TryParse(textBox2.Text, out int endValue))
            {
                MessageBox.Show("Ambos campos deben contener solo números.");
                return;
            }

            // Limpiar el textBox3 y el gráfico antes de agregar los números
            textBox3.Clear();
            chart1.Series["Series1"].Points.Clear();

            // Generar y mostrar solo los números impares en textBox3 y en el gráfico
            for (int i = startValue; i <= endValue; i++)
            {
                if (i % 2 != 0) // Verifica si el número es impar
                {
                    textBox3.AppendText(i.ToString() + Environment.NewLine);
                    chart1.Series["Series1"].Points.AddXY(i, i); // Añade los números impares al gráfico
                }
            }
        }

        // Función para mostrar solo los números primos
        private void FunPrim_Click(object sender, EventArgs e)
        {
            // Verificar que los campos no estén vacíos
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Ambos campos deben estar llenos.");
                return;
            }

            // Verificar que los valores sean numéricos
            if (!int.TryParse(textBox1.Text, out int startValue) || !int.TryParse(textBox2.Text, out int endValue))
            {
                MessageBox.Show("Ambos campos deben contener solo números.");
                return;
            }

            // Limpiar el textBox3 y el gráfico antes de agregar los números
            textBox3.Clear();
            chart1.Series["Series1"].Points.Clear();

            // Generar y mostrar solo los números primos en textBox3 y en el gráfico
            for (int i = startValue; i <= endValue; i++)
            {
                if (IsPrime(i)) // Verifica si el número es primo
                {
                    textBox3.AppendText(i.ToString() + Environment.NewLine);
                    chart1.Series["Series1"].Points.AddXY(i, i); // Añade los números primos al gráfico
                }
            }
        }

        // Función para verificar si un número es primo
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
            // Aquí puedes añadir la lógica que deseas ejecutar al hacer clic en el gráfico
            chart1.Series["Series1"].Points.Clear(); // Limpia los puntos del gráfico
            MessageBox.Show("Has hecho clic en el gráfico.", "Evento Click", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
