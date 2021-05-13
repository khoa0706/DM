namespace bai8
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("", 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("", 1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("", 2);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtTile = new System.Windows.Forms.RadioButton();
            this.rbtList = new System.Windows.Forms.RadioButton();
            this.rbtDetails = new System.Windows.Forms.RadioButton();
            this.rbtSmall = new System.Windows.Forms.RadioButton();
            this.rbtLarge = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtTenTS = new System.Windows.Forms.TextBox();
            this.txtMaTS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstv1 = new System.Windows.Forms.ListView();
            this.imgListTraSuaLarge = new System.Windows.Forms.ImageList(this.components);
            this.imgListTraSuaSmall = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(236, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH TRÀ SỮA";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtTile);
            this.groupBox1.Controls.Add(this.rbtList);
            this.groupBox1.Controls.Add(this.rbtDetails);
            this.groupBox1.Controls.Add(this.rbtSmall);
            this.groupBox1.Controls.Add(this.rbtLarge);
            this.groupBox1.Location = new System.Drawing.Point(12, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 43);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Style";
            // 
            // rbtTile
            // 
            this.rbtTile.AutoSize = true;
            this.rbtTile.Location = new System.Drawing.Point(322, 19);
            this.rbtTile.Name = "rbtTile";
            this.rbtTile.Size = new System.Drawing.Size(42, 17);
            this.rbtTile.TabIndex = 4;
            this.rbtTile.TabStop = true;
            this.rbtTile.Text = "Tile";
            this.rbtTile.UseVisualStyleBackColor = true;
            this.rbtTile.CheckedChanged += new System.EventHandler(this.rbtTile_CheckedChanged);
            // 
            // rbtList
            // 
            this.rbtList.AutoSize = true;
            this.rbtList.Location = new System.Drawing.Point(266, 19);
            this.rbtList.Name = "rbtList";
            this.rbtList.Size = new System.Drawing.Size(41, 17);
            this.rbtList.TabIndex = 3;
            this.rbtList.TabStop = true;
            this.rbtList.Text = "List";
            this.rbtList.UseVisualStyleBackColor = true;
            this.rbtList.CheckedChanged += new System.EventHandler(this.rbtList_CheckedChanged);
            // 
            // rbtDetails
            // 
            this.rbtDetails.AutoSize = true;
            this.rbtDetails.Location = new System.Drawing.Point(193, 19);
            this.rbtDetails.Name = "rbtDetails";
            this.rbtDetails.Size = new System.Drawing.Size(57, 17);
            this.rbtDetails.TabIndex = 2;
            this.rbtDetails.TabStop = true;
            this.rbtDetails.Text = "Details";
            this.rbtDetails.UseVisualStyleBackColor = true;
            this.rbtDetails.CheckedChanged += new System.EventHandler(this.rbtDetails_CheckedChanged);
            // 
            // rbtSmall
            // 
            this.rbtSmall.AutoSize = true;
            this.rbtSmall.ImageKey = "(none)";
            this.rbtSmall.Location = new System.Drawing.Point(101, 19);
            this.rbtSmall.Name = "rbtSmall";
            this.rbtSmall.Size = new System.Drawing.Size(74, 17);
            this.rbtSmall.TabIndex = 1;
            this.rbtSmall.TabStop = true;
            this.rbtSmall.Text = "Small Icon";
            this.rbtSmall.UseVisualStyleBackColor = true;
            this.rbtSmall.CheckedChanged += new System.EventHandler(this.rbtSmall_CheckedChanged);
            this.rbtSmall.SizeChanged += new System.EventHandler(this.lstv1_SelectedIndexChanged);
            // 
            // rbtLarge
            // 
            this.rbtLarge.AutoSize = true;
            this.rbtLarge.Location = new System.Drawing.Point(6, 19);
            this.rbtLarge.Name = "rbtLarge";
            this.rbtLarge.Size = new System.Drawing.Size(76, 17);
            this.rbtLarge.TabIndex = 0;
            this.rbtLarge.TabStop = true;
            this.rbtLarge.Text = "Large Icon";
            this.rbtLarge.UseVisualStyleBackColor = true;
            this.rbtLarge.CheckedChanged += new System.EventHandler(this.rbtLarge_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.txtDonGia);
            this.groupBox2.Controls.Add(this.txtTenTS);
            this.groupBox2.Controls.Add(this.txtMaTS);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(388, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 354);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết trà sữa";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(180, 325);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 10;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(32, 325);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(180, 273);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(32, 273);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(85, 238);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(191, 20);
            this.txtDonGia.TabIndex = 6;
            // 
            // txtTenTS
            // 
            this.txtTenTS.Location = new System.Drawing.Point(85, 207);
            this.txtTenTS.Name = "txtTenTS";
            this.txtTenTS.Size = new System.Drawing.Size(191, 20);
            this.txtTenTS.TabIndex = 5;
            // 
            // txtMaTS
            // 
            this.txtMaTS.Location = new System.Drawing.Point(85, 176);
            this.txtMaTS.Name = "txtMaTS";
            this.txtMaTS.Size = new System.Drawing.Size(191, 20);
            this.txtMaTS.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Đơn giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên TS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã TS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(85, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 131);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lstv1
            // 
            this.lstv1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lstv1.LargeImageList = this.imgListTraSuaLarge;
            this.lstv1.Location = new System.Drawing.Point(12, 111);
            this.lstv1.Name = "lstv1";
            this.lstv1.Size = new System.Drawing.Size(370, 305);
            this.lstv1.SmallImageList = this.imgListTraSuaSmall;
            this.lstv1.TabIndex = 3;
            this.lstv1.UseCompatibleStateImageBehavior = false;
            this.lstv1.SelectedIndexChanged += new System.EventHandler(this.lstv1_SelectedIndexChanged);
            // 
            // imgListTraSuaLarge
            // 
            this.imgListTraSuaLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListTraSuaLarge.ImageStream")));
            this.imgListTraSuaLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListTraSuaLarge.Images.SetKeyName(0, "TS001.jpg");
            this.imgListTraSuaLarge.Images.SetKeyName(1, "TS002.jpg");
            this.imgListTraSuaLarge.Images.SetKeyName(2, "TS003.jpg");
            this.imgListTraSuaLarge.Images.SetKeyName(3, "TS004.jpg");
            this.imgListTraSuaLarge.Images.SetKeyName(4, "TS005.jpg");
            this.imgListTraSuaLarge.Images.SetKeyName(5, "TS006.jpg");
            this.imgListTraSuaLarge.Images.SetKeyName(6, "TS007.jpg");
            this.imgListTraSuaLarge.Images.SetKeyName(7, "TS008.jpg");
            this.imgListTraSuaLarge.Images.SetKeyName(8, "TS009.jpg");
            this.imgListTraSuaLarge.Images.SetKeyName(9, "TS010.jpg");
            this.imgListTraSuaLarge.Images.SetKeyName(10, "TS011.jpg");
            this.imgListTraSuaLarge.Images.SetKeyName(11, "TS012.jpg");
            this.imgListTraSuaLarge.Images.SetKeyName(12, "TS013.jpg");
            this.imgListTraSuaLarge.Images.SetKeyName(13, "TS014.jpg");
            this.imgListTraSuaLarge.Images.SetKeyName(14, "TS015.jpg");
            this.imgListTraSuaLarge.Images.SetKeyName(15, "TS016.jpg");
            this.imgListTraSuaLarge.Images.SetKeyName(16, "TS017.jpg");
            this.imgListTraSuaLarge.Images.SetKeyName(17, "TS018.jpg");
            // 
            // imgListTraSuaSmall
            // 
            this.imgListTraSuaSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListTraSuaSmall.ImageStream")));
            this.imgListTraSuaSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListTraSuaSmall.Images.SetKeyName(0, "TS001.jpg");
            this.imgListTraSuaSmall.Images.SetKeyName(1, "TS002.jpg");
            this.imgListTraSuaSmall.Images.SetKeyName(2, "TS003.jpg");
            this.imgListTraSuaSmall.Images.SetKeyName(3, "TS004.jpg");
            this.imgListTraSuaSmall.Images.SetKeyName(4, "TS005.jpg");
            this.imgListTraSuaSmall.Images.SetKeyName(5, "TS006.jpg");
            this.imgListTraSuaSmall.Images.SetKeyName(6, "TS007.jpg");
            this.imgListTraSuaSmall.Images.SetKeyName(7, "TS008.jpg");
            this.imgListTraSuaSmall.Images.SetKeyName(8, "TS009.jpg");
            this.imgListTraSuaSmall.Images.SetKeyName(9, "TS010.jpg");
            this.imgListTraSuaSmall.Images.SetKeyName(10, "TS011.jpg");
            this.imgListTraSuaSmall.Images.SetKeyName(11, "TS012.jpg");
            this.imgListTraSuaSmall.Images.SetKeyName(12, "TS013.jpg");
            this.imgListTraSuaSmall.Images.SetKeyName(13, "TS014.jpg");
            this.imgListTraSuaSmall.Images.SetKeyName(14, "TS015.jpg");
            this.imgListTraSuaSmall.Images.SetKeyName(15, "TS016.jpg");
            this.imgListTraSuaSmall.Images.SetKeyName(16, "TS017.jpg");
            this.imgListTraSuaSmall.Images.SetKeyName(17, "TS018.jpg");
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 428);
            this.Controls.Add(this.lstv1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtTile;
        private System.Windows.Forms.RadioButton rbtList;
        private System.Windows.Forms.RadioButton rbtDetails;
        private System.Windows.Forms.RadioButton rbtSmall;
        private System.Windows.Forms.RadioButton rbtLarge;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtTenTS;
        private System.Windows.Forms.TextBox txtMaTS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView lstv1;
        private System.Windows.Forms.ImageList imgListTraSuaLarge;
        private System.Windows.Forms.ImageList imgListTraSuaSmall;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

