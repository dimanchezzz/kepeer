   M S B A M L   `   `   `  ����J  FCourse_kepeer_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Course_kepeer_1Course_kepeer_1  5           Course_kepeer_1.Reset_main   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:Course_kepeer_1     5      X TXceed.Wpf.Toolkit, Version=3.3.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5        N� Title$  
Reset_main��5
       � 	Resources 5         validationErrorTemplate �� Orientation �� TextAlignment � ToolTip �� ElementName �� Path ��Name��%�  &	        �� 5   
   .R�5      ]� .+�5      �� $ 
Horizontal=�6   $	��Top=�66   .+�5      � $��12��6   $��12��6&   .+�5      A� $��12��6"   $��12��6-   
���  ��$��Center=�6D   $��Center=�6a   5   !   �� 5      
�������$��Heavy"�67   $��8(�6J   $��Center=�6W   $��Center=�6t   $ Center=�6�    5       �� $ ErrorAdorner��$8 2AdornedElement.(Validation.Errors)[0].ErrorContent�X5   $   5      �� 5      
���  ��$��12"�61   $��2,0,0,0q�6A   ��5      �� $ ErrorAdorner��$8 2AdornedElement.(Validation.Errors)[0].ErrorContent�5      5      �� 5      $ ErrorAdorner��6,   6E   5      5      5      .��5      � .+�5   
   (  "Xceed.Wpf.Toolkit.WatermarkTextBox  -   5        $	��log��5   �    =� ErrorTemplate# [  6l   	   	Watermark$	 Password��6�   $	��270��6�   $	��0.5q�6�   
���   �$��0,80,0,0q�6  
������ $	��35 ��61  $	��Top=�6?  $��20(�6W  
 �� TextAlignment$
 Center=�6f  .��6}  ��5       �� 5!      $
 Name�6    �� Mode$ TwoWay=�6&    �� UpdateSourceTrigger$ 	LostFocus=�64    �� ValidationRules 5"      '  !Course_kepeer_1.PasswordValidator  5#      64   5%      .��5&   *   5'        5(   
   -   5        $	��res��5(   �   # [  6l   $	 Repeat password��6�   $	��270��6�   $	��0.5q�6�   
���   �$��	0,150,0,0q�6  
������ $	��35 ��69  $	��Top=�6G  $��20(�6_  $
 Center=�6n  .��6�  ��5)      �� 5*      $
 Name�6   $ TwoWay=�6&   $ 	LostFocus=�64    5+        5,      64   5.      .��5/   *   50      �� 51   
   -   5        $	��sav��51   <   $��30��6   $	��120��6   $��	0,250,0,0q�6)   {�.  $
��Save��6Y   6h   �� 52   
   -   5        $
��back��52   @   $��30��6   $��30��6   $	��Top=�6(   $
��Left=�6L   $��10q�6g   
�������.��53      �� $��/Resources/back.png��6   54      55      56      