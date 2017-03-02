using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyGiaoVien7
{
    public partial class frmQuanLyHoatDongGiaoVien7 : Form
    {
        public frmQuanLyHoatDongGiaoVien7()
        {
            InitializeComponent();
        }

        DataSet ds;
        DataView dv;
        SqlDataAdapter dachuyengiaocongnghe;
        SqlDataAdapter dagiaovien;
        SqlDataAdapter datengiaovien;
        SqlDataAdapter dachuyengiaocongnghe_tengiaovien;
        private void Form1_Load(object sender, EventArgs e)
        {
            string sChuoiKetNoi = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyHoatDongGiaoVien7;Integrated Security=True";
            string sSelectchuyengiaocongnghe = @"Select * from chuyengiaocongnghe";
            dachuyengiaocongnghe = new SqlDataAdapter(sSelectchuyengiaocongnghe, sChuoiKetNoi);
            ds = new DataSet("DsQuanLyHoatDongGiaoVien7");
            dachuyengiaocongnghe.Fill(ds, "tblchuyengiaocongnghe");
            dv = new DataView(ds.Tables["tblchuyengiaocongnghe"]);
           // dgvchuyengiaocongnghe.DataSource = ds.Tables["tblchuyengiaocongnghe"];
            dgvchuyengiaocongnghe.DataSource = dv;//gan nhu vay de thuc hien chuc nang tim kiem cho de rang hon vif dv hotro tim kiem
            //dat ten cot thafnh cos dau
            dgvchuyengiaocongnghe.Columns["ma"].HeaderText = "mã";
            dgvchuyengiaocongnghe.Columns["giaovienma"].HeaderText = "mã giáo viên";
            dgvchuyengiaocongnghe.Columns["ngaynhan"].HeaderText = "ngày nhận";
            dgvchuyengiaocongnghe.Columns["doanhthu"].HeaderText = "doanh thu";
            dgvchuyengiaocongnghe.Columns["thoigian"].HeaderText = "thời gian";
            //đặt lại độ dài cho các cột
            dgvchuyengiaocongnghe.Columns["ma"].Width = 40;
            dgvchuyengiaocongnghe.Columns["giaovienma"].Width = 50;
            dgvchuyengiaocongnghe.Columns["ngaynhan"].Width = 100;
            dgvchuyengiaocongnghe.Columns["doanhthu"].Width = 100;
            dgvchuyengiaocongnghe.Columns["thoigian"].Width = 150;
            //lay chuoi truy van lay thong tin ca hai bang
            string sSelectchuyengiaocongnghe_tengiaovien = @"Select chuyengiaocongnghe.*,giaovien.ten from chuyengiaocongnghe,giaovien where chuyengiaocongnghe.giaovienma =giaovien.ma";
            dachuyengiaocongnghe_tengiaovien = new SqlDataAdapter(sSelectchuyengiaocongnghe_tengiaovien, sChuoiKetNoi);
            dachuyengiaocongnghe_tengiaovien.Fill(ds, "tblchuyengiaocongnghe_tengiaovien");
            dgvchuyengiaocongnghe.DataSource = ds.Tables["tblchuyengiaocongnghe_tengiaovien"];
            //cho ten co dau tieng viet
            //an cot  ma giao vien
            // dgvchuyengiaocongnghe.Columns["giaovienma"].Visible = false;
            dgvchuyengiaocongnghe.Columns["ten"].HeaderText = "tên giáo viên";
            dgvchuyengiaocongnghe.Columns["ten"].Width = 90;
            //tao doi tuong ket noi den database
            SqlConnection con = new SqlConnection(sChuoiKetNoi);
            //tao doi tuong command thuc thi truy van
            string sthem = @"Insert into chuyengiaocongnghe(ma,giaovienma,ngaynhan,doanhthu,thoigian)values(@ma,@giaovienma,@ngaynhan,@doanhthu,@thoigian)";
            SqlCommand cmthem = new SqlCommand(sthem, con);
            cmthem.Parameters.Add(@"ma", SqlDbType.VarChar, 10, "ma");
            cmthem.Parameters.Add(@"giaovienma", SqlDbType.VarChar, 10, "giaovienma");
            cmthem.Parameters.Add(@"ngaynhan", SqlDbType.DateTime, 10, "ngaynhan");
            cmthem.Parameters.Add(@"doanhthu", SqlDbType.NVarChar, 20, "doanhthu");
            cmthem.Parameters.Add(@"thoigian", SqlDbType.DateTime, 20, "thoigian");
            dachuyengiaocongnghe.InsertCommand = cmthem;
            // dong ket noi
            con.Close();
            //them bang giao vien cho vào lien ket vs sql server
            // load cmbgiaovienma
            LoadCmbGiaoVien();
            string ssua = @"Update chuyengiaocongnghe set ma=@ma,giaovienma=@giaovienma,ngaynhan=@ngaynhan,doanhthu=@doanhthu,thoigian=@thoigian where ma=@ma";
            SqlCommand cmsua = new SqlCommand(ssua, con);
            cmsua.Parameters.Add(@"ma", SqlDbType.VarChar, 10, "ma");
            cmsua.Parameters.Add(@"giaovienma", SqlDbType.VarChar, 10, "giaovienma");
            cmsua.Parameters.Add(@"ngaynhan", SqlDbType.DateTime, 10, "ngaynhan");
            cmsua.Parameters.Add(@"doanhthu", SqlDbType.NVarChar, 20, "doanhthu");
            cmsua.Parameters.Add(@"thoigian", SqlDbType.DateTime, 20, "thoigian");
            dachuyengiaocongnghe.UpdateCommand = cmsua;
            // dong ket noi
            con.Close();
            //tạo đối tượng truy vấn command xóa dữ liệu
            string sxoa = @"Delete from chuyengiaocongnghe where ma=@ma";
            SqlCommand cmxoa = new SqlCommand(sxoa, con);
            cmxoa.Parameters.Add("@ma", SqlDbType.VarChar, 10, "ma");
            dachuyengiaocongnghe.DeleteCommand = cmxoa;
            // dong ket noi
            con.Close();
        }

        private void LoadCmbGiaoVien()
        {
            string sChuoiKetNoi = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyHoatDongGiaoVien7;Integrated Security=True";
            string select = @"select * from giaovien";
            SqlConnection conn = new SqlConnection(sChuoiKetNoi);
            SqlCommand cmd = new SqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = select;
            cmd.ExecuteNonQuery();
            dagiaovien = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dagiaovien.Fill(dt);
            cmbgiaovienma.DataSource = dt;
            cmbgiaovienma.DisplayMember = "ma";
            cmbgiaovienma.ValueMember = "ma";
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            //kiem tra tinh hop le cua dau vao du lieu
            if (txtma.Text == "" || cmbgiaovienma.Text == "")
            {
                MessageBox.Show("bạn cần phải nhập đầy đủ thông tin!", "thông báo");
                return;
            }
            //them 1 dong vao table chuyengiaocongnghe
            DataRow r = ds.Tables["tblchuyengiaocongnghe"].NewRow();
            //nhap gia tri vao cac trg tuong ung tren datarows
            r["ma"] = txtma.Text;
            r["giaovienma"] = cmbgiaovienma.Text;
            r["ngaynhan"] = dtpngaynhan.Text;
            r["doanhthu"] = txtdoanhthu.Text;
            r["thoigian"] = dtpthoigian.Text;
            //add vao bang
           ds.Tables["tblchuyengiaocongnghe"].Rows.Add(r);
            dgvchuyengiaocongnghe.DataSource = ds.Tables["tblchuyengiaocongnghe"];
        }
      
        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {
                dachuyengiaocongnghe.Update(ds, "tblchuyengiaocongnghe");
                MessageBox.Show("lưu thanh công", "thông báo");
            }
            catch(Exception ex)
            {
                return;
            }
        }

        private void dgvchuyengiaocongnghe_Click(object sender, EventArgs e)
        {
            //lay thong tin de sua bang
            DataGridViewRow dr = dgvchuyengiaocongnghe.SelectedRows[0];
            txtma.Text = dr.Cells["ma"].Value.ToString();
            cmbgiaovienma.SelectedValue = dr.Cells["giaovienma"].Value.ToString();
            dtpngaynhan.Text = dr.Cells["ngaynhan"].Value.ToString();
            txtdoanhthu.Text = dr.Cells["doanhthu"].Value.ToString();
            dtpthoigian.Text = dr.Cells["thoigian"].Value.ToString();

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvchuyengiaocongnghe.SelectedRows[0];
            dgvchuyengiaocongnghe.BeginEdit(true);
            dr.Cells["ma"].Value = txtma.Text;
            dr.Cells["giaovienma"].Value = cmbgiaovienma.SelectedValue;
            dr.Cells["ngaynhan"].Value = dtpngaynhan.Text;
            dr.Cells["doanhthu"].Value = txtdoanhthu.Text;
            dr.Cells["thoigian"].Value = dtpthoigian.Text;
            //add vao bang
            //ds.Tables["tblchuyengiaocongnghe"].Rows.Add(dr);
            dgvchuyengiaocongnghe.DataSource = ds.Tables["tblchuyengiaocongnghe"];
            dgvchuyengiaocongnghe.EndEdit();
            MessageBox.Show("cập nhập dữ liệu thanh công", "thông báo");

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = dgvchuyengiaocongnghe.SelectedRows[0];
                dgvchuyengiaocongnghe.Rows.Remove(dr);
                dgvchuyengiaocongnghe.DataSource = ds.Tables["tblchuyengiaocongnghe"];
                MessageBox.Show("xóa thành công!","thông báo");
            }
            catch(Exception ex)
                {
                    MessageBox.Show("xóa thất bại","thông báo");
                }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            //quya trở lại cái mày vuwrda xóa hoặc sửa
            //neesu bam nut luu thif k huy ddk
            ds.Tables["tblchuyengiaocongnghe"].RejectChanges();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("bạn thực sự muốn thoát?", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
            return;
        }

        private void txttimkiem_Click(object sender, EventArgs e)
        {
            txttimkiem.Text = "";
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            //dv.RowFilter = "ma like '%" + txttimkiem.Text + "%'";
         //dv.RowFilter = string.Format("ma like'%{0}'", txttimkiem.Text);
          //  string schuoiketnoi = string.Format("ma like '%{0}%'", txttimkiem.Text);
            //ds.Tables["tblchuyengiaocongnghe"].DefaultView.RowFilter = schuoiketnoi;
            dv.RowFilter = "ma like '%" + txttimkiem.Text + "%'";
            dv.RowFilter = string.Format("ma like '%{0}%'", txttimkiem.Text);
        }
    }
}