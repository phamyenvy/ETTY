   M S B A M L   `   `   `  ����R  NLTUDQL2_QUAN_LY_CCVIDEO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:LTUDQL2_QUAN_LY_CCVIDEO.ModelLTUDQL2_QUAN_LY_CCVIDEO.Model  5      e7clr-namespace:LTUDQL2_QUAN_LY_CCVIDEO.Views.Adminstator)LTUDQL2_QUAN_LY_CCVIDEO.Views.Adminstator  5      >    8LTUDQL2_QUAN_LY_CCVIDEO.Views.Adminstator.AccountGeneral   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      3v+clr-namespace:LTUDQL2_QUAN_LY_CCVIDEO.Model  5      Clocal7clr-namespace:LTUDQL2_QUAN_LY_CCVIDEO.Views.Adminstator  5        � 	Resources  5       
  levels S� 
ObjectType.   (LTUDQL2_QUAN_LY_CCVIDEO.Model.DBProvider S� 
MethodName��%6   &	        S� 5   
   "  6,   $ getCapDo��6O   5      .��5      � 
�������.+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dtgAcc��5   (   $��10,10,10,60q�6      CanUserSortColumns .    CanUserAddRows .     AutoGenerateColumns .  -  'MaterialDesignThemes.Wpf.DataGridAssist   CellPadding$ 13 8 8 8q�5         ColumnHeaderPadding$ 8q�6P   ��5      �� 	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 ID��6%    0 ,MaterialDesignDataGridTextColumnEditingStyle1  +System.Windows.Controls.DataGridBoundColumn   EditingElementStyle# [ 5   %      Binding 5   %   �� *
MaTaiKhoan+  5      $

 Name��6%   # [ 5   %      Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6y    5   %   �� *
TenHienThi+  5      $

 Mail��6%   $	 250 63    6?   �� *TenTaiKhoan+4  .System.Windows.Controls.DataGridComboBoxColumn  5      $
 Level��6)   $	 100 68      SelectedValuePath$ MaCapDo��5!   )      DisplayMemberPath$ TenCapDo��5"   )      ItemsSource 5   *   ��  �� Source# [     SelectedValueBinding 5    )   �� *CapDo+5"   )   4	  .System.Windows.Controls.DataGridTemplateColumn	  5#      $	
 EXP��6)   $	 110 66    	  CellTemplate 5$      �� 5%      .R�5&      �� .+�5'   "   (
  "System.Windows.Controls.DatePicker
   
  Text 6-   �� *
NgayHetHan+5(      5*      5-        5.      $
 Status��6)   $	 100 69     5/      $
 Card ID��6%   $	 120 66    6B   �� *IDThe+	  50      $
 Delete��6)    51      �� 52      .R�53      �� $��btnDeleteAcc��6%   -   5        $��10q�53   9   ���	#FFEE1717.��54   "   '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]   Kind$ Delete=�6:   $��20��6H   $��20��6T   
���   �6_   55      56      58      5:      5=      5>      