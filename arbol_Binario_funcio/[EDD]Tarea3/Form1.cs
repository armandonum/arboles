﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace arboles_binarios
{
    public partial class Form1 : Form
    {
        ABB arbol;
        public Form1()
        {
            InitializeComponent();
            arbol = new ABB();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(textBox1.Text) == false)
            {
                arbol.insertar(textBox1.Text);

                textBox2.Text = arbol.inorden();
                textBox3.Text = arbol.preorden();
                textBox4.Text = arbol.postorden();
            }
            textBox1.Focus();
            textBox1.Clear();

           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            arbol.limpiar();

            textBox2.Text = arbol.inorden();
            textBox3.Text = arbol.preorden();
            textBox4.Text = arbol.postorden();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

     

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
