   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��293* �6   �� 5      $
��107* �6   .+�5   
   �� $��Podaj a��6   $
��Left=�6"   $��150,127,0,0q�6=   $	��Top=�6R   $��18(�6j   �� 5   
   $��Podaj b��6   $
��Left=�6"   $��	150,0,0,0q�6=   $��Center=�6P   $��18(�6k   �� 5   
   -   5         ��Name$ iloraz��5      $��Iloraz��6!   $
��Left=�62   $��
29,312,0,0q�6M   $	��Top=�6a   $	��106��6y   $��1��6�   6�   �� 5   
   -   5         ��Name$ textBox1��5      $
��Left=�6$   $��293,131,0,0q�6?    �� TextWrapping$
 Wrap=�6T   $	��Top=�6h   $	��151��6�   $��30��6�   �� 5   
   -   5        $ textBox2��5      $
��Left=�6$   $��293,204,0,0q�6?   $
 Wrap=�6T   $	��Top=�6h   $	��151��6�   $��30��6�   �� 5   
   -   5         ��Name$ result��5      $��wynik��6    $
��Left=�60   $��
54,381,0,0q�6K   $	��Top=�6_   $��35��6w   $	��358��6�   $��16(�6�   �� 5   
   -   5        $
 suma��5      $
��Suma��6   $
��Left=�6.   $��
96,312,0,0q�6I   $	��Top=�6]   $��94��6u   6�   �� 5   
   -   5        $ roznica��5      $��Roznica��6"   $
��Left=�64   $��277,312,0,0q�6O   $	��Top=�6d   $	��107��6|   6�   �� 5   
   -   5        $ iloczyn��5      $��Iloczyn��6"   $
��Left=�64   $��450,312,0,0q�6O   $	��Top=�6d   $	��100��6|    J� RenderTransformOrigin$ 0.498,0.576&�6�   5      5      