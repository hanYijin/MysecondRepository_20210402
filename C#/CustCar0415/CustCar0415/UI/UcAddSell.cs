using CustCar0415.Controll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustCar0415.UI
{
    partial class UcAddSell : UserControl
    {
        UnionControll uHandler;
        public UcAddSell()
        {
            InitializeComponent();
        }
        public UcAddSell(UnionControll uHandler)
        {
            InitializeComponent();
            this.uHandler = uHandler;
        }

        private void ucAddSellOK_Click(object sender, EventArgs e)
        {

        }

        private void ucAddSellInit_Click(object sender, EventArgs e)
        {

        }
    }
}
