using CustCar0415.Controll;
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
    public partial class DealView : MaterialForm
    {
        List<Deal<Car, Customer, Seller>> deals = new List<Deal<Car, Customer, Seller>>();
        public DealView(List<Deal<Car, Customer, Seller>> deals)
        {
            InitializeComponent();
            this.deals = deals;
            
        }
        private void DealView_Load(object sender, EventArgs e)
        {
            initDealListView();
        }
        private void initDealListView()
        {
            
            string[] data = { "1", "그랜저", "4천만원", "홍길동", "전우치", "2021년4월16일", "3천8백만원" };
            dealSmListView.Items.Add(new ListViewItem(data));
            for(int i=0; i<50;i++)
            {
                dealSmListView.Items.Add(new ListViewItem(
                    new string[]
                    {
                        (i+2).ToString(),"그랜저","4천만원","홍길동","전우치","2021년04월16일","3천8백만원"
                    }));
            }
            setRowColor(Color.White, Color.LightGray);
            int index = dealSmListView.Items.Count - 1;
            dealSmListView.Items[index].Selected = true;//열 선택
            dealSmListView.Items[index].Focused = true;// 선택 열 포커스 맞춰줌 
            dealSmListView.EnsureVisible(index);
        }
        
        private void dealSmExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void setRowColor(Color color1,Color color2)
        {
            foreach(ListViewItem item in dealSmListView.Items)
            {
                if ((item.Index % 2 == 0))
                {
                    item.BackColor = color1;
                }
                else
                {
                    item.BackColor = color2;
                }
                    
            }
        }

    }
}
