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
    /// Interaction logic for SignUpPage.xaml
    /// </summary>
    public partial class SignUpPage : Page
    {
        private SignUpVM vm;
        public SignUpPage()
        {
            InitializeComponent();
            vm = new SignUpVM();
            DataContext = vm;
        }

        private void uname_TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (vm.Username == "Ex: abc2021")
            {
                uname_TextBox.Text = string.Empty;
            }
     
            

        }

        private void pwd_TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (vm.Password == "Type your password here...")
            {
                pwd_TextBox.Text = string.Empty;
            }
        }

        private void email_TextBox_GotFocus(object sender, RoutedEventArgs e)
        {

            if (vm.Email == "Ex: yourname@gmail.com")
            {
                email_TextBox.Text = string.Empty;
            }
        }
    }
}
