   M S B A M L   `   `   `  ���� E  ATypeClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:TypeClient
TypeClient  =#clr-namespace:TypeClient.ViewModelsTypeClient.ViewModels  "    TypeClient.LeaderboardWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:TypeClient     :
viewmodels#clr-namespace:TypeClient.ViewModels     -     � Title$  LeaderboardWindow��$	��750��$	��850�����#333333.���  � RowDefinitions �� $	��15* ��� $	��20* ��� $
��100* � � ColumnDefinitions �� $	��10* ��� $	��10* ��� $	��10* ��� $	��10* �.+��� $��Center=�$��Center=�$��3��$!��All-Time World Leaderboards��$
��Bold"�$
��Nexa)����#C5C5C5$��35(��� $��Time 15��$��1��$��Center=�$��Center=�����  �� Path$ Set15STimer�����  �� 
TargetType" ��.R��� #��z��#��z��#��z�� �� CornerRadius$ 5��$��	0,0,0,-11q�._��� $��5q� �� Triggers P�  P� Property �@J�IsMouseOver P� Value$
 True��. ��� 	 �� Property	 � ��
 �� Value
 �#E9D8D8����  �� 
TargetType" ��.��� 	 � ��
 �� $ Timer15SBrush��� 	 � ��

 ���� �� 	 � ��$
 35(��� 	 � ��$

 Nexa)��� 	 � ��$
 Italic$��� 	 � ��$
 DemiBold"��� 	 � ��

 ���� �� 	 � ��$
 0q��� $��Time 30��$��1��$��1��$��Center=�$��Center=����� $ Set30STimer����� " ��.R��� #��z��#��z��#��z��$ 5��$��	0,0,0,-11q�._��� $��5q� P�  �@J�IsMouseOver$
 True��. ��� 	 � ��
 �#E9D8D8���� " ��.��� 	 � ��
 �� $ Timer30SBrush��� 	 � ��

 ���� �� 	 � ��$
 35(��� 	 � ��$

 Nexa)��� 	 � ��$
 Italic$��� 	 � ��$
 DemiBold"��� 	 � ��

 ���� �� 	 � ��$
 0q��� $��Time 60��$��1��$��2��$��Center=�$��Center=����� $ Set60STimer����� " ��.R��� #��z��#��z��#��z��$ 5��$��	0,0,0,-11q�._��� $��5q� P�  �@J�IsMouseOver$
 True��. ��� 	 � ��
 �#E9D8D8���� " ��.��� 	 � ��
 �� $ Timer60SBrush��� 	 � ��

 ���� �� 	 � ��$
 35(��� 	 � ��$

 Nexa)��� 	 � ��$
 Italic$��� 	 � ��$
 DemiBold"��� 	 � ��

 ���� �� 	 � ��$
 0q��� $��Time 120��$��1��$��3��$��Center=�$��Center=����� $ Set120STimer����� " ��.R��� #��z��#��z��#��z��$ 5��$��	0,0,0,-11q�._��� $��5q� P�  �@J�IsMouseOver$
 True��. ��� 	 � ��
 �#E9D8D8���� " ��.��� 	 � ��
 �� $ Timer120SBrush��� 	 � ��

 ���� �� 	 � ��$
 35(��� 	 � ��$

 Nexa)��� 	 � ��$
 Italic$��� 	 � ��$
 DemiBold"��� 	 � ��

 ���� �� 	 � ��$
 0q��� $��2��$��4��
������ $��0q����� $ Leaders� �� SelectedItem �� $ Selected����� .R���  �� Orientation$ 
Horizontal=�.+��� $
��Bold"�$
��Nexa)����#C5C5C5$��35(�$��Center=����� $ Item3��� $��80��$��80��$��Center=����� $ 
Item1.Logo��� $
��Bold"�$
��Nexa)����#C5C5C5$��25(�$��50,0,0,0q�$��Center=����� $ Item1.Nickname��� $��Center=�$��50,0,0,0q�.+��� $ 
Horizontal=�.+��� $
��Bold"�$
��Nexa)����#C5C5C5$��25(����� $ 	Item2.Wpm��� $
�� Wpm��$
��Bold"�$
��Nexa)����#C5C5C5$��25(��� $ 
Horizontal=�.+��� $
��Bold"�$
��Nexa)����#777777$��20(����� $ Item2.Accuracy��� $
�� Acc��$
��Bold"�$
��Nexa)����#777777$��20(��� $��50,0,0,0q�.+��� $
��Bold"�$
��Nexa)����#C5C5C5$��25(�$��Center=����� $ 
Item2.Date� �� StringFormat$ {0:dd MMM yyyy}���� $
��Bold"�$
��Nexa)����#777777$��20(�$��Center=����� $ 
Item2.Date�$ 	{0:HH:mm}��