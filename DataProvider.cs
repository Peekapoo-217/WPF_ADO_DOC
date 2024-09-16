using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPF_ADO
{
    internal class DataProvider
    {
        private string connectionString = "Data Source=LAPTOP-AAITQIGN;Initial Catalog=QLCHOTHUENHA;Integrated Security=True";
        private SqlConnection connection;
        private SqlDataAdapter adapter;

        public DataProvider()
        {
            connection = new SqlConnection(connectionString);
        }

    //LoadData
        public DataTable LoadData()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT * FROM NHA";
                adapter = new SqlDataAdapter(query, connection);
                connection.Open();
                adapter.Fill(dt);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu!" + ex.Message);
                connection.Close();
            }
            return dt;
        }

        //LoadData sql JOIN các thứ
        public DataTable LoadHopDong()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = @"
                SELECT 
                    hd.SoHD, 
                    cn.TenChuNha, 
                    kh.TenKhach, 
                    hd.NgayBatDau, 
                    hd.NgayKetThuc, 
                    DATEDIFF(month, hd.NgayBatDau, hd.NgayKetThuc) * cn.GiaThue AS ThanhTien 
                FROM 
                    HOPDONG hd
                INNER JOIN 
                    NHA cn ON hd.MaNha = cn.MaNha
                INNER JOIN 
                    KHACHTHUENHA kh ON hd.MaKhach = kh.MaKhach";

                adapter = new SqlDataAdapter(query, connection);
                connection.Open();
                adapter.Fill(dt);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu hợp đồng!" + ex.Message);
                connection.Close();
            }
            return dt;
        }



        #region
        //Kiểm tra mã nhà trùng lặp
        public bool MaNhaTrungLap(string maNha)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM NHA WHERE MaNha = @MaNha";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaNha", maNha);
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    connection.Close();
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kiểm tra mã nhà!" + ex.Message);
                connection.Close();
                return true;
            }
        }
        public bool TenChuNhaRong(string tenChuNha)
        {
            return string.IsNullOrWhiteSpace(tenChuNha);
        }
        public bool giaThueLaSo(string giaThueSTR, out float giaThue)
        {
            return float.TryParse(giaThueSTR, out giaThue);
        }



        #endregion


        //Chức năng thêm
        public bool Them(string maNha, string tenChuNha, float giaThue, bool daChoThue)
        {
            try
            {
                string query = "INSERT INTO NHA (MaNha, TenChuNha, GiaThue, DaCHoThue) VALUES (@MaNha, @TenChuNha, @GiaThue, @DaCHoThue)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaNha", maNha);
                    command.Parameters.AddWithValue("@TenChuNha", tenChuNha);
                    command.Parameters.AddWithValue("@GiaThue", giaThue);
                    command.Parameters.AddWithValue("@DaCHoThue", daChoThue);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm nhà!" + ex.Message);
                connection.Close();
                return false;
            }
        }

        public bool Sua(string maNha, string tenChuNha, float giaThue, bool daChoThue)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE NHA SET TenChuNha = @TenChuNha, GiaThue = @GiaThue, DaChoThue = @DaChoThue WHERE MaNha = @MaNha";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaNha", maNha);
                    command.Parameters.AddWithValue("@TenChuNha", tenChuNha);
                    command.Parameters.AddWithValue("@GiaThue", giaThue);
                    command.Parameters.AddWithValue("@DaChoThue", daChoThue);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật nhà!" + ex.Message);
                return false;
            }
        }

        public bool Xoa(string maNha)
        {
            try
            {
                string query = "DELETE FROM NHA WHERE MaNha = @MaNha";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaNha", maNha);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa nhà!" + ex.Message);
                connection.Close();
                return false;
            }
        }
    }
}
