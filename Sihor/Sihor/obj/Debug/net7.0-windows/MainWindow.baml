   M S B A M L   `   `   `  ����@  <Sihor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:SihorSihor  5   	       Sihor.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.6.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      localclr-namespace:Sihor  5   	     � Title$  
MainWindow��5	   	   $	��495��6   $	��740��6)    � WindowStyle$
 None=�65    � 
ResizeMode$ NoResize=�6H    � WindowStartupLocation$ CenterScreen=�6^    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ StyleMain - Copy.xaml?�6%   %    5      .��5      � .+�5   
   �� -   5         ��Name$ dockmain��5      $��Center=�5      $��35��6*   $	��Top=�66   $	��740��6N   $��0,-2,0,0q�6Z   ��5      �� 5       �� EndPoint$	 1,1&�6&   	 �� 
StartPoint$		 0,0&�65   .��5      � 
 � Color$
 	#FFA5C0F5��6#   � 5      $
 	#FF9EB6F1��6#    � Offset$ 1Q�65   5       5#      �� 5$   
   -   5         ��Name$ btnclose��5$      $
��Left=�6;   $��35��6V   $	��Top=�6d   $��40��6|   
������ $��0,0,0,0q�6�   $��0,-2,0,0q�6�   ��6�   Z� .��5%      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�6&   $��Center=�63   $��32��6P   
���   �$��Center=�6o   $��46��6�   5&      �� 5'   
   -   5        $ 	btnresize��5'      $
��Left=�6<   $��35��6W   $	��Top=�6e   $��40��6}   
������ $��0,0,0,0q�6�   $��40,0,0,0q�6�   ��6�   Z� .��5(        $ Minimize=�6&   $��Center=�66   $��32��6S   
���   �$��46��6r   5)      �� 5*   
   $
��Left=�6   $��25��6/   $��	664,8,0,0q�6;   $
��Wrap=�6N   $	��Top=�6b   $��70��6z   �� 6�    �� FlowDirection$ RightToLeft=�6�    � Language$ he-il�6�   $�שיעורי תורה��6�   6�   �� 5+   
   $��Center=�6   $��87��61   $��0,76,0,0q�6=   $
��Wrap=�6O   $	��Top=�6c   $	��550��6{   $��49(�6�   $
��Bold"�6�   �� 6�   $ RightToLeft=�6�   $ he-il�6�   $.�(חישובים לשיעורי התורה��6�   6�   �� 5,   
   $��Center=�6   $��75��61   $��	0,168,0,0q�6=   $
��Wrap=�6P   $	��Top=�6d   $	��430��6|   $��25(�6�    �� TextAlignment$ Center=�6�   �� 6�   $ RightToLeft=�6�   $ he-il�6�   $x�rכולל: מדות אורך, נפח, משקל, שיעור מטבע. ומידות שונות בדיני התורה.��6�   6+  �� 5-   
   -   5        $ btnenter��5.         ButtonStyle1#���   5-      $��Center=�5/      $��45��6.   $��	0,260,0,0q�6:   $	��Top=�6M   $	��150��6e   .��51      ��  �� Orientation$ 
Horizontal=�6   $��25��62   .+�52        $ 	ArrowLeft=�6*   $��0 5 0 0q�6;   �� 53      $��
כניסה��6   $��25,0,0,0q�6)   $��Right=�6;   $��Center=�6W   55      57        58   
   $ BookOpenPageVariant=�6"   $��68��6=   $��67��6H   $��Center=�6T   $��	0,322,0,0q�6q     iconmain#��[ 6�   6�   �� 59   
   -   5         ��Name$ 	textBlock��59      $��Center=�6'   $��	0,398,0,0q�6D   $
��Wrap=�6W   $g��aלקריאה ולמידע על יסודות חישוב שיעורי תורה לחץ על הספר��6k   $	��Top=�6�   $��37��6�   $	��172��6�   $ Center=�6�   5=      5>      