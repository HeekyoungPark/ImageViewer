namespace ImageViewer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picImg = new System.Windows.Forms.PictureBox();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblNum = new System.Windows.Forms.Label();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).BeginInit();
            this.SuspendLayout();
            // 
            // picImg
            // 
            this.picImg.Location = new System.Drawing.Point(10, 10);
            this.picImg.Name = "picImg";
            this.picImg.Size = new System.Drawing.Size(256, 144);
            this.picImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImg.TabIndex = 0;
            this.picImg.TabStop = false;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(10, 160);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(84, 46);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.Text = "이전";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.BtnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(182, 160);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(84, 46);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "다음";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // lblNum
            // 
            this.lblNum.Font = new System.Drawing.Font("굴림", 14F);
            this.lblNum.Location = new System.Drawing.Point(100, 160);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(76, 46);
            this.lblNum.TabIndex = 2;
            this.lblNum.Text = "/";
            this.lblNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "43.JPG");
            this.imgList.Images.SetKeyName(1, "1.jpg");
            this.imgList.Images.SetKeyName(2, "2.JPG");
            this.imgList.Images.SetKeyName(3, "3.JPG");
            this.imgList.Images.SetKeyName(4, "4.JPG");
            this.imgList.Images.SetKeyName(5, "5.JPG");
            this.imgList.Images.SetKeyName(6, "6.JPG");
            this.imgList.Images.SetKeyName(7, "7.JPG");
            this.imgList.Images.SetKeyName(8, "8.jpg");
            this.imgList.Images.SetKeyName(9, "9.JPG");
            this.imgList.Images.SetKeyName(10, "10.JPG");
            this.imgList.Images.SetKeyName(11, "11.JPG");
            this.imgList.Images.SetKeyName(12, "12.JPG");
            this.imgList.Images.SetKeyName(13, "13.JPG");
            this.imgList.Images.SetKeyName(14, "14.JPG");
            this.imgList.Images.SetKeyName(15, "15.JPG");
            this.imgList.Images.SetKeyName(16, "16.JPG");
            this.imgList.Images.SetKeyName(17, "17.JPG");
            this.imgList.Images.SetKeyName(18, "18.JPG");
            this.imgList.Images.SetKeyName(19, "19.JPG");
            this.imgList.Images.SetKeyName(20, "20.JPG");
            this.imgList.Images.SetKeyName(21, "21.JPG");
            this.imgList.Images.SetKeyName(22, "22.JPG");
            this.imgList.Images.SetKeyName(23, "23.JPG");
            this.imgList.Images.SetKeyName(24, "24.JPG");
            this.imgList.Images.SetKeyName(25, "25.JPG");
            this.imgList.Images.SetKeyName(26, "26.JPG");
            this.imgList.Images.SetKeyName(27, "27.JPG");
            this.imgList.Images.SetKeyName(28, "28.JPG");
            this.imgList.Images.SetKeyName(29, "29.JPG");
            this.imgList.Images.SetKeyName(30, "30.JPG");
            this.imgList.Images.SetKeyName(31, "31.JPG");
            this.imgList.Images.SetKeyName(32, "32.JPG");
            this.imgList.Images.SetKeyName(33, "33.JPG");
            this.imgList.Images.SetKeyName(34, "34.JPG");
            this.imgList.Images.SetKeyName(35, "35.JPG");
            this.imgList.Images.SetKeyName(36, "36.JPG");
            this.imgList.Images.SetKeyName(37, "37.JPG");
            this.imgList.Images.SetKeyName(38, "38.JPG");
            this.imgList.Images.SetKeyName(39, "39.JPG");
            this.imgList.Images.SetKeyName(40, "40.JPG");
            this.imgList.Images.SetKeyName(41, "41.JPG");
            this.imgList.Images.SetKeyName(42, "42.JPG");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 218);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.picImg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "사진첩";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picImg;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.ImageList imgList;
    }
}

