   M S B A M L   `   `   `  ���� J  FCourse_kepeer_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Course_kepeer_1Course_kepeer_1      Course_kepeer_1.register   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /localclr-namespace:Course_kepeer_1     X TXceed.Wpf.Toolkit, Version=3.3.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit    N� Title$  register�� � 	Resources    validationErrorTemplate �� Orientation �� TextAlignment � ToolTip �� ElementName �� Path ��Name��%�  &	        �� .R�]� .+��� $ 
Horizontal=�$	��Top=�.+�� $��12��$��12��.+�A� $��12��$��12��
���  ��$��Center=�$��Center=��� 
�������$��Heavy"�$��8(�$��Center=�$��Center=�$ Center=� �� $ ErrorAdorner��$8 2AdornedElement.(Validation.Errors)[0].ErrorContent�X�� 
���  ��$��12"�$��2,0,0,0q����� $ ErrorAdorner��$8 2AdornedElement.(Validation.Errors)[0].ErrorContent��� $ ErrorAdorner��.��� .+��� $��Register��$��30(�$ Center=�$��0,10,0,0q�$	��250��$	��35 ��$	��Top=�$��Center=�(  "Xceed.Wpf.Toolkit.WatermarkTextBox  -   $	��log�� �� 	MaxLength$ 15��$	��400��	 =� ErrorTemplate#	 [  
   	Watermark$
 Login��$	��0.5q�
���   �$��
60,80,60,0q�
������ $	��250��$	��35 ��$	��Top=�$��20(� �� TextAlignment$ Center=�.������ $
 Name� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ 	LostFocus=� �� ValidationRules $   Course_kepeer_1.LoginValidator  .��,  &Xceed.Wpf.Toolkit.WatermarkPasswordBox  -   $	��pw1��$ 15��$
 Password��$	��400��#	 [  $	��250��$	��35 ��$	��0.5q�$	��Top=�
������ 
���   �$��60,140,60,0q�$��20(�$ Password��.������ $
 Name�$ TwoWay=�$ 	LostFocus=� '  !Course_kepeer_1.PasswordValidator  .��  -   $	��pw2��$ 15��$
 Repeat��$	��400��#	 [  $	��250��$	��35 ��$	��0.5q�
���   �
������ $	��Top=�$��60,200,60,0q�$��20(�$ Repead Password��.������ $
 Name�$ TwoWay=�$ 	LostFocus=�   .���� -   $��check��$��Bottom=�$��55,0,234,79q�$��1q�$��4,-1,0,0q�.��I have read�� -   $��	agreement��$��141,0,185,81q�$��Bottom=�
������ $��	agreement�� � Cursor$
 Hand��  -   $��qu��$ 15��$
 Question��$	��400��$	��250��$	��35 ��$	��0.5q�#	 [  
���   �$��60,260,60,0q�
������ $	��Top=�$��20(�$ Center=�.������ $ Names�$ TwoWay=�$ 	LostFocus=� "   Course_kepeer_1.QuValidation  .��  -   $	��ans��$ 15��$
 Answer��$	��400��$	��250��$	��35 ��$	��0.5q�#	 [  
���   �$��60,320,60,0q�
������ $	��Top=�$��20(�$ Center=�.������ $ Names�$ TwoWay=�$ 	LostFocus=� !   Course_kepeer_1.answerValid  .���� -   $��	registers��$��30��$	��100�� �� 	IsDefault . {�.  $��Bottom=�$	��300��$��120,0,120,40q�$��Register��