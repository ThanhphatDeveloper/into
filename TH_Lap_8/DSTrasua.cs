using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;


namespace TH_Lap_8
{
    public partial class frm_Danhsachtrasua : Form
    {
        //chua danh sach đối
        List<TraSua> lstTraSua = new List<TraSua>();
        public frm_Danhsachtrasua()
        {
            InitializeComponent();
            DocFile();
            LoadImageList();
            LoadData1();
        }

        private void Docfile()
        {
            lstTraSua.Clear();
            string line;
            string[] split;
            StreamReader srd = new StreamReader("../../TRASUA/DSTraSua.txt");
            while ((line = srd.ReadLine()) != null)
            {
                split = line.Split(',');
                TraSua ts = new TraSua
                {
                    MaTra = split[0],
                    TenTra = split[1],
                    DonGia = int.Parse(split[2])
                };
                lstTraSua.Add(ts);
            }
        }
        private void Loadimg()
        {
            imageList.Images.Clear();
            imageList1.Images.Clear();
            DirectoryInfo dir = new DirectoryInfo("../../TRASUA/img");
            FileInfo[] files = dir.GetFiles("*.jpg");
            foreach (var file in files)
            {
                imageList.Images.Add(file.Name, Image.FromFile(file.FullName));
                imageList1.Images.Add(file.Name, Image.FromFile(file.FullName));
            }
        }
        private void LoadData()
        {
            lvwTraSua.Items.Clear();
            foreach (var ts in lstTraSua)
            {
                ListViewItem items = new ListViewItem(ts.MaTra, ts.MaTra + ".jpg");
                items.SubItems.Add(ts.TenTra);
                items.SubItems.Add(ts.DonGia.ToString());
                lvwTraSua.Items.Add(items);
            }

        }

        private void LoadImageList()
        {
            DirectoryInfo dir = new DirectoryInfo("img"); // truy xu?t thu m?c ch?a hình ?nh img

            FileInfo[] files = dir.GetFiles("*.jpg");

            foreach (var file in files)
            {
                imageList.Images.Add(file.Name, Image.FromFile(file.FullName));

                imageList1.Images.Add(file.Name, Image.FromFile(file.FullName));
            }
        }
        private void DocFile()
        {
            string line; // TS001,Song V? Nhi?t Ð?i,25000

            string[] splitters; // TS001 | Song V? Nhi?t Ð?i | 25000

            StreamReader srd = new StreamReader("../DSTraSua.txt");

            while ((line = srd.ReadLine()) != null)
            {
                splitters = line.Split(','); // c?t chu?i theo d?u ,

                TraSua ts = new TraSua
                {
                    MaTra = splitters[0],
                    TenTra = splitters[1],
                    DonGia = int.Parse(splitters[2])
                };

                lstTraSua.Add(ts);
            }
        }

        private void LoadData1()
        {
            foreach (var ts in lstTraSua)
            {
                ListViewItem lviTraSua = new ListViewItem(ts.MaTra, ts.MaTra + ".jpg");
                lviTraSua.SubItems.Add(ts.TenTra);
                lviTraSua.SubItems.Add(ts.DonGia.ToString());

                lvwTraSua.Items.Add(lviTraSua);
            }
        }

        private void WriteFile()
        {
            using (StreamWriter sw = new StreamWriter(@"..\TRASUA\DSTraSua.txt", false))
            {
                for (int i = 0; i < lstTraSua.Count; i++)
                {
                    string line = string.Format("{0},{1},{2}", lstTraSua[i].MaTra, lstTraSua[i].TenTra, lstTraSua[i].DonGia);
                    sw.WriteLine(line);
                }
                sw.Close();
                sw.Dispose();
                System.GC.Collect();
            }
        }

        public byte[] ConvertImageToByteArray(Image imageToConvert)
        {
            using (var ms = new MemoryStream())
            {
                //Chuyển image sang kiểu bitmap
                Bitmap bmp = new Bitmap(imageToConvert);

                //Lưu bitmap thành MemoryStream cho việc lưu trữ ảnh
                bmp.Save(ms, ImageFormat.Jpeg);

                return ms.ToArray();
            }
        }

        private void radLargeicon_CheckedChanged(object sender, EventArgs e)
        {
            lvwTraSua.View = View.LargeIcon;
        }

        private void radDetail_CheckedChanged(object sender, EventArgs e)
        {
            lvwTraSua.View = View.Details;
        }

        private void radSmallicon_CheckedChanged(object sender, EventArgs e)
        {
            lvwTraSua.View = View.SmallIcon;
        }

        private void radList_CheckedChanged(object sender, EventArgs e)
        {
            lvwTraSua.View = View.List;
        }

        private void radTile_CheckedChanged(object sender, EventArgs e)
        {
            lvwTraSua.View = View.Tile;
        }

        private void lvwTraSua_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if (lvwTraSua.SelectedItems.Count == 0) return;

            txtMatra.Text = lvwTraSua.SelectedItems[0].SubItems[0].Text;
            txtTentra.Text = lvwTraSua.SelectedItems[0].SubItems[1].Text;
            txtSotien.Text = lvwTraSua.SelectedItems[0].SubItems[2].Text;

            int index = lvwTraSua.SelectedIndices[0];

            if (index < imageList.Images.Count)
            {
                picImg.Image = imageList.Images[index];
            }
            else
            {
                picImg.Image = null;
            }                       
        }

        private void picImg_Click(object sender, EventArgs e)
        {
            Stream stream = null;

            ofdFile.InitialDirectory = "D:\\";

            ofdFile.Filter = "Image files (*.jmg, *.jpeg, *.jpe, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";// chỉ mở được các file hình
            ofdFile.FilterIndex = 2; // cho phép chọn cái thứ 2
            ofdFile.RestoreDirectory = true;

            // hiển thị hộp thoại

            if(ofdFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // tập tin tồn tại

                    if((stream = ofdFile.OpenFile()) != null)
                    {
                        using (stream)
                        {
                            picImg.Image = Image.FromStream(stream);
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi", "Lỗi xxx", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                }

                stream.Close();

                stream.Dispose();
                System.GC.Collect();
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {


            TraSua ts = new TraSua
            {
                MaTra = txtMatra.Text,
                TenTra = txtTentra.Text,
                DonGia = int.Parse(txtSotien.Text)
            };

            lstTraSua.Add(ts);

            // lưu ảnh
            using (MemoryStream memory = new MemoryStream())
            {
                using (FileStream fs = new FileStream("../../TRASUA/img/" + txtMatra.Text + ".jpg", FileMode.Create, FileAccess.ReadWrite))
                {
                    byte[] bytes = ConvertImageToByteArray(picImg.Image);
                    fs.Write(bytes, 0, bytes.Length);
                }
            }
            // ghi file
            WriteFile();


            //Xóa sạch các textbox khi dữ liệu đã được thêm vào
            txtMatra.Text = string.Empty;
            txtTentra.Text = string.Empty;
            txtSotien.Text = string.Empty;
            picImg.Image = null;

            //2 chức năng xóa và sửa bất hoạt
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            txtMatra.Enabled = true;

            Docfile();
            Loadimg();
            LoadData1();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvwTraSua.Items.Count; i++)
            {
                if (lvwTraSua.Items[i].Selected)
                {
                    lvwTraSua.Items[i].Remove();

                    btnLammoi_Click(sender, e);
                }
            }

        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            picImg.Image = null;
            txtMatra.Text = string.Empty;
            txtSotien.Text = string.Empty;
            txtTentra.Text = string.Empty;
            txtMatra.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }
    }
}
