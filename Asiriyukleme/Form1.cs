﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asiriyukleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int toplama(int s1,int s2)
        {
            int sonuc = s1 + s2;
            return sonuc;
        }
        int toplama(int s1,int s2, int s3)
        {
            int sonuc = s1 + s2 + s3;
            return sonuc;
        }
        int toplama(int s1,int s2, int s3, int s4)
        {
            int sonuc = s1 + s2 + s3 + s4;
            return sonuc;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(toplama(5, 8));
            listBox1.Items.Add(toplama(9, 10, 1));
        }
    }
}
