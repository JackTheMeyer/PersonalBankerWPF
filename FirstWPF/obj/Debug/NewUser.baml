   M S B A M L   `   `   `  ����C  ?FirstWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:FirstWPFFirstWPF  5          FirstWPF.NewUser   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:FirstWPF     5        N� Title$   Personal Banker - New User��5	      .��5      � $��
10,0,10,10q�6    � ColumnDefinitions 5   
   �� 5      $	��145 �6   �� 5      $	��490 �6   �� 5      $	��145 �6   �� 5       � RowDefinitions 5   
   �� 5      �� 5      $
��Auto �6   �� 5      �� 5      $
��Auto �6   .+�5   
   �� -   5        $��Create User��5      $��1��6'   $
��Left=�67   $��
200,85,0,0q�6R   $	��Top=�6f   $��75��6~    J� RenderTransformOrigin$ -1.102,4.13&�6�   $��2��6�   6�   �� 5   
   -   5         ��Name$ UsernameTextBox��5      $��1��6+   $
��Left=�6;   $��23��6V   $��181,104,0,0q�6b    �� TextWrapping$
 Wrap=�6w   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ PasswordTextBox��5      $��1��6+   $
��Left=�6;   $��23��6V   $��181,164,0,0q�6b   $
 Wrap=�6w   $	��Top=�6�   $	��120��6�   �� 5   
   -   5         ��Name$ PasswordTextBlock��5      $��1��6/   $
��Left=�6?   $��190,143,0,0q�6Z   $
��Wrap=�6o   $��Choose a Password��6�   $	��Top=�6�   �� 5   
   -   5        $ UsernameTextBlock��5      $��1��6/   $
��Left=�6?   $��
178,83,0,0q�6Z   $
��Wrap=�6n   $��Chose a Client Number��6�   $	��Top=�6�   �� 5   
   -   5        $ BalanceTextBox��5      $��1��6*   $
��Left=�6:   $��23��6U   $��
181,31,0,0q�6a   $
 Wrap=�6u   $	��Top=�6�   $	��120��6�   $��2��6�   �� 5   
   -   5        $ BalanceTextBlock��5      $��1��6.   $
��Left=�6>   $��
139,10,0,0q�6Y   $
��Wrap=�6m   $)��#How much would you like to deposit?��6�   $	��Top=�6�   $	��218��6�   $��2��6�   ��5   
   �� 5        �� ImageSource$ 	bgRed.png��6   5"      5#      