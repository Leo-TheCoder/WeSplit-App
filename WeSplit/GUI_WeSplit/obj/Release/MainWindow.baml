   M S B A M L   `   `   `  ���� F  BGUI_WeSplit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:GUI_WeSplitGUI_WeSplit      GUI_WeSplit.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     +localclr-namespace:GUI_WeSplit     -     � Title$+  %WeSplit - Chia tiền đi chơi chung�� � WindowStyle$
 None=� � AllowsTransparency . 
������  � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ 	CanResize=����� *&$SystemParameters.PrimaryScreenHeight+���� *%#SystemParameters.PrimaryScreenWidth+ � 	Resources  �� 
TargetType �� Property �� Value��%y   '��       �� " ��.���  � ��
 �   ���  � ��$ 18(���  � ��$ Center=���  � ��$ Bottom=�.��� 	 � ShowGridLines	 .  .+��� 
 �� CornerRadius$
 20�� K� ZIndex$ 2��._��  � RowDefinitions �� $��10 ��� $��50 ��� $��10 ��� $��* ��� $��10 � � ColumnDefinitions �� $��15 ��� $��* ��� $��15 �.+��� $
��Left=�$��Center=�$��1��$��1��.+��� -    ��Name$ 
ExitButton��$��40��$��40��
�������$
 50�� � Triggers :�  :� RoutedEvent$ Border.MouseEnter��.[��� .���� .����  g� Duration$ 0:0:0.3D� �� From$ WhiteX�	 �� To$ 	OrangeRedX� �� TargetProperty$1 +(Border.Background).(SolidColorBrush.Color)� �� 
TargetName$ 
ExitButton��:� $ Border.MouseLeave��.[��� .���� .���� $ 0:0:0.3D�$ 	OrangeRedX�$ WhiteX�$1 +(Border.Background).(SolidColorBrush.Color)�$ 
ExitButton��._��� -    ��Name$ 	ExitImage��$��Images/powerIcon.png�� �� BitmapScalingMode$ HighQuality=�$��30��$��0 0 0 1q�� $��1��$��1��$��2��$��Center=�$��Right=�$	��480��$��60�� �� $��1* ��� $��2* ��� $��2* ��� $��1* � �� $��35 ��� $��35 �.+��� $��0��$��0��Trang chủ�� $��0��$��1��Chưa hoàn thành�� $��0��$��2��Đã hoàn thành�� $��0��$��3��
About Us� -    �Name$ ActiveIndicator��$��Center=�$��Center=�$��20��$��15�� � Points1 �    �������� ����� �� �����
���   � �� Stretch$
 Fill=�$��0��$��1��$��0 0 0 0q� J� Opacity$	 0.5Q��� -   $ MainFrameBorder��$��1��$��3��$
 20������  �� Color$ Black�� �� Opacity$	 0.5Q�._� � -     �Name$ 	MainFrame��  � NavigationUIVisibility$ Hidden=�$��10q��� -   $ WindowBackgroundImage��$
 20������   �� ImageSource$  Images/Rina002.png��! j� Stretch$! UniformToFill=�