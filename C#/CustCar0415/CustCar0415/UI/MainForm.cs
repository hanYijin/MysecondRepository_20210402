using CustCar0415.Controll;
using CustCar0415.Util;
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

namespace CustCar0415
{
    public partial class MainWin : MaterialForm //자식 : 부모 => 상속관계
    {
        MyMenu menu = new MyMenu();
        UnionControll uHandler = new UnionControll(new RandData());
        public MainWin()
        {
            InitializeComponent();//form 초기화

        }
        private void mainExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("고객차량관리앱 v1.0\n" + "2021년 04월 15일 by 한이진");
        }

        private void randAddBtn_Click(object sender, EventArgs e)
        {
            uHandler.CarHandle.insrtRandData(menu.getRandSize());
            uHandler.CustHandle.insrtRandCust(menu.getRandSize());
            uHandler.SellHandle.insertRandSeller(menu.getRandSize());
        }

        private void randDelBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void dataALLBtn_Click(object sender, EventArgs e)
        {

        }

        private void dataAddBtn_Click(object sender, EventArgs e)
        {

        }

        private void dataUpdateBtn_Click(object sender, EventArgs e)
        {

        }

        private void dataDelBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
