   M S B A M L   `   `   `  ����F  BGUI_WeSplit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:GUI_WeSplitGUI_WeSplit  5           GUI_WeSplit.MemberListPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:GUI_WeSplit     5      -   5          N� Title$  MemberListPage��5	       � 	Resources 5         	NameStyle �� 
TargetType �� Property �� Value  	InfoStyle��%�  &	        &	 �     �� 5   
   " ��5      .�5      ��  � ��$ 20(�6)   �� 5       � ��$ 
Bree Serif)�6+   �� 5       � ��
 �����6+   5      �� 5   
   " ��5      .�5      ��  � ��$ 25(�6)   �� 5       � ��$ 
Bree Serif)�6+   �� 5       � �� �#0cebeb6+   �� 5       � ��$ Center=�64   �� 5       � ��$ Center=�62   5      5      .��5      �� -   5         ��Name$ 
MemberList��5      
������ $��Stretch=�5      $��Hidden=�5       $��50��5!      $��50��5"      $��0q�5#      ��5%   
   �� 5&      .R�5'      �� .+�5(      9� 
���������5)      �� ��5*      �� ��5,      �� 5-      .R�5.   "   � 
����d���5/   '   ��  �� Path$ HorizontalAlignment� �� RelativeSource �� *FindAncestor+ �� AncestorType" ��	 �� Mode$	 OneWayToSource=�.+�50   &   ]� $��0 5 0 0q�60   .+�51   *   �� 
 ��Name$
 MemberNameTextBlock��64   $��1��53   4   $��Center=�54   4   $��Center=�55   4   #���   56   4   ��52   4   �� *
MemberName+56   4   57   '   59   #   5:      ��5=      �� 5>      .R�5?   "   �  � ColumnDefinitions 5@   &   �� 5A   *   $��* �6;   6G   �� 5B   *   $��7* �6;   6H    � RowDefinitions 5D   &   �� 5E   *   $��* �68   6E   �� 5F   *   $��* �68   6E   .+�5I   &   ��  ��Name$ MemberAvatarBorder��6-   $	��250��5J   -   $��50��6:   $	��200��5K   -   $��50��69    �� CornerRadius$ 15��5L   -   $��5q�5M   -   $��0��5N   -   $��2��5O   -   ��5P   *   �� 5Q   .    �� 
StartPoint$	 0,0&�6B    �� EndPoint$	 1,1&�6S   .��5R   2   �  � Color$ #91EAE4��6?    � Offset$	 0.0Q�6O   � 5S   2   $ #20e3b2��6?   $
 0.25Q�6O   � 5T   2   $ #0cebeb��6?   $
 0.75Q�6O   5U   /   ��5W   *   �� 5X   .   MemberAvatarImage�� �� BitmapScalingMode$ HighQuality=�5Z   9    j� Stretch$ UniformToFill=�5[   9    �� ImageSource 5Y   9   �� *MemberAvatar+5[   S   5]   '   �� 5_   &   $��0��5`   0   $��1��5a   0   
��������5_   0   �� *
MemberName+5b   J   �� 5d   &   $
 MemberDOBTextBlock��60   $��1��5f   0   $��1��5g   0   ��5e   0   �� *	MemberDOB+5g   B   5i   #   5j      5l      5m      5o      5s      5v      