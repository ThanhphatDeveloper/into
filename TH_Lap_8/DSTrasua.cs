using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            LoadData();
        }
        private void LoadImageList()
        {
            DirectoryInfo dir = new DirectoryInfo("img"); // truy xu?t thu m?c ch?a hình ?nh img

            FileInfo[] files = dir.GetFiles("*.jpg");

            foreach (var file in files)
            {
                imageList.Images.Add(file.Name, Image.FromFile(file.FullName));
            }
        }
        private void DocFile()
        {
            string line; // TS001,Song V? Nhi?t Ð?i,25000

            string[] splitters; // TS001 | Song V? Nhi?t Ð?i | 25000

            StreamReader srd = new StreamReader("DSTraSua.txt");
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

        private void LoadData()
        {
            foreach (var ts in lstTraSua)
            {
                ListViewItem lviTraSua = new ListViewItem(ts.MaTra, ts.MaTra + ".jpg");
                lviTraSua.SubItems.Add(ts.TenTra);
                lviTraSua.SubItems.Add(ts.DonGia.ToString());

                lvwTraSua.Items.Add(lviTraSua);
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




    }
}
