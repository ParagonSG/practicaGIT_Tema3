﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3
{
    public partial class Practica3 : Form
    {
        public Practica3()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = ' ';
            int numPalabras = 0;
            double coste;
            //Leo el telegrama
            textoTelegrama = txtTelegrama.Text;
            // telegrama urgente?
            if (cbUrgente.Checked)
                tipoTelegrama = 'u';
            //Obtengo el número de palabras que forma el telegrama
            numPalabras = textoTelegrama.Length;
            //Si el telegrama es ordinario
            if (tipoTelegrama == 'o')
                if (numPalabras <= 10)
                    coste = 25;
                else
                    coste = 0.5 * numPalabras;
            else
            //Si el telegrama es urgente
            if (tipoTelegrama == 'u')
                if (numPalabras <= 10)
                    coste = 5;
                else
                    coste = 5 + 0.75 * (numPalabras - 10);
            else
                coste = 0;
            txtPrecio.Text = coste.ToString() + " euros";
        }
    }
}
