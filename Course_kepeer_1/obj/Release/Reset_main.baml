   M S B A M L   `   `   `  ���� J  FCourse_kepeer_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Course_kepeer_1Course_kepeer_1       Course_kepeer_1.Reset_main   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /localclr-namespace:Course_kepeer_1     X TXceed.Wpf.Toolkit, Version=3.3.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit    N� Title$  
Reset_main�� � 	Resources    validationErrorTemplate �� Orientation �� TextAlignment � ToolTip �� ElementName �� Path ��Name��%�  &	        �� .R�]� .+��� $ 
Horizontal=�$	��Top=�.+�� $��12��$��12��.+�A� $��12��$��12��
���  ��$��Center=�$��Center=��� 
�������$��Heavy"�$��8(�$��Center=�$��Center=�$ Center=� �� $ ErrorAdorner��$8 2AdornedElement.(Validation.Errors)[0].ErrorContent�X�� 
���  ��$��12"�$��2,0,0,0q����� $ ErrorAdorner��$8 2AdornedElement.(Validation.Errors)[0].ErrorContent��� $ ErrorAdorner��.��� .+�(  "Xceed.Wpf.Toolkit.WatermarkTextBox  -   $	��log�� =� ErrorTemplate# [  	   	Watermark$	 Password��$	��270��$	��0.5q�
���   �$��0,80,0,0q�
������ $	��35 ��$	��Top=�$��20(�
 �� TextAlignment$
 Center=�.������ $
 Name� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ 	LostFocus=� �� ValidationRules '  !Course_kepeer_1.PasswordValidator  .��  -   $	��res��# [  $	 Repeat password��$	��270��$	��0.5q�
���   �$��	0,150,0,0q�
������ $	��35 ��$	��Top=�$��20(�$
 Center=�.������ $
 Name�$ TwoWay=�$ 	LostFocus=�   .���� -   $	��sav��$��30��$	��120��$��	0,250,0,0q�{�.  $
��Save���� -   $
��back��$��30��$��30��$	��Top=�$
��Left=�$��10q�
�������.���� $��/Resources/back.png��