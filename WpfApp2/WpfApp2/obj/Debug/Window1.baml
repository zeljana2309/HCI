   M S B A M L   `   `   `  ����B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp2WpfApp2  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   7 clr-namespace:WpfApp2.ValidacijaWpfApp2.Validacija  5   	       WpfApp2.Window1   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp2     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	   0val clr-namespace:WpfApp2.Validacija     5   	   X TXceed.Wpf.Toolkit, Version=3.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5	   	     � WindowStartupLocation$  CenterScreen=�5
   	    � Title$ Kreiranje manifestacije��5   	   $	��470��6*   $	��800��67   ��5      �� 5   
   .��5      A� ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6    � Offset$ 0Q�6-   � 5      $ White��6   $ 1Q�6-   5      .+�5   
   ��  �� Orientation$ Vertical=�6   .+�5      A� $	��469��6   .+�5      � $��
0,0,-26,10q�6   ���	#FFC5D6A6.+�5      � $
��Left=�6   $��36��66   $��	81,84,0,0q�6B   $	��Top=�6U   $	��242��6m    � RowDefinitions 5      �� 5      $	��42* �6,   �� 5      $	��25* �6,   5       � 5!      $
��Left=�6   $	��424��66   $	��Top=�6C   $	��772��6[   ���	#FFC5D6A6$��5,0,0,0q�6~    J� RenderTransformOrigin$ 0.5,0.5&�6�   z�5"      V� 5#      .~�5$   "   �� �� 5%   "   �� 5&   "   	 �� Angle$
	 0.03Q�62   T� 5'   "   5(      .+�5*      �� $��Ime *��6    $
��Left=�60   $��	10,53,0,0q�6K   $	��Top=�6^   $��31��6v   $	��119��6�   � 5+      .+�5,      �� -   5        
 ��Name$
 manifestacijaIme��5,     $��1��6k   -  'System.Windows.Input.KeyboardNavigation   TabIndex$ 1��6|   $
��Left=�6�   $��23��6�   $��
157,53,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��176��6  $��Sitka Small)�6)  .��6�  .��5-   "   ��  �� Path$ ValidString1�6*    �� UpdateSourceTrigger$ PropertyChanged=�6>    �� ValidationRules 5.   &   )  #WpfApp2.Validacija.ValidationString  5/   *   ,  &System.Windows.Controls.ValidationRule   ValidationStep$ RawProposedValue=�6?   51   #   52      � 53      -   5         �Name$ popupIme��53   $   $	��450��66   $��70��6B   $��Right=�6�    � AllowsTransparency .  � PlacementTarget 6N   ��  �� ElementName$ manifestacijaIme�� � 	StaysOpen 54   	   �� $ IsKeyboardFocused�.��55   "   � 
�������$	��450��6>   $	��200��6J   $��0,0,10,0q�6W   .+�56   &   �� $
��Wrap=�60   
���   �$����Unesite ime manifestacije čije održavanje bilježite. Na primjer: 'Festival Osmjeha'. Ime može da sadrži sve što Vi smatrate da pripada imenu manifestacije. Ovo je obavezna komponenta.��57      $��	0,0,47,61q�6�   58   #   59      5:      �� 5;      $��Tip manifestacije *��6    $
��Left=�6>   $��	10,89,0,0q�6Y   $	��Top=�6l   $	��119��6�   �� 5<      -   5         ��Name$ ComboBoxTipovi��5<   #    �� DisplayMemberPath$	 Ime��6;   $
��Left=�6S   $��
157,89,0,0q�6n   $	��Top=�6�   $	��176��6�   6�   	� 5=      -   5         d� 	IsChecked$
 TrueY�5=   &   $��
Dozvoljeno��67    	� 	GroupName$ Pusenje��6L   $
��Left=�6a   $��157,218,0,0q�6|   $	��Top=�6�   $��15��6�   $��85��6�   6�   	� 5>      -   5         	�Name$ rbZabranjeno��5>   &   $��
Zabranjeno��6<   $ Pusenje��6Q   $
��Left=�6e   $��247,218,0,0q�6�   $	��Top=�6�   $	��102��6�   $ 	0.782,1.2&�6�   $��15��6�   �� 5?      $��Datum održavanja *��6    $
��Left=�6=   $��
10,120,0,0q�6X   $	��Top=�6l   (  "System.Windows.Controls.DatePicker  5@      -   5          Name$ datumm��5@   %   
 �� Now   SelectedDate# Z 66   $
��Left=�6a   $��157,120,0,0q�6|   $	��Top=�6�   $ 0.373,-2.417&�6�   �� 5A      $��	Pušenje ��6    $
��Left=�63   $��
10,213,0,0q�6N   $	��Top=�6b   $ 0.118,-3.462&�6z   �� 5B      $��Održava se : ��6    $
��Left=�68   $��
10,182,0,0q�6S   $	��Top=�6g   $ 	0.5,1.192&�6   	� 5C      -   5        $
 TrueY�5C   &   $��Napolju��67   $ 	Odrzavase��6I   $
��Left=�6`   $��157,185,0,0q�6{   $	��Top=�6�   $ 	0.475,1.4&�6�   6�   	� 5D      -   5        $ rbUnutra��5D   &   $��Unutra��68   $ 	Odrzavase��6I   $
��Left=�6`   $��242,185,0,0q�6{   $	��Top=�6�   $ 0.655,0.667&�6�   �� 5E      $��Alkohol��6    $
��Left=�62   $��
10,270,0,0q�6M   $	��Top=�6a   $ 	0.5,3.077&�6y   �� 5F      -	   5        $ alkoh��5F   #   $
��Left=�62   $��157,274,0,0q�6l   $	��Top=�6�   $	��208��6�   $ 0.889,0.545&�6�   6�   �� 5G      $��Kategorija cijena ��6    $
��Left=�6=   $��
10,244,0,0q�6X   $	��Top=�6l   �� 5H      -
   5        $ 	katCijena��5H   #   $
��Left=�66   $��157,248,0,0q�6i   $	��Top=�6~   $	��208��6�   6�   	� 5I      -   5        $
 TrueY�5I   &   $��Ne��67   $ d��6D   $
��Left=�6S   $��184,157,0,0q�6n   $	��Top=�6�   $ 
0.15,0.432&�6�   	� 5J      -   5        $ dostupanzaH��5J   &   $��Da��6;   $ d��6H   $
��Left=�6W   $��242,157,0,0q�6r   $	��Top=�6�   $ 0.882,-6&�6�   �� 5K      $!��Dostupno za hendikepirane *��6    $
��Left=�6F   $��
10,151,0,0q�6a   $	��Top=�6u   � 5L      $
��Left=�6   $	��208��6:   $��
397,25,0,0q�6G   $	��Top=�6[   $	��270��6s   .+�5M      � .+�5N   "   �� -   5        $
 opisMan��5N   *   $
��Left=�6y   $	��159��6�   $��	33,39,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��212��6�   .��6&  5O   #   � 5P   "   -   5        $ 	popupOpis��5P   (   $	��450��6;   $	��100��6G   $��Right=�6�    .  6T   �� $ opisMan�� 5Q   	   �� $ IsKeyboardFocused�.��5R   &   � 
�������$	��250��6B   $	��170��6N   $��0,0,10,0q�6[   .+�5S   *   �� $
��Wrap=�64   
���   �$����Ukoliko želite,možete unijeti opis manifestacije.Ovo je opciono. U opis stavite sve što smatrate da je važno za ovu manifestaciju i opisuje je,a nije već navedeno.��5T      $��	0,0,47,61q�6�   5U   '   5V   #   5W      �� 5X      $��Opis manifestacije��6$   $
��Left=�6A   $��23,0,0,0q�6\   $	��Top=�6n   $ -0.579,-2.192&�6�   $	��159��6�   5Y      �� 5Z      -   5        $��Potvrdi��5Z   !   $
��Left=�63   $��532,380,0,0q�6N   $	��Top=�6c   $	��113��6{   $��34��6�   $ 0.708,-0.441&�6�    � ToolTip 5[      _� 5\   "   .��5]   &   �� .+�5^   *   �� $
��Bold"�64   Dodavanje manifestacije6_   �� 5_   *   ECKlikom na ovo dugme dodacete manifestaciju sa unijetim parametrima.6y   5`   '   5a   #   5c      �� 5d      -   5        $��Odustani��5d   !   $
��Left=�64   $��650,380,0,0q�6O   $	��Top=�6d   $	��112��6|   $��34��6�   6�   �� 5e      $
��ID *��6    $
��Left=�6/   $��	10,25,0,0q�6J   $	��Top=�6]   � 5f      $��0,0,439,371q�6   .+�5g      �� -   5        $
 manifestacijaID��5g   4  $
��Left=�6j   $��23��6�   $��1��6�   $ 0��6�   $��
157,28,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��176��6  .��6t  .��5h   "   �� $ ValidString2�6*   $ PropertyChanged=�6>    5i   &     5j   *   $ RawProposedValue=�6?   5l   #   5n      � 5p      -   5        $ popup��5p   $   $	��450��63   $��50��6?   $��Right=�6�    .  6K   �� $ manifestacijaID�� 5q   	   �� $ IsKeyboardFocused�.��5r   "   � 
�������$	��450��6>   $	��120��6J   $��0,0,10,0q�6W   .+�5s   &   �� $
��Wrap=�60   
���   �$����Jedinstven ID za vašu manifestaciju. Možete unijeti bilo koji niz karaktera koji nije već korišten za neku manifestaciju i koji počinje znakom '_' ili slovom.��5t      $��	0,0,47,61q�6�   5u   #   5v      5w      �� 5x      $�� ��6    $
��Left=�6+   $��
103,25,0,0q�6F   $	��Top=�6Z   �� 5y      $��	Ikonica *��6    $
��Left=�64   $��
10,328,0,0q�6O   $	��Top=�6c   $ 0.106,-0.593&�6{   �� 5z      $
��Left=�6!   $��80��6<   $��159,303,0,0q�6H   $	��Top=�6]   $	��100��6u   ���	#FFF1E7E7.+�5{      �� -   5         ��Name$ image��5{   $   $
��Left=�63   $��80��6N   $	��Top=�6Z   $	��100��6r   5|      � 5}      .+�5~      �� -   5        $��
Potraži..��5~   %   $
��Left=�69   $��290,328,0,0q�6T   $	��Top=�6i   $��94��6�    5   "   _� 5�   &   .��5�   *   �� .+�5�   .   �� $
��Bold"�68   Uvoz ikonice6X   �� 5�   .   B@Klikom na ovo dugme birate da uvezete ikonicu sa vaseg racunara.6z   5�   +   5�   '   5�      5�      �� 5�      $'��!Polja označena sa * su obavezna.��6    $
��Left=�6K   $��
0,388,0,-1q�6f   $	��Top=�6z   $	��200��6�   ���	#FFCF0606$
��Bold"�6�   �� 5�      $��Etiketa��6    $
��Left=�62   $��433,252,0,0q�6M   $	��Top=�6b   $ 0.126,-0.184&�6z   %  Xceed.Wpf.Toolkit.CheckComboBox  5�      -   5        $��CheckComboBox��5�   .   $ 	IDEtiketa��6h   $
��Left=�6�   $��32��6�   $��497,248,0,0q�6�   $	��Top=�6�   $	��148��6�   ��6C   �� *listaEtikete+6�   5�      5�      5�      5�      5�      5�      