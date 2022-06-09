﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody19_IKAP_ML405
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int Mocnina(int a)
        {
            return a * a;
        }
        public static double Mocnina(int a, int exponent)
        {
            double vysledek = 1;
            if (exponent < 0)
            {
                for (int i = 1; i <= exponent * (-1); ++i)
                {
                    vysledek /= a;
                }
            }
            else
            {
                for (int i = 1; i <= exponent; i++)
                {
                    vysledek *= a;
                }
            }
            return vysledek;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mocnina je: " + Form1.Mocnina(2) +
                "\nCeločíselná mocnina je: " + Form1.Mocnina(4, -2));
        }
    }
}