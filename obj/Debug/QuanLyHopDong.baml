   M S B A M L   `   `   `  ����B  >WPF_ADO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WPF_ADOWPF_ADO  5   	       WPF_ADO.QuanLyHopDong   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WPF_ADO     5   	     � Title$  QuanLyHopDong��5   	   $	��600��6   $	��800��6,   .��5	      � .+�5
   
   �� .+�5      �� $"��Thông tin khách thuê nhà��6   $	��200��69   .��5      �  � ColumnDefinitions 5      �� 5      $	��100 �6+   69   �� 5      6-   �� 5      6-   �� 5      $	��100 �6+   69    � RowDefinitions 5      �� 5      6*   �� 5      6*   �� 5      $��40 �6(   66   �� 5      6*   �� 5      6*   .+�5      �� $��Mã hợp đồng��6    $��0��63   $��0��6C   6R   �� 5      -   5         ��Name$ txtMaHopDong��5      $��1��64   $��0��6D   6S   �� 5      $��Tên chủ nhà��6    $��0��63   $��1��6C   6R   �� 5       -   5        $ txtTenChuNha��5       $��1��64   $��1��6D   6S   �� 5"      $��Tên khách��6    $��0��61   $��2��6A   6P   �� 5#      -   5        $ txtTenKh��5#      $��1��60   $��2��6@   6O   �� 5%      $��Ngày Bắt Đầu��6    $��0��64   $��3��6D   6S   (  "System.Windows.Controls.DatePicker  5&      -   5          Name$ dtpNgayBatDau��5&   !   $��1��68   $��3��6H   6W   �� 5(      $��Ngày Kết Thúc��6    $��0��65   $��4��6E   6T     5)      -   5        $ dtpNgayKetThuc��5)   !   $��1��69   $��4��6I   6X   5*      5+      �� 5-      $��Tìm kiếm��6   $��50��6)   .��5.      ��  �� Orientation$ 
Horizontal=�6   .+�5/      �� -   5        $ 
txtTimKiem��5/      $�� ��62   $	��300��6:   $
��70,1q�6F   6V   �� 50      -   5         ��Name$ 
btnTimKiem��50      $	��100��61   $��Tìm Khách��6=   6S   51      52      �� 54      $��Danh sách hợp đồng��6   .��55      &   System.Windows.Controls.DataGrid  -   5          Name$ DataGrid��55      $	��150��6-      AutoGenerateColumns .  	   Columns	 56      0  *System.Windows.Controls.DataGridTextColumn  58      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Số hợp đồng��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6B   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6N   �� *SoHD+  59      $
 Tên chủ nhà��6-   $	 100 6B    6N   �� *	TenChuNha+  5:      $
 Tên khách hàng��6-   $	 100 6E    6Q   �� *
TenKhach+  5;      $
 Ngày bắt đầu��6-   $	 100 6C    6O   �� *
NgayBatDau+  5<      $
 Ngày kết thúc��6-   $	 100 6D    6P   �� *NgayKetThuc+  5=      $
 Thành tiền��6-   $	 100 6A    6M   �� *	ThanhTien+5?      5@      �� 5B      $��Chức năng��6   $��50��6*   $	��500��66   .��5C      �� $ 
Horizontal=�6   .+�5D      �� -	   5        $ btnThem��5D      $��Thêm��6.   $��70��6=   $
��10,1q�6H   6X   �� 5E      -
   5        $ btnSua��5E      $��Sửa��6-   $��70��6;   $
��10,1q�6F   6V   �� 5F      -   5        $ btnXoa��5F      $
��Xóa��6-   $��70��6;   $
��10,1q�6F   6V   �� 5G      -   5        $ 	btnLamMoi��5G      $��
Làm mới��60   $��70��6B   $
��10,1q�6M   6u   5H      5I      5K      5L      5M      