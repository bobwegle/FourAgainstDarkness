   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5       FourAgainstDarkness'   !FourAgainstDarkness.Views.Monster   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    6.   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     6p   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5        � Title$  Monster Tracker��6   $��0q�5      (   "MahApps.Metro.Controls.MetroWindow   	GlowBrush
 �   � � 
ResizeMode$ CanResizeWithGrip=�5         WindowTransitionsEnabled .   � WindowStartupLocation$ CenterScreen=�5	      $	��627��5
      $	��343��5       � 	Resources 5         	encounter � ColumnDefinitions �� Orientation �� CornerRadius  AccentedSquareButtonStyle��%  &	       7  �� 5      $	��300��5      $	��300��5      ._�5      �  5      �� 5      $
��.62* �5      �� 5      $
��.38* �5      .+�5      �� $��0��5      $ Vertical=�5      .+�5      �� $ 
Horizontal=�5      .+�5      �� 
���   �$��1q�5       $ 10��5!      ._�5"   	   �� $ Vertical=�5#   	   .+�5$   
   �� $��Minion��5%   
   �� 5&   
   5'   
   5(   	   �� 5)      $ Vertical=�5*      .+�5+   	   	� $
��BOSS��5,   	   $��8(�5-   	   $��0,8,0,0q�5.   	   $��Stretch=�5/   	   $
��Left=�50   	   	� 51   	   $��VERMIN��52   	   $��8(�53   	   $
��Left=�54   	   55   	   �� 56      
���   �$��1q�58      $ 10��59      ._�5:   	   �� $ Vertical=�5;   	   .+�5<   
   �� $��Level��5=   
   �� 5>   
   5?   
   5@   	   �� 5A      
���   �$��1q�5C      $ 10��5D      ._�5E   	   �� $ Vertical=�5F   	   .+�5G   
   �� $��Count��5H   
   �� 5I   
   5J   
   5K   	   5L      �� 5M      
���   �$��2q�5O      ._�5P      � .+�5Q   	   �� �� 5R   	   -   5        $��+1��5S   	   8��  5U   	   5V   	   5W      5X      �� 5Y      
���   �$��1q�5[      $ 10��5\      $��1��5]      ._�5^      �� $ Vertical=�5_      .+�5`      �� $ 
Horizontal=�5a      .+�5b   	   �� $ Vertical=�5c   	   .+�5d   
   �� $
��FLEE��5e   
   $��8(�5f   
   	� 5g   
   $��Center=�5h   
   5i   
   �� 5j   	   $ Vertical=�5k   	   .+�5l   
   �� $��AMBUSH��5m   
   $��8(�5n   
   	� 5o   
   $��Center=�5p   
   5q   
   �� 5r   	   $ Vertical=�5s   	   .+�5t   
   �� $��BRIBE��5u   
   $��8(�5v   
   	� 5w   
   $��Center=�5x   
   5y   
   5z   	   �� 5{      $ Vertical=�5|      .+�5}   	   �� $
��NOTE��5~   	   $��8(�5   	   �� 5�   	   5�   	   �� 5�      $ 
Horizontal=�5�      .+�5�   	   �� $��ATTACKS PER ROUND: ��5�   	   $��8(�5�   	   �� 5�   	   5�   	   5�      5�      5�      5�      5�      .��5�      � 	 � RowDefinitions	 5�      �� 5�      $��0.25* �5�      �� 5�      $��* �5�      .+�5�      �� -   5        $��Add Encounter��5�      #��[ 5�      $��25��5�      $
��Left=�5�      $��5,5,5,5q�5�      5�      � 5�      -   5        $��	wrappanel��5�      $��1��5�      $��Stretch=�5�      .+�5�      �� #��[  5�      $��5,0,0,5q�5�      5�      5�      5�      