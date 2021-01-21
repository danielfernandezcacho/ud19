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
    public partial class ej3 : Form
    {
        string so = "";
        string espe = "";
        string msgSo = "";
        int horas;
        public ej3()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked)
            {
                so = radioButton1.Text;
            
            }
            
            else if (radioButton2.Checked)
            {
                so = radioButton2.Text;
            }
            
            else if(radioButton3.Checked)
            {
                so = radioButton3.Text;
            }

           
           

            if (checkBox1.Checked)
            {
                espe += checkBox1.Text;
                espe += ", ";
            }

            if (checkBox2.Checked)
            {
                espe += checkBox2.Text;
                espe += ", ";
            }

            if (checkBox3.Checked)
            {
                espe += checkBox3.Text;
            }


            MessageBox.Show("El sistema operativo elegido es: "+so+ " \nLa especialidad escogida es: " + espe + " \nEl total de horas es: " + trackBar1.Value.ToString());

            espe = "";
            so = "";

        }

        private void ej3_Load(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label4.Text = "horas:"+ trackBar1.Value.ToString();
        }
    }
}
