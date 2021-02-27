using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CateringApp
{
    class SignUpVM
    {
       
        public CommandHandler CreateAcc { get; private set; }
        public CommandHandler Google { get; private set; }
        public CommandHandler Login { get; private set; }

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
