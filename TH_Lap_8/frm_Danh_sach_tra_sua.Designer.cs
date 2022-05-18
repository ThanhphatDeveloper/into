
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
            this.grp_View_Style = new System.Windows.Forms.GroupBox();
            this.rad_Tile = new System.Windows.Forms.RadioButton();
            this.rad_List = new System.Windows.Forms.RadioButton();
            this.rad_Small_icon = new System.Windows.Forms.RadioButton();
            this.rad_Detail = new System.Windows.Forms.RadioButton();
            this.rad_Large_icon = new System.Windows.Forms.RadioButton();
            this.grp_Chitet_trasua = new System.Windows.Forms.GroupBox();
            this.btn_Lammoi = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_Sotien = new System.Windows.Forms.TextBox();
            this.txt_Tentra = new System.Windows.Forms.TextBox();
            this.txt_Matra = new System.Windows.Forms.TextBox();
            this.lbl_Sotien = new System.Windows.Forms.Label();
            this.lbl_Tentra = new System.Windows.Forms.Label();
            this.lbl_Matra = new System.Windows.Forms.Label();
            this.lvw_TraSua = new System.Windows.Forms.ListView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grp_View_Style.SuspendLayout();
            this.grp_Chitet_trasua.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_DStrasua
            // 
            this.lbl_DStrasua.AutoSize = true;
            this.lbl_DStrasua.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DStrasua.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_DStrasua.Location = new System.Drawing.Point(301, 9);
            this.lbl_DStrasua.Name = "lbl_DStrasua";
            this.lbl_DStrasua.Size = new System.Drawing.Size(381, 38);
            this.lbl_DStrasua.TabIndex = 0;
            this.lbl_DStrasua.Text = "DANH SÁCH TRÀ SỮA";
            // 
            // grp_View_Style
            // 
            this.grp_View_Style.Controls.Add(this.rad_Tile);
            this.grp_View_Style.Controls.Add(this.rad_List);
            this.grp_View_Style.Controls.Add(this.rad_Small_icon);
            this.grp_View_Style.Controls.Add(this.rad_Detail);
            this.grp_View_Style.Controls.Add(this.rad_Large_icon);
            this.grp_View_Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_View_Style.Location = new System.Drawing.Point(29, 65);
            this.grp_View_Style.Name = "grp_View_Style";
            this.grp_View_Style.Size = new System.Drawing.Size(680, 86);
            this.grp_View_Style.TabIndex = 1;
            this.grp_View_Style.TabStop = false;
            this.grp_View_Style.Text = "View Style";
            // 
            // rad_Tile
            // 
            this.rad_Tile.AutoSize = true;
            this.rad_Tile.Location = new System.Drawing.Point(530, 36);
            this.rad_Tile.Name = "rad_Tile";
            this.rad_Tile.Size = new System.Drawing.Size(57, 24);
            this.rad_Tile.TabIndex = 4;
            this.rad_Tile.TabStop = true;
            this.rad_Tile.Text = "Tile";
            this.rad_Tile.UseVisualStyleBackColor = true;
            this.rad_Tile.CheckedChanged += new System.EventHandler(this.rad_Tile_CheckedChanged);
            // 
            // rad_List
            // 
            this.rad_List.AutoSize = true;
            this.rad_List.Location = new System.Drawing.Point(431, 36);
            this.rad_List.Name = "rad_List";
            this.rad_List.Size = new System.Drawing.Size(58, 24);
            this.rad_List.TabIndex = 3;
            this.rad_List.TabStop = true;
            this.rad_List.Text = "List";
            this.rad_List.UseVisualStyleBackColor = true;
            this.rad_List.CheckedChanged += new System.EventHandler(this.rad_List_CheckedChanged);
            // 
            // rad_Small_icon
            // 
            this.rad_Small_icon.AutoSize = true;
            this.rad_Small_icon.Location = new System.Drawing.Point(279, 36);
            this.rad_Small_icon.Name = "rad_Small_icon";
            this.rad_Small_icon.Size = new System.Drawing.Size(108, 24);
            this.rad_Small_icon.TabIndex = 2;
            this.rad_Small_icon.TabStop = true;
            this.rad_Small_icon.Text = "Small Icon";
            this.rad_Small_icon.UseVisualStyleBackColor = true;
            this.rad_Small_icon.CheckedChanged += new System.EventHandler(this.rad_Small_icon_CheckedChanged);
            // 
            // rad_Detail
            // 
            this.rad_Detail.AutoSize = true;
            this.rad_Detail.Location = new System.Drawing.Point(159, 36);
            this.rad_Detail.Name = "rad_Detail";
            this.rad_Detail.Size = new System.Drawing.Size(74, 24);
            this.rad_Detail.TabIndex = 1;
            this.rad_Detail.TabStop = true;
            this.rad_Detail.Text = "Detail";
            this.rad_Detail.UseVisualStyleBackColor = true;
            this.rad_Detail.CheckedChanged += new System.EventHandler(this.rad_Detail_CheckedChanged);
            // 
            // rad_Large_icon
            // 
            this.rad_Large_icon.AutoSize = true;
            this.rad_Large_icon.Location = new System.Drawing.Point(7, 36);
            this.rad_Large_icon.Name = "rad_Large_icon";
            this.rad_Large_icon.Size = new System.Drawing.Size(109, 24);
            this.rad_Large_icon.TabIndex = 0;
            this.rad_Large_icon.TabStop = true;
            this.rad_Large_icon.Text = "Large Icon";
            this.rad_Large_icon.UseVisualStyleBackColor = true;
            this.rad_Large_icon.CheckedChanged += new System.EventHandler(this.rad_Large_icon_CheckedChanged);
            // 
            // grp_Chitet_trasua
            // 
            this.grp_Chitet_trasua.Controls.Add(this.btn_Lammoi);
            this.grp_Chitet_trasua.Controls.Add(this.btn_Xoa);
            this.grp_Chitet_trasua.Controls.Add(this.btn_Sua);
            this.grp_Chitet_trasua.Controls.Add(this.btn_Them);
            this.grp_Chitet_trasua.Controls.Add(this.txt_Sotien);
            this.grp_Chitet_trasua.Controls.Add(this.txt_Tentra);
            this.grp_Chitet_trasua.Controls.Add(this.txt_Matra);
            this.grp_Chitet_trasua.Controls.Add(this.lbl_Sotien);
            this.grp_Chitet_trasua.Controls.Add(this.lbl_Tentra);
            this.grp_Chitet_trasua.Controls.Add(this.lbl_Matra);
            this.grp_Chitet_trasua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Chitet_trasua.Location = new System.Drawing.Point(727, 65);
            this.grp_Chitet_trasua.Name = "grp_Chitet_trasua";
            this.grp_Chitet_trasua.Size = new System.Drawing.Size(346, 421);
            this.grp_Chitet_trasua.TabIndex = 2;
            this.grp_Chitet_trasua.TabStop = false;
            this.grp_Chitet_trasua.Text = "Chi tiết trà sữa";
            // 
            // btn_Lammoi
            // 
            this.btn_Lammoi.Location = new System.Drawing.Point(215, 366);
            this.btn_Lammoi.Name = "btn_Lammoi";
            this.btn_Lammoi.Size = new System.Drawing.Size(75, 31);
            this.btn_Lammoi.TabIndex = 9;
            this.btn_Lammoi.Text = "Làm mới";
            this.btn_Lammoi.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(96, 366);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 31);
            this.btn_Xoa.TabIndex = 8;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(215, 308);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 31);
            this.btn_Sua.TabIndex = 7;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(96, 308);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 31);
            this.btn_Them.TabIndex = 6;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            // 
            // txt_Sotien
            // 
            this.txt_Sotien.Location = new System.Drawing.Point(96, 258);
            this.txt_Sotien.Name = "txt_Sotien";
            this.txt_Sotien.Size = new System.Drawing.Size(207, 27);
            this.txt_Sotien.TabIndex = 5;
            // 
            // txt_Tentra
            // 
            this.txt_Tentra.Location = new System.Drawing.Point(96, 220);
            this.txt_Tentra.Name = "txt_Tentra";
            this.txt_Tentra.Size = new System.Drawing.Size(207, 27);
            this.txt_Tentra.TabIndex = 4;
            // 
            // txt_Matra
            // 
            this.txt_Matra.Location = new System.Drawing.Point(96, 181);
            this.txt_Matra.Name = "txt_Matra";
            this.txt_Matra.Size = new System.Drawing.Size(207, 27);
            this.txt_Matra.TabIndex = 3;
            // 
            // lbl_Sotien
            // 
            this.lbl_Sotien.AutoSize = true;
            this.lbl_Sotien.Location = new System.Drawing.Point(16, 265);
            this.lbl_Sotien.Name = "lbl_Sotien";
            this.lbl_Sotien.Size = new System.Drawing.Size(61, 20);
            this.lbl_Sotien.TabIndex = 2;
            this.lbl_Sotien.Text = "Số tiền";
            // 
            // lbl_Tentra
            // 
            this.lbl_Tentra.AutoSize = true;
            this.lbl_Tentra.Location = new System.Drawing.Point(16, 223);
            this.lbl_Tentra.Name = "lbl_Tentra";
            this.lbl_Tentra.Size = new System.Drawing.Size(62, 20);
            this.lbl_Tentra.TabIndex = 1;
            this.lbl_Tentra.Text = "Tên trà";
            // 
            // lbl_Matra
            // 
            this.lbl_Matra.AutoSize = true;
            this.lbl_Matra.Location = new System.Drawing.Point(16, 181);
            this.lbl_Matra.Name = "lbl_Matra";
            this.lbl_Matra.Size = new System.Drawing.Size(57, 20);
            this.lbl_Matra.TabIndex = 0;
            this.lbl_Matra.Text = "Mã trà";
            // 
            // lvw_TraSua
            // 
            this.lvw_TraSua.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvw_TraSua.HideSelection = false;
            this.lvw_TraSua.LargeImageList = this.imageList;
            this.lvw_TraSua.Location = new System.Drawing.Point(29, 182);
            this.lvw_TraSua.Name = "lvw_TraSua";
            this.lvw_TraSua.Size = new System.Drawing.Size(680, 289);
            this.lvw_TraSua.SmallImageList = this.imageList;
            this.lvw_TraSua.TabIndex = 3;
            this.lvw_TraSua.UseCompatibleStateImageBehavior = false;
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(55, 50);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
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
            // frm_Danhsachtrasua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 498);
            this.Controls.Add(this.lvw_TraSua);
            this.Controls.Add(this.grp_Chitet_trasua);
            this.Controls.Add(this.grp_View_Style);
            this.Controls.Add(this.lbl_DStrasua);
            this.Name = "frm_Danhsachtrasua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách trà sữa";
            this.grp_View_Style.ResumeLayout(false);
            this.grp_View_Style.PerformLayout();
            this.grp_Chitet_trasua.ResumeLayout(false);
            this.grp_Chitet_trasua.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_DStrasua;
        private System.Windows.Forms.GroupBox grp_View_Style;
        private System.Windows.Forms.GroupBox grp_Chitet_trasua;
        private System.Windows.Forms.RadioButton rad_Large_icon;
        private System.Windows.Forms.RadioButton rad_Detail;
        private System.Windows.Forms.RadioButton rad_Small_icon;
        private System.Windows.Forms.RadioButton rad_List;
        private System.Windows.Forms.RadioButton rad_Tile;
        private System.Windows.Forms.Label lbl_Matra;
        private System.Windows.Forms.Label lbl_Sotien;
        private System.Windows.Forms.Label lbl_Tentra;
        private System.Windows.Forms.TextBox txt_Matra;
        private System.Windows.Forms.TextBox txt_Tentra;
        private System.Windows.Forms.TextBox txt_Sotien;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Lammoi;
        private System.Windows.Forms.ListView lvw_TraSua;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

