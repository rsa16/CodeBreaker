using System;
using System.Windows;
using UnityCoroutines;
using System.Windows.Documents;
using System.IO;

namespace CodeBreakerGUI
{
    /// <summary>
    /// Interaction logic for DialogueBoxEncryptOrDecrypt.xaml
    /// </summary>
    public partial class DialogueBoxEncryptOrDecrypt : Window
    {
        public string FileToUseName = "";
        public string FileText = "";
        public Run documentText2;
        public MainWindow mnWindow;
        public DialogueBoxEncryptOrDecrypt(string filename = "", string text = "",  Run documentText = null, MainWindow mainWindow = null)
        {
            InitializeComponent();
            if (text == "")
            {
                FileToUseName = filename;
            }
            else
            {
                FileText = text;
            }
            mnWindow = mainWindow;
            documentText2 = documentText;
            CoroutineManager.Instance.Run();
        }

        private void BtnEncrypt(object sender, RoutedEventArgs e)
        {
            OptionsMenu encryptionmenu = new OptionsMenu();
            encryptionmenu.Show();
            if (!(FileToUseName == ""))
            {
                CoroutineManager.Instance.StartCoroutine(encryptionmenu.MenuLoop("Encrypt", FileToUseName));
            }
            else
            {
                CoroutineManager.Instance.StartCoroutine(encryptionmenu.MenuLoop("Encrypt", text: FileText, mnWindow: mnWindow));
            }
            Console.WriteLine("hi! closing");
            Close();
        }

        private void BtnDecrypt(object sender, RoutedEventArgs e)
        {
            OptionsMenu decryptionmenu = new OptionsMenu();
            decryptionmenu.Show();
            if (!(FileToUseName == ""))
            {
                CoroutineManager.Instance.StartCoroutine(decryptionmenu.MenuLoop("Decrypt", FileToUseName));
            }
            else
            {
                CoroutineManager.Instance.StartCoroutine(decryptionmenu.MenuLoop("Decrypt", text: FileText, mnWindow: mnWindow));
            }
            
            Console.WriteLine("Hi! closing");
            Close();
        }

        private void BtnCancel(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnOpen(object sender, RoutedEventArgs e)
        {
            mnWindow.Title = string.Format("{0} - CodeBreaker", FileToUseName);
            if (FileToUseName.EndsWith(".txt"))
            {
                using (StreamReader sd = new StreamReader(FileToUseName))
                {
                    mnWindow.textModifiedBySoftware = true;
                    documentText2.Text = sd.ReadToEnd();
                    this.Close();
                }
            }
            else
            {
                Console.WriteLine("Document Type Not Supported!");
                string messageBoxText = "This document type has not yet been supported by CodeBreaker GUI, sorry. If you want to see this document type getting supported, please email the author at rsa165.ali@gmail.com.";
                string messageBoxTitle = "Type Not Supported!";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Information;
                MessageBoxResult result = MessageBox.Show(messageBoxText, messageBoxTitle, button, icon);
                if (result == MessageBoxResult.OK) {
                    // idk why i left this here dont ask me guess its an easter egg?
                }

            }
        }
    }
}
