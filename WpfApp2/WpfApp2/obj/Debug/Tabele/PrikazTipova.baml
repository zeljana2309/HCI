   M S B A M L   `   `   `  ����B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WpfApp2.TabeleWpfApp2.Tabele  5   	   7 clr-namespace:WpfApp2.ValidacijaWpfApp2.Validacija  5   	   !    WpfApp2.Tabele.PrikazTipova   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:WpfApp2.Tabele     5   	   7
Validacija clr-namespace:WpfApp2.Validacija     5   	     � Title$  PrikazTipova��5	   	   $	��450��6   $	��800��6+   .��5
      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGridTipovi��5   _      
IsReadOnly . $	��159��6&   $
��Left=�63   $��1,1,0,0q�6N      AutoGenerateColumns .  $	��Top=�6�   $	��791��6�   ��6w   ��  �� Path$ Tipovi�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6%      Header$ ID��61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *IDD+  5      $	 100 6%   $	 Ime��61    6>   �� *Ime+  5      $	 100 6%   $
 Opis��61    6?   �� *Opis+4  .System.Windows.Controls.DataGridTemplateColumn  5      $ Ikonica��6)   $ * 6;   	   CellTemplate	 5      �� 5      .R�5      �� $��50��6$   ��64   �� *	Ikonica+
 �� UpdateSourceTrigger$
 PropertyChanged=�5      5      5      � 5   
   $
��Left=�6T   $	��180��6o   $��	0,165,0,0q�6|   $	��Top=�6�   $	��792��6�   ���	#FFC5D6A6 � DataContext 6   ��  �� ElementName$ dataGridTipovi��$ SelectedItem�.+�5      �� $
��ID *��6   $
��Left=�6#   $��	14,11,0,0q�6>   $	��Top=�6Q    J� RenderTransformOrigin$ 0.833,0&�6i   �� 5      $��Ime *��6   $
��Left=�6$   $��	10,39,0,0q�6?   $	��Top=�6R   �� 5      -   5         ��Name$ tipID��5   )    �� 
IsReadOnly . -  'System.Windows.Input.KeyboardNavigation   TabIndex$ 0��6S   $
��Left=�6s   $��23��6�   $��	93,14,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��222��6�   ��68   �� $	 IDD�.��6�   5      �� 5       -   5        $ tipIme��5    (    . $ 1��6S   $
��Left=�6s   $��23��6�   $��	93,42,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��222��6�   ��69   �� $	 Ime�.��6�   .��5%      5&      �� 5'      $��	Ikonica *��6   $
��Left=�6(   $��
439,11,0,0q�6C   $	��Top=�6W   $ 0.354,0.038&�6o   �� 5(      -   5         ��Name$ image��5(      $
��Left=�6p   $��80��6�   $	��Top=�6�   $	��103��6�   $��
527,10,0,0q�6�   ��6#   �� *	Ikonica+ �� Mode$ TwoWay=�$
 PropertyChanged=�6�   �� 5)      $
��Opis��6   $
��Left=�6#   $��
10,86,0,68q�6>   $ 9.735,-0.962&�6R   �� 5*       . $
��Left=�6C   $��94��6^   $��	93,76,0,0q�6j   $
 Wrap=�6}   $	��Top=�6�   $	��135��6�   ��6(   �� $
 Opis�6�   5+      �� 5,   
   -   5        $��Izmjeni ��5,      $
��Left=�6$   $��
10,370,0,0q�6?   $	��Top=�6S   $	��150��6k   $��30��6w   $ 
0.867,-1.5&�6�   6�   �� 5-   
   -   5        $��Izbriši��5-      $
��Left=�6#   $��180,370,0,0q�6>   $	��Top=�6S   $	��145��6k   $��30��6w   $ 
0.28,0.667&�6�   6�   �� 5.   
   -   5        $��Zatvori��5.      $
��Left=�6#   $��657,379,0,0q�6>   $	��Top=�6S   $	��125��6k   $ 1.667,1&�6w   $��29��6�   6�   5/      50      