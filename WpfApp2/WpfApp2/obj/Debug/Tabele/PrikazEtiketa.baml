   M S B A M L   `   `   `  ����B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WpfApp2.TabeleWpfApp2.Tabele  5   	   7 clr-namespace:WpfApp2.ValidacijaWpfApp2.Validacija  5   	   "    WpfApp2.Tabele.PrikazEtiketa   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:WpfApp2.Tabele     5   	   7
Validacija clr-namespace:WpfApp2.Validacija     5   	   X TXceed.Wpf.Toolkit, Version=3.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  6=     � Title$  PrikazEtiketa��5	   	   $	��450��6   $	��800��6,   .��5
      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGridEtiketa��5         
IsReadOnly .    AutoGenerateColumns .  $	��198��6|   $
��Left=�6�   $	��Top=�6�   $ �� IsSynchronizedWithCurrentItem$
 TrueY�6�   ��6-   �� *	Etikete+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6&      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 62   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *	IDEtiketa+4  .System.Windows.Controls.DataGridTemplateColumn  5      $
 Boja��6)   $ * 67   	   CellTemplate	 5      �� 5      .R�5      A� $��20��6C   $��20��6O   ��6&   �� *
ColorBrush+6O   5      5        5      $
 Opis��6%   $ * 63    6=   �� *OpisEtiketa+5      � 5   
   $
��Left=�6V   $	��127��6q   $��	0,203,0,0q�6~   $	��Top=�6�   $	��792��6�   ���	#FFC5D6A6
 � DataContext
 6   ��  �� ElementName$ dataGridEtiketa�� �� Path$ SelectedItem�.+�5      �� $
��ID *��6   $
��Left=�6#   $��10,6,0,0q�6>   $	��Top=�6P   $��36��6h   $��68��6t   ���	#FF2E2222��6�   Z� �� 5      -   5         ��Name$ 	EtiketaID��5   i    �� 
IsReadOnly . -  'System.Windows.Input.KeyboardNavigation   TabIndex$ 0��6H   $
��Left=�6|   $��23��6�   $��	78,10,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��215��6�   ��6(   �� $ 	IDEtiketa�.��6�   .��5"      5#      �� 5$      $��Boja *��6   $
��Left=�6%   $��	10,50,0,0q�6@   $	��Top=�6S   ���	#FF0201016k   #  Xceed.Wpf.Toolkit.ColorPicker  5%      {�.  $
��Left=�6�   $��	78,52,0,0q�6�   $	��Top=�6�   $��90��6�      SelectedColor 61   �� $ bojaEtiketa� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5&      $
��Opis��6   $
��Left=�6#   $��
375,48,0,0q�6>   $	��Top=�6R    J� RenderTransformOrigin$ -2.206,0.923&�6j   �� 5'       . $
��Left=�6J   $	��101��6e   $��
430,10,0,0q�6r   $
 Wrap=�6�   $	��Top=�6�   $	��215��6�   $ 0.791,0.257&�6�   ��6(   �� $ OpisEtiketa�6�   5(      �� 5)   
   -   5        $��Izmjeni ��5)      $
��Left=�6$   $��
10,370,0,0q�6?   $	��Top=�6S   $	��150��6k   $��30��6w   $ 
0.867,-1.5&�6�   6�   �� 5*   
   -   5        $��Izbriši��5*      $
��Left=�6#   $��180,370,0,0q�6>   $	��Top=�6S   $	��145��6k   $��30��6w   $ 
0.28,0.667&�6�   6�   �� 5+   
   -   5        $��Zatvori��5+      $
��Left=�6#   $��657,379,0,0q�6>   $	��Top=�6S   $	��125��6k   $ 1.667,1&�6w   $��29��6�   6�   5,      5-      