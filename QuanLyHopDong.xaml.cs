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
    /// Interaction logic for QuanLyHopDong.xaml
    /// </summary>
    public partial class QuanLyHopDong : Window
    {
        private DataProvider dataProvider;
        public QuanLyHopDong()
        {
            InitializeComponent();
            dataProvider = new DataProvider();
            this.Loaded += QuanLyHopDong_Loaded;
        }

        private void QuanLyHopDong_Loaded(object sender, RoutedEventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            DataTable dataTable = dataProvider.LoadHopDong();
            DataGrid.ItemsSource = dataTable.DefaultView;
        }
    //Buộc dữ liệu
        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataGrid.SelectedItem is DataRowView row)
            {
                txtMaHopDong.Text = row["SoHD"].ToString();
                txtTenChuNha.Text = row["TenChuNha"].ToString();
                txtTenKh.Text = row["TenKhach"].ToString();

                if (DateTime.TryParse(row["NgayBatDau"].ToString(), out DateTime ngayBatDau))
                {
                    dtpNgayBatDau.SelectedDate = ngayBatDau;
                }
                else
                {
                    dtpNgayBatDau.SelectedDate = null;
                }

                if (DateTime.TryParse(row["NgayKetThuc"].ToString(), out DateTime ngayKetThuc))
                {
                    dtpNgayKetThuc.SelectedDate = ngayKetThuc;
                }
                else
                {
                    dtpNgayKetThuc.SelectedDate = null;
                }
            }
        }

        private void btnLamMoi_Click(object sender, RoutedEventArgs e)
        {
            txtMaHopDong.Text = string.Empty;
            txtTenChuNha.Text = string.Empty;
            txtTenKh.Text = string.Empty;
            dtpNgayBatDau.SelectedDate = null;
            dtpNgayKetThuc.SelectedDate = null;

            // Tải lại dữ liệu
            LoadData();
        }
    }
}

