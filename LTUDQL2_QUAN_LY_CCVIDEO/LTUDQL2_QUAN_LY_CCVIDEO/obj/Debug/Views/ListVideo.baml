   M S B A M L   `   `   `  ����R  NLTUDQL2_QUAN_LY_CCVIDEO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:LTUDQL2_QUAN_LY_CCVIDEO.ViewsLTUDQL2_QUAN_LY_CCVIDEO.Views  5   	   M+clr-namespace:LTUDQL2_QUAN_LY_CCVIDEO.ModelLTUDQL2_QUAN_LY_CCVIDEO.Model  5	   	   -    'LTUDQL2_QUAN_LY_CCVIDEO.Views.ListVideo   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:LTUDQL2_QUAN_LY_CCVIDEO.Views     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   6controls'using:Microsoft.Toolkit.Uwp.UI.Controls  5   	   3m+clr-namespace:LTUDQL2_QUAN_LY_CCVIDEO.Model  5	   	     � WindowStartupLocation$  CenterScreen=�5   	   $��20(�5   	    � Title$
 ETTY��5   	   $	��700��6   $
��1200��6#    � 
ResizeMode$ CanMinimize=�60    � 	Resources 5       �� DataType-   'LTUDQL2_QUAN_LY_CCVIDEO.Model.VideoInfo
 � Tag �� Path �� 
TargetType � LayoutTransform	 �� ImageSource
 � ColumnDefinitions � RowDefinitions r� Stretch r� LoadedBehavior r� Source d�Name )  %MaterialDesignFlatPrimaryToggleButton � ToolTip d� 	IsChecked'  !MaterialDesignThemes.Wpf.PackIcon�  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]   Kind ) %MaterialDesignActionLightToggleButton��%  (��       5      *, +)7   7  �� 6
   "  6   .R�5      � $��Scroll��6W   $	��250��6   $	��200��6   $��Center=�6,   $
��10,5q�6I    6e   �� $ ID���5      �� 5      " �6   .�5      -   5        5       5      �� 5      .+�5      � $
��0,30q�6   ��5      �� 5      	 6%   �� $
 Path�
 5      �� 5       �� 5!      �� 5"       5$      �� 5%      �� 5&      �� 5'      .+�5)      r� $��video��6I   $��3��6#   $��3��67   $
 Fill=�5+   #   $ Manual=�62    5*   #   �� $ 	PathVideo�5+   2   d� 5,      $ btnHeart��50      -   5        $��0��5,   $   $��2��64   8��  $ Love this video��5-      $ FalseY�5.      $��Center=�61   $
��Left=�6L   $��25��6g   $��5q�6s   $��25��5/      ���	#FFF17171$y�	Collapsed=�6A    50   1   �� $ ID�.��51        $ ThumbUp=�62   $��17��6A   $��17��52   2   
���  ��
������ 53   2   54      d� 55      $ btnAddMyList��6;   -   5        8�� $ FalseY�56   #   $��0��65   $��1��6E   $y�	Collapsed=�6R   ���	#FFFCE22B$��Center=�57   #   $
��Left=�6>   $��25��6Y   $��5q�6e   $��25��58   #   $ Add my list��6.   
������  55   #   �� $ ID�.��59        $
 Plus=�62   $��17��6>   $��17��5:   5   ���	#FFFCE22B6@   5;      5=      �� 5>      $�� 5,-10q�6   $
��Left=�6,   $��Bottom=�6G   
�������$��
UltraLight"�6�   $��20(�6�   ��6c   �� $ Title�6�   5C      5F      5G      .��5H      � ��5I   
   �� 5J       �� EndPoint$ 0.5,1&�6"    � MappingMode$ RelativeToBoundingBox=�63    �� 
StartPoint$ 0.5,0&�6W   .��5K      �  � Color$ 	#FF34495E��6   � 5L      $ 	#FFF0CD09��6    � Offset$ 1Q�61   � 5M      $ 	#FFDF4949��6   $	 0.4Q�61   5N       5P   
   �� 5Q      �� 5R      $��6* �6   .+�5T   
   (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ Inverted=�6#   $��90��63   $��16q�6?   ���#1A2530.��5U      ]� .+�5V      '  !MaterialDesignThemes.Wpf.PopupBox  $��Right=�6*      PlacementMode$ BottomAndAlignRightEdges=�6A      PopupContent. 5W      �� .@�5X      �� -   5        $��lstItemLogOut��5X   &   .��6]   	Log out5Z      5[      5\      �� 5]       �� Orientation$ 
Horizontal=�6   .+�5^      �� $ 
Horizontal=�6!   $��Stretch=�6:   .+�5_      �� -   5         ��Name$ btnBackToHome��5_   !   $
��Left=�68   $��Center=�6S   $��5q�6n   
������ 
������ .��5`        $ 	ArrowLeft=�66   $��30��6G   $��50��6S   5a      �� 5b      -   5        $��/Images/a.png��5b   <   $��80��6S   $	��100��6_   $��-20,-10,0,0q�6k   5e      5f        5g      $��Right=�6+   $ Standard=�6B   $��8 4 8 4q�6R      CornerRadius$ 2��6d    K� ZIndex$ 1��6u   $��7q�5h   $   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth1=�5i   $   ���#DCDCDC.��5j      � 
 5k      �� 5l      $
��Auto �6/   �� 5m      $��* �6/   �� 5n      $
��Auto �6/   .+�5p      �� -   5        $ 	btnSearch��5p   !     MaterialDesignToolButton#���  6L   .��5q        $ Magnify=�66     J� Opacity$	  .56Q�6E   5r      �� 5s      -   5        ! ��Name$! 	txtSearch��5s   "   $��1��65   $��8 0 0 0q�6E   )  #MaterialDesignThemes.Wpf.HintAssist"   Hint$" 
Search ...��6V   .  (MaterialDesignThemes.Wpf.TextFieldAssist#   DecorationVisibility$# Hidden=�5t   &   $��0q�6c   $	��200��5u   &   $��Center=�65   6P   5v      5w      o� 5y      ���	#FF1A2530$��0q�6.   
�������$��Center=�6L   .@�5{      m� -	   5        $��btnHome��5{   -   $
��Home��6   6T   m� 5|      -
   5        $��cbCats��5|   3   $��
Categories��6   ��6A   �� *
lstVideo+5}      m� 5~      -   5        $��My List��5~      6G   m� 5      -   5        $��menuplayList��5   1   $��Playlist��6   6G   5�      5�      5�      �� 5�   
   
������ $��2��60   $
��Auto��6=   .��5�      �� $
��10,0q�67   ��6   �� *[0]+��5�      �� 5�      .R�5�      A� $ A� Columns$$ 4��6'   5�      5�      5�      5�      5�      5�      