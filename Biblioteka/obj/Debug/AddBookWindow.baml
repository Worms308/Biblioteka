   M S B A M L   `   `   `  ����E  ABiblioteka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Biblioteka
Biblioteka  5   	       Biblioteka.AddBookWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Biblioteka     5   	     � Title$  AddBookWindow��5   	   $	��400��6    $	��300��6-    � 
ResizeMode$ NoResize=�69   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��1.1* �6   �� 5      $��2* �6    � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��Tytuł��6   $��Right=�6    $��Center=�6<   $��14(�6W   �� 5   
   $
��ISBN��6   $��Right=�6   $��Center=�6;   $��14(�6V   $��1��6d   �� 5   
   $
��Opis��6   $��Right=�6   $��Center=�6;   $��14(�6V   $��2��6d   �� 5   
   $��Rok wydania��6   $��Right=�6&   $��Center=�6B   $��14(�6]   $��3��6k   �� 5   
   $��Wydawnictwo��6   $��Right=�6&   $��Center=�6B   $��14(�6]   $��4��6k   �� 5   
   $��	Kategoria��6   $��Right=�6$   $��Center=�6@   $��14(�6[   $��5��6i   �� 5   
   $��Autorzy��6   $��Right=�6"   $��Center=�6>   $��14(�6Y   $��6��6g   �� 5    
   -   5        $��	titleText��5       $��1��6#   $��Center=�63   $��23��6P    �� TextWrapping$
 Wrap=�6\   $��Center=�6p   $	��120��6�   �� 5!   
   -   5        $��isbnText��5!      $��1��6"   $��Center=�62   $��23��6O   $��1��6[   $
 Wrap=�6h   $��Center=�6|   $	��120��6�   �� 5"   
   -   5        $��descriptionText��5"      $��1��6)   $��Center=�69   $��23��6V   $��2��6b   $
 Wrap=�6o   $��Center=�6�   $	��120��6�   �� 5#   
   -   5        $��yearText��5#      $��1��6"   $��Center=�62   $��23��6O   $��3��6[   $
 Wrap=�6h   $��Center=�6|   $	��120��6�   �� 5$   
   -   5        $��publishingHouseText��5$      $��1��6-   $��Center=�6=   $��23��6Z   $��4��6f   $
 Wrap=�6s   $��Center=�6�   $	��120��6�   �� 5%   
   -   5        $��categoryText��5%      $��1��6'   $��Center=�67   $��23��6T   $��5��6`   $��Center=�6m   $	��120��6�   �� 5&   
   -   5        $��authorsText��5&      $��1��6%   $��Center=�65   $��23��6R   $��6��6^   $
 Wrap=�6k   $��Center=�6   $	��120��6�   �� 5'   
   -   5        $��Dodaj książkę��5'      $��1��6)   $��Center=�69   $��9��6V   $��Center=�6c   $	��120��6~   $��23��6�   6�   5(      5)      