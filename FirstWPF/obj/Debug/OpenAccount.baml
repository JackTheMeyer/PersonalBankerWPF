   M S B A M L   `   `   `  ����C  ?FirstWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:FirstWPFFirstWPF  5          FirstWPF.OpenAccount   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:FirstWPF     5        N� Title$  OpenAccount��5	      .��5      � -   5         �Name$ rootGrid��5      $��
10,0,10,10q�6    � ColumnDefinitions 5   
   �� 5      $	��145 �6   �� 5      $	��490 �6   �� 5      $	��145 �6   �� 5       � RowDefinitions 5   
   �� 5      �� 5      $
��Auto �6   �� 5      �� 5      $
��Auto �6   ��5   
   �� 5       �� ImageSource$ 	bgRed.png��6   .+�5   
   �� $��1��6   $
��Left=�6$   $��
123,60,0,0q�6?   $
��Wrap=�6S   $2��,What Kind of Account would you like to open?��6g   $	��Top=�6�   �� 5   
   -   5         ��Name$ InterestButton��5      $��Interest��6)   $��1��6<   $
��Left=�6L   $��123,112,0,0q�6g   $	��Top=�6|   $��75��6�   6�   �� 5   
   -   5        $ SavingsButton��5      $��Savings��6(   $��1��6:   $
��Left=�6J   $��294,112,0,0q�6e   $	��Top=�6z   $��75��6�   6�   �� 5   
   -   5         ��Name$ InterestOpenBlock��5      $��1��6/   $
��Left=�6?   $��
61,145,0,0q�6Z   $
��Wrap=�6n   $(��"How Much Would You Like To Deposit��6�   $	��Top=�6�   �� 5   
   -   5         ��Name$ InterestOpenBox��5      $��1��6+   $
��Left=�6;   $��23��6V   $��123,166,0,0q�6b    �� TextWrapping$
 Wrap=�6w   $	��Top=�6�   $��75��6�   �� 5    
   -   5        $ InterestOpenButton��5       $
��Open��6-   $��1��6<   $
��Left=�6L   $��123,194,0,0q�6g   $	��Top=�6|   $��75��6�   6�   �� 5!   
   $��1��6   $
��Left=�6$   $��232,145,0,0q�6?   $
��Wrap=�6T   $(��"How Much Would You Like To Deposit��6h   $	��Top=�6�   �� 5"   
   $��1��6   $
��Left=�6"   $��23��6=   $��294,166,0,0q�6I   $
 Wrap=�6^   $	��Top=�6r   $��75��6�   �� 5#   
   $
��Open��6   $��1��6    $
��Left=�60   $��294,194,0,0q�6K   $	��Top=�6`   $��75��6x   5$      5%      