using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using UnityCoroutines;

namespace CodeBreakerGUI
{
    /// <summary>
    /// Interaction logic for OptionsMenuForEncryption.xaml
    /// </summary>
    public partial class OptionsMenu : Window
    {
        public bool st = false;
        private string saved_aes_key_filename = "";
        private string saved_fernet_key_filename = "";
        private string filename = "";
        private string text1 = "";
        private string new_file_name = "";
        private bool change_aes_key = false;
        private bool change_fernet_key = false;
        private string change_aes_key_path = "";
        private string change_fernet_key_path = "";
        public OptionsMenu()
        {
            InitializeComponent();
            CoroutineManager.Instance.Run();
        }
        public IEnumerator MenuLoop(string content, string file = "", string text="", MainWindow mnWindow = null)
        {
            if (file == "")
            {
                if (text == "")
                {
                    throw new ArgumentException("Parameter file and text are both null, choose one or the other.");
                }
                else
                {
                    Convert.Text = text;
                    Files.Visibility = Visibility.Hidden;
                    Text2.Visibility = Visibility.Visible;
                    Button.Content = content;
                    Console.WriteLine("Hi, writing value of text");
                    Console.WriteLine(text);
                }
            }
            else
            {
                FilePath.Text = file;
                Button.Content = content;
                Console.WriteLine("Hi, writing value of file");
                Console.WriteLine(file);
            }
            while (st.Equals(false))
            {
                if ((bool)Change_Aes_Key.IsChecked)
                {
                    Aes_Key_Path_Text.Visibility = Visibility.Visible;
                    Aes_Key_Path.Visibility = Visibility.Visible;
                }
                else
                {
                    Aes_Key_Path_Text.Visibility = Visibility.Hidden;
                    Aes_Key_Path.Visibility = Visibility.Hidden;
                }
                if ((bool)Change_Fernet_Key.IsChecked)
                {
                    Fernet_Key_Path_Text.Visibility = Visibility.Visible;
                    Fernet_Key_Path.Visibility = Visibility.Visible;
                }
                else
                {
                    Fernet_Key_Path.Visibility = Visibility.Hidden;
                    Fernet_Key_Path_Text.Visibility = Visibility.Hidden;
                }
                yield return null;
            }
            object[] arguments = { filename, saved_aes_key_filename, saved_fernet_key_filename, new_file_name, change_aes_key, change_fernet_key, change_aes_key_path, change_fernet_key_path, text1 };
            string args;
            if (content.Equals("Encrypt"))
            {
                if (!(file == ""))
                {
                    args = $"encrypt -f \"{arguments[0]}\" -sp |Extra Args|";
                }
                else
                {
                    args = $"encrypt -t \"{arguments[8]}\" -sp |Extra Args|";
                }
            }
            else if (content.Equals("Decrypt"))
            {
                if (!(file == ""))
                {
                    args = $"decrypt -f \"{arguments[0]}\" -sp |Extra Args|";
                }
                else
                {
                    args = $"decrypt -t \"{arguments[8]}\" -sp |Extra Args|";
                }
                
            }
            else
            {
                throw new System.ArgumentException("Parameter must be either (Encrypt) or (Decrypt), all other parameters are not accepted", "content");
            }
            using (StreamWriter sw = new StreamWriter("log.txt"))
            {
                sw.Write(arguments);
                sw.Close();
            }
            if (!(arguments[1].ToString() == ""))
            {
                args = args.Replace("|Extra Args|", $"-sakn {arguments[1]} |Extra Args|");
            }
            if (!(arguments[2].ToString() == ""))
            {
                args = args.Replace("|Extra Args|", $"-skn {arguments[2]} |Extra Args|");
            }
            if (!(arguments[3].ToString() == ""))
            {
                args = args.Replace("|Extra Args|", $"-s {arguments[3]} |Extra Args|");
            }
            if (!arguments[4].Equals(false) && !arguments[6].ToString().Equals(""))
            {
                args = args.Replace("|Extra Args|", $"-ca {arguments[6]} |Extra Args|");
            }
            if (!arguments[5].Equals(false) && !arguments[7].ToString().Equals(""))
            {
                args = args.Replace("|Extra Args|", $"-c {arguments[7]} |Extra Args|");
            }
            args = args.Replace("|Extra Args|", "");
            ProcessStartInfo start = new ProcessStartInfo
            {
                FileName = @"./CodeBreaker/CodeBreaker.exe",
                Arguments = args,
                UseShellExecute = false,
                RedirectStandardOutput = true
            };
            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    Console.Write(result);
                    Console.Write(args);
                    result = result.Replace("b'", "");
                    result = result.Replace("'", "");
                    if (content.Equals("Encrypt"))
                    {
                        MessageBox.Show("Document successfully encrypted", "CodeBreaker");
                    }
                    else if (content.Equals("Decrypt"))
                    {
                        MessageBox.Show("Document was successfully decrypted", "CodeBreaker");
                    }
                    else
                    {
                        throw new ArgumentException("Parameter must be either (Encrypt) or (Decrypt), all other parameters are not accepted", "content");
                    }
                    using (StreamWriter writer = new StreamWriter("log.txt"))
                    {
                        writer.WriteLine(result);
                        writer.WriteLine(mnWindow.Input_Text.Text);
                    }
                    if (file == "")
                    {
                        mnWindow.Input_Text.Text = result;
                    }
                    else
                    {
                        if (mnWindow.Title.Contains(file))
                        {
                            Console.WriteLine(mnWindow.Title);
                            mnWindow.Input_Text.Text = result;
                            mnWindow.Title = mnWindow.Title.Replace("*", "");
                        }
                        else
                        {
                            mnWindow.Title = $"{file} - CodeBreaker";
                            mnWindow.Input_Text.Text = result;
                        }
                    }
                }
            }
            Hide();
        }
        private void Btn_Encrypt(object sender, RoutedEventArgs e)
        {
            if (!(Files.Visibility == Visibility.Hidden))
            {
                filename = FilePath.Text;
                new_file_name = New_File.Text;
            }
            else
            {
                text1 = Convert.Text;
                new_file_name = New_File1.Text;
            }
            change_aes_key = (bool)Change_Aes_Key.IsChecked;
            change_fernet_key = (bool)Change_Fernet_Key.IsChecked;
            saved_aes_key_filename = Save_AES_Key_As.Text;
            saved_fernet_key_filename = Save_Fernet_Key_As.Text;
            change_aes_key_path = Aes_Key_Path_Text_Get.Text;
            change_fernet_key_path = Fernet_Key_Path_Text_Get.Text;
            st = true;
            return;
        }

    }
}
