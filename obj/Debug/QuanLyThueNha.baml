   M S B A M L   `   `   `  ����B  >WPF_ADO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WPF_ADOWPF_ADO  5   	       WPF_ADO.QuanLyThueNha   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WPF_ADO     5   	     � Title$  QuanLyThueNha��5   	   $	��450��6   $	��800��6,   .��5	      � .+�5
   
   �� .+�5      �� $"��Thông tin khách thuê nhà��6   $	��150��69   .��5      �  � ColumnDefinitions 5      �� 5      $	��100 �6+   69   �� 5      6.   �� 5      6.   �� 5      $	��100 �6+   69    � RowDefinitions 5      �� 5      6*   �� 5      6*   �� 5      $��40 �6(   66   �� 5      6*   .+�5      �� $��Mã nhà��6    $��0��6.   $��0��6>   6M   �� 5      -   5         ��Name$ txtMaNha��5      $��1��60   $��0��6@   6O   �� 5      $��Tên chủ nhà��6    $��0��63   $��1��6C   6R   �� 5      -   5        $ txtTenChuNha��5      $��1��64   $��1��6D   6S   �� 5"      $��
Giá thuê��6    $��0��60   $��4��6@   6O   �� 5#      -   5        $ 
txtGiaThue��5#      $��1��62   $��4��6B   6Q   �� 5%      $��Trạng thái��6   $��0��63   $��2��6C   $��2��6P   .��5&      ��  �� Orientation$ 
Horizontal=�6%   .+�5'      	� -   5         	�Name$ rdYes��5'   *   $��Đã cho thuê��69   $��90��6O   $
��50,1q�6Z   	� 5(      -   5        $
 rdNo��5(   *   $��Chưa cho thuê��68   $	��100��6P   5)      5*      5+      5,      �� 5.      $"��Danh sách khách thuê nhà��6   .��5/      &   System.Windows.Controls.DataGrid  -   5          Name$ DataGrid��5/      $	��150��6-      AutoGenerateColumns .     Columns 50      0  *System.Windows.Controls.DataGridTextColumn  52      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Mã nhà��6-   
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 100 6=   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6I   �� *MaNha+  53      $	 Tên chủ nhà��6-   $	
 100 6B    6N   �� *	TenChuNha+  54      $	 
Giá thuê��6-   $	
 100 6?    6K   �� *	GiaThue+  55      $	 Trạng thái��6-   $	
 100 6A    6M   �� *	DaChoThue+57      58      �� 5:      $��Chức năng��6   $��50��6*   $	��500��66   .��5;      �� $ 
Horizontal=�6   .+�5<      �� -   5         ��Name$ btnThem��5<      $��Thêm��6.   $��70��6=   $
��10,1q�6H   6n   �� 5=      -   5        $ btnSua��5=      $��Sửa��6-   $��70��6;   $
��10,1q�6F   6k   �� 5>      -	   5        $ btnXoa��5>      $
��Xóa��6-   $��70��6;   $
��10,1q�6F   6k   �� 5?      -
   5        $ 	btnLamMoi��5?      $��
Làm mới��60   $��70��6B   $
��10,1q�6M   6]   5@      5A      5C      5E      5F      