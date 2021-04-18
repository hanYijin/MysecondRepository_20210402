
namespace MedicineOrder
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.viewBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.delAllBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(111, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(355, 374);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // viewBtn
            // 
            this.viewBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.viewBtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.viewBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.viewBtn.Location = new System.Drawing.Point(612, 223);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(255, 83);
            this.viewBtn.TabIndex = 1;
            this.viewBtn.Text = "데이터 보기";
            this.viewBtn.UseVisualStyleBackColor = false;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.LightSlateGray;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(612, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(255, 83);
            this.button1.TabIndex = 2;
            this.button1.Text = "데이터 추가";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // delBtn
            // 
            this.delBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.delBtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.delBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.delBtn.Location = new System.Drawing.Point(612, 329);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(255, 83);
            this.delBtn.TabIndex = 5;
            this.delBtn.Text = "데이터 삭제";
            this.delBtn.UseVisualStyleBackColor = false;
            // 
            // delAllBtn
            // 
            this.delAllBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.delAllBtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.delAllBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.delAllBtn.Location = new System.Drawing.Point(612, 539);
            this.delAllBtn.Name = "delAllBtn";
            this.delAllBtn.Size = new System.Drawing.Size(255, 83);
            this.delAllBtn.TabIndex = 6;
            this.delAllBtn.Text = "데이터 초기화";
            this.delAllBtn.UseVisualStyleBackColor = false;
            // 
            // updateBtn
            // 
            this.updateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.updateBtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.updateBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.updateBtn.Location = new System.Drawing.Point(612, 435);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(255, 83);
            this.updateBtn.TabIndex = 7;
            this.updateBtn.Text = "데이터 수정";
            this.updateBtn.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 707);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.delAllBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Text = "나혼자약산다 v1.0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button delAllBtn;
        private System.Windows.Forms.Button updateBtn;
    }
}

