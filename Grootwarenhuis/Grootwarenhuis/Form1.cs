﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grootwarenhuis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnVerder_Click(object sender, EventArgs e)
        {
            if(RbFood.Checked==true)
            {
                Form2 f2 = new Form2();
                f2.Show();
            }
            else
            {
                Form3 f3 = new Form3();
                f3.Show();
            }
        }
    }
}
