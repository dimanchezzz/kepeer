   M S B A M L   `   `   `  ����J  FCourse_kepeer_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Course_kepeer_1Course_kepeer_1  5          Course_kepeer_1.register   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:Course_kepeer_1     5      X TXceed.Wpf.Toolkit, Version=3.3.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5        N� Title$  register��5
       � 	Resources 5         validationErrorTemplate �� Orientation �� TextAlignment � ToolTip �� ElementName �� Path ��Name��%�  &	        �� 5   
   .R�5      ]� .+�5      �� $ 
Horizontal=�6   $	��Top=�66   .+�5      � $��12��6   $��12��6&   .+�5      A� $��12��6"   $��12��6-   
���  ��$��Center=�6D   $��Center=�6a   5   !   �� 5      
�������$��Heavy"�67   $��8(�6J   $��Center=�6W   $��Center=�6t   $ Center=�6�    5       �� $ ErrorAdorner��$8 2AdornedElement.(Validation.Errors)[0].ErrorContent�X5   $   5      �� 5      
���  ��$��12"�61   $��2,0,0,0q�6A   ��5      �� $ ErrorAdorner��$8 2AdornedElement.(Validation.Errors)[0].ErrorContent�5      5      �� 5      $ ErrorAdorner��6,   6E   5      5      5      .��5      � .+�5   
   �� $��Register��6   $��30(�6%   $ Center=�63   $��0,10,0,0q�6K   $	��250��6^   $	��35 ��6m   $	��Top=�6}   $��Center=�6�   (  "Xceed.Wpf.Toolkit.WatermarkTextBox  5    
   -   5        $	��log��5    �    �� 	MaxLength$ 15��6    $	��400��6S   	 =� ErrorTemplate#	 [  6b   
   	Watermark$
 Login��6�   $	��0.5q�6�   
���   �$��
60,80,60,0q�6�   
������ $	��250��6  $	��35 ��6*  $	��Top=�6;  $��20(�6S   �� TextAlignment$ Center=�6b  .��6y  ��5!      �� 5"      $
 Name�6    �� Mode$ TwoWay=�6&    �� UpdateSourceTrigger$ 	LostFocus=�64    �� ValidationRules 5#      $   Course_kepeer_1.LoginValidator  5$      61   5&      .��5'   *   5(      ,  &Xceed.Wpf.Toolkit.WatermarkPasswordBox  5)   
   -   5        $	��pw1��5)   r  $ 15��6$   $
 Password��63   $	��400��6J   #	 [  6}   $	��250��6�   $	��35 ��6�   $	��0.5q�6�   $	��Top=�6�   
������ 
���   �$��60,140,60,0q�6<  $��20(�6Q  $ Password��6_  .��6  ��5*      �� 5+      $
 Name�6   $ TwoWay=�6&   $ 	LostFocus=�64    5,      '  !Course_kepeer_1.PasswordValidator  5-      64   5/      .��50   .   51        52   
   -   5        $	��pw2��52   �   $ 15��6$   $
 Repeat��63   $	��400��6G   #	 [  6V   $	��250��6�   $	��35 ��6�   $	��0.5q�6�   
���   �
������ $	��Top=�6  $��60,200,60,0q�6   $��20(�65  $ Repead Password��6D  .��6_  ��53      �� 54      $
 Name�6   $ TwoWay=�6&   $ 	LostFocus=�64    55        56      64   58      .��59   .   5:      �� 5;   
   -   5        $��check��5;   �   $��Bottom=�6   $��55,0,234,79q�6c   $��1q�6x   $��4,-1,0,0q�6�   .��6�   I have read6�   �� 5<   
   -   5        $��	agreement��5<   �   $��141,0,185,81q�6   $��Bottom=�6*   
������ $��	agreement��6^    � Cursor$
 Hand��6�     5=   
   -   5        $��qu��5=   �   $ 15��6    $
 Question��60   $	��400��6F   $	��250��6U   $	��35 ��6d   $	��0.5q�6t   #	 [  6�   
���   �$��60,260,60,0q�6�   
������ $	��Top=�6  $��20(�64  $ Center=�6C  .��6Z  ��5>      �� 5?      $ Names�6   $ TwoWay=�6'   $ 	LostFocus=�65    5@      "   Course_kepeer_1.QuValidation  5A      6/   5C      .��5D   *   5E        5F   
   -   5        $	��ans��5F   �   $ 15��6    $
 Answer��6/   $	��400��6C   $	��250��6R   $	��35 ��6a   $	��0.5q�6q   #	 [  6�   
���   �$��60,320,60,0q�6�   
������ $	��Top=�6  $��20(�62  $ Center=�6A  .��6X  ��5G      �� 5H      $ Names�6   $ TwoWay=�6'   $ 	LostFocus=�65    5I      !   Course_kepeer_1.answerValid  5J      6.   5L      .��5M   *   5N      �� 5O   
   -   5        $��	registers��5O   �   $��30��6   $	��100��6     �� 	IsDefault . {�.  $��Bottom=�6R   $	��300��6m   $��120,0,120,40q�6|   $��Register��6�   6�   5P      5Q      