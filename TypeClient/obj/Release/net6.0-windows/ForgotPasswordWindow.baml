   M S B A M L   `   `   `  ���� E  ATypeClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:TypeClient
TypeClient  =#clr-namespace:TypeClient.ConvertersTypeClient.Converters  =#clr-namespace:TypeClient.ViewModelsTypeClient.ViewModels  %    TypeClient.ForgotPasswordWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:TypeClient     :
converters#clr-namespace:TypeClient.Converters     :
viewmodels#clr-namespace:TypeClient.ViewModels     ���#333333  � Title$  ForgotPasswordWindow��$	��550��$	��400�� � 	Resources <   6TypeClient.Converters.PasswordStrengthToBrushConverter $   PasswordStrengthToBrushConverter=   7TypeClient.Converters.PasswordStrengthToStringConverter % !PasswordStrengthToStringConverter��%   &	        &	          .���  � RowDefinitions �� �� .+��� $��Center=�$��	0,00,0,50q�$��Center=�.+��� $��New Password�����#C5C5C5$��25(�$
��Bold"�$
��Nexa)�$��0,10,0,0q��� ���#222222$��1q� �� CornerRadius$ 10��$��35��._�G� -    G�Name$ Passwordbox�� G� PasswordChar$ *��
������ $��0q����#C5C5C5$��Stretch=�$��Center=�$��5q�$
��Nexa)�$��20(�$
��Bold"�����  �� 
TargetType" G�.���  �� Property �@J�Opacity �� Value$	 0.8Q���  � �� �#c2d1c9��  � ��
 ���� ��  � ��$ 0q�	 �� Triggers	 P� 
 P� Property
 �@J�IsMouseOver P� Value$
 True��. ���  �@J�Opacity$ 1Q��� $��Confirm Password��$��25(����#C5C5C5$
��Bold"�$
��Nexa)�$��0,10,0,0q��� ���#222222$��1q�$ 10��$��35��._�G� -   $ ConfirmPasswordbox��$ *��
������ $��0q����#C5C5C5$��Stretch=�$��Center=�$��5q�$
��Nexa)�$��20(�$
��Bold"����� " G�.���  �@J�Opacity$	 0.8Q���  � �� �#c2d1c9��  � ��
 ���� ��  � ��$ 0q�	 P� 
 �@J�IsMouseOver$
 True��. ���  �@J�Opacity$ 1Q���  �� TextAlignment$ Center=�
���  ��$��20(�$
��Bold"�$��Microsoft sans serif)�$��40��$��
0,192,0,10q�����  �� Path$ Error� �� UpdateSourceTrigger$ PropertyChanged=��� $��0��$��2��$	��Top=�$��	0,267,0,0q�.+��� $ Center=�$��Password strength:��$��1��$��25(�$
��Bold"����� $ PasswordStrength� �� 	Converter# [  � ���#333333$��15��$	��250��$��1��$��0,10,0,0q� � Value �� $ PasswordStrength� �� Mode$ OneWay=����� $ PasswordStrength�# [  �� $ Center=�$��1��$��0,10,0,0q�$��25(����� $ PasswordStrength�$ OneWay=�# [ ���� $ PasswordStrength�# [  �� $��1��$��Submit��
������ ���#222222$��35(�$
��Bold"�$��89,134,89,41q����� $ Submit�  �� 
TargetType ��Name �� Triggers �� 
TargetName��%�  '��       �� " ��.���  � �� �#C5C5C5��  � �� �� " ��.R��� $ Border��#��z��#��z��$��1q�$ 20��._��� $��Center=�$��Center=� P� 
 � {�$ False��. ��� $ Border�� � �� �#222222��  � ��
 �������  �@J�Opacity$	 0.9Q�P� 
 �@J�IsMouseOver$
 True��. ��� $ Border�� � �� �#636363��  � �� �#c2d1c9��  �@J�Opacity$ 1Q�