   M S B A M L   `   `   `  ����_  [MaterialDesignThemes.Wpf, Version=4.6.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a{Sclr-namespace:MaterialDesignThemes.Wpf.Converters;assembly=MaterialDesignThemes.Wpf#MaterialDesignThemes.Wpf.Converters  5      eHclr-namespace:MaterialDesignThemes.Wpf;assembly=MaterialDesignThemes.WpfMaterialDesignThemes.Wpf  5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   btn  �� 
TargetType �� Property �� Value  ButtonStyle1  FocusVisual  PrimaryHueMidBrush   PrimaryHueMidForegroundBrush.    (MaterialDesignThemes.Wpf.ElevationAssist+   %MaterialDesignThemes.Wpf.ButtonAssist+   %MaterialDesignThemes.Wpf.RippleAssist3   -MaterialDesignThemes.Wpf.ButtonProgressAssist �� 
TargetType J� 	CacheMode �� RelativeSource ��Name �� CornerRadius J� Effect9   3MaterialDesignThemes.Wpf.Converters.ShadowConverter	   Instance
 �� 	Converter �Name # MaterialDesignLinearProgressBar � IsIndeterminate � Maximum � Minimum J� Opacity � Value   BooleanToVisibilityConverter �� AncestorType J� Clip  BorderClipConverter `� 	Converter �� ElementName �� Path%   MaterialDesignThemes.Wpf.Ripple �� ContentStringFormat J� SnapsToDevicePixels �� Triggers P� Property P� Value �� 
TargetName+   %MaterialDesignThemes.Wpf.ShadowAssist�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml     5      b
convertersSclr-namespace:MaterialDesignThemes.Wpf.Converters;assembly=MaterialDesignThemes.Wpf  5      PwpfHclr-namespace:MaterialDesignThemes.Wpf;assembly=MaterialDesignThemes.Wpf  5      %  &	        &	 J     7  7  7  7  �� 5      "  ��6   .�5   
   ��  � ��
 �  ��6'   5      �� 5      "  ��6!   .�5   
   ��  �@�FocusVisualStyle8   6-   �� 5   
    � ��# �  6'   �� 5   
    � ��# �  6(   �� 5   
    � ��# �  6'   �� 5   
    �@�Cursor$
 Hand��6#   �� 5   
    � ��$ Medium"�61   �� 5   
    � ��$ 14(�6/   �� 5   
    � ��$ 1q�6,   �� 5   
    � ��$ Center=�67   �� 5   
    � ��$ Center=�65   �� 5   
    � ��$ 	16 4 16 4q�6$   �� 5   
    � ��$ 32��6#   �� 5   
    �@  	Elevation$	 Dp2=�6:   �� 5   
    �@ CornerRadius$ 2��6:   �� 5    
    �@ Feedback
 �����66   �� 5!   
    �@ IndicatorForeground# �  6I   �� 5"   
    �@ IndicatorBackground# �  6I   �� 5#   
    �@ IsIndicatorVisible$ False��6H   �� 5$   
    �@ Opacity$ .4Q�6=   �� 5%   
    � �� 5&      �� 5'      " ��6"   .R�5(      � .+�5)      ��  6+   �� *(wpf:ShadowAssist.CacheMode)+ �� *Self+.u�5*      � .+�5+   "   �� $ border��6)   #��z��69   #��z��6c   #��z��6�   $ 20��6�    6�   �� *!(wpf:ElevationAssist.Elevation)+#
 Z	  �� *TemplatedParent+� 5,   "   $ ProgressBar��6.   $
��Left=�6�  #��z��6�  #���  6�  $��Center=�64  ��6C   �� *0.(wpf:ButtonProgressAssist.IndicatorBackground)+ �� *TemplatedParent+��6�   �� *0.(wpf:ButtonProgressAssist.IndicatorBackground)+ �� *TemplatedParent+��62  �� *0.(wpf:ButtonProgressAssist.IndicatorForeground)+ �� *TemplatedParent+ 6�  �� *,*(wpf:ButtonProgressAssist.IsIndeterminate)+ �� *TemplatedParent+ 6^  �� *$"(wpf:ButtonProgressAssist.Maximum)+ �� *TemplatedParent+ 6�  �� *$"(wpf:ButtonProgressAssist.Minimum)+ �� *TemplatedParent+ 6.  �� *$"(wpf:ButtonProgressAssist.Opacity)+ �� *TemplatedParent+ 6�  �� *" (wpf:ButtonProgressAssist.Value)+ �� *TemplatedParent+y�6O  �� */-(wpf:ButtonProgressAssist.IsIndicatorVisible)+8
   �� *TemplatedParent+��6�  �� *ActualWidth+ �� *FindAncestor+" �� 5-   &   `� 5.   *   8  .1�5/   .   �� $ border��66   $ ActualWidth�6K   �� 50   .   $ border��66   $ ActualHeight�6K   �� 51   .   $ border��66   $ CornerRadius�6K   �� 52   .   $ border��66   $ BorderThickness�6K   53   +   55   #   56      57        58      # z 6%   #��z��6a   #��z��6�   $|�False��6�   #��z��6�   #��z��6  # z 69  #��z��6u   59      `� 5:   "   8  .1�5;   &   �� $ border��6.   $ ActualWidth�6C   �� 5<   &   $ border��6.   $ ActualHeight�6C   �� 5=   &   $ border��6.   $ CornerRadius�6C   �� 5>   &   $ border��6.   $ BorderThickness�6C   5?   #   5A      5B       5C      P� 5D       �@J�IsMouseOver$
 true��69   . �5E      �� $ border��6H    �@ Darken$
 True��6\   5F      P� 5G       �@J�IsKeyboardFocused$
 true��6?   . �5H      �� $ border��6H    �@ Darken$
 True��6\   5I      P� 5J       � {�$ false��67   . �5K      ��  �@J�Opacity$
 0.38Q�68   5L      5N      5P      5Q      5S      