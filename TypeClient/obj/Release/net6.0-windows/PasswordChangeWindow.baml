   M S B A M L   `   `   `  ���� E  ATypeClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:TypeClient
TypeClient  =#clr-namespace:TypeClient.ViewModelsTypeClient.ViewModels  =#clr-namespace:TypeClient.ConvertersTypeClient.Converters  %    TypeClient.PasswordChangeWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:TypeClient     :
viewmodels#clr-namespace:TypeClient.ViewModels     :
converters#clr-namespace:TypeClient.Converters     ���#333333  � Title$  PasswordChangeWindow��$	��680��$	��500�� � 	Resources <   6TypeClient.Converters.PasswordStrengthToBrushConverter $   PasswordStrengthToBrushConverter=   7TypeClient.Converters.PasswordStrengthToStringConverter % !PasswordStrengthToStringConverter��%   &	        &	          .��� .+��� $��1��$��Center=�$	��Top=�.+��� ���#C5C5C5$��Password��$��25(�$
��Bold"�$��40��$��0,20,0,0q��� ���#222222$��1q� �� CornerRadius$ 10��$	��200��$��35��._�G� -    G� PasswordChar$ *��
������ $��0q����#C5C5C5$��Stretch=�$��Center=�$��5q�$
��Nexa)�$��20(�$
��Bold"�����  �� 
TargetType" G�.���  �� Property �@J�Opacity �� Value$	 0.8Q���  � �� �#c2d1c9��  � ��
 ���� ��  � ��$ 0q� �� Triggers P�  P� Property �@J�IsMouseOver	 P� Value$
	 True��. ���  �@J�Opacity$ 1Q��� $��Forgot Password?��$��Center=�$��	0,10,0,10q�$��40������ 
 �� Path$
 ForgotPassword�����  �� 
TargetType" ��.R��� #��z��#��z��#��z��$ 5��._��� $��5q� �� Triggers P�  �@J�IsMouseOver$
	 True��. ���  � �� �#E9D8D8���� " ��.���  � �� �#8C8C8C��  � ��
 ���� ��  � ��$ 18(���  � ��$
 Nexa)���  � ��$ Italic$���  � ��$ DemiBold"���  � ��
 ���� ��  � ��$ 0q��� ���#C5C5C5$��New Password��$��25(�$
��Bold"�$��40��$��0,20,0,0q��� ���#222222$��1q�$ 10��$	��200��$��35��._�G� -   $ *��
������ $��0q����#C5C5C5$��Stretch=�$��Center=�$��5q�$
��Nexa)�$��20(�$
��Bold"����� " G�.���  �@J�Opacity$	 0.8Q���  � �� �#c2d1c9��  � ��
 ���� ��  � ��$ 0q� P�  �@J�IsMouseOver$
	 True��. ���  �@J�Opacity$ 1Q��� ���#C5C5C5$��Confirm Password��$��25(�$
��Bold"�$��40��$��0,20,0,0q��� ���#222222$��1q�$ 10��$	��200��$��35��._�G� -   $ *��
������ $��0q����#C5C5C5$��Stretch=�$��Center=�$��5q�$
��Nexa)�$��20(�$
��Bold"����� " G�.���  �@J�Opacity$	 0.8Q���  � �� �#c2d1c9��  � ��
 ���� ��  � ��$ 0q� P�  �@J�IsMouseOver$
	 True��. ���  �@J�Opacity$ 1Q���  �� TextAlignment$ Center=�
���  ��$��20(�$
��Bold"�$��Microsoft sans serif)�$��40������ $
 Error� �� UpdateSourceTrigger$ PropertyChanged=��� $��	0,392,0,0q�.+��� $ Center=�$��Password strength:��$��1��$��25(�$
��Bold"����� $
 PasswordStrength� �� 	Converter# [  � $��15��$	��250��$��1��$��0,10,0,0q� � Value �� $
 PasswordStrength� �� Mode$ OneWay=����� $
 PasswordStrength�# [  �� $ Center=�$��1��$��0,10,0,0q�$��25(����� $
 PasswordStrength�$ OneWay=�# [ ���� $
 PasswordStrength�# [  �� $��Change Password��
������ ���#222222$��35(�$
��Bold"�$��79,507,79,47q����� $
 ConfirmPassword�  ��Name �� 
TargetName��%�  '��       �� " ��.���  � �� �#C5C5C5��  � �� �� " ��.R��� $ Border��#��z��#��z��$��1q�$ 20��._��� $��Center=�$��Center=� P�  � {�$	 False��. ��� $ Border�� � �� �#222222��  � ��
 �������  �@J�Opacity$	 0.9Q�P�  �@J�IsMouseOver$
	 True��. ��� $ Border�� � �� �#636363��  � �� �#c2d1c9��  �@J�Opacity$ 1Q�