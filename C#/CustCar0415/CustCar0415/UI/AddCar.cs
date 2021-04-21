using CustCar0415.Model;
using MaterialSkin.Controls;
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
    public partial class AddCar : MaterialForm
    {
        private string model;
        private string campany;
        private string color;
        private string price;

        public AddCar()
        {
            InitializeComponent();
            
        }

        private void addCarOK_Click(object sender, EventArgs e)
        {

        }

        private void addCarCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            model= showCarCombo(sender);
            infoModel.Text = model;
            infoModel.ForeColor = Color.Red;
            switch (model)
            {
                case "마세라티":
                    pictureBox1.Image = Properties.Resources.ma_f;
                    pictureBox2.Image = Properties.Resources.ma_b;
                    pictureBox3.Image = Properties.Resources.ma_s;
                    pictureBox4.Image = Properties.Resources.ma_i;
                    break;
                case "제규어":
                    pictureBox1.Image = Properties.Resources.je_f;
                    pictureBox2.Image = Properties.Resources.je_b;
                    pictureBox3.Image = Properties.Resources.ma_s;
                    pictureBox4.Image = Properties.Resources.je_i;
                    break;
                case "제네시스":
                    pictureBox1.Image = Properties.Resources.ge_f;
                    pictureBox2.Image = Properties.Resources.ge_b;
                    pictureBox3.Image = Properties.Resources.ge_s;
                    pictureBox4.Image = Properties.Resources.ge_i;
                    break;
            }
        }

        private void comboCampany_SelectedIndexChanged(object sender, EventArgs e)
        {
            campany=showCarCombo(sender);
            infoCanpany.Text = model;
            infoCanpany.ForeColor = Color.Red;
        }

        private void comboColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            color=showCarCombo(sender);
            infoColor.Text = model;
            infoColor.ForeColor = Color.Red;
        }

        private void comboPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            price=showCarCombo(sender);
            infoPrice.Text = model;
            infoPrice.ForeColor = Color.Red;
        }
        private string showCarCombo(object obj)
        {
            Sunny.UI.UIComboBox cb = obj as Sunny.UI.UIComboBox;
            Console.WriteLine("index: " + cb.SelectedIndex);
            string item = cb.SelectedItem.ToString();
            if(cb.SelectedIndex>-1)
            {
                Console.WriteLine("선택: " + item);
              
            }return item;
        }

        private void infoModel_Click(object sender, EventArgs e)
        {

        }

        private void infoCanpany_Click(object sender, EventArgs e)
        {

        }

        private void infoColor_Click(object sender, EventArgs e)
        {

        }

        private void infoPrice_Click(object sender, EventArgs e)
        {

        }

        private void AddCar_Load(object sender, EventArgs e)
        {

        }
    }
}
