   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5       FourAgainstDarkness,   &FourAgainstDarkness.Views.NewCharacter   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    63   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     6u   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5        � Title$  Build Character��5      $	��300��5      $	��NaN��5      $��0q�5      (   "MahApps.Metro.Controls.MetroWindow   	GlowBrush
 �   � � 
ResizeMode$ CanResizeWithGrip=�5	         WindowTransitionsEnabled .   � WindowStartupLocation$ CenterScreen=�5      .��5      � .+�5      ��  �� Orientation$ Vertical=�5      $��Stretch=�5      .+�5      �� -   5         ��Name$ CharTypeCombo��5      $	��262��5      $��27��5      $��0��5      $��0��5      $
��Left=�5      $	��Top=�5      $��	14,16,0,0q�5      5      �� 5      $ 
Horizontal=�5      $��0,10,0,0q�5      .+�5      �� $��Name:��5      �� 5      -   5        $��NameBox��5       $	��225��5!      5"      �� 5#      $ 
Horizontal=�5$      $��0,10,0,0q�5%      .+�5&      �� $��Level:��5'      �� 5(      -   5        $ 
LevelCombo��5*      $��20��5)      $��45��5+       �� Text$  ��5,      5-      �� 5.      $��Life:��5/      $��25,0,0,0q�50      �� 51      -   5         ��Name$ LifeBox��52      $��50��53      	 �� 
IsReadOnly	 . $��Center=�55      $��Center=�56      57      �� 58      $ 
Horizontal=�59      $��0,10,0,0q�5:      .+�5;      �� $��Gold:��5<      �� 5=      -   5        $ GoldBox��5>      $��50��5?      $��Center=�5@      $��Center=�5A      	 .  
 J� RenderTransformOrigin$
 0.5,0.5&�5C      $��0��5D      �� 5E      -   5         ��Name$ 	GoldLabel��5G      $��25,0,0,0q�5F      5G      5H      �� 5I      -   5        $��
equipstack��5J      $ Vertical=�5K      .+�5L      �� $��
Equipment:��5M      �� 5N      
���   �$��2q�5P      ._�5Q      �� -   5         ��Name$ EquipmentInventory��5R      ��5S      �� *Equipmentcarried+ �� Mode$ TwoWay=���5T      �� 5U   	   .R�5V   
   �� �� 5W      �5X      ��  �� Path$
 Name� �� 5Y      $�, Value=��5Z       �� 5[      �5\      �� $ Value�5]      5^   
   5`      5a      �� 5b      $ 
Horizontal=�5c      .+�5d      �� -	   5         ��Name$ 
SellButton��5i         AccentedSquareButtonStyle#��[  5e      $
��Sell��5f      $��10,10,10,10q�5g      $��35��5h      $
 0.5,0.5&�5j      5k      �� 5l      -
   5        $ 	BuyButton��5q      #��[  5m      $	��Buy��5n      $��10,10,10,10q�5o      $��35��5p      $
 0.5,0.5&�5s      5t      �� 5u      -   5        $ EquipNoteBlock��5v       �� TextWrapping$
 Wrap=�5w      ��5x      �� *
Equipnotes+$ TwoWay=�5y      �� 5z      $��2,2,2,2q�5{      Trading Instructions:�� 5|      (&1. Inflate Gold, note original amount.�� 5}   .   642. Accomplish trade by buying and selling equipment.�� 5~   <   #!3. Reset Gold to original amount.5�      �� 5�      -   5        $��CompleteButton��5�      #��[  5�      $��Add Character to Party��5�      $��Center=�5�      $��0,10,0,0q�5�      5�      5�      5�      5�      