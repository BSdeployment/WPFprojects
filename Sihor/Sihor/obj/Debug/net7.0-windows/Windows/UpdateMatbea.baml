   M S B A M L   `   `   `  ����@  <Sihor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Sihor.WindowsSihor.Windows  5   	        Sihor.Windows.UpdateMatbea   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Sihor.Windows     5   	   _ [MaterialDesignThemes.Wpf, Version=4.6.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        � AllowsTransparency$
  True��5	   	    � Title$ UpdateMatbea��5
   	   $	��380��6   $	��320��6+    � 
ResizeMode$ NoResize=�67    � WindowStartupLocation$ CenterScreen=�6M    � WindowStyle$
 None=�6r   ��6�   Z� .��5      �� 
������� �� CornerRadius$ 	0 0 20 20��6    ._�5   
   � .+�5      �� -   5         ��Name$ movewin��5      $��Center=�5      $��25��6*   $	��Top=�66   $	��320��6N   ��5      �� 5       �� EndPoint$ 0.5,1&�6*    �� 
StartPoint$ 0.5,0&�6;   .��5      � 	 � Color$	 	#FF97C4F5��6'   � 5      $	 	#FF027AFF��6'   
 � Offset$
 1Q�69   5      5      �� 5      $
��Left=�6   $��0,-4,0,0q�62   $	��Top=�6D   $��0,0,0,0q�6s   ��6]   Z� ��6�   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon  -   5           Kind$ Close=�5   *   $��25��5   "   $��25��6.   
�������69   5        5       $ Update=�5!      $��Center=�5"      $��70��6*   $	��100��66    J� RenderTransformOrigin$ 0.5,-1&�6B   $��0,42,0,0q�6a   ���	#FF9693EF6s   �� 5#      $
��Left=�6   $��35��63   $��100,112,0,0q�6?   $
��Wrap=�6T   $	��Top=�6h   $	��140��6�   $��24(�6�   �� 6�    �� FlowDirection$ RightToLeft=�6�    � Language$ he-il�6�   $�עדכון נתונים��6�   6�   �� 5$      $
��Left=�6    �� Orientation$ 
Horizontal=�65   $	��Top=�6N   $��
56,174,0,0q�6f   .+�5%      �� -   5         ��Name$ txtdolar��5&      $��25��5'       �� TextWrapping$
 Wrap=�6   $	��115��61   ���	#89086DF5$��RightToLeft=�5(      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ הזן ערך חדש��5)      $
��10 0q�5+      ��5*      �� *dolar+5+      �� 5.      $��15��6   $
��Wrap=�6(   $��60��6<   �� 6H   $ RightToLeft=�6L   $ he-il�6h   $�שער הדולר��6y   6�   50      �� 51      $
��Left=�6   $ 
Horizontal=�65   $	��Top=�6N   $��
54,214,0,0q�6f   .+�52      �� -   5        $ 	txtsilver��59      $��25��54      $
 Wrap=�6!   $	��115��65   ���	#89086DF5$��RightToLeft=�55      $ הזן ערך חדש��56      $
��10 0q�58      ��57      �� *silver+59      �� 5<      $��15��6   $
��Wrap=�6(   $��73��6<   �� 6H   $ RightToLeft=�6L   $ he-il�6h   $�אונקיית כסף��6y   6�   5>      �� 5?      $
��Left=�6   $ 
Horizontal=�65   $	��Top=�6N   $��
54,254,0,0q�6f   .+�5@      �� -   5        $ txtgold��5F      $��25��5B      $
 Wrap=�6   $	��115��61   ���	#89086DF5$��RightToLeft=�5C      $ הזן ערך חדש��5D      $
��10 0q�5E      ��5A      �� *gold+5F      �� 5H      $��15��6   $
��Wrap=�6(   $��68��6<   �� 6H   $ RightToLeft=�6L   $ he-il�6h   $�אונקיית זהב��6y   6�   5J      �� 5K      -   5         ��Name$ 	btnupdate��5L      $��עדכן��5N      $��Center=�6   $��30��69   $��	0,320,0,0q�6E   $	��Top=�6X   $	��140��6p   �� 5O      -   5         ��Name$ 
txtreqourd��5Q      $y�Hidden=�5P      $��Center=�5Q   %   $��21��6B   $��	0,291,0,0q�6N   $
��Wrap=�6a   $	��Top=�6u   $	��174��6�   
���  ���� 6�   $ RightToLeft=�6�   $ he-il�6�   $5�/כל אחת מהשדות הם שדות חובה��6�   6  5S      5T      5U      