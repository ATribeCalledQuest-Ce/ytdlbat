using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Windows.Controls.Primitives;

namespace ytdlBatGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        bool isVerbose = false;
        public MainWindow()
        {
            InitializeComponent();
            this.Title = "YTDLBatGUI";
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            uiBox.KeyDown += new KeyEventHandler(uiBox_KeyDown);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            download();
        }
        public void uiBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= uiBox_GotFocus;
        }
        private void download()
        {
            //bool hasChanged = false;
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = @"\media";
            watcher.NotifyFilter = NotifyFilters.LastWrite;
            watcher.Filter = "*.*";
            if (isVerbose)
            {
                textBox1.Text = String.Format("Downloading: {0}\n{1}", uiBox.Text, textBox1.Text);
                string strCmdText = String.Format("/C YTDLmusic {0}", uiBox.Text);
                System.Diagnostics.Process.Start("CMD.exe", strCmdText);
                uiBox.Text = string.Empty;
            }
            if (!isVerbose)
            {
                textBox1.Text = String.Format("Downloading: {0}\n{1}", uiBox.Text, textBox1.Text);
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = String.Format("/C YTDLmusic {0}", uiBox.Text);
                process.StartInfo = startInfo;
                process.Start();
                uiBox.Text = string.Empty;
            }
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.EnableRaisingEvents = true;
        }
        public static void OnChanged(object source, FileSystemEventArgs e)
        {
            //hasChanged = true;
        }
        public void uiBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                download();
            }
        }
        private void about_Click(object sender, RoutedEventArgs e)
        {
            string text = String.Format("Made by Ben F.\nhttps://github.com/ATribeCalledQuest-CeQue?tab=repositories \nhttps://twitter.com/Heffeeee \n");
            MessageBox.Show(text);

        }
        private void verbChecked(object sender, RoutedEventArgs e)
        {
            isVerbose = true;
        }
        private void verbUnchecked(object sender, RoutedEventArgs e)
        {
            isVerbose = false;
        }
    }
}
