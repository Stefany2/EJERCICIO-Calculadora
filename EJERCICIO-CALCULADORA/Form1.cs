using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIO_CALCULADORA
{
    public partial class Form1 : Form
    {
        private double valor1;
        private double valor2;

        private double resultado;

        private int operacion;
        public Form1()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // boton numero 1
            tbDisplay.Text = tbDisplay.Text + "1";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            // boton cero
            tbDisplay.Text = tbDisplay.Text + "0";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            // boton punto
            tbDisplay.Text = tbDisplay.Text + ".";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            // boton igual
            valor2 = Convert.ToDouble(tbDisplay.Text);
            // Verificar si el divisor es cero
            if (operacion == 4 && valor2 == 0)
            {
                MessageBox.Show("No se puede dividir entre cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir de la función sin realizar la división
            }
            switch (operacion)
            {
                case 1:
                    resultado = valor1 + valor2;
                    break;
                case 2:
                    resultado = valor1 - valor2;
                break;
                case 3:
                    resultado = valor1 * valor2;
                break;
                    case 4:
                    resultado = valor1 / valor2;
                    break;
                }
                tbDisplay.Text = resultado.ToString();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            // boton resta
            operacion = 2;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            // boton multiplicación
            operacion = 3;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            // boton división
            operacion = 4;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            // boton numero 2
            tbDisplay.Text = tbDisplay.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            // boton numero 3
            tbDisplay.Text = tbDisplay.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            // boton numero 4
            tbDisplay.Text = tbDisplay.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            // boton numero 5
            tbDisplay.Text = tbDisplay.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            // boton numero 6
            tbDisplay.Text = tbDisplay.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            // boton numero 7
            tbDisplay.Text = tbDisplay.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            // boton numero 8
            tbDisplay.Text = tbDisplay.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            // boton numero 9
            tbDisplay.Text = tbDisplay.Text + "9";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            // boton Suma
            operacion = 1;
                valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // boton de limpiar 
            tbDisplay.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
    }
    }
}
