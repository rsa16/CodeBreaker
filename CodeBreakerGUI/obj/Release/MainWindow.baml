   M S B A M L   `   `   `  ���� R  NCodeBreaker, Version=1.0.0.3, Culture=neutral, PublicKeyToken=9e1ebafc62da2519/clr-namespace:CodeBreakerGUICodeBreakerGUI      CodeBreakerGUI.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:CodeBreakerGUI     -     �Name$  MainWindow1�� � Title$ Untitled - CodeBreaker��$	��720��$
��1080�� � 	Resources    MenuItemControlTemplate1 �� 
TargetType ��Name J� SnapsToDevicePixels � ColumnDefinitions ��Name m� Icon	 F�Name
 �� HeaderStringFormat �� ContentStringFormat �Name � AllowsTransparency �� RelativeSource �� Padding ��Name �� 
ResourceId �� TypeInTargetAssembly �� ClearTypeHint ��Name �� ElementName ��Name-  'System.Windows.Input.KeyboardNavigation   DirectionalNavigation � IsSharedSizeScope   TabNavigation �� Triggers P� Property P� Value �� 
TargetName �� Property �� Value  P� 
SourceName  MenuItemControlTemplate2! z� SharedSizeGroup" ��Name# J� Opacity$ m� InputGestureText% ]� 
Conditions& �� Property' �� Value  Menu.Static.Separator( �� Color  SeparatorStyle1) �� 
TargetType��%�  &	        &	 �    &	 �    &	 �    7  7  �� " m�.R��� $ templateRoot��#��z��#��z��#��z�� . ._�� $��Center=� �� $
��Auto ��� $
��Auto �.+��� $
 Icon��#��z $
��Icon��$��Center=�$��16��$��3q�# z $��Center=�$��16��F� $	 
GlyphPanel��T������� �O �`�G �ڊ � �D �ڊ �    �XO � � �g5 ���A  ] ������� @    р�� �O #��z��$��LeftToRight=�$��3q�$y�	Collapsed=�$��Center=��� #��z��#��z��$��1��# z
 $��Header��#��z����. # z � $ 
PART_Popup�� . |�.  #��� -�$��Bottom=����� *IsSubmenuOpen+ �� *TemplatedParent+.���� $ SubMenuBorder�����	#FF999999$��1q����	#FFF0F0F0$ 2q�._��� $ SubMenuScrollViewer����C� *�� $ MenuScrollViewer��" �+.��� $ Enabled=�.+��� $
��Left=�$��0��$	��Top=�$��0��.+��� $ 
OpaqueRect������ *
Background+$ SubMenuBorder������ *ActualHeight+$ SubMenuBorder������ *ActualWidth+$ SubMenuBorder���� $ ItemsPresenter��$ Cycle=� . # z $ Cycle=� P� " �@m�IsSuspendingPopupAnimation . . ��� $ 
PART_Popup�� � ��$
 None=�P�  Z�  �@m�Icon. ��� $
 Icon�� � y�$ 	Collapsed=�P�  �@m�	IsChecked . . ��� $ 
GlyphPanel�� � y�$ Visible=��� $
 Icon�� � y�$ 	Collapsed=�P�  �@m�IsHighlighted . . ��� $ templateRoot�� � �� �	#3D26A0DA�� $ templateRoot�� � �� �	#FF26A0DAP�  � {� .  . ��� $ templateRoot�� � �� �	#FF707070�� $ 
GlyphPanel�� � �� �	#FF707070P� $  SubMenuScrollViewer�� � �� .  . ��� $ 
OpaqueRect�� �� *VerticalOffset+$ SubMenuScrollViewer�� �@��Top�� $ 
OpaqueRect�� �� *HorizontalOffset+$ SubMenuScrollViewer�� �@��Left�� " m�.R��� $ templateRoot��#��z��#��z��#��z�� . ._�� $��-1q� �� $��22��$! MenuItemIconColumnGroup��$
��Auto ��� $��5 ��� $��* ��� $��30 ��� $! MenuItemIGTColumnGroup��$
��Auto ��� $��20 �.+��� $
 Icon��#��z $
��Icon��$��Center=�$��16��$��3q�# z $��Center=�$��16���� $ 
GlyphPanel�����	#FF26A0DA$��1q����	#3D26A0DA}�.  $��Center=�$��22��$��-1,0,0,0q�$y�Hidden=�$��Center=�$��22��._�F� $	 Glyph��T������� �O �`�G �ڊ � �D �ڊ �    �XO � � �g5 ���A  ] ������� @    р�� �O ���	#FF212121$��LeftToRight=�$��11��$��10���� $ menuHeaderContainer��#��z��#��z��$��2��# z
 $��Header��$
��Left=�#��z����. # z $��Center=��� $" menuGestureText��$��4��#��z��$	# 0.7Q�#��z$ $��Center=� P�  Z�  �@m�Icon. ��� $
 Icon�� � y�$ 	Collapsed=�P�  �@m�	IsChecked . . ��� $ 
GlyphPanel�� � y�$ Visible=��� $
 Icon�� � y�$ 	Collapsed=�P�  �@m�IsHighlighted . . ��� $ templateRoot�� � �� �	#3D26A0DA�� $ templateRoot�� � �� �	#FF26A0DAP�  � {� .  . ��� $ templateRoot�� � �� �	#FF707070�� $ Glyph�� � �� �	#FF707070]� % �� & �@m�IsHighlighted' . �� & � {�' .  ./��� $ templateRoot�� � �� �	#0A000000�� $ templateRoot�� � �� �	#21000000�� $( 	#FFD7D7D7���� ") ��.���  � ��8   ��  � ��8  ��  � ��$ 1����  �@J�SnapsToDevicePixels . ��  � �� �� " ��.R��� #��z��#��z��#��z��$��24,0,0,0q�* J� CommandBindings* )  #System.Windows.Input.CommandBinding  -      CodeBreakerGUI.MainWindow+   	NewWindow,   Command#, Z+   -   
-   New#, Z- .��]� $��0,0,0,655.5q�.+�o� $	��Top=�
����������	#FFF4F4F4$��0,0,0,2q�$��21��.@�m� $��_File��$
��23.5��$��Center=�$��Center=�#���   .@�m� $	��New��$��0,0,-2.828,0q�. m� Command#. Z- #���  $$ Ctrl+N��m� $��_New Window��#. Z+ $$ 
Ctrl+Alt+N��#���  $��
0,0,-2.5,0q�m� $��_Open..��$. ApplicationCommands.Open��#���  $��0,0,-2.989,0q�m� $��_Save��$. ApplicationCommands.Save��$
��Left=�#���  $��289.743��$��0,0,-2.631,0q�m� $��_Save As��$ . ApplicationCommands.SaveAs��#���  $$ Ctrl+Shift+S��/ m� StaysOpenOnClick/ . $��0,0,-3.005,0q��� #���  $��0,0,-3.005,0q�m� -   $��_Encrypt Current Document��#���  $��0,0,-3.005,0q�m� -   $��_Decrypt Current Document��#���  $��0,0,-3.005,0q��� #���  $��0,0,-3.005,0q�m� -   $��_Exit��#���  $��0,0,-3.005,0q�m� $��_Edit��$
��23.5��$��Center=�$��Center=�#���   .@�m� -   0 m�Name$0 UndoMenuItem��$��_Undo��$. ApplicationCommands.Undo��#���  {�.  $��0,0,-1,0q�m� -   $0 RedoMenuItem��$��_Redo��$. ApplicationCommands.Redo��#���  {�.  $��0,0,-2,0q��� #���  m� -	   $0 CutMenuItem��$
��_Cut��$. ApplicationCommands.Cut��#���  $��0,0,-1.958,0q�$$ Ctrl+X��m� -
   $0 CopyMenuItem��$��_Copy��$. ApplicationCommands.Copy��#���  $��0,0,-2.062,0q�m� -   $0 PasteMenuItem��$��_Paste��$. ApplicationCommands.Paste��#���  $��0,0,-2.062,0q�m� -   $0 DeleteMenuItem��$��_Delete��$ . ApplicationCommands.Delete��#���  $��0,0,-2,0q��� #���  m� -   $0 SearchMenuItem��$��_Search With Bing...��1   SearchWithBing#. Z1 #���  $��0,0,-2,0q�m� -   $0 FindMenuItem��{�.  $��_Find��$. ApplicationCommands.Find��#���  $��0,0,-1,0q�m� $��_Format��$
��23.5��$��Center=�$��Center=�#���   .@�m� $��_Sample Control��#���  m� $��_Tools��$
��23.5��$��Center=�$��Center=�#���   .@�m� -   $��_QuickConverter��#���  m� $��_View��$
��23.5��$��Center=�$��Center=�#���   .@�m� $��_Sample Control��#���  m� $��_Help��$
��23.5��$��Center=�$��Center=�#���   .@�m� $��_Sample Control��#���  �� #���  m� -   $��_About CodeBreaker��#���  �� -   2 ��Name$2 textbox��$��Stretch=�$��Stretch=�$��0,0,0,-746.86q�"3 �� VerticalScrollBarVisibility$
3 Auto=�$4 �� HorizontalScrollBarVisibility$
4 Auto=���. $��Consolas)�$��15(�5 �� 	IsEnabled5 . $��0,5,0,0q�6 �� SelectionBrush6 �	#FF0078D7���	#FF0078D7$��0q�$��4��. �/� .T�J� .*�.*��� -   7 �Name$7 
Input_Text��$� ��(  "System.Windows.Controls.WebBrowser  -   8  Name$8 myWebBrowser��