using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CateringApp
{
    public class CommandHandler : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private Action _exe;
        public CommandHandler(Action exe)
        {
            _exe = exe;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _exe.Invoke();
        }
    }
}
