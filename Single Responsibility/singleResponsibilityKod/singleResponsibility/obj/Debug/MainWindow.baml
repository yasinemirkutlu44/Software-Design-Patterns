   M S B A M L   `   `   `  ����O  KsingleResponsibility, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:singleResponsibilitysingleResponsibility  5   	   %    singleResponsibility.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:singleResponsibility     5   	     � Title$  Kargo Kayıt Sistemi��5   	   $	��300��6%   $	��300��62   .��5	      � -   5         �Name$
 Grid��5	      ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FF003972��6    � Offset$ 0Q�61   � 5      $ 	#FFB2D9FF��6   $ 1Q�61   5      .+�5   
   �� -   5         ��Name$ lblCargoNumber��5      $��Cargo Number��6(   $��	20,40,0,0q�6?   $
��Left=�6R   $	��Top=�6m   �� 5   
   -   5        $ lblReceiverName��5      $��Receiver Name ��6)   $��	20,70,0,0q�6B   $
��Left=�6U   $	��Top=�6p   �� 5   
   -   5        $ lblReceiverSurname��5      $��Receiver Surname ��6,   $��
20,100,0,0q�6H   $
��Left=�6\   $	��Top=�6w   �� 5   
   -   5        $ lblDestination��5      $��Destination ��6(   $��
20,130,0,0q�6?   $
��Left=�6S   $	��Top=�6n   �� 5   
   -   5         ��Name$ txtCargoNumber��5      $
��Left=�6*   $��26��6E   $��
125,40,0,0q�6Q   $	��Top=�6e   $	��124��6}    �� MaxLines$ 1��6�   	 �� 	MaxLength$	 24��6�   $��Center=�6�   $��1��6�   �� 5   
   -   5        $ txtReceiverName��5      $
��Left=�6+   $��26��6F   $��
125,70,0,0q�6R   $	��Top=�6f   $	��124��6~   $ 1��6�   $	 24��6�   $��Center=�6�   $��2��6�   �� 5   
   -   5        $ txtReceiverSurname��5      $
��Left=�6.   $��26��6I   $��125,100,0,0q�6U   $	��Top=�6j   $	��124��6�   $ 1��6�   $	 24��6�   $��Center=�6�   $��3��6�   �� 5   
   -	   5        $ txtDestination��5      $
��Left=�6*   $��26��6E   $��125,130,0,0q�6Q   $	��Top=�6f   $	��124��6~   $ 1��6�   $	 24��6�   $��Center=�6�   $��4��6�   �� 5   
   -
   5        
 ��Name$
 AddButon��5      $��
Kargo ekle��6#   $
��Left=�68   $��24��6S   $��
50,200,0,0q�6_   $	��Top=�6s   $��70��6�   6�   �� 5   
   -   5        $
 DeleteButon��5      $��	Kargo sil��6&   $
��Left=�6:   $��24��6U   $��180,200,0,0q�6a   $	��Top=�6v   $��70��6�   6�   5      5      