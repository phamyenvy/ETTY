   M S B A M L   `   `   `  ����R  NLTUDQL2_QUAN_LY_CCVIDEO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle7clr-namespace:LTUDQL2_QUAN_LY_CCVIDEO.Views.Adminstator)LTUDQL2_QUAN_LY_CCVIDEO.Views.Adminstator  5      U/clr-namespace:LTUDQL2_QUAN_LY_CCVIDEO.Converter!LTUDQL2_QUAN_LY_CCVIDEO.Converter  5      :    4LTUDQL2_QUAN_LY_CCVIDEO.Views.Adminstator.IMDBSearch   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Ilocal7clr-namespace:LTUDQL2_QUAN_LY_CCVIDEO.Views.Adminstator     5      F
converters/clr-namespace:LTUDQL2_QUAN_LY_CCVIDEO.Converter     5      V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	        � 	Resources  5      :   4LTUDQL2_QUAN_LY_CCVIDEO.Converter.PosterUrlConverter   posterUrlToImg��%   &	          5   
   6(   5      .��5      � 
������� � RowDefinitions 5   
   �� 5      $��55 �6   �� 5      .+�5   
   (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ Standard=�6$   $��8 4 8 4q�64      CornerRadius$ 2��6F    K� ZIndex$ 1��6W   $��7q�5   $   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth1=�5   $   ���	#FFF1F1F1.��5      �  � ColumnDefinitions 5      �� 5      $
��Auto �6'   �� 5      $��* �6'   �� 5      $
��Auto �6'   .+�5      �� -   5         ��Name$ 	btnSearch��5        MaterialDesignToolButton#���  6,   .��5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]   Kind$ Magnify=�6.   	 J� Opacity$		 .56Q�6=   5      �� 5      -   5        
 ��Name$
 	txtSearch��5      $��1��6-   $��8 0 0 0q�6=   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Search ...��6N   .  (MaterialDesignThemes.Wpf.TextFieldAssist   DecorationVisibility$ Hidden=�5    &   $��0q�6c   $	��200��5!   &   $��Center=�65   $��15(�6P   5"   "   5#      5$      �� 5%   
   -   5        $��
searchList��5&      $��5 2 5 5q�5%      $��1��6#   
�������$
��Auto=�5(      ��5)      �� 5*      .R�5+      ��  �� Orientation$ Vertical=�6%   $	��230��6<   $��Center=�5,   %   $��Center=�6B   $��3q�5-   %   .+�5.      �� $��Center=�5/   "   $��Center=�50   "   $
��Wrap=�51   "   $	��180��52   "   $��68��6.    �� TextAlignment$ Center=�53   "   $��15(�54   "   $
��Bold"�55   "   $
��Auto=�56   "   ��5.   $   �� *Title+56   "   � 57       58      �� 59   "   �� 5:   "   �� 5;   "   .+�5>      �� $��3��6$   $	��190��68   $	��240��6D   ��5?      �� *Poster+ �� 	Converter# [  �� 5@      $��btnGet��6%   -   5        $��1��5@   J   $��60��6Z   $��Bottom=�5A   %   
������ 
���   �$	��Get��6m   ���	#FFFFEE62
 � Tag 5@   3   �� *ImdbID+5A   �   5B      5C      5D      ��5F      �� 5G      .R�5H      A�  K� IsItemsHost . $��Center=�65   5I      5L      5M      5N      