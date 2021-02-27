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

namespace CateringApp
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
            DataContext = new LoginVM();
        }

        private void pwd_TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            pwd_TextBox.Text = "";
            pwd_TextBox.GotFocus -= pwd_TextBox_GotFocus;
        }

        private void uname_TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            uname_TextBox.Text = "";
            uname_TextBox.GotFocus -= uname_TextBox_GotFocus;
        }
    }
}
