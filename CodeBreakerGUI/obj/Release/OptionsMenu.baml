   M S B A M L   `   `   `  ���� R  NCodeBreaker, Version=1.0.0.3, Culture=neutral, PublicKeyToken=9e1ebafc62da2519/clr-namespace:CodeBreakerGUICodeBreakerGUI       CodeBreakerGUI.OptionsMenu   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:CodeBreakerGUI       � Title$  OptionsMenuForEncryption��$	��406��$��369.5��.���� $
��Left=�$��420.312��$��-4,-0.333,-4.062,-3.979q�$	��Top=�$��369.562��.+�� $��421.293�� � RowDefinitions �� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* � � ColumnDefinitions �� $��* ��� $��* ��� $��* �.+��� $
��Left=�$��22.538��$��9,24.462,0,0q�$
��Wrap=�$	��Top=�$��111.167��$��2��$
��Bold"�$��16(�$��2���� $
�Keys���� �� �� -    ��Name$ Files��$��3��$��8.666,0,15.687,17.941q�$��3��.+��� -    ��Name$ FilePathText��$
��Left=�$
��Wrap=�$��
File Path:��$
��51.5�� J� RenderTransformOrigin$ 
0.53,1.439&�$��23.651�� �� Left$ 1.334��
 �� Top$
 57.7���� $
��Left=�$��21��$	��Top=�$��344.834��$ 0.375��$ 75.957��. �/� .T�J� .*�.*��� -    ��Name$ FilePath��$� ���� -   $ New_FileText��$
��Left=�$
��Wrap=�$��Save New File As Path:��$��131.167��$ 
0.53,1.439&�$��23.618��$ 0.334��$ 20.097���� -   $ BoldText��$
��Left=�$��22.538��$
��Wrap=�$	��Top=�$��111.167��$
��Bold"�$��16(�$��Files��$ 1.334���� $
��Left=�$��20.104��$	��Top=�$��344.834��$ 38.636��. �/� .T�J� .*�.*��� -   $ New_File��$� ���� -   	 ��Name$	 Change_Aes_Key��$��Change AES Key?��$
��Left=�$��14.667��$��10,23.526,0,0q�$��3��$	��Top=�$	��120��$��2��$��2���� -   $ Aes_Key_Path_Text��$
��Left=�$��17.743��$��10,3.257,0,0q�$��4��$
��Wrap=�$��AES Key Path:��$	��Top=�$��91.333���� -	   
 ��Name$
 Aes_Key_Path��$��2��$
��Left=�$��19.333��$��10,21.258,0,0q�$��4��$	��Top=�$��141.333��$��2��. �/� .T�J� .*�.*��� -
   $ Aes_Key_Path_Text_Get��$� ���� -   $	 Change_Fernet_Key��$��Change Fernet Key?��$
��Left=�$��14.667��$��65.166,23.526,0,0q�$��3��$	��Top=�$	��120��$��1��$��2��$��2���� -   $ Fernet_Key_Path_Text��$
��Left=�$��17.743��$��65.166,2.591,0,0q�$��4��$
��Wrap=�$��Fernet Key Path��$	��Top=�$��91.333��$��2��$��1���� -   $
 Fernet_Key_Path��$��2��$
��Left=�$��19.333��$��65.166,21.001,0,0q�$��4��$	��Top=�$��141.333��$��1��$��2��. �/� .T�J� .*�.*��� -   $ Fernet_Key_Path_Text_Get��$� ���� -    ��Name$ Button��$��3��$�� ��$��Center=�$��28��$��8��$��Center=�$	��225���� $
��Left=�$��21.918��$��10,16.291,0,0q�$��5��$
��Wrap=�$��Save AES Key As:��$	��Top=�$��91.333���� $��2��$
��Left=�$��20��$��10,35.291,0,0q�$��5��$��2��$	��Top=�$��141.333��. �/� .T�J� .*�.*��� -   $ Save_AES_Key_As��$� ���� $
��Left=�$��21.918��$��65.166,16.291,0,0q�$��5��$
��Wrap=�$��Save Fernet Key As:��$	��Top=�$	��120��$��2��$��1���� $��2��$
��Left=�$��20��$��65.166,35.291,0,0q�$��5��$��2��$	��Top=�$��141.333��$��1��. �/� .T�J� .*�.*��� -   $ Save_Fernet_Key_As��$� ���� -   $ Text2��$��3��$��8.666,0,15.687,14.941q�$��3��$y�Hidden=�.+��� -   $ New_FileText1��$
��Left=�$
��Wrap=�$��Save File As (Optional):��$��130.167��$ 
0.53,1.439&�$��23.651��$ 1.334��$
 60.7���� $
��Left=�$��21��$	��Top=�$��344.834��$ 0.375��$ 78.957��. �/� .T�J� .*�.*��� -   $ 	New_File1��$� ���� -   $ ConvertText��$
��Left=�$
��Wrap=�$��Convert from text:��$��131.167��$ 
0.53,1.439&�$��23.618��$ 0.334��$ 20.097���� -   $ 	BoldText1��$
��Left=�$��22.538��$
��Wrap=�$	��Top=�$��111.167��$
��Bold"�$��16(�$
��Text��$ 1.334���� $
��Left=�$��22.064��$	��Top=�$��344.834��$ 38.636��. �/� .T�J� .*�.*��� -   $ Convert��$� ��