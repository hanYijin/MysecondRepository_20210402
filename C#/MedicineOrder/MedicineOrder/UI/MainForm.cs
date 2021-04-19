﻿using MaterialSkin.Controls;
using MedicineOrder.Controll;
using MedicineOrder.UI;
using MedicineOrder.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicineOrder
{
    public partial class MainForm : MaterialForm
    {
        MedicineData data = new MedicineData();
            
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AddForm().ShowDialog();
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            
            MediControll mediControll = new MediControll();
            mediControll.mediView();
            
        }

        private void mainExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void appInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("상비약품 주문 앱 나혼자약산다 v1.0\n" + "2021년 04월 19일 by 한이진");
        }
    }
}
