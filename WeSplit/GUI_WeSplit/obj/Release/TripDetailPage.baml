   M S B A M L   `   `   `  ���� F  BGUI_WeSplit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:GUI_WeSplitGUI_WeSplit       GUI_WeSplit.TripDetailPage   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     +localclr-namespace:GUI_WeSplit     -     N� Title$  TripDetailPage�� � 	Resources    SidebarStyle �� 
TargetType �� Property �� Value �� Triggers :� RoutedEvent g� Duration W� From		 W� To
 �� TargetProperty  SidebarHoverStyle��%  &	        &	 �    �� " ��.���  � ��
 �������  � ��
 ���� ��  � ��$ 20(���  � ��$ SemiBold"���  � ��$ Center=���  � ��$ Center=� :� $ TextBlock.MouseEnter��.[��� .���� .��W� $ 0:0:0.5D�$ 20X�$	 22X�$
 (TextBlock.FontSize)�:� $ TextBlock.MouseLeave��.[��� .���� .��W� $ 0:0:0.5D�$ 22X�$	 20X�$
 (TextBlock.FontSize)��� " ��.���  � ��
 �������  � ��
 ���� ��  � ��$ 22(���  � ��$ SemiBold"�.���  � ColumnDefinitions �� $
��auto ��� $
��auto ��� $��* �.+��� -    ��Name$ Sidebar��$
��Left=�$��Stretch=�$��50�� K� ZIndex$ 5��$��Disabled=� � Triggers :� $ StackPanel.MouseEnter��.[��� .���� .��W� $ 0:0:0.5D�$ 50X�$		 220X� �� 
TargetName$ Sidebar��$
 (StackPanel.Width)�:� $ StackPanel.MouseLeave��.[��� .���� .��W� $ 0:0:0.5D�$	 220X�$	 50X�$ Sidebar��$
 (StackPanel.Width)�.+��� -   $ GeneralInfoButton�� �� Orientation$ 
Horizontal=�$��Center=�$��50��.+��� $��Images/Rina002.png�� �� BitmapScalingMode$ HighQuality=�$��UniformToFill=�$��50��$��50���� $�� ���� $��50��
������ ._��� #���   Thông tin chung�� -   $ MemberListButton��$ 
Horizontal=�$��Center=�.+��� $��Images/Rina002.png��$ HighQuality=�$��UniformToFill=�$��50��$��50���� $�� ���� $��50��
������ ._��� #���   Thành viên�� -   $ DestinationListButton��$ 
Horizontal=�$��Center=�.+��� $��Images/Rina002.png��$ HighQuality=�$��UniformToFill=�$��50��$��50���� $�� ���� $��50��
������ ._��� #���   Địa điểm đi qua�� -   $ ExpenseHistoryButton��$ 
Horizontal=�$��Center=�.+��� $��Images/Rina002.png��$ HighQuality=�$��UniformToFill=�$��50��$��50���� $�� ���� $��50��
������ ._��� #���   Lịch sử chi tiêu� $��1��$��4�� � RowDefinitions �� $��50 ��� $��50 ��� $��50 ��� $��50 ��� $��50 �.+��� -    ��Name$ ActiveIndicator��
�������$��0�� � -     �Name$ TripDetailFrame��  � NavigationUIVisibility$ Hidden=�$��2��