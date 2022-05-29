
namespace TH_Lap_8
{
    partial class frm_Danhsachtrasua
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
            this.lbl_DStrasua = new System.Windows.Forms.Label();
            this.grpViewStyle = new System.Windows.Forms.GroupBox();
            this.radTile = new System.Windows.Forms.RadioButton();
            this.radList = new System.Windows.Forms.RadioButton();
            this.radSmallicon = new System.Windows.Forms.RadioButton();
            this.radDetail = new System.Windows.Forms.RadioButton();
            this.radLargeicon = new System.Windows.Forms.RadioButton();
            this.grpChitettrasua = new System.Windows.Forms.GroupBox();
            this.picImg = new System.Windows.Forms.PictureBox();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtSotien = new System.Windows.Forms.TextBox();
            this.txtTentra = new System.Windows.Forms.TextBox();
            this.txtMatra = new System.Windows.Forms.TextBox();
            this.lbl_Sotien = new System.Windows.Forms.Label();
            this.lbl_Tentra = new System.Windows.Forms.Label();
            this.lbl_Matra = new System.Windows.Forms.Label();
            this.lvwTraSua = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.grpViewStyle.SuspendLayout();
            this.grpChitettrasua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_DStrasua
            // 
            this.lbl_DStrasua.AutoSize = true;
            this.lbl_DStrasua.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DStrasua.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_DStrasua.Location = new System.Drawing.Point(226, 7);
            this.lbl_DStrasua.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_DStrasua.Name = "lbl_DStrasua";
            this.lbl_DStrasua.Size = new System.Drawing.Size(317, 31);
            this.lbl_DStrasua.TabIndex = 0;
            this.lbl_DStrasua.Text = "DANH SÁCH TRÀ SỮA";
            // 
            // grpViewStyle
            // 
            this.grpViewStyle.Controls.Add(this.radTile);
            this.grpViewStyle.Controls.Add(this.radList);
            this.grpViewStyle.Controls.Add(this.radSmallicon);
            this.grpViewStyle.Controls.Add(this.radDetail);
            this.grpViewStyle.Controls.Add(this.radLargeicon);
            this.grpViewStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpViewStyle.Location = new System.Drawing.Point(22, 53);
            this.grpViewStyle.Margin = new System.Windows.Forms.Padding(2);
            this.grpViewStyle.Name = "grpViewStyle";
            this.grpViewStyle.Padding = new System.Windows.Forms.Padding(2);
            this.grpViewStyle.Size = new System.Drawing.Size(510, 70);
            this.grpViewStyle.TabIndex = 1;
            this.grpViewStyle.TabStop = false;
            this.grpViewStyle.Text = "View Style";
            // 
            // radTile
            // 
            this.radTile.AutoSize = true;
            this.radTile.Location = new System.Drawing.Point(398, 29);
            this.radTile.Margin = new System.Windows.Forms.Padding(2);
            this.radTile.Name = "radTile";
            this.radTile.Size = new System.Drawing.Size(49, 21);
            this.radTile.TabIndex = 5;
            this.radTile.TabStop = true;
            this.radTile.Text = "Tile";
            this.radTile.UseVisualStyleBackColor = true;
            this.radTile.CheckedChanged += new System.EventHandler(this.radTile_CheckedChanged);
            // 
            // radList
            // 
            this.radList.AutoSize = true;
            this.radList.Location = new System.Drawing.Point(323, 29);
            this.radList.Margin = new System.Windows.Forms.Padding(2);
            this.radList.Name = "radList";
            this.radList.Size = new System.Drawing.Size(48, 21);
            this.radList.TabIndex = 4;
            this.radList.TabStop = true;
            this.radList.Text = "List";
            this.radList.UseVisualStyleBackColor = true;
            this.radList.CheckedChanged += new System.EventHandler(this.radList_CheckedChanged);
            // 
            // radSmallicon
            // 
            this.radSmallicon.AutoSize = true;
            this.radSmallicon.Location = new System.Drawing.Point(209, 29);
            this.radSmallicon.Margin = new System.Windows.Forms.Padding(2);
            this.radSmallicon.Name = "radSmallicon";
            this.radSmallicon.Size = new System.Drawing.Size(90, 21);
            this.radSmallicon.TabIndex = 3;
            this.radSmallicon.TabStop = true;
            this.radSmallicon.Text = "Small Icon";
            this.radSmallicon.UseVisualStyleBackColor = true;
            this.radSmallicon.CheckedChanged += new System.EventHandler(this.radSmallicon_CheckedChanged);
            // 
            // radDetail
            // 
            this.radDetail.AutoSize = true;
            this.radDetail.Location = new System.Drawing.Point(119, 29);
            this.radDetail.Margin = new System.Windows.Forms.Padding(2);
            this.radDetail.Name = "radDetail";
            this.radDetail.Size = new System.Drawing.Size(62, 21);
            this.radDetail.TabIndex = 2;
            this.radDetail.TabStop = true;
            this.radDetail.Text = "Detail";
            this.radDetail.UseVisualStyleBackColor = true;
            this.radDetail.CheckedChanged += new System.EventHandler(this.radDetail_CheckedChanged);
            // 
            // radLargeicon
            // 
            this.radLargeicon.AutoSize = true;
            this.radLargeicon.Location = new System.Drawing.Point(5, 29);
            this.radLargeicon.Margin = new System.Windows.Forms.Padding(2);
            this.radLargeicon.Name = "radLargeicon";
            this.radLargeicon.Size = new System.Drawing.Size(93, 21);
            this.radLargeicon.TabIndex = 1;
            this.radLargeicon.TabStop = true;
            this.radLargeicon.Text = "Large Icon";
            this.radLargeicon.UseVisualStyleBackColor = true;
            this.radLargeicon.CheckedChanged += new System.EventHandler(this.radLargeicon_CheckedChanged);
            // 
            // grpChitettrasua
            // 
            this.grpChitettrasua.Controls.Add(this.picImg);
            this.grpChitettrasua.Controls.Add(this.btnLammoi);
            this.grpChitettrasua.Controls.Add(this.btnXoa);
            this.grpChitettrasua.Controls.Add(this.btnSua);
            this.grpChitettrasua.Controls.Add(this.btnThem);
            this.grpChitettrasua.Controls.Add(this.txtSotien);
            this.grpChitettrasua.Controls.Add(this.txtTentra);
            this.grpChitettrasua.Controls.Add(this.txtMatra);
            this.grpChitettrasua.Controls.Add(this.lbl_Sotien);
            this.grpChitettrasua.Controls.Add(this.lbl_Tentra);
            this.grpChitettrasua.Controls.Add(this.lbl_Matra);
            this.grpChitettrasua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpChitettrasua.Location = new System.Drawing.Point(545, 53);
            this.grpChitettrasua.Margin = new System.Windows.Forms.Padding(2);
            this.grpChitettrasua.Name = "grpChitettrasua";
            this.grpChitettrasua.Padding = new System.Windows.Forms.Padding(2);
            this.grpChitettrasua.Size = new System.Drawing.Size(260, 342);
            this.grpChitettrasua.TabIndex = 2;
            this.grpChitettrasua.TabStop = false;
            this.grpChitettrasua.Text = "Chi tiết trà sữa";
            // 
            // picImg
            // 
            this.picImg.Location = new System.Drawing.Point(30, 21);
            this.picImg.Name = "picImg";
            this.picImg.Size = new System.Drawing.Size(213, 108);
            this.picImg.TabIndex = 13;
            this.picImg.TabStop = false;
            this.picImg.Click += new System.EventHandler(this.picImg_Click);
            // 
            // btnLammoi
            // 
            this.btnLammoi.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnLammoi.Location = new System.Drawing.Point(161, 297);
            this.btnLammoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(56, 25);
            this.btnLammoi.TabIndex = 12;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(72, 297);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(56, 25);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(161, 250);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(56, 25);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(72, 250);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(56, 25);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtSotien
            // 
            this.txtSotien.Location = new System.Drawing.Point(72, 210);
            this.txtSotien.Margin = new System.Windows.Forms.Padding(2);
            this.txtSotien.Name = "txtSotien";
            this.txtSotien.Size = new System.Drawing.Size(156, 23);
            this.txtSotien.TabIndex = 8;
            // 
            // txtTentra
            // 
            this.txtTentra.Location = new System.Drawing.Point(72, 179);
            this.txtTentra.Margin = new System.Windows.Forms.Padding(2);
            this.txtTentra.Name = "txtTentra";
            this.txtTentra.Size = new System.Drawing.Size(156, 23);
            this.txtTentra.TabIndex = 7;
            // 
            // txtMatra
            // 
            this.txtMatra.Location = new System.Drawing.Point(72, 147);
            this.txtMatra.Margin = new System.Windows.Forms.Padding(2);
            this.txtMatra.Name = "txtMatra";
            this.txtMatra.Size = new System.Drawing.Size(156, 23);
            this.txtMatra.TabIndex = 6;
            // 
            // lbl_Sotien
            // 
            this.lbl_Sotien.AutoSize = true;
            this.lbl_Sotien.Location = new System.Drawing.Point(12, 215);
            this.lbl_Sotien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Sotien.Name = "lbl_Sotien";
            this.lbl_Sotien.Size = new System.Drawing.Size(52, 17);
            this.lbl_Sotien.TabIndex = 2;
            this.lbl_Sotien.Text = "Số tiền";
            // 
            // lbl_Tentra
            // 
            this.lbl_Tentra.AutoSize = true;
            this.lbl_Tentra.Location = new System.Drawing.Point(12, 181);
            this.lbl_Tentra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Tentra.Name = "lbl_Tentra";
            this.lbl_Tentra.Size = new System.Drawing.Size(54, 17);
            this.lbl_Tentra.TabIndex = 1;
            this.lbl_Tentra.Text = "Tên trà";
            // 
            // lbl_Matra
            // 
            this.lbl_Matra.AutoSize = true;
            this.lbl_Matra.Location = new System.Drawing.Point(12, 147);
            this.lbl_Matra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Matra.Name = "lbl_Matra";
            this.lbl_Matra.Size = new System.Drawing.Size(48, 17);
            this.lbl_Matra.TabIndex = 0;
            this.lbl_Matra.Text = "Mã trà";
            this.lbl_Matra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvwTraSua
            // 
            this.lvwTraSua.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvwTraSua.HideSelection = false;
            this.lvwTraSua.LargeImageList = this.imageList;
            this.lvwTraSua.Location = new System.Drawing.Point(22, 148);
            this.lvwTraSua.Margin = new System.Windows.Forms.Padding(2);
            this.lvwTraSua.Name = "lvwTraSua";
            this.lvwTraSua.Size = new System.Drawing.Size(511, 236);
            this.lvwTraSua.SmallImageList = this.imageList;
            this.lvwTraSua.TabIndex = 3;
            this.lvwTraSua.UseCompatibleStateImageBehavior = false;
            this.lvwTraSua.SelectedIndexChanged += new System.EventHandler(this.lvwTraSua_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Trà";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Trà";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số Tiền";
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(55, 50);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ofdFile
            // 
            this.ofdFile.FileName = "ofdFile";
            // 
            // frm_Danhsachtrasua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(821, 405);
            this.Controls.Add(this.lvwTraSua);
            this.Controls.Add(this.grpChitettrasua);
            this.Controls.Add(this.grpViewStyle);
            this.Controls.Add(this.lbl_DStrasua);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.Name = "frm_Danhsachtrasua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách trà sữa";
            this.grpViewStyle.ResumeLayout(false);
            this.grpViewStyle.PerformLayout();
            this.grpChitettrasua.ResumeLayout(false);
            this.grpChitettrasua.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_DStrasua;
        private System.Windows.Forms.GroupBox grpViewStyle;
        private System.Windows.Forms.GroupBox grpChitettrasua;
        private System.Windows.Forms.RadioButton radLargeicon;
        private System.Windows.Forms.RadioButton radDetail;
        private System.Windows.Forms.RadioButton radSmallicon;
        private System.Windows.Forms.RadioButton radList;
        private System.Windows.Forms.RadioButton radTile;
        private System.Windows.Forms.Label lbl_Matra;
        private System.Windows.Forms.Label lbl_Sotien;
        private System.Windows.Forms.Label lbl_Tentra;
        private System.Windows.Forms.TextBox txtMatra;
        private System.Windows.Forms.TextBox txtTentra;
        private System.Windows.Forms.TextBox txtSotien;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.ListView lvwTraSua;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.PictureBox picImg;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.OpenFileDialog ofdFile;
    }
}

