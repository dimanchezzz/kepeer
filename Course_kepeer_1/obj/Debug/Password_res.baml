   M S B A M L   `   `   `  ����J  FCourse_kepeer_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Course_kepeer_1Course_kepeer_1  5   	   "    Course_kepeer_1.Password_res   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Course_kepeer_1     5   	   X TXceed.Wpf.Toolkit, Version=3.3.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	     � Title$  Password_res��5	   	   $	��355��6   $	��300��6.   $	��355��6=   $	��300��6M   $	��300��6\    � 	Resources 5
         validationErrorTemplate �� Orientation �� TextAlignment � ToolTip �� ElementName �� Path ��Name��%�  &	        �� 5   
   .R�5      ]� .+�5      �� $ 
Horizontal=�6   $	��Top=�66   .+�5      � $��12��6   $��12��6&   .+�5      A� $��12��6"   $��12��6-   
���  ��$��Center=�6D   $��Center=�6a   5   !   �� 5      
�������$��Heavy"�67   $��8(�6J   $��Center=�6W   $��Center=�6t   $ Center=�6�    5       �� $ ErrorAdorner��$8 2AdornedElement.(Validation.Errors)[0].ErrorContent�X5   $   5      �� 5      
���  ��$��12"�61   $��2,0,0,0q�6A   ��5      �� $ ErrorAdorner��$8 2AdornedElement.(Validation.Errors)[0].ErrorContent�5      5      �� 5      $ ErrorAdorner��6,   6E   5      5      5      .��5      � .+�5   
   �� $��Password reset��6   $��30(�6*   $ Center=�68   $��0,10,0,0q�6P   $	��300��6c   $��40��6o   $	��Top=�6{   $��Center=�6�   (  "Xceed.Wpf.Toolkit.WatermarkTextBox  5   
   -   5        $��logcheck��5   A      	Watermark$ Login��6    $	��270��62   $	��0.5q�6Q   
���   �$��
11,60,54,0q�6{   
������ $	��35 ��6�   $	��200��6�   $	��Top=�6�   $��20(�6�   	 �� TextAlignment$	 Center=�6  .��62  5       �� 5!   
   -   5        $	��go1��5!   y   $��0,60,0,0q�6   {�.  $��go��65   $��35��6S   $	��Top=�6_   $��Right=�6�   $��40��6�   5"      �� 5#   
   -   5        $��Quest��5#   �   {�.  $	��270��6#   $	��0.5q�6/   
���   �$��	0,110,0,0q�6Y   
������ $	��40 ��6�   $	��Top=�6�   $��20(�6�   $��What?��6�   5$        5%   
   -   5        $	��Ans��5%   }   $ Answer��6    $	��270��6[   $	��0.5q�6g   
 =� ErrorTemplate#
 [  6�   
���   �$��	0,160,0,0q�6�   
������ $	��35 ��6  $	��Top=�6  $��20(�62  $	 Center=�6A  .��6X  ��5&      �� 5'      $ Names�6    �� Mode$ TwoWay=�6'    �� UpdateSourceTrigger$ 	LostFocus=�65    �� ValidationRules 5(      !   Course_kepeer_1.answerValid  5)      6.   5+      .��5,   *   5-        5.   
   -   5        $
��newe��5.   <  $ New password��6    #
 [  6a   $	��270��6�   $	��0.5q�6�   
���   �$��	0,210,0,0q�6�   
������ $	��35 ��6  $	��Top=�6  $��20(�6.  $	 Center=�6H  .��6_  ��5/      �� 50      $
 Name�6   $ TwoWay=�6&   $ 	LostFocus=�64    51      '  !Course_kepeer_1.PasswordValidator  52      64   54      .��55   *   56      �� 57   
   -   5        $
��rese��57   A   $��Center=�6   {�.  $��Reset��6b   $��29��6r   $��	0,280,0,0q�6~   $	��Top=�6�   $	��100��6�   58      59      