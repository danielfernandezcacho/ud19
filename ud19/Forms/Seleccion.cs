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
    public partial class Seleccion : Form
    {
        public Seleccion()
        {
            InitializeComponent();
            label1.Text = "Clique en el ejercicio que quieras ejecutar: ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Estás seguro? No te conviene entrar aquí...");

            
           // Application.Run(new Form1());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Estás seguro? No te conviene entrar aquí...");
           // Application.Run(new ej3());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Estás seguro? No te conviene entrar aquí...");
            Ejercicio4 ejercicio4 = new Ejercicio4();
            ejercicio4.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Estás seguro? No te conviene entrar aquí...");
            Ejercicio2 ejercicio2 = new Ejercicio2();
            
            ejercicio2.ShowDialog();
        }
    }
}
