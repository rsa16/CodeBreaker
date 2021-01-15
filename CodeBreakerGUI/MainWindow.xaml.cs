using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;
using System.Windows.Input;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Controls;
using UnityCoroutines;
using Gat.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace CodeBreakerGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public OpenFileDialog ofd = new OpenFileDialog();
        public SaveFileDialog sfd = new SaveFileDialog();
        public bool textModifiedBySoftware = true;
        public static RoutedCommand NewWindow = new RoutedCommand();
        public static RoutedCommand New = new RoutedCommand();
        public int times2 = 0;
        public int times = 0;
        public string FileName;
        public List<MainWindow> newWindows = new List<MainWindow>();
        public MainWindow()
        {
            // Comment Out Below to disable console.
            using (StreamWriter sw = new StreamWriter(".temp"))
            {
                sw.Write(newWindows.Count);
                sw.Close();
            }
            ConsoleManager.Show();
            ApplicationCommands.SaveAs.InputGestures.Add(new KeyGesture(Key.S, ModifierKeys.Control | ModifierKeys.Shift));

            this.Title = "Untitled - CodeBreaker";
            sfd.InitialDirectory = "C:\\";
            ofd.InitialDirectory = "C:\\";
            ofd.Filter = "All Files (*.*)|*.*";
            sfd.Filter = "All Files (*.*)|*.*";
            ofd.FilterIndex = 1;
            sfd.FilterIndex = 1;
            NewWindow.InputGestures.Add(new KeyGesture(Key.N, ModifierKeys.Control | ModifierKeys.Alt));
            New.InputGestures.Add(new KeyGesture(Key.N, ModifierKeys.Control));
            InitializeComponent();
            CommandBinding oBinding = new CommandBinding
            {
                Command = ApplicationCommands.Open
            };
            CommandBinding sBinding = new CommandBinding
            {
                Command = ApplicationCommands.SaveAs
            };
            CommandBinding sbinding = new CommandBinding
            {
                Command = ApplicationCommands.Save
            };
            oBinding.Executed += Event;
            oBinding.CanExecute += OpenCanExecute;
            sBinding.Executed += SaveAs;
            sBinding.CanExecute += SaveAsCanExecute;
            sbinding.Executed += Save;
            sbinding.CanExecute += SaveCanExecute;
            CommandBindings.Add(oBinding);
            CommandBindings.Add(sBinding);
            CommandBindings.Add(sbinding);

        }

        private void SaveCanExecute(object sender,  CanExecuteRoutedEventArgs e) {
            e.CanExecute = true;
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            if (!(FileName == null))
            {
                using (StreamWriter writer = new StreamWriter(FileName))
                {
                    writer.WriteLine(Input_Text.Text);
                    writer.Close();
                }
                Title = Title.Replace("*", "");
            }
            else
            {
                if (sfd.ShowDialog() == true)
                {
                    FileName = sfd.FileName;
                    if (FileName == null)
                    {
                        return;
                    }
                    using (StreamWriter writer = new StreamWriter(FileName))
                    {
                        writer.WriteLine(Input_Text.Text);
                        writer.Close();
                    }
                    Title = $"{FileName} - CodeBreaker";
                }
            }
        } 
        private void Event(object sender, RoutedEventArgs e)
        {
            if (times.Equals(0))
            {
                if (ofd.ShowDialog() == true)
                {
                    FileName = ofd.FileName;
                    if (FileName == null)
                    {
                        return;
                    }
                    DialogueBoxEncryptOrDecrypt dlgbeord = new DialogueBoxEncryptOrDecrypt(FileName, documentText: Input_Text, mainWindow: this);
                    dlgbeord.ShowDialog();
                    times = 3;
                    return;
                }
                else
                {
                    times++;
                    Console.Write("Hi");
                    return;
                }
            }
            else
            {
                times = 0;
                return;
            }
        }
        public void OpenCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
        public void SaveAsCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
        private void Encrypt_Text(object sender, RoutedEventArgs e)
        {
            OptionsMenu encryptionmenu = new OptionsMenu();
            if (!(FileName == null))
            {
                encryptionmenu.Show();
                CoroutineManager.Instance.StartCoroutine(encryptionmenu.MenuLoop("Encrypt", FileName, mnWindow: this));
            }
            else
            {
                string messageBoxDialog = "Do you want save? If not the text will be encrypted as is.";
                string messageBoxCaption = "Save?";
                MessageBoxButton btn = MessageBoxButton.YesNoCancel;
                MessageBoxImage icon = MessageBoxImage.Question;
                MessageBoxResult res = MessageBox.Show(messageBoxDialog, messageBoxCaption, btn, icon);
                switch (res)
                {
                    case MessageBoxResult.Yes:
                        if (sfd.ShowDialog() == true)
                        {
                            FileName = sfd.FileName;
                            using (StreamWriter file = new StreamWriter(FileName))
                            {
                                file.Write(Input_Text.Text);

                            }
                        }
                        encryptionmenu.Show();
                        CoroutineManager.Instance.StartCoroutine(encryptionmenu.MenuLoop("Encrypt", FileName, mnWindow: this));
                        break;
                    case MessageBoxResult.No:
                        encryptionmenu.Show();
                        CoroutineManager.Instance.StartCoroutine(encryptionmenu.MenuLoop("Encrypt", text: Input_Text.Text, mnWindow: this));
                        break;
                    case MessageBoxResult.Cancel:
                        break;
                }
            }
        }

        private void Decrypt_Text(object sender, RoutedEventArgs e)
        {
            OptionsMenu decryptionmenu = new OptionsMenu();
            if (!(FileName == null))
            {
                decryptionmenu.Show();
                CoroutineManager.Instance.StartCoroutine(decryptionmenu.MenuLoop("Decrypt", FileName, mnWindow: this));
            }
            else
            {
                string messageBoxDialog = "Do you want save? If not the text will be decrypted as is.";
                string messageBoxCaption = "Save?";
                MessageBoxButton btn = MessageBoxButton.YesNoCancel;
                MessageBoxImage icon = MessageBoxImage.Question;
                MessageBoxResult res = MessageBox.Show(messageBoxDialog, messageBoxCaption, btn, icon);
                switch (res)
                {
                    case MessageBoxResult.Yes:
                        if (sfd.ShowDialog() == true)
                        {
                            FileName = sfd.FileName;
                            using (StreamWriter file = new StreamWriter(FileName))
                            {
                                file.Write(Input_Text.Text);
                                decryptionmenu.Show();
                                CoroutineManager.Instance.StartCoroutine(decryptionmenu.MenuLoop("Decrypt", FileName, mnWindow: this));
                            }
                        }
                        break;
                    case MessageBoxResult.No:
                        decryptionmenu.Show();
                        CoroutineManager.Instance.StartCoroutine(decryptionmenu.MenuLoop("Decrypt", text: Input_Text.Text, mnWindow: this));
                        break;
                    case MessageBoxResult.Cancel:
                        break;
                }
            }
        }
        private void SaveAs(object sender, RoutedEventArgs e)
        {
            if (sfd.ShowDialog() == true)
            {
                FileName = sfd.FileName;
                using (StreamWriter file = new StreamWriter(FileName))
                {
                    file.Write(Input_Text.Text);
                }
            }
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            int Count;
            using (StreamReader sd = new StreamReader(".temp"))
            {
                Count = int.Parse(sd.ReadLine());
                sd.Close();
            }
            if (Count == 0)
            {
                Application.Current.Shutdown();
            }
            else
            {
                this.Close();
            }
        }

        private void NewCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void New1(object sender, RoutedEventArgs e)
        {
            MessageBoxButton btn = MessageBoxButton.YesNoCancel;
            MessageBoxImage icon = MessageBoxImage.Question;
            MessageBoxResult res = MessageBox.Show("Do you want to save?", "Save", btn, icon);
            switch (res)
            {
                case MessageBoxResult.Yes:
                    if (sfd.ShowDialog() == true)
                    {
                        FileName = sfd.FileName;
                        using (StreamWriter file = new StreamWriter(FileName))
                        {
                            file.Write(Input_Text.Text);
                        }
                    }
                    Input_Text.Text = "";
                    Title = "Untitled - CodeBreaker";
                    FileName = null;
                    break;
                case MessageBoxResult.No:
                    Input_Text.Text = "";
                    Title = "Untitled - CodeBreaker";
                    FileName = null;
                    break;
                case MessageBoxResult.Cancel:
                    break;
            }
        }
        private void New_WindowCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
        private void New_Window(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();
            newWindows.Add(m);
            using (StreamWriter sw = new StreamWriter(".temp"))
            {
                sw.Write(newWindows.Count);
                sw.Close();
            }
        }
   

        private void TextChange(object sender, KeyEventArgs e)
        {
            Key[] nonAllowedKeys = { Key.Escape, Key.End, Key.Delete, Key.Home, Key.Help, Key.HanjaMode, Key.HangulMode, Key.Insert, Key.CapsLock, Key.LeftShift, Key.RightShift, Key.RightAlt, Key.LeftAlt, Key.LeftCtrl, Key.RightCtrl, Key.F1, Key.F2, Key.F3, Key.F4, Key.F5, Key.F6, Key.F7, Key.F8, Key.F9, Key.F10, Key.F11, Key.F12, Key.F13, Key.F14, Key.F15, Key.F16, Key.F17, Key.F18, Key.F19, Key.F20, Key.F21, Key.F22, Key.F23, Key.F24, Key.LWin, Key.RWin, Key.Right, Key.Left, Key.Down, Key.Up, Key.PageDown, Key.PageUp, Key.Scroll, Key.Pause, Key.PrintScreen };
            foreach (Key key in nonAllowedKeys)
            {
                if (e.Key == key)
                {
                    return;
                }
            }
            if (FileName == null)
            {
                Title = "*Untitled - CodeBreaker";
                return;
            }
            Title = string.Format("*{0} - CodeBreaker", FileName);
            times2 = 1;
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            int Count;
            using (StreamReader sd = new StreamReader(".temp"))
            {
                Count = int.Parse(sd.ReadLine());
                sd.Close();
            }
            if (Count == 0)
            {
                Application.Current.Shutdown();
            }
            else
            {
                this.Close();
            }
        }

        private void About(object sender, RoutedEventArgs e)
        {
            Gat.Controls.About ab = new Gat.Controls.About();
            BitmapImage applicationLogo = new BitmapImage();
            applicationLogo.BeginInit();
            applicationLogo.UriSource = new Uri("codebreaker.ico", UriKind.Relative);
            applicationLogo.EndInit();
            BitmapImage publisherLogo = new BitmapImage();
            publisherLogo.BeginInit();
            publisherLogo.UriSource = new Uri("devenv.png", UriKind.Relative);
            publisherLogo.EndInit();
            ab.PublisherLogo = publisherLogo;
            ab.ApplicationLogo = applicationLogo;
            ab.Show();
        }
    }
}
