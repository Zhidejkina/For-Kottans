   M S B A M L   `   `   `  ����C  ?Calendar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:CalendarCalendar  5   	       Calendar.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Calendar     5   	   -   5          �Name$  window��5   	    � Title$ Calendar��5   	   $	��239��6   $	��401��6'    � ForceCursor .  � Icon$ icon.jpg��6F    � 
ResizeMode$ NoResize=�6V    � Topmost .  � Cursor$ Arrow��6{   ��5	      �� 5
   
    �� 
StartPoint$	 0,0&�6    �� EndPoint$	 1,0&�6/   .��5      � 	 � Color$
	 Pink��6   
 � Offset$	
 0.0Q�6(   � 5      $	 Violet��6   $

 0.25Q�6*   � 5      $	 	LightPink��6   $

 0.55Q�6-   � 5      $	 HotPink��6   $

 0.75Q�6+   $��RightToLeft=�69   � 5      $
	 Pink��6   $	
 1.0Q�6(   5      .��5      � $��	0,0,-51,0q�6    � ColumnDefinitions 5   
   �� 5      $	��32* �6   �� 5      $	��20* �6   �� 5      $
��Auto �6   �� 5      $��3* �6   �� 5      $��2* �6    � RowDefinitions 5   
   �� 5      $��0* �6   �� 5      .+�5   
   &   System.Windows.Controls.Calendar  -   5          Name$ Calendar��5         DisplayMode$ Month=�5         SelectionMode$ 
SingleDate=�5       $��
0,19,18,-9q�5!      $��1��5"      ��5#      �� 5$      $	 0,0&�6&   $	 1,0&�67   .��5%      � $
	 Pink��6#   $	
 0.0Q�60   � 5&      $
	 Plum��6#   $

 0.25Q�60   � 5'      $	 HotPink��6#   $

 0.75Q�63   � 5(      $
	 Pink��6#   $	
 1.0Q�60   5)      ��5+      �� 5,      $	 0,0&�6&   $	 1,1&�67   .��5-      � $	 Black��6#   $

 0.25Q�61   � 5.      $	 Indigo��6#   $	
 1.0Q�62   5/      53      �� 55   
   -   5         ��Name$ textBox��55      $
��Left=�56      $	��126��57      $��
212,54,0,0q�58      $��2��59       �� TextWrapping$
 Wrap=�5:      $��Event for today: ��5;      $	��Top=�5<      $	��156��5=      $��2��6   {�.  5>      �� 5?   
   -   5        $ textBox_Date��5?      $
��Left=�5@      $��23��5A      $��
212,23,0,0q�5B      $��2��5C      $
 Wrap=�5D      $	��Top=�5F      $��71��5G      $��13.333(�6    �� 
IsReadOnly . $��2��5H   $   ��5E      �� *SelectedDate+ �� ElementName$ Calendar�� �� StringFormat$ M/d/yyyy��5H   8   �� 5I   
   -   5         ��Name$ button��5I      $��
Save Event��6!   $��1��66   $��Right=�6F   $��	0,23,39,0q�6b   $��2��6u   $	��Top=�6�   $��70��6�   $��23��6�   6�   5L      5M      