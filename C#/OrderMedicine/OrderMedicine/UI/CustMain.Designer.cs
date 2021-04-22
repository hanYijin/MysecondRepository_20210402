
namespace OrderMedicine.UI
{
    partial class CustMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.custMainExit = new Sunny.UI.UISymbolButton();
            this.topLayout = new System.Windows.Forms.Panel();
            this.leftLayout = new System.Windows.Forms.Panel();
            this.centerLayout = new System.Windows.Forms.Panel();
            this.custAddDataBtn = new Sunny.UI.UIHeaderButton();
            this.orderAddData = new Sunny.UI.UIHeaderButton();
            this.orderDataView = new Sunny.UI.UIHeaderButton();
            this.custMainClose = new Sunny.UI.UIHeaderButton();
            this.leftLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // custMainExit
            // 
            this.custMainExit.BackColor = System.Drawing.Color.Transparent;
            this.custMainExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custMainExit.FillColor = System.Drawing.Color.DarkRed;
            this.custMainExit.FillDisableColor = System.Drawing.Color.Transparent;
            this.custMainExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custMainExit.Location = new System.Drawing.Point(867, 29);
            this.custMainExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.custMainExit.Name = "custMainExit";
            this.custMainExit.RectColor = System.Drawing.Color.Transparent;
            this.custMainExit.Size = new System.Drawing.Size(31, 31);
            this.custMainExit.Style = Sunny.UI.UIStyle.Custom;
            this.custMainExit.Symbol = 61453;
            this.custMainExit.SymbolSize = 30;
            this.custMainExit.TabIndex = 4;
            // 
            // topLayout
            // 
            this.topLayout.BackColor = System.Drawing.Color.Transparent;
            this.topLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.topLayout.Location = new System.Drawing.Point(0, 0);
            this.topLayout.Name = "topLayout";
            this.topLayout.Size = new System.Drawing.Size(910, 60);
            this.topLayout.TabIndex = 8;
            // 
            // leftLayout
            // 
            this.leftLayout.BackColor = System.Drawing.Color.Transparent;
            this.leftLayout.Controls.Add(this.custMainClose);
            this.leftLayout.Controls.Add(this.orderDataView);
            this.leftLayout.Controls.Add(this.orderAddData);
            this.leftLayout.Controls.Add(this.custAddDataBtn);
            this.leftLayout.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftLayout.Location = new System.Drawing.Point(0, 60);
            this.leftLayout.Name = "leftLayout";
            this.leftLayout.Size = new System.Drawing.Size(196, 535);
            this.leftLayout.TabIndex = 9;
            // 
            // centerLayout
            // 
            this.centerLayout.BackColor = System.Drawing.Color.Transparent;
            this.centerLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerLayout.Location = new System.Drawing.Point(196, 60);
            this.centerLayout.Name = "centerLayout";
            this.centerLayout.Size = new System.Drawing.Size(714, 535);
            this.centerLayout.TabIndex = 10;
            // 
            // custAddDataBtn
            // 
            this.custAddDataBtn.CircleColor = System.Drawing.Color.Transparent;
            this.custAddDataBtn.CircleSize = 100;
            this.custAddDataBtn.FillColor = System.Drawing.Color.SteelBlue;
            this.custAddDataBtn.FillHoverColor = System.Drawing.Color.LightCoral;
            this.custAddDataBtn.FillSelectedColor = System.Drawing.Color.Salmon;
            this.custAddDataBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custAddDataBtn.Location = new System.Drawing.Point(0, 3);
            this.custAddDataBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.custAddDataBtn.Name = "custAddDataBtn";
            this.custAddDataBtn.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.custAddDataBtn.Radius = 0;
            this.custAddDataBtn.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.custAddDataBtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.custAddDataBtn.Size = new System.Drawing.Size(196, 145);
            this.custAddDataBtn.Style = Sunny.UI.UIStyle.Custom;
            this.custAddDataBtn.Symbol = 62142;
            this.custAddDataBtn.TabIndex = 0;
            this.custAddDataBtn.Text = "고객 정보 추가";
            this.custAddDataBtn.Click += new System.EventHandler(this.custAddDataBtn_Click);
            // 
            // orderAddData
            // 
            this.orderAddData.CircleColor = System.Drawing.Color.Transparent;
            this.orderAddData.CircleSize = 100;
            this.orderAddData.FillColor = System.Drawing.Color.SteelBlue;
            this.orderAddData.FillHoverColor = System.Drawing.Color.LightCoral;
            this.orderAddData.FillPressColor = System.Drawing.Color.Salmon;
            this.orderAddData.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.orderAddData.Location = new System.Drawing.Point(0, 154);
            this.orderAddData.MinimumSize = new System.Drawing.Size(1, 1);
            this.orderAddData.Name = "orderAddData";
            this.orderAddData.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.orderAddData.Radius = 0;
            this.orderAddData.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.orderAddData.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.orderAddData.Size = new System.Drawing.Size(196, 145);
            this.orderAddData.Style = Sunny.UI.UIStyle.Custom;
            this.orderAddData.Symbol = 57365;
            this.orderAddData.TabIndex = 1;
            this.orderAddData.Text = "주문 정보 추가";
            this.orderAddData.Click += new System.EventHandler(this.orderAddData_Click);
            // 
            // orderDataView
            // 
            this.orderDataView.CircleColor = System.Drawing.Color.Transparent;
            this.orderDataView.CircleSize = 100;
            this.orderDataView.FillColor = System.Drawing.Color.SteelBlue;
            this.orderDataView.FillHoverColor = System.Drawing.Color.LightCoral;
            this.orderDataView.FillPressColor = System.Drawing.Color.Salmon;
            this.orderDataView.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.orderDataView.Location = new System.Drawing.Point(0, 305);
            this.orderDataView.MinimumSize = new System.Drawing.Size(1, 1);
            this.orderDataView.Name = "orderDataView";
            this.orderDataView.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.orderDataView.Radius = 0;
            this.orderDataView.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.orderDataView.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.orderDataView.Size = new System.Drawing.Size(196, 145);
            this.orderDataView.Style = Sunny.UI.UIStyle.Custom;
            this.orderDataView.Symbol = 104;
            this.orderDataView.TabIndex = 2;
            this.orderDataView.Text = "주문 내역 조회";
            this.orderDataView.Click += new System.EventHandler(this.orderDataView_Click);
            // 
            // custMainClose
            // 
            this.custMainClose.CircleColor = System.Drawing.Color.Transparent;
            this.custMainClose.FillColor = System.Drawing.Color.LightSeaGreen;
            this.custMainClose.FillHoverColor = System.Drawing.Color.IndianRed;
            this.custMainClose.FillSelectedColor = System.Drawing.Color.IndianRed;
            this.custMainClose.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custMainClose.Location = new System.Drawing.Point(0, 456);
            this.custMainClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.custMainClose.Name = "custMainClose";
            this.custMainClose.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.custMainClose.Radius = 0;
            this.custMainClose.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.custMainClose.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.custMainClose.Size = new System.Drawing.Size(196, 79);
            this.custMainClose.Style = Sunny.UI.UIStyle.Custom;
            this.custMainClose.TabIndex = 3;
            this.custMainClose.Text = "종료";
            this.custMainClose.Click += new System.EventHandler(this.custMainClose_Click);
            // 
            // CustMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 595);
            this.Controls.Add(this.centerLayout);
            this.Controls.Add(this.leftLayout);
            this.Controls.Add(this.topLayout);
            this.Controls.Add(this.custMainExit);
            this.Name = "CustMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "customer";
            this.leftLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolButton custMainExit;
        private System.Windows.Forms.Panel topLayout;
        private System.Windows.Forms.Panel leftLayout;
        private System.Windows.Forms.Panel centerLayout;
        private Sunny.UI.UIHeaderButton custMainClose;
        private Sunny.UI.UIHeaderButton orderDataView;
        private Sunny.UI.UIHeaderButton orderAddData;
        private Sunny.UI.UIHeaderButton custAddDataBtn;
    }
}