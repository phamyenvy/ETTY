   M S B A M L   `   `   `  ����R  NLTUDQL2_QUAN_LY_CCVIDEO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:LTUDQL2_QUAN_LY_CCVIDEO.ModelLTUDQL2_QUAN_LY_CCVIDEO.Model  5      e7clr-namespace:LTUDQL2_QUAN_LY_CCVIDEO.Views.Adminstator)LTUDQL2_QUAN_LY_CCVIDEO.Views.Adminstator  5	      <    6LTUDQL2_QUAN_LY_CCVIDEO.Views.Adminstator.VideoGeneral   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      9v+clr-namespace:LTUDQL2_QUAN_LY_CCVIDEO.Model     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Clocal7clr-namespace:LTUDQL2_QUAN_LY_CCVIDEO.Views.Adminstator  5	        � 	Resources  5       
  levels S� 
ObjectType.   (LTUDQL2_QUAN_LY_CCVIDEO.Model.DBProvider S� 
MethodName  cats��%k   &	        &	 ,     S� 5   
   "  6,   $ getCapDo��6O   S� 5   
   "  6*   $ GetCats��6M   5      .��5      � 
�������.+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dtgVideo��5   %   $��5,5,5,60q�6      AutoGenerateColumns .     CanUserSortColumns .    CanUserAddRows .  -  'MaterialDesignThemes.Wpf.DataGridAssist   CellPadding$ 13 8 8 8q�5         ColumnHeaderPadding$ 8q�6P   ��5   7   �� 	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 ID��6%    0 ,MaterialDesignDataGridTextColumnEditingStyle1  +System.Windows.Controls.DataGridBoundColumn   EditingElementStyle# [ 5    %      Binding 5!   %   �� *	MaVideo+  5"      $

 Name��6%   # [ 5#   %      Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6y    5$   %   �� *
TenVideo+4  .System.Windows.Controls.DataGridComboBoxColumn  5%      $
 
Categories��6)   $	 100 6=      SelectedValuePath$ MaLoaiVideo��5'   )      DisplayMemberPath$ TenLoaiVideo��5(   )      ItemsSource 5%   I   ��  �� Source# [    SelectedValueBinding 5&   )   �� *MaLoai_Video+5(   )     5+      $
 Level��6)   $ 70 68   $ MaCapDo��5-   )   $ TenCapDo��5.   )    5+   C   �� # [   5,   )   �� *
CapDoVideo+5.   )     5/      $
 Release��6%   $ 92 66    6A   �� *NgaySanXuat+  50      $
 Upload��6%   $ 92 65    6@   �� *
NgayUpload+  52      $

 Like��6%    63   �� *Like+  53      $
 Viewed��6%   $
 Auto 65    6B   �� *	LuotXem+4	  .System.Windows.Controls.DataGridTemplateColumn	  55      $
 Delete��6)    	  CellTemplate 56      �� 57      .R�58      �� $��	btnDelete��6%   -   5        $��10q�58   6   ���	#FFEE1717.��59   "   '
  !MaterialDesignThemes.Wpf.PackIcon
  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]   Kind$ Delete=�6:   $��20��6H   $��20��6T   
���   �6_   5:      5;      5=         RowDetailsTemplate 5@      �� 5A      .R�5B      �� $��1q�6   
��� ��� �� CornerRadius$ 7��6F   $��5q�5C      $��Center=�6(   $��Center=�6E   $	��900��6`   ._�5D      �� .+�5E      ��  �� Orientation$ 
Horizontal=�6)   .+�5F   "   �� $��Link Video: ��6,   $��5q�6@   �� 5G   "   ��6*   �� *	LinkVideo+5H      �� 5I      $ 
Horizontal=�6)   .+�5J   "   �� $��Link Image: ��6,   $��5q�6@   �� 5K   "   ��6*   �� *	LinkImage+5L      �� 5M      $ 
Horizontal=�6)   .+�5N   "   �� $��Link Trailer: ��6,   $��5q�6B   �� 5O   "   ��6*   �� *LinkTrailer+5P      �� 5Q      $ Vertical=�6)   .+�5R   "   �� $��Description: ��6,   $��5q�6A   �� 5S   "   $��5q�6@    �� AcceptsReturn .  �� TextWrapping$
 Wrap=�6`   $
��Auto=�6t   ��. ��6*   �� *MoTa+6�   5T      5U      5V      5W      5Y      5[      5\      