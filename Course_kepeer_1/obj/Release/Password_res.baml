   M S B A M L   `   `   `  ���� J  FCourse_kepeer_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Course_kepeer_1Course_kepeer_1  "    Course_kepeer_1.Password_res   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     /localclr-namespace:Course_kepeer_1     X TXceed.Wpf.Toolkit, Version=3.3.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit    � Title$  Password_res��$	��355��$	��300��$	��355��$	��300��$	��300�� � 	Resources    validationErrorTemplate �� Orientation �� TextAlignment � ToolTip �� ElementName �� Path ��Name��%�  &	        �� .R�]� .+��� $ 
Horizontal=�$	��Top=�.+�� $��12��$��12��.+�A� $��12��$��12��
���  ��$��Center=�$��Center=��� 
�������$��Heavy"�$��8(�$��Center=�$��Center=�$ Center=� �� $ ErrorAdorner��$8 2AdornedElement.(Validation.Errors)[0].ErrorContent�X�� 
���  ��$��12"�$��2,0,0,0q����� $ ErrorAdorner��$8 2AdornedElement.(Validation.Errors)[0].ErrorContent��� $ ErrorAdorner��.��� .+��� $��Password reset��$��30(�$ Center=�$��0,10,0,0q�$	��300��$��40��$	��Top=�$��Center=�(  "Xceed.Wpf.Toolkit.WatermarkTextBox  -   $��logcheck��   	Watermark$ Login��$	��270��$	��0.5q�
���   �$��
11,60,54,0q�
������ $	��35 ��$	��200��$	��Top=�$��20(�	 �� TextAlignment$	 Center=�.���� -   $	��go1��$��0,60,0,0q�{�.  $��go��$��35��$	��Top=�$��Right=�$��40���� -   $��Quest��{�.  $	��270��$	��0.5q�
���   �$��	0,110,0,0q�
������ $	��40 ��$	��Top=�$��20(�$��What?��  -   $	��Ans��$ Answer��$	��270��$	��0.5q�
 =� ErrorTemplate#
 [  
���   �$��	0,160,0,0q�
������ $	��35 ��$	��Top=�$��20(�$	 Center=�.������ $ Names� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ 	LostFocus=� �� ValidationRules !   Course_kepeer_1.answerValid  .��  -   $
��newe��$ New password��#
 [  $	��270��$	��0.5q�
���   �$��	0,210,0,0q�
������ $	��35 ��$	��Top=�$��20(�$	 Center=�.������ $
 Name�$ TwoWay=�$ 	LostFocus=� '  !Course_kepeer_1.PasswordValidator  .���� -   $
��rese��$��Center=�{�.  $��Reset��$��29��$��	0,280,0,0q�$	��Top=�$	��100��