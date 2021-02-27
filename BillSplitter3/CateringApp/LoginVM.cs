using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CateringApp
{
    class LoginVM
    {
        public CommandHandler BackBtn { get; private set; }
        public CommandHandler LoginBtn { get; private set; }
        public CommandHandler IssueBtn { get; private set; }
        
        public LoginVM()
        {
            BackBtn = new CommandHandler(back);
        }

        public void back()
        {
            MainWindow.Frame.Content = new SignUpPage();
        }
    }
}
