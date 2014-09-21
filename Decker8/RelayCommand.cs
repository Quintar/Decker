using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Decker8
{
    public class RelayCommand : ICommand
    {
        public delegate void Exe(object parameter);
        private readonly Func<bool> canExecute;
        private readonly Exe execute;

        public RelayCommand(Exe execute)
            : this(execute, null)
        {
        }

        /// <exception cref="ArgumentNullException"><paramref name="execute" /> is <c>null</c>.</exception>
        public RelayCommand(Exe execute, Func<bool> canExecute)
        {
            if (execute == null)
            {
                throw new ArgumentNullException("execute");
            }

            this.execute = execute;
            this.canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged;

        public void RaiseCanExecuteChanged()
        {
            var handler = CanExecuteChanged;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }

        [DebuggerStepThrough]
        public bool CanExecute(object parameter)
        {
            return canExecute == null || canExecute();
        }

        public void Execute(object parameter)
        {
            execute(parameter);
        }
    }
}
