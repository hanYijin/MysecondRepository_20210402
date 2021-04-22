using MaterialSkin.Controls;
using OrderMedicine.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderMedicine
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void mainExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("상비약품 주문 앱 나혼자약산다 v1.0\n" + "2021년 04월 19일 by 한이진");
        }

        private void custBtn_Click(object sender, EventArgs e)
        {
            new CustMain().ShowDialog();
        }

        private void stoBtn_Click(object sender, EventArgs e)
        {
            new StoMain().ShowDialog();
        }
    }
}
