   M S B A M L   `   `   `  ����D  @Principal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Principal	Principal  5   	       Principal.WinVotantes   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Principal     5   	   -   5          � Title$  WinVotantes��5   	   $��745.79��6   $��843.011��6-   .��5	      � ���	#FFA9BAB9.+�5
   
   �� -   5         ��Name$ 
lblBinomio��5
      $&�� Seleccione el binomio para votar��6$   $
��Left=�6O   $��
136,49,0,0q�6j   $	��Top=�6~   $	��554��6�   $��36(�6�   $
��Bold"�6�   $��Segoe UI Semibold)�6�   �� 5   
   -   5         ��Name$ 
btnVotar35��5      $�� ��6%   $
��Left=�60   $��
20,179,0,0q�6K   $	��Top=�6_   $	��130��6w   $	��104��6�    � ToolTip$  ��6�   ��6�   Z�  J� OpacityMask 5      �� 5       �� Color# � ��6"   ��5      �� 5      $ Black��6"   ��5      �� 5       �� ImageSource$ Resources/alianzaPais.jpg��6    j� Stretch$ Uniform=�6E   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dtgBinomio35��5      $
��Left=�6P   $��165,187,0,0q�6k   $	��Top=�6�   $��89��6�   $	��205��6�   {�.  ��6)   �� 	 �� Path$	 	Candidato�6�     5   
   -   5        $ dtgBinomio23��5      $
��Left=�6R   $��580,183,0,0q�6m   $	��Top=�6�   $��93��6�   $	��220��6�   {�.  ��6)   �� $	 Candidato23�6�     5   
   -   5        $ dtgBinomio10��5      $
��Left=�6R   $��167,375,0,0q�6m   $	��Top=�6�   $��87��6�   $	��203��6�   {�.  ��6)   �� $	 Candidato10�6�     5   
   -   5        $ dtgBinomio6��5      $
��Left=�6P   $��580,375,0,0q�6k   $	��Top=�6�   $��87��6�   $	��220��6�   {�.  ��6(   �� $	 
Candidato6� 5      �� 5      
 �� EndPoint$
 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ Black��6#    � Offset$ 0Q�61   � 5      $ 	#FFDD7F7F��6#   $ 1Q�65   5      5       �� 5!   
   -   5        $ 
btnVotar23��5!      $�� ��6%   $
��Left=�60   $��417,174,0,0q�6K   $	��Top=�6`   $	��136��6x    �	#FF851414$	��111��6�   ��6�   Z� ��5"      �� 5#      $ Resources/creoSuma.jpg��6   $ Uniform=�6B   5%      �� 5&   
   -	   5        $ 	btnVotar6��5&      $�� ��6$   $
��Left=�6/   $��395,359,0,0q�6J   $	��Top=�6_   $	��170��6w   $	��122��6�   ��6�   Z� ��5'      �� 5(      $# Resources/socialCristiano.png��6   $ Uniform=�6I   5*      �� 5+   
   -
   5        $ 
btnVotar10��5+      $�� ��6%   $
��Left=�60   $��
33,367,0,0q�6K   $	��Top=�6_   $	��113��6w    �	#FF882424$	��101��6�   ��6�   Z� ��5,      �� 5-      $ Resources/FUERZA.jpg��6   $ Uniform=�6@   5/      �� 50   
   -   5        $ btnVotarNulo��50      $�� ��6'   $
��Left=�62   $��204,557,0,0q�6M   $	��Top=�6b   $	��115��6z   $	��110��6�   ��6�   Z� ��51      �� 52      $ Resources/nulo.jpg��6   $ Uniform=�6>   54      �� 55   
   -   5        $ btnVotarBanco��55      $�� ��6(   $
��Left=�63   $��498,553,0,0q�6N   $	��Top=�6c   $	��101��6{   $	��116��6�   ��6�   Z� ��56      �� 57      $  Resources/votoEnBlanco.jpg��6   $ Uniform=�6F   59      r� 5:   
   -   5         r�Name$ mediaElement��5:      $
��Left=�6-   $	��100��6H   $��	10,10,0,0q�6U   $	��Top=�6h   $	��100��6�    r� Source$7 1Resources/Patti Smith - People Have The Power.wav?�6�   5;      5<      