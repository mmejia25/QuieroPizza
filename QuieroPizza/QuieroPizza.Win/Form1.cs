﻿using QuieroPizza.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuieroPizza.Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var productosBL = new ProductosBL();
            var ListadeProductos = productosBL.Obtener();

            listadeproductosBindingSource.DataSource = ListadeProductos;
        }


        private void productosBLBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
