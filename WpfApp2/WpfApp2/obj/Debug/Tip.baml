   M S B A M L   `   `   `  ����B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp2WpfApp2  5   	   7 clr-namespace:WpfApp2.ValidacijaWpfApp2.Validacija  5   	       WpfApp2.Tip   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp2     5   	   0val clr-namespace:WpfApp2.Validacija     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Kreiranje tipa��5
   	   $	��630��6    $	��930��6-   .��5      � $��
0,0,-8,-21q�6   ��5   
   �� 5       �� ImageSource$@ :pack://siteoforigin:,,,/Resources/nevesinje-ribolov013.jpg��6    � ColumnDefinitions 5   
   �� 5      $	��29* �6   �� 5      $	��14* �6   �� 5      $
��117* �6   .+�5   
   (� $��2��6   $
��Left=�6"   $	��280��6=   $��0,20,0,0q�6J   $	��Top=�6\   $	��450��6t    (� Stretch$
 Fill=�6�   .��5      (� $	��338��6   $
 Fill=�6#   $	��517��62   .��5      (� $	��283��6   $
 Fill=�6'   $	��458��66   .��5      � $	��303��6   $	��473��6(   .+�5      (� $��-90,81,-99,-206q�6"   $
 Fill=�6;   5      5      5      5       �� 5!   
   $ ��Jezero Alagovac ,Nevesinje��6   $��2��65   $
��Left=�6E   $��482,548,0,0q�6`   $	��Top=�6u   $��32��6�   $	��166��6�   � 5"   
   $��1��6   $��0,94,144,133q�6   $��2��65    5#      �� 5$      $	��11* �6#   �� 5%      $	��19* �6#   �� 5&      $
��563* �6#   .+�5(      � ���	#FFABB9C1$��-66,58,120,-53q�6*   $��3��6B    5)      �� 5*      $
��107* �6'   �� 5+      $
��433* �6'   .+�5-      �� $
��ID *��6   $
��Left=�6'   $��	43,25,0,0q�6B   $	��Top=�6U   �� 5.      $��Ime *��6   $
��Left=�6(   $��	43,56,0,0q�6C   $	��Top=�6V   �� 5/      $��	Ikonica *��6   $
��Left=�6,   $��	43,95,0,0q�6G   $	��Top=�6Z    J� RenderTransformOrigin$ 0.354,0.038&�6r   �� 50      $
��Opis��6   $
��Left=�6'   $��
43,228,0,0q�6B   $	��Top=�6V   �� 51      -   5        $��tipID��51      -  'System.Windows.Input.KeyboardNavigation   TabIndex$ 0��6�   $
��Left=�6�   $��23��6�   $��	18,29,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6  $	��222��6  $��1��6K  .��6[  ��52      �� 53       �� Path$ ValidString4�6"   	 �� UpdateSourceTrigger$	 PropertyChanged=�66   
 �� ValidationRules
 54      )  #WpfApp2.Validacija.ValidationString  55   "   ,  &System.Windows.Controls.ValidationRule   ValidationStep$ RawProposedValue=�67   57      .��58   $   59      � 5:      -   5         �Name$ popupID��5:      $	��450��6)   $��60��65   $��Right=�6o    � AllowsTransparency .  � PlacementTarget 6A   ��  �� ElementName$ tipID�� � 	StaysOpen 5;   	   �� $ IsKeyboardFocused�.��5<      � 
�������$	��250��62   $	��120��6>   $��0,0,0,0q�6K   .+�5=      �� $
��Wrap=�6$   
���   �$����Unijeti ID tipa.ID mora biti jedinstven,nemojte unositi ID koji ste već dodijelili nekom tipu. ID može da sadrži biilo koji skup karaktera.��5>      $��0,0,0,61q�6�   5?      5@      �� 5A      -   5        $��tipIme��5A      $ 1��6�   $
��Left=�6�   $��23��6�   $��	18,60,0,0q�6�   $
 Wrap=�6�   $	��Top=�6	  $	��222��6!  $��1��6-  .��6=  ��5B      �� 5C      $ ValidString5�6"   $	 PropertyChanged=�66   
 5D        5E   "   $ RawProposedValue=�67   5G      .��5H   $   5I      � 5J      -   5        $ popupIme��5J      $	��450��6*   $��90��66   $��Right=�6q    .  6B   �� $ tipIme�� 5K   	   �� $ IsKeyboardFocused�.��5L      � 
�������$	��280��62   $	��140��6>   $��0,0,10,0q�6K   .+�5M      �� $
��Wrap=�6$   
���   �$����Unesite ime koje želite dodijeliti tipu,radi lakšeg raspoznavanja. Ime može sadržati bilo koje karaktere,ali se preporučuje da bude sastavljen od slova i brojeva koji će Vam jasno govoriti o kom tipu se radi.��5N      $��0,0,0,61q�6�   5O      5P      �� 5Q      -   5        $��Potvrdi��5Q      $
��Left=�6+   $��256,322,0,0q�6F   $	��Top=�6[   $��75��6s   $ 
1.02,1.527&�6~   $��1��6�   5R      �� 5S      -   5        $��Odustani��5S      $
��Left=�6,   $��336,322,0,0q�6G   $	��Top=�6\   $��75��6t   $ 0.987,1.736&�6   $��1��6�   �� 5T      -   5        $��tipOpis��5T      $
��Left=�6�   $	��113��6�   $��
18,188,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��222��6  $��1��6  � 5U      -   5        $ 	popupOpis��5U      $	��450��6+   $��60��67   $��Right=�6s    .  6C   �� $ tipOpis�� 5V   	   �� $ IsKeyboardFocused�.��5W      � 
�������$	��280��62   $	��110��6>   $��0,0,10,0q�6K   .+�5X      �� $
��Wrap=�6$   
���   �$���� Unesite opis ovog tipa manifestacije. Ovo je opciono polje i ovdje možete, ako želite, unijeti neke dodatne podatke o ovom tipu manifestacije.��5Y      $��0,0,0,61q�6�   5Z      5[      �� 5\      $
��Left=�6   $��81��64   $��	18,88,0,0q�6@   $	��Top=�6S   $	��103��6k   
�������$��1��6�   .+�5]      �� -	   5         ��Name$ image��5]      $
��Left=�6+   $��80��6F   $	��Top=�6R   $	��103��6j   5^      �� 5_      -
   5        $��
Potraži..��5_      $
��Left=�6-   $��144,119,0,0q�6H   $	��Top=�6]   $��75��6u   $��Arial Unicode MS)�6�   $��1��6�    � ToolTip 5`      _� 5a      .��5b      �� .+�5c   "   �� $
��Bold"�6,   Uvoz ikonice6L   �� 5d   "   B@Klikom na ovo dugme birate da uvezete ikonicu sa vaseg racunara.6n   5e      5f      5h      �� 5i      $'��!Polja označena sa * su obavezna.��6   $
��Left=�6C   $��
13,322,0,0q�6^   $	��Top=�6r   $��2��6�   $	��200��6�   ���	#FFCF0606$
��Bold"�6�   5j      5l      5n      5o      