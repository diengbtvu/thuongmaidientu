using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace De02_110121255_LamHueTrung
{
    class Ketnoicosodulieu
    {
        public SqlConnection ketnoi;
        public SqlDataAdapter docghi;
        public SqlCommand lenh;
        public SqlCommandBuilder capnhat;
        public Ketnoicosodulieu()
        {
            ketnoi = new SqlConnection();
            string chuoiketnoi = "Data Source=.;Initial Catalog=QLCH;Integrated Security=true";
            ketnoi.ConnectionString = chuoiketnoi;
        }

        public DataTable DocDuLieu(string sql)
        {
            ketnoi.Open();
            docghi = new SqlDataAdapter(sql, ketnoi);
            DataTable bangtam = new DataTable();
            docghi.Fill(bangtam);
            ketnoi.Close();
            return bangtam;
        }

        public void ThaoTacDuLieu(string sql)
        {
            ketnoi.Open();
            lenh = new SqlCommand(sql, ketnoi);
            lenh.ExecuteNonQuery();
            ketnoi.Close();
        }

        public void CapNhatDuLieu(SqlDataAdapter bdg, DataTable dt)
        {
            capnhat = new SqlCommandBuilder(bdg);
            bdg.Update(dt);
        }
    }
}
