   M S B A M L   `   `   `  ����J  FCourse_kepeer_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Course_kepeer_1Course_kepeer_1  5   	   H DMahApps.Metro, Version=1.6.0.0, Culture=neutral, PublicKeyToken=nullD2clr-namespace:MahApps.Metro;assembly=MahApps.MetroMahApps.Metro 5
      '    !Course_kepeer_1.AccentStyleWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Course_kepeer_1     5   	   ;Controls,http://metro.mahapps.com/winfx/xaml/controls  5      ;
Converters*http://metro.mahapps.com/winfx/xaml/shared  5	      >metro2clr-namespace:MahApps.Metro;assembly=MahApps.Metro  5
        �� ClearTypeHint$  Enabled=�5   
   &   System.Windows.Media.TextOptions   TextFormattingMode$ Display=�5       � Title$ Change App Style��5       � SizeToContent$ WidthAndHeight=�5         AccentColorBrush(  "MahApps.Metro.Controls.MetroWindow   	GlowBrush# �   5       � 
ResizeMode$ CanResizeWithGrip=�5       � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $M Gpack://application:,,,/MahApps.Metro;component/Styles/Accents/Blue.xaml?�6%   �� 5      $R Lpack://application:,,,/MahApps.Metro;component/Styles/Accents/BaseLight.xaml?�6%   %    5      	   TitleTemplate	 5      �� 5   
   .R�5      �� $��CharacterEllipsis=�5      $��Center=�5       $��8 -1 0 0q�5!        WindowTitleFontSize#���  5"        DefaultFont#���  5#      ��5      �� 
 �� RelativeSource
 �� *TemplatedParent+ �� Path$ Content� �� 	Converter /  )MahApps.Metro.Converters.ToUpperConverter  5#      5$      .��5'      �  5)   
    �� 
TargetType  MetroButton �� BasedOn �� Property �� Value��%�   '��       7  �� 5*      " ��6   8   .�5,      ��  � ��$ 23��5-      �� 5.       � ��$ 2q�5/      50      51       � RowDefinitions 53   
   �� 54      $
��Auto �6   �� 55      $
��Auto �6   .+�58   
   �� $��0��6   $��5q�59      $��This Window��5:      .��5;      A�  A� Columns$ 5��6   .+�5<      �� -   5        $
��Dark��5<      5=      �� 5>      -   5        $��Light��5>      5?      �� 5@      -   5        $
��Blue��5@      5A      �� 5B      -   5        $	��Red��5B      5C      �� 5D      -   5        $��Green��5D      5E      5F      5G      �� 5I   
   $��1��6   $��5q�5J      $��The Application��5K      .��5L      �  5M      �� 5N      $
��Auto �6$   �� 5O      $
��Auto �6$   �� 5P      $
��Auto �6$   .+�5S      A� $��0��6   $ 5��5T      .+�5U      �� -   5        $
��Dark��5U      5V      �� 5W      -   5        $��Light��5W      5X      �� 5Y      -   5        $
��Blue��5Y      5Z      �� 5[      -	   5        $	��Red��5[      5\      �� 5]      -
   5        $��Green��5]      5^      5_      A� 5k      $��2��6   $��5q�6+   $ 2��66    A� Rows$ 2��6B   .+�5l      �� $��Accents��6    $��0 0 2 0q�6/   $��Center=�6@   �� 5m      $��Colors��6    $��2 0 0 0q�6.   $��Center=�6?   �� 5o      -   5         ��Name$ AccentSelector��5o      $��0 0 2 0q�5p      $��Center=�5q         MahApps.Metro.ThemeManager   Accents#��Z 5s      ��5t      �� 5u      .R�5v   "   �� ��6,   �� *Name+5w      5y      �� 5{      -   5        $ ColorsSelector��5{      $��2 0 0 0q�5|      $��Center=�5}      ��5      �� *Colors+��5�      �� 5�      .R�5�   "   �� ��6,   �� *Key+5�      5�      5�      5�      5�      5�      5�      