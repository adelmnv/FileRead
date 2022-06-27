using System;
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

namespace WPF_Study
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, Abstractions.IView
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public event EventHandler OpenFile;

        public string TextBox { get => tbxValue.Text; set => tbxValue.Text = value; }

        public string FileName { get; set; }

        public void GetRes(string text)
        {
            tbxValue.Text = text;
        }
        
        private void bExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void bFile1_Click(object sender, RoutedEventArgs e)
        {
            FileName = "text.txt";
            if(OpenFile != null)
            {
                OpenFile.Invoke(this, e);
            }
        }

        private void bFile2_Click(object sender, RoutedEventArgs e)
        {
            FileName = "text1.txt";
            if (OpenFile != null)
            {
                OpenFile.Invoke(this, e);
            }
        }
    }
}
