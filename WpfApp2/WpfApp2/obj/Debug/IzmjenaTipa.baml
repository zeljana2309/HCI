   M S B A M L   `   `   `  ����B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp2WpfApp2  5   	   7 clr-namespace:WpfApp2.ValidacijaWpfApp2.Validacija  5   	       WpfApp2.IzmjenaTipa   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp2     5   	   7
Validacija clr-namespace:WpfApp2.Validacija     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Izmjena tipa��5
   	   $	��630��6   $	��930��6+   .��5      � $��
0,0,-8,-21q�6   ��5   
   �� 5       �� ImageSource$@ :pack://siteoforigin:,,,/Resources/nevesinje-ribolov013.jpg��6    � ColumnDefinitions 5   
   �� 5      $	��29* �6   �� 5      $	��14* �6   �� 5      $
��117* �6   .+�5   
   (� $��2��6   $
��Left=�6"   $	��280��6=   $��0,20,0,0q�6J   $	��Top=�6\   $	��450��6t    (� Stretch$
 Fill=�6�   .��5      (� $	��338��6   $
 Fill=�6#   $	��517��62   .��5      (� $	��283��6   $
 Fill=�6'   $	��458��66   .��5      � $	��303��6   $	��473��6(   .+�5      (� $��-90,81,-99,-206q�6"   $
 Fill=�6;   .��5      � $	��363��6#   $	��593��60   .+�5   "   (� $��-124,46,137,-35q�6*   $
 Fill=�6C   .��5   &   � $	��352��6+   $	��574��68   .+�5   *   � .+�5   .   � $��	0,0,-14,0q�63   .+�5   2   � ���	#FFABB9C1$��42,10,-48,-20q�6N   .+�5   6   �� $
��Left=�6<   $��	43,10,0,0q�6W   $	��Top=�6j   .��5    :   �� $
��ID *��6@   $
��Left=�6O   $	��Top=�6j    J� RenderTransformOrigin$ 0.955,0.628&�6�   5!   7   �� 5"   6   $��	Ikonica *��6<   $
��Left=�6P   $��
43,138,0,0q�6k   $	��Top=�6   $ 0.354,0.038&�6�   �� 5#   6   $
��Opis��6<   $
��Left=�6K   $��
43,247,0,0q�6f   $	��Top=�6z   $ 0.309,1.673&�6�   �� 5$   6   -   5        $��Potvrdi��5$   =   $
��Left=�6O   $��416,332,0,0q�6j   $	��Top=�6   $��75��6�   $ 
1.02,1.527&�6�   6�   �� 5%   6   -   5        $��Odustani��5%   =   $
��Left=�6P   $��509,332,0,0q�6k   $	��Top=�6�   $��75��6�   $ 0.987,1.736&�6�   6�   �� 5&   6   -   5         ��Name$ tbOpis��5&   >   $
��Left=�6N   $	��113��6i   $��125,213,0,0q�6v    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��222��6�   $ 0.499,0.705&�6�   � 5'   6   -   5         �Name$ 	popupOpis��5'   <   $	��450��6O   $��60��6[   $��Right=�6�   	 � AllowsTransparency	 . 
 � PlacementTarget
 6g   ��  �� ElementName$ tbOpis�� � 	StaysOpen 5(   	   ��  �� Path$ IsKeyboardFocused�.��5)   :   � 
�������$	��280��6V   $	��110��6b   $��0,0,10,0q�6o   .+�5*   >   �� $
��Wrap=�6H   
���   �$���� Unesite opis ovog tipa manifestacije. Ovo je opciono polje i ovdje možete, ako želite, unijeti neke dodatne podatke o ovom tipu manifestacije.��5+      $��0,0,0,61q�6�   5,   ;   5-   7   �� 5.   6   $
��Left=�6=   $��80��6X   $��125,112,0,0q�6d   $	��Top=�6y   $	��100��6�   
�������$ 
0.44,0.012&�6�   .+�5/   :   �� -   5         ��Name$ image��5/   @   $
��Left=�6O   $��80��6j   $	��Top=�6v   $	��100��6�   $ 0.541,1.253&�6�   50   7   �� 51   6   -   5        $��
Potraži..��51   =   $
��Left=�6Q   $��249,136,0,0q�6l   $	��Top=�6�   $��75��6�   $ 0.422,3.432&�6�    � ToolTip 52   6   _� 53   :   .��54   >   �� .+�55   B   �� $
��Bold"�6L   Uvoz ikonice6l   �� 56   B   B@Klikom na ovo dugme birate da uvezete ikonicu sa vaseg racunara.6�   57   ?   58   ;   5:   7   �� 5;   6   $'��!Polja označena sa * su obavezna.��6<   $
��Left=�6g   $��
10,326,0,0q�6�   $	��Top=�6�   $	��200��6�   ���	#FFCF0606$
��Bold"�6�   $ 0.473,1.162&�6�   �� 5<   6   $��Ime *��6<   $
��Left=�6L   $��	43,56,0,0q�6g   $	��Top=�6z   �� 5=   6   -   5        $ tipIme��5=   >   -  'System.Windows.Input.KeyboardNavigation   TabIndex$ 1��6�   $
��Left=�6�   $��23��6�   $��
125,59,0,0q�6	  $
 Wrap=�6  $	��Top=�61  $	��222��6I  .��6U  5?   7   � 5@   6   -   5        $ popupIme��5@   <   $	��450��6N   $��90��6Z   $��Right=�6�   	 . 
 6f   �� $ tipIme�� 5A   	   �� $ IsKeyboardFocused�.��5B   :   � 
�������$	��280��6V   $	��140��6b   $��0,0,10,0q�6o   .+�5C   >   �� $
��Wrap=�6H   
���   �$����Unesite ime koje želite dodijeliti tipu,radi lakšeg raspoznavanja. Ime može sadržati bilo koje karaktere,ali se preporučuje da bude sastavljen od slova i brojeva koji će Vam jasno govoriti o kom tipu se radi.��5D      $��0,0,0,61q�6�   5E   ;   5F   7   �� 5G   6   -	   5        $
 tbID��5G   >   {�.   �� 
IsReadOnly . $ 0��6�   $
��Left=�6�   $��23��6  $��
125,23,0,0q�6$  $
 Wrap=�68  $	��Top=�6L  $	��222��6d  .��6�  5I   7   � 5K   6   -
   5        $ popupID��5K   <   $	��170��6M   $��20��6Y   $��Right=�6�   	 . 
 6e   �� $
 tbID�� 5L   	   �� $ IsKeyboardFocused�.��5M   :   � 
�������$��0,0,-11,-56q�6V   .+�5N   >   �� $
��Wrap=�6H   
���   �$%��ID tipa ne može biti mijenjan.��5O      $��0,0,0,61q�68   5P   ;   5Q   7   5R   3   5T   /   5V   +   5X   '   5Z   #   5\      5^      5`      5b      5d      5f      �� 5g   
   $ ��Jezero Alagovac ,Nevesinje��6   $��2��65   $
��Left=�6E   $��473,548,0,0q�6`   $	��Top=�6u   $��32��6�   $	��166��6�   5i      5j      