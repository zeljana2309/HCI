   M S B A M L   `   `   `  ����B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WpfApp2.ValidacijaWpfApp2.Validacija  5          WpfApp2.Etiketa1   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   X TXceed.Wpf.Toolkit, Version=3.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	   *val clr-namespace:WpfApp2.Validacija  5        � WindowStartupLocation$  CenterScreen=�5	       � Title$ Kreiranje etikete��5
   	   $	��600��6#   $	��600��60   .��5      � ��5   
   �� 5       �� ImageSource$A ;pack://siteoforigin:,,,/Resources/sahat-kula-nevesinje2.jpg��6    j� Stretch$ UniformToFill=�6c   .+�5   
   � $
��Left=�6   $	��310��6*   $��
50,170,0,0q�67   $	��Top=�6K   $	��480��6c   ���	#FFC9D1DA J� RenderTransformOrigin$ 0.5,0.5&�6�   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ 0.258Q�6&   T� 5      5      .+�5      �� $
��ID *��6   $
��Left=�6#   $��	55,24,0,0q�6>   $	��Top=�6Q   $��36��6i   $��68��6u   �� 5      $��Boja *��6   $
��Left=�6%   $��	55,65,0,0q�6@   $	��Top=�6S   �� 5      $��Label��6   $
��Left=�6$   $��0��6?   $��115,210,0,0q�6J   $	��Top=�6_   $��13��6w   �� 5      $
��Opis��6   $
��Left=�6#   $��
55,125,0,0q�6>   $	��Top=�6R   $ -2.206,0.923&�6j   �� 5      -   5        $��Odustani��5      $
��Left=�6(   $��395,282,0,0q�6C   $	��Top=�6X   $��75��6p   $ 
-0.667,0.5&�6{   6�   �� 5      -   5        $��Potvrdi��5      $
��Left=�6'   $��315,282,0,0q�6B   $	��Top=�6W   $��75��6o   $ 0.808,0.497&�6�   � 5      .+�5       �� -   5        $��	EtiketaID��5    �   -  'System.Windows.Input.KeyboardNavigation   TabIndex$ 0��6v   $
��Left=�6�   $��23��6�   $��
115,24,0,0q�6�    �� TextWrapping$
 Wrap=�6  $	��Top=�6  $	��215��6.  .��6:  ��5!      �� 5"       �� Path$ ValidString3�6"   	 �� UpdateSourceTrigger$	 PropertyChanged=�66   
 �� ValidationRules
 5#      )  #WpfApp2.Validacija.ValidationString  5$   "   ,  &System.Windows.Controls.ValidationRule   ValidationStep$ RawProposedValue=�67   5&      .��5'   $   5(      � 5)      -   5         �Name$ popupID��5)      $	��450��6)   $��50��65   $��Right=�6s    � AllowsTransparency .  � PlacementTarget 6A   ��  �� ElementName$ 	EtiketaID�� � 	StaysOpen 5*   	   �� $ IsKeyboardFocused�.��5+      � 
�������$	��450��62   $	��100��6>   $��0,0,10,0q�6K   .+�5,      �� $
��Wrap=�6$   
���   �$w��qJedinstven ID za vašu etiketu. Možete unijeti bilo koji niz karaktera koji nije već korišten za neku etiketu.��5-      $��	0,0,47,61q�6�   5.      5/      50      � 51      .+�52      �� -   5        $��EtiketaOpis��52   �   $
��Left=�6�   $	��101��6�   $��115,125,0,0q�6�   $
 Wrap=�6�   $	��Top=�6   $	��215��6  � 53      -   5        $ 	popupOpis��53      $	��450��6+   $��60��67   $��Right=�6w    .  6C   �� $ EtiketaOpis�� 54   	   �� $ IsKeyboardFocused�.��55      � 
�������$	��280��62   $	��120��6>   $��0,0,10,0q�6K   .+�56      �� $
��Wrap=�6$   
���   �$[��UOvdje možete unijeti dodatni opis etikete,kao i šta ona predstavlja. Opciono polje.��57      $��	0,0,47,61q�6m   58      59      5:      #  Xceed.Wpf.Toolkit.ColorPicker  5;      -   5          Name$ _colorEtiketa��5;         SelectedColor$ BlackX�66   $
��Left=�6L   $��
115,69,0,0q�6g   $	��Top=�6{   $��90��6�   �� 5<      -   5        $��Pomoć��5<      $
��Left=�6%   $��
395,10,0,0q�6@   $	��Top=�6T   $��75��6l   $ 	2.867,0.5&�6�   �� 5=      $'��!Polja označena sa * su obavezna.��6   $
��Left=�6?   $��	0,276,0,0q�6Z   $	��Top=�6m   $	��200��6�   ���	#FFCF0606$
��Bold"�6�   5>      �� 5?   
   $��Sahat kula,Nevesinje
��6   $
��Left=�69   $��
440,10,0,0q�6T   $	��Top=�6h   5A      5B      