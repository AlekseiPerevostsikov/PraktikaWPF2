   M S B A M L   `   `   `  ����V  RPraktika_wpf2_Perevostsikov, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Praktika_wpf2_PerevostsikovPraktika_wpf2_Perevostsikov  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089I2clr-namespace:System.Collections;assembly=mscorlibSystem.Collections 5   	   ,    &Praktika_wpf2_Perevostsikov.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:Praktika_wpf2_Perevostsikov     5   	   JCollections2clr-namespace:System.Collections;assembly=mscorlib     5   	   -   5          � Title$  Camps��5	   	   $��398.235��6   $��645.471��6(    � WindowStartupLocation$ CenterScreen=�68   .��5
      �  � ColumnDefinitions 5   
   �� 5      .+�5   
   �� -   5         ��Name$ CampList��5   %    �� SelectedIndex$ 0��6   $	��199��67   $��16,103,21,0q�6D   $	��Top=�6Y    �� View 5      �� 5      .P�5      ��  �� Width$	 150��6O   $��	Camp name��6[    �� DisplayMemberBinding 6%   �� *
CampName+6[   �� 5      $	 400��6R   $��
Decription��6^    6%   �� *Description+6^   5      5      �� 5   
   -   5         ��Name$ txtCampName��5      $
��Left=�6'   $��23��6B   $��	18,60,0,0q�6N   	 �� TextWrapping$
	 Wrap=�6a   $	��Top=�6u   $	��150��6�   6�   �� 5    
   $��Searching: Camp name��6   $
��Left=�6/   $��	18,29,0,0q�6J   $	��Top=�6]   $	��134��6u   �� 5!   
   -   5        
 ��Name$
 
btnAddCamp��5!      $��Add Camp��6%   $
��Left=�68   $��
188,60,0,0q�6S   $	��Top=�6g   $��80��6   6�   �� 5"   
   -   5        $
 btnEditCamp��5"      $��	Edit Camp��6&   $
��Left=�6:   $��
286,59,0,0q�6U   $	��Top=�6i   $��80��6�   6�   �� 5#   
   -   5        $
 btnDeleteCamp��5#      $��Delete Camp��6(   $
��Left=�6>   $��
391,59,0,0q�6Y   $	��Top=�6m   $��80��6�   6�   �� 5$   
   -   5        $
 btnShowStudent��5$      $��Groups And Students��6)   $
��Left=�6G   $��
494,59,0,0q�6b   $	��Top=�6v   $	��122��6�   6�   o� 5&   
   $��25��6   $	��Top=�6   .@�5'      m� $
��File��6   .@�5(      m� -   5        $��All Students��5(      6O   �� 5)      m� 5*      -	   5        $
��Exit��5*      6C   5+      5-      50      51      