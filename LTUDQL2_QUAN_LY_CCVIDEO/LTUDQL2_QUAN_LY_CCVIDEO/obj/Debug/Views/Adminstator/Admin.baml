   M S B A M L   `   `   `  ����R  NLTUDQL2_QUAN_LY_CCVIDEO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle7clr-namespace:LTUDQL2_QUAN_LY_CCVIDEO.Views.Adminstator)LTUDQL2_QUAN_LY_CCVIDEO.Views.Adminstator  5   	   5    /LTUDQL2_QUAN_LY_CCVIDEO.Views.Adminstator.Admin   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Ilocal7clr-namespace:LTUDQL2_QUAN_LY_CCVIDEO.Views.Adminstator     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � WindowStartupLocation$  CenterScreen=�5
   	   $��20(�5   	    � Title$
 ETTY��5   	   $	��700��6   $
��1200��6#    � 
ResizeMode$ CanMinimize=�60   .��5      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ White��6    � Offset$ 0Q�6-   � 5      $ 	#FFFED700��6   $ 1Q�61   5      .+�5   
   �� $	��100��6   $	��Top=�6"    �� Orientation$ 
Horizontal=�6;   .+�5      �� -   5         ��Name$ btnBackToHome��5   !   $��80��6   $
��Left=�68   $��Center=�6S   $��5q�6n   
������ 
������ .��5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]	   Kind$	 	ArrowLeft=�6*   $��50��6<   $��50��6H   ���	#FFFFE2346S   5      �� 5      -   5        $ btnChartPie��5   !   $��80��6   $
��Left=�66   $��Center=�6Q   $��5q�6l   
������ 
 � ToolTip$
 Search in IMDB��6�   
������ .��5        $	 ChartPie=�6*   $��50��6;   $��50��6G   ���	#FFFFE2346R   5      �� 5      -   5        $ btnSearchIMDB��5   !   $��80��6   $
��Left=�68   $��Center=�6S   $��5q�6n   
������ $
 Search in IMDB��6�   
������ .��5        $	 	SearchWeb=�6*   $��50��6<   $��50��6H   ���	#FFFFE2346S   5       �� 5!      -   5        $ 	btnUpLoad��5!   !   $��80��6   $
��Left=�64   $��Center=�6O   $��5q�6j   
������ $
 Upload Video��6�   
������ .��5"        $	 Upload=�6*   $��50��69   $��50��6E   ���	#FFFFE2346P   5#      �� 5$      -   5        $ btnAcc��5$   !   $��80��6   $
��Left=�61   $��Center=�6L   $��5q�6g   
������ $
 Search in IMDB��6�   
������ .��5%        $	 HomeAccount=�6*   $��50��6>   $��50��6J   ���	#FFFFE2346U   5&      �� 5'      -   5        $��D:\LTUDQL2\a.png��5'   1   $	��120��6K   $	��150��6X   $��100,-50q�6d   5(      � 5)   
   $��	0,100,0,0q�6    � ColumnDefinitions 5*      �� 5+      �� 5,      $��4* �6#   .+�5.      � $��0��6   $��5,5,0,5q�6#   
������ .+�5/      R� $	��220��6   .@�50      Q� $��	Dashboard��6#    Q� 
IsExpanded . .@�51      Q� -   5        $��TopLiked��51   '   $��	Top Liked��67   6J   Q� 52      -   5        $��	TopViewed��52   '   $��
Top Viewed��68   6L   53      Q� 54      $��Video Manager��6#    . .@�55      Q� -	   5        $��GeneralItem��55   '   $��General��6:   6K   Q� 56      -
   5        $��
SearchItem��56   '   $��Search in IMDB��69   6Q   Q� 57      -   5        $��
UploadItem��57   '   $��Upload��69   6I   58      Q� 59      -   5        $��AccountItem��59   #   $��Account Manager��66   5;      5<      5=      � 5>      -   5         �Name$ content��5>      $��1��6$   $��Stretch=�64   $��Stretch=�6R   $��5q�6n   
�������5@      5A      5B      5C      