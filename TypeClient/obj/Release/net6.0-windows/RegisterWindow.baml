   M S B A M L   `   `   `  ���� E  ATypeClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:TypeClient.ModelsTypeClient.Models  'clr-namespace:TypeClient
TypeClient  =#clr-namespace:TypeClient.ViewModelsTypeClient.ViewModels  =#clr-namespace:TypeClient.ConvertersTypeClient.Converters      TypeClient.RegisterWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     2modelsclr-namespace:TypeClient.Models     *localclr-namespace:TypeClient     :
viewmodels#clr-namespace:TypeClient.ViewModels     :
converters#clr-namespace:TypeClient.Converters     ���#333333  � Title$  RegisterWindow��$	��570��$	��820�� � 	Resources <   6TypeClient.Converters.PasswordStrengthToBrushConverter $   PasswordStrengthToBrushConverter=   7TypeClient.Converters.PasswordStrengthToStringConverter % !PasswordStrengthToStringConverter��%   &	        &	          .���  � ColumnDefinitions �� ��  � RowDefinitions �� �� .+��� $��0,30,0,0q�$��2��$��1��$	��Top=�$��Center=�.+��� $��Nickname�����#C5C5C5$��21(�$
��Bold"�$��Microsoft sans serif)��� ���#222222$��1q� �� CornerRadius$ 5��$	��300��$��35��._��� )   #TypeClient.Models.WatermarkBehavior   WatermarkText$ Email��
������ $��0q����#C5C5C5$��Stretch=�$��Center=�$��5q�$
��Nexa)�$��20(�$
��Bold"�����  �� Path$ NickName� �� UpdateSourceTrigger$ PropertyChanged=�.������  �� 
TargetType" ��.��� 	 �� Property	 �@J�Opacity
 �� Value$	
 0.8Q� �� Triggers P�  P� Property �@J�IsMouseOver P� Value$
 True��. ��� 	 �@J�Opacity$
 1Q�.���� $��Login��$��21(����#C5C5C5$
��Bold"�$��Microsoft sans serif)�$��0,5,0,0q��� ���#222222$��1q�$ 5��$	��300��$��35��._��� $ Login��
������ $��0q����#C5C5C5$��Stretch=�$��Center=�$��5q�$
��Nexa)�$��20(�$
��Bold"����� $ Login�$ PropertyChanged=�.������ " ��.��� 	 �@J�Opacity$	
 0.8Q� P�  �@J�IsMouseOver$
 True��. ��� 	 �@J�Opacity$
 1Q�.���� $��Email(Can be empty)�����#C5C5C5$��21(�$
��Bold"�$��Microsoft sans serif)�$��0,5,0,0q��� ���#222222$��1q�$ 5��$	��300��$��35��._��� $ Email��
������ $��0q����#C5C5C5$��Stretch=�$��Center=�$��5q�$
��Nexa)�$��20(�$
��Bold"����� $ Email�$ PropertyChanged=�.������ " ��.��� 	 �@J�Opacity$	
 0.8Q� P�  �@J�IsMouseOver$
 True��. ��� 	 �@J�Opacity$
 1Q�.���� $��Password��$��21(����#C5C5C5$
��Bold"�$��Microsoft sans serif)��� ���#222222$��1q�$ 5��$	��300��$��35��._�G� -    G� PasswordChar$ *��
������ $��0q����#C5C5C5$��Stretch=�$��Center=�$��5q�$
��Nexa)�$��20(�$
��Bold"����� " G�.��� 	 �@J�Opacity$	
 0.8Q��� 	 � ��
 �#c2d1c9�� 	 � ��

 ���� �� 	 � ��$
 0q��� ���#C5C5C5$��Confirm Password��$��21(�$
��Bold"�$��Microsoft sans serif)�$��0,5,0,0q��� ���#222222$��1q�$ 5��$	��300��$��35��._�G� -   $ *��
������ $��0q����#C5C5C5$��Stretch=�$��Center=�$��5q�$
��Nexa)�$��20(�$
��Bold"����� " G�.��� 	 �@J�Opacity$	
 0.8Q��� 	 � ��
 �#c2d1c9�� 	 � ��

 ���� �� 	 � ��$
 0q��� $��1��$��1�� �� TextAlignment$ Center=����#E02700$��20(�$
��Bold"�$��Microsoft sans serif)�$��15,95,15,133q����� $ Error�$ PropertyChanged=��� $��1��$��	0,120,0,0q�$��1��$��Center=�$��Center=�.+��� $ Center=�$��Password Strength:��$��1��$��20(�$
��Bold"����� $ PasswordStrength� �� 	Converter# [  � ���#333333$��0q�$��10��$	��250��$��1��$��0,10,0,0q� � Value �� $ PasswordStrength� �� Mode$ OneWay=����� $ PasswordStrength�# [  �� $��1��$��0,10,0,0q�$��20(����� $ PasswordStrength�$ OneWay=�# [ ���� $ PasswordStrength�# [  �� $��0,20,0,0q�$��2��$	��Top=�$��Center=�$��0��.+��� $
��Logo�����#C5C5C5$��20(�$
��Bold"��� $	��300��$	��300��$��0q�
������ ���� $ LoadLogo�  �� 
TargetType A�Name �� ImageSource �� Triggers �� 
TargetName��%�   '��       �� " ��.��� 	 � ��

 �   ��� 	 � ��
 �� " ��.R�A� $ BackgroundEllipse������  �� $
 Logo� P�  �@J�IsMouseOver$
 True��. ��� $ BackgroundEllipse��	 �@J�Opacity$	
 0.5Q��� $��0��
������ $��1��$��84,133,84,62q�$��Sign up now�����#222222$��35(�$
��Bold"����� $ 	TrySubmit�  ��Name��%�  '��       �� " ��.��� 	 � ��
 �#C5C5C5�� 	 � ��
 �� " ��.R��� $ Border��#��z��#��z��$��1q�$ 25��._��� $��Center=�$��Center=� P�  � {�$ False��. ��� $ Border��	 � ��
 �#222222�� 	 � ��

 ������� 	 �@J�Opacity$	
 0.9Q�P�  �@J�IsMouseOver$
 True��. ��� $ Border��	 � ��
 �#636363�� 	 � ��
 �#c2d1c9�� 	 �@J�Opacity$
 1Q�