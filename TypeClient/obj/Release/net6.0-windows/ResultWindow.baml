   M S B A M L   `   `   `  ���� E  ATypeClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:TypeClient
TypeClient  U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf =#clr-namespace:TypeClient.ViewModelsTypeClient.ViewModels      TypeClient.ResultWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:TypeClient     Dlvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     :
viewmodels#clr-namespace:TypeClient.ViewModels     -   ���#333333  � Title$  Results��$	��850��$
��1560��.���  � ColumnDefinitions �� $	��30* ��� $	��30* ��� $	��30* ��� $	��30* ��� $	��30* ��� $	��20* � � RowDefinitions �� $	��10* ��� $	��20* ��� $	��20* ��� $	��20* ��� $	��20* �.+��� $��1��$��Center=�$��Center=�.+��� $	��wpm�����#4c4c4c$��30(��� ���#007acc$��65(�$
��Nexa)�$��DemiBold"�����  �� Path$	 Wpm��� $��2��$��Center=�$��Center=�.+��� $	��acc�����#4c4c4c$��30(���  �� Orientation$ 
Horizontal=�.+��� ���#007acc$��60(�$
��Nexa)�$��DemiBold"����� $ Accuracy��� $��%�����#007acc$��60(�$
��Nexa)�$��DemiBold"��� $��3��$��Center=�$��Center=�.+��� $��raw wpm�����#4c4c4c$��30(��� ���#007acc$��65(�$
��Nexa)�$��DemiBold"����� $	 Raw��� $��4��$��1��$��Center=�$��Center=�.+��� $��
Characters�����#4c4c4c$��30(��� ���#007acc$��60(�$
��Nexa)�$��DemiBold"����� $ Charachters��� $��4��$��2��$��Center=�$��Center=�.+��� $��Errors�����#4c4c4c$��30(��� ���#007acc$��60(�$
��Nexa)�$��DemiBold"����� $ Errors��� $��4��$��3��$��Center=�$��Center=�.+��� $��Time spent(s)�����#4c4c4c$��30(��� ���#007acc$��60(�$
��Nexa)�$��DemiBold"����� $ Seconds�#  LiveCharts.Wpf.CartesianChart  ���#333333$��1��$��1��$��3��$��4��&   LiveCharts.Wpf.Charts.Base.Chart   LegendLocation$
 None=�   Series �� *ResultsChart+   AxisX   LiveCharts.Wpf.Axis     LabelsRotation$	 -90Q�	   Title$	 Seconds��
   Labels
 �� *Labels+   AxisY   $	 -90Q�$	 Average Words Per Minute��   MinValue$ 0Q�   LabelFormatter �� $ 	Formatter��� $��4��$��4��$	��100��$	��100��$��0q�
������ ���� $
 Exit� � 	Resources  �� 
TargetType �� Property �� Value �� 
TargetType ��Name �� Triggers P� Property P� Value �� 
TargetName��%�   '��       �� " ��.���  � �� �� " ��.R��� $ ScreenImage������ $ TakeAScreenShotImage� P�  �@J�IsMouseOver$
 True��. ��� $ ScreenImage�� �@J�Opacity$	 0.5Q�