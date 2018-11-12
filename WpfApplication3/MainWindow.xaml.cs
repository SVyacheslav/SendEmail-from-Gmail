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

namespace WpfApplication3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SendMail_Click(object sender, RoutedEventArgs e)
        {

            if (Helper.Helpers.SendMail(tbTo.Text, tbSubject.Text, tbBody.Text, out string msg))
                ErrMsg.Foreground = new SolidColorBrush(Colors.Green);
            else
                ErrMsg.Foreground = new SolidColorBrush(Colors.Red);

            ErrMsg.Text = msg;
        }
    }
}
