   M S B A M L   `   `   `  ����B  >WpfApp5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp5WpfApp5  5   	       WpfApp5.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp5     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ btn_add_student��5
      $��Add student��6*   $
��Left=�6@   $��
203,61,0,0q�6[   $	��Top=�6o   $��61��6�   $	��139��6�   6�   �� 5   
   -   5        $ btn_remove_student��5      $��Remove student��6-   $
��Left=�6F   $��
422,61,0,0q�6a   $	��Top=�6u   $��61��6�   $	��148��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ mainDG��5      $��	0,150,0,0q�6#      RowDetailsVisibilityMode$ Visible=�66      AutoGenerateColumns$ False��6Y      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   �� *name+  5      $ Surname��6%    67   �� *	surname+  5      $ Index��6%    65   �� *index+  5      $ 
Department��6%    6:   �� *
department+4  .System.Windows.Controls.DataGridTemplateColumn  5      $ Grade��6)      CellTemplate 5      �� 5      .R�5        $ grade��6'   ��66   �� *grade+5      5      5&      5(      5)      