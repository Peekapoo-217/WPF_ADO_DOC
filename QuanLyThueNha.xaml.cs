using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF_ADO
{
    /// <summary>
    /// Interaction logic for QuanLyThueNha.xaml
    /// </summary>
    public partial class QuanLyThueNha : Window
    {
        private DataProvider dataProvider;
        public QuanLyThueNha()
        {
            InitializeComponent();
            dataProvider = new DataProvider();
            this.Loaded += QuanLyThueNha_Loaded;

        }

        private void QuanLyThueNha_Loaded(object sender, RoutedEventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            DataTable dataTable = dataProvider.LoadData();
            DataGrid.ItemsSource = dataTable.DefaultView;
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            string maNha = txtMaNha.Text;
            string tenChuNha = txtTenChuNha.Text;
            float giaThue;

            if (dataProvider.MaNhaTrungLap(maNha))
            {
                MessageBox.Show("Mã nhà đã tồn tại!");
                return;
            }

            if (dataProvider.TenChuNhaRong(tenChuNha))
            {
                MessageBox.Show("Không có tên chủ nhà!");
                return;
            }

            if (!dataProvider.giaThueLaSo(txtGiaThue.Text, out giaThue))
            {
                MessageBox.Show("Giá thuê phải là một giá trị số!");
                return;
            }

            bool daChoThue = rdYes.IsChecked == true;

            if (dataProvider.Them(maNha, tenChuNha, giaThue, daChoThue))
            {
                MessageBox.Show("Thêm nhà thành công!");
                LoadData();
            }
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            string maNha = txtMaNha.Text;
            string tenChuNha = txtTenChuNha.Text;
            float giaThue;
            bool daChoThue = rdYes.IsChecked == true;

            if (!dataProvider.giaThueLaSo(txtGiaThue.Text, out giaThue))
            {
                MessageBox.Show("Giá thuê không phải là số");
                return;
            }

            if (dataProvider.TenChuNhaRong(tenChuNha))
            {
                MessageBox.Show("Tên chủ nhà không được để trống!");
                return;
            }

            if (dataProvider.Sua(maNha, tenChuNha, giaThue, daChoThue))
            {
                MessageBox.Show("Đã sửa");
                LoadData();
            }
            else
            {
                MessageBox.Show("Lỗi sửa nhà");
            }

        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            string maNha = txtMaNha.Text;

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhà này?", "Xác nhận xóa", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                if (dataProvider.Xoa(maNha))
                {
                    MessageBox.Show("Xóa nhà thành công!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Lỗi khi xóa nhà");
                }
            }
        }

        //Buộc dữ liệu
        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataGrid.SelectedItem != null)
            {
                DataRowView row = (DataRowView)DataGrid.SelectedItem;

                // Lấy dữ liệu từ DataRowView và gán vào các TextBox tương ứng
                txtMaNha.Text = row["MaNha"].ToString();
                txtTenChuNha.Text = row["TenChuNha"].ToString();
                txtGiaThue.Text = row["GiaThue"].ToString();

                // Kiểm tra giá trị của DaChoThue và gán cho rdYes hoặc rdNo tương ứng
                bool daChoThue = (bool)row["DaChoThue"];
                rdYes.IsChecked = daChoThue;
                rdNo.IsChecked = !daChoThue;
            }
        }


    }
}