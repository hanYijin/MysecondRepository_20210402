using OrderMedicine.Controll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderMedicine.UI
{
    partial class UcCustOrder : UserControl
    {
        string symptom;
        OrderControll orderControll;
        public UcCustOrder()
        {
            InitializeComponent();
        }
        public UcCustOrder(OrderControll orderControll)
        {
            InitializeComponent();
            this.orderControll = orderControll;
        }
        private void comboHeadache_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboCold_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboStomache_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboMuscle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboSkin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ucCustOrderOk_Click(object sender, EventArgs e)
        {
            if()
        }
    }
}
