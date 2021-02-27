using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CateringApp
{
    class SignUpVM : ObservableObject
    {

        public CommandHandler CreateAcc { get; private set; }
        public CommandHandler Google { get; private set; }
        public CommandHandler Login { get; private set; }

        private static string _username;
        public string Username
        {
            get
            {
                if (string.IsNullOrEmpty(_username))
                {
                    return "Ex: abc2021";
                }
                return _username;
            }
            set
            {
            
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }

        private static string _email;
        public string Email
        {
            get
            {
                if (string.IsNullOrEmpty(_email))
                {
                    return "Ex: yourname@gmail.com";
                }
                return _email;
            }
            set
            {

                _email = value;
                OnPropertyChanged(nameof(Username));
            }
        }

        private static string _password;
        public string Password
        {
            get
            {
                if (string.IsNullOrEmpty(_password))
                {
                    return "Type your password here...";
                }
                return _password;
            }
            set
            {

                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }
        public SignUpVM()
        {
            Login = new CommandHandler(openLoginPage);
        }

       

        private void openLoginPage()
        {
            MainWindow.Frame.Content = new LoginPage();
        }

    }
}
