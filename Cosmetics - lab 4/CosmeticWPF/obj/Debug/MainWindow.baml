   M S B A M L   `   `   `  ����F  BCosmeticWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:CosmeticWPFCosmeticWPF  5   	       CosmeticWPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:CosmeticWPF     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	       �� 
TargetType �� Property �� Value��%�   '��       '�� P     �� 5
   
   " ��6   .�5      ��  � ��$ 20 10q�6'   67   5      �� 5   
   " ��6   .�5      ��  � ��$	 0 6q�6'   65   5      5      .��5      � .+�5   
   ]� .+�5      o� $	��Top=�6   ���	#FF673AB7.@�5      m� $��_Find��6   ���	#FF673AB7.@�5      �� -   5         ��Name$ 
tbFindText��5      $	��100��6R   ��62   �� *ServiceTypeStr+.��6a   5      �� 5      m� 5      $��_By Service type��6    � Cursor$
 Hand��69    m� Command 6G   �� *FindCommand+5      5      m� 5      $��_View��6   .@�5      m� $��_All cosmetics��6   $
 Hand��6Z    67   �� *ShowAllCommand+5       �� 5!      m� 5"      $��_Cosmetics to order��6   $
 Hand��6a    6<   �� *ShowOrderCommand+5#      5$      5%      � 5&       � ColumnDefinitions 5'      �� 5(      $	��200��6'   $��2* �66   �� 5)      $
��Auto �6'   �� 5*      $	��110��6'   $��* �66   �� 5+      $
��Auto �6'   �� 5,      $	��110��6'   $��* �66   .+�5.      �� -   5        $��contactListBox��5.      $��0��51      
���   �$��Stretch=�52      $��2��67   ��5/      �� *	Cosmetics+	 �� SelectedItem	 50      �� 
 �� Path$
 SelectedCosmetic���53      �� 54      .R�55      �  � RowDefinitions 56   "   �� 57   &   �� 58   &    5:   "   �� 5;   &   $��5* �67   �� 5<   &   $
��187* �67   �� 5=   &   $
��192* �67   .+�5?   "   ]� $��0��6,   $��0��6<   $��2��6I   .+�5@   &   �� $��18(�6K   $
��Bold"�6Y   
���������60   �� $

 Name�6�   5A   #   ]� 5B   "   $��2��6,   $��1��6<   ��.  .+�5C   &   �� $��Price: ��60   $��Light"�6?   
�������6k   �� 5D   &   
���������60   �� $
 Price�6e   �� 5E   &   $��DemiBold"�61   $��Right=�6G   
��������� 5F   *   .�6.   Count:66    �� 5G   *   �6.   �� $
 Count�6L   5H   '   5I   #   5J      5K      5M      �� 5N      $��Center=�6   $��Stretch=�5O      $��2��5P      $��1��6!   64   �� 5Q      $��2��6   
�������.+�5R      �� $��Center=�6   .��69   Name6?   �� 5S      $��Center=�6   .��69   Price6@   �� 5T      $��Center=�6   .��69   Count6@   �� 5U      $��Center=�6   .��69   Receive time6G   �� 5V      $��Center=�6   .��69   Service type6G   �� 5W      $��Center=�6   .��69   Expire date6F   5X      �� 5Y      $��4��6   
�������.+�5Z      �� ��6   �� $
 SelectedCosmetic.Name�6L   �� 5[      ��6   �� $
 SelectedCosmetic.Price�6M   �� 5\      ��6   �� $
 SelectedCosmetic.Count�6M   �� 5]      ��6   �� $"
 SelectedCosmetic.ReceiveTime�6S   �� 5^      ��6   �� $"
 SelectedCosmetic.ServiceType�6S   �� 5_      ��6   �� $!
 SelectedCosmetic.ExpireDate�6R   5a      �� 5b      $��Center=�6   $��Stretch=�5c      $��2��5d      $��3��6!   64   5e      5f      5g      5h      