   M S B A M L   `   `   `  ����R  NLTUDQL2_QUAN_LY_CCVIDEO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:LTUDQL2_QUAN_LY_CCVIDEO.ViewsLTUDQL2_QUAN_LY_CCVIDEO.Views  5   	   3    -LTUDQL2_QUAN_LY_CCVIDEO.Views.VideoFullScreen   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:LTUDQL2_QUAN_LY_CCVIDEO.Views     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � WindowStartupLocation$  CenterScreen=�5	   	   $��20(�5
   	    � WindowState$ 	Maximized=�5   	    � Title$ VideoFullScreen��5   	   $	��720��6!   $
��1280��6.    � WindowStyle$
 None=�6;    J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ MediaCommands.Play��5      6S     5   
   -   5        $ MediaCommands.Pause��5      6U     5   
   -   5        $ MediaCommands.Stop��5      6S   .��5      �� 
���   �$��1q�6!   ._�5   
   � .+�5      r� -   5        $��
mediaVideo��5   '   $��0q�6    r� Stretch$
 Fill=�5        r� LoadedBehavior$ Manual=�5        r� Source 5   '   �� 	 �� Path$	 PathVideoPhim�5       d� 5      -   5        
 d�Name$
 btnPlayorPause��5      $��80��63   $��80��6?   
������  $   MaterialDesignActionToggleButton#��[  5       �� 	ClickMode$ Press=�5      ��5!      '  !MaterialDesignThemes.Wpf.PackIcon  5"      $��50��6.   $��50��6:   �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]   Kind$ Pause=�6E   ���	#FFFCD7006S   1  +MaterialDesignThemes.Wpf.ToggleButtonAssist   	OnContent 5$        5%      $��50��6.   $��50��6:   $
 Play=�6E   ���	#FFFCD7006Q   5'      �� 5(      -   5         ��Name$ stusBar��5(      $
��Auto��6)   $��50��66   ���	#FFEECB0A$��1q�5)   <   
������ $��Bottom=�5*   =   .@�5.      �� .��5/      �� $��MediaCommands.Pause��6   $��5q�6;   
������ 
������ ���	#FFFCD700.��52        $ Pause=�62   $��28��6?   $��28��6K   54      55      �� 56      .��57      �� $��MediaCommands.Play��6   $��5q�6:   
������ 
������ ���	#FFFCD700.��5:        $
 Play=�62   $��28��6>   $��28��6J   5<      5=      �� 5?      .��5@      �� $��MediaCommands.Stop��6   $��5q�6:   
������ 
������ ���	#FFFCD700.��5C        $
 Stop=�62   $��28��6?   $��28��6K   5D      5F      �� 5G      .��5H      �� -   5        $��lblProgressStatus��5H   9   $
��Auto��6    $��50��6.   ���	#FFFCD700
00:00:006s   5I      �� 5J      .��5K      �� -   5        $��
sliderTime��5K      $��2,0,0,0q�6/   $��Center=�6@   $
��1450��5L      $
��Auto��6+   ���	#FFEECB0A5N   H   5O      �� 5P      .��5Q      �� -	   5         ��Name$ btnFullScreen��5Q   E   $��5q�6:   
������ $��Right=�5R   C   
������ ���	#FFFCD700.��5T        $ 
Fullscreen=�62   $��28��6E   $��28��6Q   5U      5W      �� 5X      .��5Y      �� -
   5        $ btnExitFullScreen��5Y      $	��1,0q�6X   
������ 
������ ���	#FFFCD700.��5\        $ FullscreenExit=�62   $��28��6I   $��28��6U   5]      5_      5b      5c      5d      5e      