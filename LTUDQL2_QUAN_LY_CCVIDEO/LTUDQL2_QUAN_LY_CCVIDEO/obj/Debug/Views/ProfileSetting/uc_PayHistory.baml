   M S B A M L   `   `   `  ����R  NLTUDQL2_QUAN_LY_CCVIDEO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullk:clr-namespace:LTUDQL2_QUAN_LY_CCVIDEO.Views.ProfileSetting,LTUDQL2_QUAN_LY_CCVIDEO.Views.ProfileSetting  5      M+clr-namespace:LTUDQL2_QUAN_LY_CCVIDEO.ModelLTUDQL2_QUAN_LY_CCVIDEO.Model  5      @    :LTUDQL2_QUAN_LY_CCVIDEO.Views.ProfileSetting.uc_PayHistory   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Llocal:clr-namespace:LTUDQL2_QUAN_LY_CCVIDEO.Views.ProfileSetting     5      9v+clr-namespace:LTUDQL2_QUAN_LY_CCVIDEO.Model     5      V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      
�������  � 	Resources  5       
  levels S� 
ObjectType.   (LTUDQL2_QUAN_LY_CCVIDEO.Model.DBProvider S� 
MethodName  mail��%o   &	        &	 ,     S� 5   
   "  6,   $ getCapDo��6O   S� 5   
   "  6*   $ getAccounts��6M   5      .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dtgVideo��5   J   
�������$��5,5,5,5q�6&      
IsReadOnly .    CanUserSortColumns .    CanUserAddRows .     AutoGenerateColumns .  -  'MaterialDesignThemes.Wpf.DataGridAssist   CellPadding$ 13 8 8 8q�5      	   ColumnHeaderPadding$	 8q�6P   ��5   \   �� 
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 62    0 ,MaterialDesignDataGridTextColumnEditingStyle1  +System.Windows.Controls.DataGridBoundColumn   EditingElementStyle# [ 5   %      Binding 5   %   �� *MaThanhToan+  5      $
 Name��6%   # [ 5   %   $	 250 6y    5   %   �� *TenThanhToan+4  .System.Windows.Controls.DataGridComboBoxColumn  5      $
 Mail��6)   $	 300 67      SelectedValuePath$ 
MaTaiKhoan��5   )      DisplayMemberPath$ TenTaiKhoan��5    )      ItemsSource 5   )   ��  �� Source# [    SelectedValueBinding 5   )   �� *
TaiKhoan+5    )     5#      $ Level��6)   $	 100 68   $ MaCapDo��5&   )   $ TenCapDo��5'   )    5$   )   �� # [   5%   )   �� *
CapDoMua+5'   )     5(      $ ID Card��6%   $	 150 66    6B   �� *IDThe+5-      5/      50      