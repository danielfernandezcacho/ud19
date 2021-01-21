using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ud19
{
    public partial class Ejercicio4 : Form
    {
        double result = 0;
        double tempResult1 = 0;
        double tempResult2 = 0;
        string firstString = "0";
        string operacion = "";

        public Ejercicio4()
        {
            InitializeComponent();
            textBox1.Text = firstString;
        }

        private void AddValueToTextBox(string value)
        {
            if(firstString == "0")
            {             
                firstString = value;
            }
            else
            {
                firstString += value;
            }
            textBox1.Text = firstString;
        }

        #region Botones
        private void button10_Click(object sender, EventArgs e)
        {
            AddValueToTextBox("0");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddValueToTextBox("1");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddValueToTextBox("2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddValueToTextBox("3");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddValueToTextBox("4");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddValueToTextBox("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddValueToTextBox("6");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            AddValueToTextBox("7");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            AddValueToTextBox("8");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            AddValueToTextBox("9");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            AddValueToTextBox(",");
        }

        #endregion
        private void button4_Click(object sender, EventArgs e)
        {
            //SUMA
            tempResult1 = Double.Parse(firstString);
            firstString = "0";
            operacion = button4.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // RESTA
            tempResult1 = Double.Parse(firstString);
            firstString = "0";
            operacion = button13.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //MULTIPLICACION
            tempResult1 = Double.Parse(firstString);
            firstString = "0";
            operacion = button5.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //DIVISION
            tempResult1 = Double.Parse(firstString);
            firstString = "0";
            operacion = button9.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //RESET
           
            firstString = "0";
            textBox1.Text = firstString;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //IGUAL
            tempResult2 = Double.Parse(firstString);

            CalculateResult();

            if (tempResult2 != 0)
            {
                textBox1.Text = result.ToString();
            }
            else
            {
                textBox1.Text = "Math ERROR";
            }
        }

        private void CalculateResult ()
        {
            if (operacion == "+")
            {
                result = tempResult1 + tempResult2;
            }
            else if (operacion == "-")
            {
                result = tempResult1 - tempResult2;
            }
            else if (operacion == "*")
            {
                result = tempResult1 * tempResult2;
            }
            else if (operacion == "/")
            {
                if (tempResult2 != 0)
                {
                    result = tempResult1 / tempResult2;

                }
                else // DIVISION ENTRE 0 no permitida
                {
                    result = 0;
                }
            }
        }
    }
}
