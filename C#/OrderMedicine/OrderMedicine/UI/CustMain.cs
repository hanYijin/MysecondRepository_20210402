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

namespace OrderMedicine.UI
{
     partial class CustMain : MaterialForm
    {
        const string UC_ADD_CUST = "UcAddCust";
        const string UC_ADD_CUSTORDER = "UcCustOrder";

        UcAddCust ucAddCust;
        UcCustOrder ucCustOrder;
        public CustMain()
        {
            InitializeComponent();
            ucAddCust = new UcAddCust();
            ucCustOrder = new UcCustOrder();
            centerLayout.Controls.Add(ucAddCust);
            centerLayout.Dock = DockStyle.Fill;
        }

        private void custAddDataBtn_Click(object sender, EventArgs e)
        {
            controllView(ucAddCust, UC_ADD_CUST);
        }

        private void orderAddData_Click(object sender, EventArgs e)
        {
            controllView(ucCustOrder, UC_ADD_CUSTORDER);
        }

        private void orderDataView_Click(object sender, EventArgs e)
        {

        }
        private void controllView(UserControl uc, string view)
        {
            if (!centerLayout.Controls.ContainsKey(view))
            {
                uc.Dock = DockStyle.Fill;
                centerLayout.Controls.Add(uc);
            }
            centerLayout.Controls[view].BringToFront();
        }

        private void custMainClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
