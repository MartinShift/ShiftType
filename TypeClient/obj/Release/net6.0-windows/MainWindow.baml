   M S B A M L   `   `   `  ���� E  ATypeClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:TypeClient
TypeClient  =#clr-namespace:TypeClient.ViewModelsTypeClient.ViewModels      TypeClient.MainWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:TypeClient     :
viewmodels#clr-namespace:TypeClient.ViewModels     -   ���#333333  � WindowState$  	Maximized=� � Title$ 
MainWindow��$
��1080��$
��1920��.���  � ColumnDefinitions �� $	��20* ��� $	��32* ��� $	��32* ��� $	��32* ��� $	��20* � � RowDefinitions �� $	��25* ��� $	��20* ��� $	��10* ��� $	��10* ��� $	��10* ��� $	��10* ��� $	��10* ��� $	��10* �.+��� $��1��$��1��$��Bottom=�$
��Left=�$��28(�$��Banana Grotesk)�
����+�� J� Opacity$	 0.8Q�����  �� Path$ SecondsLeft��� -    ��Name$ CheckTextBox��$|�False�����#333333$��0q�$��1��$��2��$��3��$��4��$��38(�$��Banana Grotesk)����#d1d0c5�� $��2��$��1��$��Center=�$��Center=����� $ SelectLanguage����� $ SelectedLanguage�����  �� 
TargetType" ��.R��� #��z��#��z��#��z�� �� CornerRadius$ 5��$��	0,0,0,-11q�._��� $��5q�	 �� Triggers	 P� 
 P� Property
 �@J�IsMouseOver P� Value$
 True��. ���  �� Property � �� �� Value �#E9D8D8����  �� 
TargetType" ��.���  � �� �#8C8C8C��  � ��
 ���� ��  � ��$ 50(���  � ��$
 Nexa)���  � ��$ Italic$���  � ��$ DemiBold"���  � ��
 ���� ��  � ��$ 0q��� $��2�� �� Orientation$ 
Horizontal=�$��3��$��0,30,0,0q�$��Center=�$	��Top=�.+��� $��80��$��80������ $ Client.Logo��� $��Center=����� $ GotoProfileOrLogin����� $ UserName����� " ��.R��� #��z��#��z��#��z��$ 5��$��	0,0,0,-11q�._��� $��5q�	 P� 
 �@J�IsMouseOver$
 True��. ���  � �� �#E9D8D8���� " ��.���  � �� �#8C8C8C��  � ��
 ���� ��  � ��$ 28(���  � ��$
 Nexa)���  � ��$ Italic$���  � ��$ DemiBold"���  � ��
 ���� ��  � ��$ 0q��� $��80��$��80��$��30,0,0,0q�y��� $ LogoutVisibility����� $ LogoutOrLogin� � 	Resources  ��Name �� 
TargetName��%�   '��       �� " ��.���  � �� �� " ��.R��� $ ScreenImage������ $ LogoutImage�	 P� 
 �@J�IsMouseOver$
 True��. ��� $ ScreenImage�� �@J�Opacity$	 0.5Q��� ���#222222$	��900��$��90��$��3��$��Center=�$��Center=����� " ��.���  �@��CornerRadius$ 35���� $ 
Horizontal=�
������ $
��1000��$��90��$��3��$��Center=�$��Center=�.+��� $
��time��$��	100,0,0,0q�$��Center=����� $ ForgotPassword����� " ��.R��� #��z��#��z��#��z��$ 5��$��	0,0,0,-11q�._��� $��5q�	 P� 
 �@J�IsMouseOver$
 True��. ���  � �� �#E9D8D8���� " ��.���  � �� �#8C8C8C��  � ��
 ���� ��  � ��$ 35(���  � ��$
 Nexa)���  � ��$ Italic$���  � ��$ DemiBold"���  � ��
 ���� ��  � ��$ 0q��� $��15��$��	100,0,0,0q�$��Center=����� $ Set15STimer����� " ��.R��� #��z��#��z��#��z��$ 5��$��	0,0,0,-11q�._��� $��5q�	 P� 
 �@J�IsMouseOver$
 True��. ���  � �� �#E9D8D8���� " ��.���  � �� �� $ Timer15SBrush���  � ��
 ���� ��  � ��$ 35(���  � ��$
 Nexa)���  � ��$ Italic$���  � ��$ DemiBold"���  � ��
 ���� ��  � ��$ 0q��� $��30��$��	100,0,0,0q�$��Center=����� $ Set30STimer����� " ��.R��� #��z��#��z��#��z��$ 5��$��	0,0,0,-11q�._��� $��5q�	 P� 
 �@J�IsMouseOver$
 True��. ���  � �� �#E9D8D8���� " ��.���  � �� �� $ Timer30SBrush���  � ��
 ���� ��  � ��$ 35(���  � ��$
 Nexa)���  � ��$ Italic$���  � ��$ DemiBold"���  � ��
 ���� ��  � ��$ 0q��� $��60��$��	100,0,0,0q�$��Center=����� $ Set60STimer����� " ��.R��� #��z��#��z��#��z��$ 5��$��	0,0,0,-11q�._��� $��5q�	 P� 
 �@J�IsMouseOver$
 True��. ���  � �� �#E9D8D8���� " ��.���  � �� �� $ Timer60SBrush���  � ��
 ���� ��  � ��$ 35(���  � ��$
 Nexa)���  � ��$ Italic$���  � ��$ DemiBold"���  � ��
 ���� ��  � ��$ 0q��� $	��120��$��	100,0,0,0q�$��Center=����� $ Set120STimer����� " ��.R��� #��z��#��z��#��z��$ 5��$��	0,0,0,-11q�._��� $��5q�	 P� 
 �@J�IsMouseOver$
 True��. ���  � �� �#E9D8D8���� " ��.���  � �� �� $ Timer120SBrush���  � ��
 ���� ��  � ��$ 35(���  � ��$
 Nexa)���  � ��$ Italic$���  � ��$ DemiBold"���  � ��
 ���� ��  � ��$ 0q��� $��4��$��80��$��80��$��Center=�$��Center=����� $ OpenLeaderboards� ��%�   '��       �� " ��.���  � �� �� " ��.R��� $ ScreenImage������ $ LeaderboardImage�	 P� 
 �@J�IsMouseOver$
 True��. ��� $ ScreenImage�� �@J�Opacity$	 0.5Q�� -    �Name$ languagePopup��$	��500��$	��600��$��Center=�$��0��$��1��$��3��$��7�� � 	StaysOpen$ False������ $ IsPopupOpen�.���� ���#222222$��30(�$
��Nexa)�$
��Bold"����#8C8C8C���� *LanguageList+ �� SelectedItem �� $ SelectedLanguage����� " ��.���  � �� �� " ��.R��� #��z��#��z��#��z�� �� Padding# z��._��� 	 P� 
 �@J�IsMouseOver$
 True��. ���  � �� �#E9D8D8