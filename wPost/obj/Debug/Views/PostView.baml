   M S B A M L   `   `   `  ����@  <wPost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:wPost.ViewModelswPost.ViewModels  5          wPost.Views.PostView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5
ViewModelsclr-namespace:wPost.ViewModels     5        � DataContext  5      $   wPost.ViewModels.PostViewModel  5	   
   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $	��400 �6   �� 5      $��10 �6   �� 5      $	��290 �6   .+�5   
   � -   5        $��grdPostView��5      $��Visible=�6#    5      �� 5      $
��Auto �6!    5      �� 5      $
��Auto �6#   .+�5      �� -   5        $��LstPatients��5      $	��500��6*   ��5      ��  �� Path$ Posts� �� SelectedItem 5      �� $ SelectedPost� �� View 5      �� 5       .P�5!      �� $��Title��6)    �� Width$	 100��5"   "    �� DisplayMemberBinding 5#   %   �� $ title��� 5$      $��Description��6)   $	 300��5%   $    5&   %   �� $
 body�5'      5)      5*      � 5+   
   -   5        $��grdSelectedRecord��5+   -   $��2��6   $	��600��6    5,      �� 5-      $
��Auto �6    �� 5.      $
��Auto �6    �� 5/      $
��Auto �6    �� 50      $
��Auto �6    �� 51      $��* �6     53      �� 54      $
��Auto �6#   �� 55      $
��Auto �6#   .+�57      �� $
��Wrap=�6   $��0��6,   $��0��69   $��User:��6I   $
��Left=�6V   $	��Top=�6q   �� 58      $
��Wrap=�6   $��1��6,   $��0��69   $��Title:��6I   $
��Left=�6W   $	��Top=�6r   �� 59      $
��Wrap=�6   $��2��6,   $��0��69   $��Body:��6I   $
��Left=�6V   $	��Top=�6q   �� 5:      $
��Wrap=�6   $��1��6,   $��0��6<   $��3q�6I   $
��Left=�6�   $��Center=�6�   ��6U   �� $ SelectedPost.userId� �� Mode$ TwoWay=�	 �� UpdateSourceTrigger$	 PropertyChanged=�6�   �� 5;      $
��Wrap=�6   $��1��6,   $��1��6<   $��3q�6I   $
��Left=�6�   $��Center=�6�   ��6T   �� $ SelectedPost.title�$ TwoWay=�$	 PropertyChanged=�6�   �� 5<      $
��Wrap=�6   $��1��6,   $��2��6<   $��3q�6I   $
��Left=�6�   $��Center=�6�   ��6U   �� $ SelectedPost.body�$ TwoWay=�$	 PropertyChanged=�6�   5=      5>      5@      