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
    public partial class CustMain : MaterialForm
    {
        const int UC_ADD_CUST = "UcAddCust";
        public CustMain()
        {
            InitializeComponent();
            centerLayout.
        }

        private void custAddDataBtn_Click(object sender, EventArgs e)
        {

        }

        private void orderAddData_Click(object sender, EventArgs e)
        {

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
