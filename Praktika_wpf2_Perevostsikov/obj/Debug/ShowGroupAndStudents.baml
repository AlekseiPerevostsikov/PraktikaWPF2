   M S B A M L   `   `   `  ����V  RPraktika_wpf2_Perevostsikov, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Praktika_wpf2_PerevostsikovPraktika_wpf2_Perevostsikov  5   	   6    0Praktika_wpf2_Perevostsikov.ShowGroupAndStudents   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:Praktika_wpf2_Perevostsikov     5   	   -   5          � Title$  Show Groups and Students��5   	   $��592.5��6*   $	��983��69    � WindowStartupLocation$ CenterScreen=�6E   .��5	      �  � ColumnDefinitions 5
   
   �� 5      .+�5   
   �� -   5         ��Name$ StudentList��5   %    �� SelectedIndex$ 0��6   $	��197��6:   $��	0,343,0,0q�6G   $	��Top=�6Z    �� View 5      �� 5      .P�5      ��  �� Width$	 140��6O   $��	Last Name��6[    �� DisplayMemberBinding 6%   �� *
LastName+6[   �� 5      $	 120��6P   $��
First Name��6\    6%   �� *	FirstName+6\   �� 5      $	 100��6P   $��	Isikukood��6\    6%   �� *	Isikukood+6\   �� 5      $	 170��6Q   $��School Name��6]    6%   �� *
SchoolName+6]   �� 5      $ 80��6R   $��Class Number��6]    6%   �� *ClassNumber+6]   �� 5      $	 140��6L   $��Phone��6X    6%   �� *Phone+6X   �� 5      $	 200��6M   $��Adress��6Y    6%   �� *Adress+6Y   5      5      �� 5   
   -   5         ��Name$ txtStudentLastName��5      $
��Left=�6.   $��26��6I   $��
277,55,0,0q�6U   	 �� TextWrapping$
	 Wrap=�6i   $	��Top=�6}   $��88��6�   6�   �� 5    
   $��Searching: Last Name��6   $
��Left=�6/   $��
128,55,0,0q�6J   $	��Top=�6^   $	��144��6v   �� 5#   
   -   5        $ 	GroupList��5#   %   $ 0��6   $	��197��68   $��128,87,264,0q�6E   $	��Top=�6[   
 J� RenderTransformOrigin$
 0.488,0.259&�6�    5$      �� 5%      .P�5&      �� $	 200��6P   $��
Group Name��6\    6%   �� *	GroupName+6\   �� 5'      $	 350��6R   $��Group Description��6^    6%   �� *Description+6^   5(      5*      �� 5,   
   -   5        $ txtGroupName��5,      $
��Left=�6(   $��26��6C   $��
276,24,0,0q�6O   $
	 Wrap=�6c   $	��Top=�6w   $��89��6�   6�   �� 5-   
   $��Searching: Group Name��6   $
��Left=�60   $��
128,24,0,0q�6K   $	��Top=�6_   $	��143��6w   �� 5.   
   -   5         ��Name$ btnAddGroup��5.      $��	Add Group��6&   $
��Left=�6:   $��
725,87,0,0q�6U   $	��Top=�6i   $��90��6�   6�   �� 5/   
   -   5        $ btnEditGroup��5/      $��
Edit Group��6'   $
��Left=�6<   $��725,147,0,0q�6W   $	��Top=�6l   $��90��6�   6�   �� 50   
   -   5        $ btnDeleteGroup��50      $��Delete Group��6)   $
��Left=�6@   $��725,206,0,0q�6[   $	��Top=�6p   $��90��6�   6�   �� 51   
   -	   5        $ btnAddStudent��51      $��Add Student��6(   $
��Left=�6>   $��
851,87,0,0q�6Y   $	��Top=�6m   $��90��6�   6�   �� 52   
   -
   5        $ btnEditStudent��52      $��Edit Student��6)   $
��Left=�6@   $��851,147,0,0q�6[   $	��Top=�6p   $��90��6�   6�   �� 53   
   -   5        $ btnDeleteStudent��53      $��Delete Student��6+   $
��Left=�6D   $��851,206,0,0q�6_   $	��Top=�6t   $��90��6�   6�   54      55      