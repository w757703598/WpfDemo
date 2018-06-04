﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM
{
    public class QueryCommand : ICommand
    {
        private Action _execute;
        private Func<bool> _canExecute;

        public QueryCommand(Action execute)
            : this(execute, null)
        {

        }
        public QueryCommand(Action excute, Func<bool> canExecute)
        {
            if (excute == null)
            {
                throw new ArgumentNullException("excute");
            }
            _execute = excute;
            _canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                if (_canExecute != null)
                {
                    CommandManager.RequerySuggested += value;
                }
            }
            remove
            {
                if (_canExecute != null)
                {
                    CommandManager.RequerySuggested -= value;
                }
            }
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute();
        }
        public void Execute(object parameter)
        {
            _execute();
        }
    }
}
