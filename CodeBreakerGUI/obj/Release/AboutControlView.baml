   M S B A M L   `   `   `  ���� R  NCodeBreaker, Version=1.0.0.3, Culture=neutral, PublicKeyToken=9e1ebafc62da2519+clr-namespace:Gat.ControlsGat.Controls  #    Gat.Controls.AboutControlView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ,localclr-namespace:Gat.Controls     -   
�������$	��500��$��1q�
���   �  � 	Resources  (   "Gat.Controls.AboutControlViewModel   	ViewModel��%   &	          .���  � DataContext ��  �� Source# [   � RowDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �.+�� $��0��$��0��$��10q� � ColumnDefinitions �� $
��Auto ��� $
��Auto �.+��� -    ��Name$ ApplicationLogo��$��0��$��0��$��42��$��42������ *ApplicationLogo+�� -    ��Name$ Title��$��1��$��0��$��16(����� *Title+�� -    ��Name$ Description��$��0��$��1��$��	10,0,10,0q�$
��Wrap=����� *Description+� $��0��$��2��$��10q� �� $
��Auto ��� $��* �.+��� $��0��$��0��$��Center=�$��	Version: ���� -   $ Version��$��1��$��0������ *	Version+� $��0��$��3��$��10, 20q� �� $
��Auto ��� $��* � �� $
��Auto ��� $
��Auto �.+��� -   $ PublisherLogo��$��0��$��2��$��36��$��36������ *PublisherLogo+�� -   $ 	Copyright��$��1��$��0��$��5,2,0,0q����� *	Copyright+�� $��1��$��1��.���� -    ��Name$ 	Hyperlink������ *	Hyperlink+.�.��� -	   $ HyperlinkText������ *HyperlinkText+�� -
   $ AdditionalNotes��$��0��$��4��$��
10,0,10,10q�$
��Wrap=����� *AdditionalNotes+