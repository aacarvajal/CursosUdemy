   M S B A M L   `   `   `  ����J  FFormWinContacts, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:FormWinContactsFormWinContacts  5   	        FormWinContacts.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:FormWinContacts     5   	     � Title$  
MainWindow��5   	   $��415.726��6   $	��771��6-    � 	Resources 5	      ,   &FormWinContacts.WinFormsContactDataSet   winFormsContactDataSet  contactosViewSource �� Source �� Source��%Z   &	        &	      7     5
   
   6'   �� 5   
    6;   �� *	Contactos+8   5      .��5      �  � DataContext# [ 6    � ColumnDefinitions 5   
   �� 5      .+�5   
   �� -   5        $��Search��5      $��Buscar��6   $
��Left=�6/   $��16,6,0,0q�6J   $	��Top=�6\   �� 5   
   -   5        $��Buscador��5      $
��Left=�6"   $��23��6=   $��	66,10,0,0q�6I    �� TextWrapping$
 Wrap=�6\   $	��Top=�6p   $	��413��6�   �� 5   
   -   5        $��Buscar��5      $��Buscar��6   $
��Left=�60   $��	16,57,0,0q�6K   $	��Top=�6^   $��75��6v   6�   �� 5   
   -   5        $��Añadir��5      $��Añadir��6   $
��Left=�60   $��
208,57,0,0q�6K   $	��Top=�6_   $��75��6w   6�   �� 5   
   -   5        $��contactosListView��5       �� DisplayMemberPath$ id��6,   $��10,103,0,10q�6C    �� SelectedValuePath$ id��6X   	 �� SelectionMode$	 Single=�6o   $
��Left=�6�   $	��733��6�   
 �� View
 5      �� 5      .P�5      ��  �� Width$	 140��6%   $��Id��61    �� DisplayMemberBinding 6=   �� *id+�� 5      $	 140��6%   $��Nombre��61    6A   �� *nombre+�� 5      $	 140��6%   $��	Apellidos��61    6D   �� *	apellidos+�� 5      $	 140��6%   $��Telefono��61    6C   �� *
telefono+�� 5      $	 140��6%   $��	Direccion��61    6D   �� *	direccion+5!      5#      �� 5$   
   -   5        $��Editar��5$      $��Editar��6   $
��Left=�60   $��
404,57,0,0q�6K   $	��Top=�6_   $��75��6w   6�   �� 5%   
   -   5        $��Borrar��5%      $��Borrar��6   $
��Left=�60   $��
590,57,0,0q�6K   $	��Top=�6_   $��75��6w   6�   5&      5'      