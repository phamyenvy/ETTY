   M S B A M L   `   `   `  ����R  NLTUDQL2_QUAN_LY_CCVIDEO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:LTUDQL2_QUAN_LY_CCVIDEO.ViewsLTUDQL2_QUAN_LY_CCVIDEO.Views  5   	   /    )LTUDQL2_QUAN_LY_CCVIDEO.Views.DetailVideo   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:LTUDQL2_QUAN_LY_CCVIDEO.Views     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � WindowStartupLocation$  CenterScreen=�5	   	   $��20(�5
   	    � Title$
 ETTY��5   	   $	��700��6   $
��1200��6#    � 
ResizeMode$ CanMinimize=�60    � WindowStyle$
 None=�6I    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $h bpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.PopupBox.xaml?�6%   %    5       J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ MediaCommands.Play��5      6S     5   
   -   5        $ MediaCommands.Pause��5      6U     5   
   -   5        $ MediaCommands.Stop��5      6S   .��5      � ��5   
   �� 5      	 �� EndPoint$	 0.5,1&�6"   
 � MappingMode$
 RelativeToBoundingBox=�63    �� 
StartPoint$ 0.5,0&�6W   .��5      �  � Color$ 	#FF3E3D3B��6   � 5      $ 	#FFCBAC00��6    � Offset$ 1Q�61   5      .+�5#   
   �� .��5%      #  MaterialDesignThemes.Wpf.Card  $��20,120,20,0q�6"   $
��Auto��67   ��5&      �� 5'      $	 0.5,1&�6*   $ 0.5,0&�6;   .��5(      � $ White��6'   $ 0Q�65   � 5)      $ 	#FFFCD700��6'   $ 1Q�69   5*      .��5.      �� .+�5/      �� 
���   �$��1q�61   ._�50      � ��51      �� 52   "    �� ImageSource 6-   ��  �� Path$
 Path�.+�54      r� -   5        $��
mediaVideo��54   7   $��0q�6+    r� Stretch$
 Fill=�56       $	��530��6/    r� LoadedBehavior$ Manual=�57        r� Source 55   '   �� $ PathVideoPhim�59       d� 5:      -   5         d�Name$ btnPlayorPause��5:   +   $��80��6C   $��80��6O   
������  $   MaterialDesignActionToggleButton#��[  5<       �� 	ClickMode$ Press=�5>      ��5@   "   '  !MaterialDesignThemes.Wpf.PackIcon  5A   &   $��50��6@   $��50��6L   �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]   Kind$
 Play=�6W   ���	#FFFCD7006d   1  +MaterialDesignThemes.Wpf.ToggleButtonAssist   	OnContent 5C   "     5D   &   $��50��6>   $��50��6J   $ Pause=�6U   ���	#FFFCD7006b   5F      �� 5G      -   5         ��Name$ stusBar��5G   (   $
��Auto��69   $��50��6F   ���	#FFEECB0A$��1q�5H   <   
������ $��10,470,20,0q�5I   =   .@�5M   "   �� .��5N   &   �� $��MediaCommands.Pause��6-   $��5q�6K   
������ 
������ ���	#FFFCD700.��5Q   *     $ Pause=�6B   $��28��6O   $��28��6[   5S   '   5T   #   �� 5U   "   .��5V   &   �� $��MediaCommands.Play��6-   $��5q�6J   
������ 
������ ���	#FFFCD700.��5Y   *     $
 Play=�6B   $��28��6N   $��28��6Z   5[   '   5\   #   �� 5^   "   .��5_   &   �� $��MediaCommands.Stop��6-   $��5q�6J   
������ 
������ ���	#FFFCD700.��5b   *     $
 Stop=�6B   $��28��6O   $��28��6[   5c   '   5e   #   �� 5f   "   .��5g   &   �� -   5        $��lblProgressStatus��5g   I   $
��Auto��60   $��50��6>   ���	#FFFCD700
00:00:006�   5h   #   �� 5i   "   .��5j   &   �� -   5        $��
sliderTime��5j   -   $��2,0,0,0q�6?   $��Center=�6P   $	��650��5k      $
��Auto��6*   ���	#FFEECB0A5m   H   5n   #   �� 5o   "   .��5p   &   �� -	   5         ��Name$ btnFullScreen��5p   U   $��5q�6J   
������ 
������ ���	#FFFCD700.��5s   *     $ 
Fullscreen=�6B   $��28��6U   $��28��6a   5t   '   5v   #   �� 5w   "   .��5x   &   �� -
   5        $ btnExitFullScreen��5x   -   $��1q�6h   
������ 
������ ���	#FFFCD700.��5{   *     $ FullscreenExit=�6B   $��28��6Y   $��28��6e   5|   '   5~   #   5�      5�      5�      � 5�      $��50��6   
������ .+�5�      ��  �� Orientation$ 
Horizontal=�6%   $��50��6>   .+�5�      �� -   5         ��Name$ lblTenVideo��5�   $   $��30(�6X   ���#DF4949$
��Thin"�6{   ��69   �� $ Title�6{   5�      5�      �� 5�      $ 
Horizontal=�6!   $
��Auto��6:   .+�5�      �� -   5         + 'MaterialDesignFloatingActionLightButton#��[ 5�   "   
������ 
������ .��5�        -   5          Name$
 icon��5�   6   $ 
VolumeHigh=�6D   $��17��6V   $��17��6b   5�      �� 5�      -   5         ��Name$ sliderVolume��5�   D   $��10q�5�   !    �� TickFrequency$ 5Q�6-   $	��200��6?   $��Center=�6K    �� Orientation$ 
Horizontal=�6g    � Maximum$	 100Q�6�     � Minimum$  0Q�6�   ! � Value$	! 100Q�6�   ���	#FFFF1C1C5�   Z   �� 5�      -   5        " ��Name$" volumevalue��5�   $   6;   d� 5�      -   5         ) %MaterialDesignFlatPrimaryToggleButton#��[ 5�   (   # � ToolTip$# Add to your favorite list��5�      $ d� 	IsChecked$$ FalseY�5�      $��Center=�61   $
��Left=�5�      $��50��6:   $��50��5�      ���	#FF5C5C5C$y�Visible=�6B   ���	#FFF17171$��1q�5�   7   $��	10,0,10,0q�5�       
% � Tag% 6L   �� $ ID�.��5�        $ ThumbUp=�66   $��	10,0,10,0q�5�   "   ���	#FFE3683A
������ 6M   5�      d� 5�      -   5        $ btnAddMyList��5�   ?    ) %MaterialDesignActionLightToggleButton#��[ 6U   $$ FalseY�5�   #   ���	#FFE3683A$��Center=�5�   #   $
��Left=�6>   $��25��6Y   $��5q�6e   $��25��5�   #   $# Add my list��6.   
������ % 5�   '   �� $ ID�.��5�        $
 Plus=�66   $��17��6B   $��17��5�   5   ���	#FFE3683A6@   5�      �� 5�      $��Center=�6$   ���	#FF4A4736
Rating :6`   �� 5�      $��Center=�6$   $��10q�6?   ���#1A2530��6`   �� $ Views�5�      9� 5�      & 9� 
IsExpanded& . $
��Left=�61   
������ $	��500��6e   $
��Auto��6q   $��Description��6   .��5�      �� $ Vertical=�6%     MaterialDesignBody#���  6<   $��
24,8,24,16q�6x   .+�5�      �� ��6(   �� $ Title��� 5�      ' J� Opacity$	' .68Q�6)   $
��Wrap=�6Y   ���#1A2530��67   �� $ Description�5�      5�      5�      5�      5�      5�      � 5�   
   $��	0,0,0,580q�6   ��5�      �� 5�      $	 0.5,1&�6&   $
 RelativeToBoundingBox=�67   $ 0.5,0&�6[   .��5�      � $ 	#FF34495E��6#   � 5�      $ 	#FFF0CD09��6#   $ 1Q�65   � 5�      $ 	#FFDF4949��6#   $	 0.4Q�65   5�      .+�5�      �� $��/Images/a.png��6   $	��Top=�5�      $	��170��60   ( J� OpacityMask( �	#FFACA741$��0,-21,0,-29q�5�   0   �� 5�      -   5        $ btnBack��5�      $��70��6&   $��70��62   
������ 
������ $��10,10,1114,11q�5�   Z   .��5�        $ KeyboardBackspace=�6*   $��50��6C   $��50��6O   5�      5�      5�      5�      