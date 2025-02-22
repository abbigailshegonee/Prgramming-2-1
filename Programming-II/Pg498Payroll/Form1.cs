﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Pg498Payroll
{
    public partial class Form1 : Form
    {
        const decimal decHOURLY_PAY_RATE = 6.0m;
        const int intMAX_EMPLOYEES = 5;
        //"const" prevents us from ever changing the value

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // calculate and display the gross pay earned by employees
            int[] inthours = new int[intMAX_EMPLOYEES];
            //make a new int array of capicity MAX_EMPLOYEES
            //Capacity can never change, unlike lists in python
            int intCount = 0;          // Loop counter
            int intEmpHours = 0;        //Hours
            decimal decEmpPay = 0.0m;   //Gross pay

            //Get the hours worked by the employees
            for (intCount = 0; intCount < intMAX_EMPLOYEES; intCount++)
            {
                while (int.TryParse(
                    Interaction.InputBox("Enter the number of hours worked by employee #" +
                    (intCount+1).ToString(), "Need Hours Worked"),
                    out intEmpHours) == false){
                        MessageBox.Show("Please enter an integer for hours worked");
                }
                inthours[intCount] = intEmpHours;
            }

            //Calculate and display wache employee's gros pay
            listBox1.Items.Clear();
            for (intCount = 0; intCount < intMAX_EMPLOYEES; intCount++)
            {
                decEmpPay = inthours[intCount] * decHOURLY_PAY_RATE;
                listBox1.Items.Add("Employee " + (intCount + 1).ToString() +
                    " earned " + decEmpPay.ToString("$.00"));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
