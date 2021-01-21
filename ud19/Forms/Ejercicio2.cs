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
    public partial class Ejercicio2 : Form
    {

        private string pelicula = "";
        List<string> listaPeliculas;
        public Ejercicio2()
        {
            InitializeComponent();

            label1.Text = "Escribe el titulo de una pelicula";
            label2.Text = "Peliculas";
            button1.Text = "Añadir";

        }

        /// <summary>
        /// Boton añadir pelicula a la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
             pelicula = textBox1.Text;
            comboBox1.Items.Add(pelicula);

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
