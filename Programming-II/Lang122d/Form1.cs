﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lang122d
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int countTrailingZeros(int x)
        {
            int count = 0;
            while ((x & 1) == 0){
                x = x >> 1;
                count++;
            }
            return count;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            double lcv = -12; listBox1.Items.Add("x :\t\ty :");
            while (lcv <= 16)
            {
                double y = Math.Round((Math.Pow(lcv, 6)) + 
                            (-3 * Math.Pow(lcv, 5)) + 
                            (-93 * Math.Pow(lcv, 4)) + 
                            (87 * Math.Pow(lcv, 3)) + 
                            (1596 * Math.Pow(lcv, 2)) + 
                            (-1380 * lcv) + (-2800), 1);
                if (y <= 999999) listBox1.Items.Add(lcv + "\t\t" + y);
                else listBox1.Items.Add(lcv + "\t\t" + y + "e+06");
             lcv++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
