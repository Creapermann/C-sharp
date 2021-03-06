using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace QuizzGame.ViewModel.Commands.Login
{
    public class ToLoginWindowCommand : ICommand
    {
        public LoginVM vm { get; set; }

        public event EventHandler CanExecuteChanged;


        public ToLoginWindowCommand(LoginVM _vm)
        {
            vm = _vm;
        }


        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            vm.LoginVis = Visibility.Visible;
            vm.RegisterVis = Visibility.Collapsed;
            vm.ResetPasswordVis = Visibility.Collapsed;

            /*Sets the fields to empty, so they dont sustain*/
            vm.Email = string.Empty;
            vm.Firstname = string.Empty;
            vm.Lastname = string.Empty;
            vm.Password = string.Empty;
            vm.ConfirmPassword = string.Empty;
        }
    }
}
