   M S B A M L   `   `   `  ����E  ATypeClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:TypeClient
TypeClient  5   	   U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 60   =#clr-namespace:TypeClient.ViewModelsTypeClient.ViewModels  6q       TypeClient.ResultWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:TypeClient     5   	   Dlvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     60   :
viewmodels#clr-namespace:TypeClient.ViewModels     6q   -   5        ���#333333  � Title$  Results��5
   	   $	��850��6   $
��1560��6&   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��30* �6   �� 5      $	��30* �6   6-   �� 5      $	��30* �6   6-   �� 5      $	��30* �6   6-   �� 5      $	��30* �6   6-   �� 5      $	��20* �6   6-    � RowDefinitions 5   
   �� 5      $	��10* �6   6+   �� 5      $	��20* �6   6+   �� 5      $	��20* �6   6+   �� 5      $	��20* �6   6+   �� 5      $	��20* �6   6+   .+�5   
   �� $��1��6   $��Center=�6"   $��Center=�6=   .+�5      �� $	��wpm��6   ���#4c4c4c$��30(�69   6I   �� 5      ���#007acc$��65(�6H   $
��Nexa)�6V   $��DemiBold"�6h   ��6   ��  �� Path$	 Wpm�6�   5      �� 5   
   $��2��6   $��Center=�6"   $��Center=�6=   .+�5       �� $	��acc��6   ���#4c4c4c$��30(�69   6I   �� 5!       �� Orientation$ 
Horizontal=�6   .+�5"      �� ���#007acc$��60(�6Q   $
��Nexa)�6_   $��DemiBold"�6q   ��6   �� $ Accuracy�6�   �� 5#      $��%��6   ���#007acc$��60(�6;   $
��Nexa)�6I   $��DemiBold"�6[   6s   5$      5&      �� 5'   
   $��3��6   $��Center=�6"   $��Center=�6=   .+�5(      �� $��raw wpm��6   ���#4c4c4c$��30(�6=   6M   �� 5)      ���#007acc$��65(�6H   $
��Nexa)�6V   $��DemiBold"�6h   ��6   �� $	 Raw�6�   5*      �� 5+   
   $��4��6   $��1��6"   $��Center=�62   $��Center=�6M   .+�5,      �� $��
Characters��6   ���#4c4c4c$��30(�6@   6P   �� 5-      ���#007acc$��60(�6P   $
��Nexa)�6^   $��DemiBold"�6p   ��6   �� $ Charachters�6�   5.      �� 5/   
   $��4��6   $��2��6"   $��Center=�62   $��Center=�6M   .+�50      �� $��Errors��6   ���#4c4c4c$��30(�6<   6L   �� 51      ���#007acc$��60(�6K   $
��Nexa)�6Y   $��DemiBold"�6k   ��6   �� $ Errors�6�   52      �� 53   
   $��4��6   $��3��6"   $��Center=�62   $��Center=�6M   .+�54      �� $��Time spent(s)��6   ���#4c4c4c$��30(�6C   6S   �� 55      ���#007acc$��60(�6L   $
��Nexa)�6Z   $��DemiBold"�6l   ��6   �� $ Seconds�6�   56      #  LiveCharts.Wpf.CartesianChart  57   
   ���#333333$��1��62   $��1��6?   $��3��6O   $��4��6`   &   LiveCharts.Wpf.Charts.Base.Chart   LegendLocation$
 None=�6�      Series 6t   �� *ResultsChart+   AxisX 59        LiveCharts.Wpf.Axis     LabelsRotation$	 -90Q�6   	   Title$	 Seconds��60   
   Labels
 6@   �� *Labels+6\      AxisY 5<        $	 -90Q�6   $	 Average Words Per Minute��60      MinValue$ 0Q�6Q      LabelFormatter 6^   �� $ 	Formatter�6�   5>      �� 5?   
   $��4��6   $��4��6!   $	��100��6/   $	��100��6<   $��0q�6g   
������ ��6H   �� $
 Exit� � 	Resources 5@       �� 
TargetType �� Property �� Value �� 
TargetType ��Name �� Triggers P� Property P� Value �� 
TargetName��%d  '��       �� 5A      " ��6   .�5B      ��  � �� 5C      �� 5D      " ��6/   .R�5E   "   �� $ ScreenImage��6(   ��6=   �� $ TakeAScreenShotImage�5F   #    5G   "   P� 5H   &    �@J�IsMouseOver$
 True��6E   . �5I   *   �� $ ScreenImage��61    �@J�Opacity$	 0.5Q�6]   5K   '   5M      5O      5P      5Q      5R      5S      5T      