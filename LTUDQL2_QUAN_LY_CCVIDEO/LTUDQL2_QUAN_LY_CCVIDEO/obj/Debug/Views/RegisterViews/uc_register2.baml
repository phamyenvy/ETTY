   M S B A M L   `   `   `  ����R  NLTUDQL2_QUAN_LY_CCVIDEO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulli9clr-namespace:LTUDQL2_QUAN_LY_CCVIDEO.Views.RegisterViews+LTUDQL2_QUAN_LY_CCVIDEO.Views.RegisterViews  5      >    8LTUDQL2_QUAN_LY_CCVIDEO.Views.RegisterViews.uc_register2   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Klocal9clr-namespace:LTUDQL2_QUAN_LY_CCVIDEO.Views.RegisterViews     5      V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      $��20(�5
      .��5      #  MaterialDesignThemes.Wpf.Card  +  %MaterialDesignThemes.Wpf.ShadowAssist    ShadowDepth$  Depth4=�5         ShadowEdges$ Bottom,Right=�5      $��Center=�5      $	��450��6.   $	��380��6:   .��5   
   � ���	#FF231E03 � ColumnDefinitions 5      �� 5      �� 5      .+�5      �� -   5         ��Name$ lbLevel��5      $��0��6'   $	��380��5   B   {�5   7   �� *	IsChecked+ �� ElementName$ EnableListBox��.@�5      �� -   5         ��Name$ Standard��5      $	��128��60   .��5      � $��90��6   $	��230��6'    5      �� 5      �� 5      $
��1.5* �60   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]   Kind$ StandardDefinition=�62   $	��100��6L   $	��100��6Y   ���	#FFF505056e   �� 5       $��1��6$   $
��Thin"�64   $��30(�6F   $
��Left=�6T   $��Center=�6o   ���	#FFA19C46
Standard6�   5!      5#      �� 5$      -   5        $ Premium��5$      $	��128��6/   .��5%      � $��90��6   $	��241��6'    5&      �� 5'      �� 5(      $
��1.5* �6/   .+�5*      �� $��1��6$   $
��Thin"�64   $��30(�6F   $
��Left=�6T   $��Center=�6o   ���	#FFA19C46	Premium6�     5+      $ HighDefinition=�63   $	��100��6I   $	��100��6V   ���	#FFF505056b   5-      5.      �� 5/      -   5        $	 VIP��5/      $	��120��6+   .��50      � $��90��6   $	��241��6'    51      �� 52      �� 53      $
��1.5* �60   .+�55        $ UltraHighDefinition=�63   $	��100��6N   $	��100��6[   ���	#FFF505056g   �� 57      $��1��6$   $
��Thin"�64   $��30(�6F   $��Center=�6T   $��Center=�6q   ���	#FFA19C46VIP6�   59      5:      5<      � 5=      $��1��6   $
��0,20q�6#    � RowDefinitions 5>      �� 5?      $
��1.5* �6$   �� 5@      $��2* �6$   �� 5A      $��* �6$   .+�5D      �� -   5        $��tblStandard��5D   *   $��0��6   $��45(�6>   $
��Thin"�6L   $��Center=�6^   $��Center=�6{   ���	#FFF3D1165$ /�� 5F      
1 Mounth5J      �� 5K      -   5        $��tblStandard_1��5K   *   $��1��6   $��25(�6@   $
��Thin"�6N   $
��Left=�6`   $	��Top=�6{   ���	#FFFBFBFB$��15q�6�   First month free5N      �� 5O      -   5        $��
tblPremium��5O   *   $��0��6   $��45(�6=   $
��Thin"�6K   $��Center=�6]   $��Center=�6z   ���	#FFF3D11610$ /�� 5Q      
1 Mounth5U      �� 5V      -   5        $��tblPremium_1��5V   +   $��1��6   $��25(�6@   $
��Thin"�6N   $
��Left=�6`   $	��Top=�6{   ���	#FFFBFBFB$��15q�6�   First month free�� 5X      Premium Film available5[      �� 5\      -	   5        $��tblVIP��5\   *   $��0��6   $��45(�69   $
��Thin"�6G   $��Center=�6Y   $��Center=�6v   ���	#FFF3D11620$ /�� 5^      
1 Mounth5b      �� 5c      -
   5        $��tblVIP_1��5c   +   $��1��6   $��25(�6<   $
��Thin"�6J   $
��Left=�6\   $	��Top=�6w   ���	#FFFBFBFB$��15q�6�   First month free�� 5e      Premium Film available�� 5g      VIP Film available5j      5k      5l      5m      5n      