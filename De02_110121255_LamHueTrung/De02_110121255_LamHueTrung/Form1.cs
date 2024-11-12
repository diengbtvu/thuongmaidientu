using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De02_110121255_LamHueTrung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Ketnoicosodulieu KetNoiDuLieu = new Ketnoicosodulieu();
        SqlDataAdapter bodocghi;
        DataTable bangnv;
        int donghh;
        void HienThiDuLieu()
        {
            string sql = "select idsach, tensach, ngonngu, giabia, Sach.matl, TheLoai.tentheloai from Sach inner join Theloai on Theloai.matl = Sach.matl ";
            bangnv = KetNoiDuLieu.DocDuLieu(sql);
            bodocghi = KetNoiDuLieu.docghi;
            dgvCH.DataSource = bangnv;

        }
        void HienTheLoai()
        {
            string sql = "select * from Theloai";
            cbbTheLoai.DataSource = KetNoiDuLieu.DocDuLieu(sql);
            cbbTheLoai.DisplayMember = "tentheloai";
            cbbTheLoai.ValueMember = "matl";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cbbNgonNgu.SelectedIndex = 1;
            HienThiDuLieu();
            HienTheLoai();
        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtIdSach.Text != "")
            {
                float gia;
                if (float.TryParse(txtGiaBia.Text, out gia))
                {
                    KetNoiDuLieu.ThaoTacDuLieu("insert into Sach values('" + txtIdSach.Text + "','" + txtTenSach.Text + "',N'" + cbbNgonNgu.Text + "','" + txtGiaBia.Text + "','" + cbbTheLoai.SelectedValue + "')");
                    bangnv.Clear();
                    HienThiDuLieu();
                }
                else
                    MessageBox.Show("Giá bìa phải là số");
                
            }
        }
    }
}
