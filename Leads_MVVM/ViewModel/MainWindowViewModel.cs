using Leads_MVVM.Model;
using Leads_MVVM.ViewModel.HelperViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using static System.Net.Mime.MediaTypeNames;

namespace Leads_MVVM.ViewModel
{
    class MainWindowViewModel : ViewModelProp
    {
        LeadsEntities context = new LeadsEntities();

        private  string login, password; 

        public string Login
        {
            get => login;
            set
            {
                login = value;
                OnPropertyChanged();
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
                OnPropertyChanged();

            }
        }
        
        public Window MainWindowView { get; set; }
        private Window MainMenuView { get; set; } 

        public ICommand Enter { get; set; }
        public ICommand Exit { get; set; }

        public MainWindowViewModel()
        {
            
            MainMenuView = new View.MainMenu();
            Enter = new Command(EnterCommand, CanEnterCommand);
            Exit = new Command(ExitCommand);
        }

        private bool CanEnterCommand(object arg)
        {
            return arg as string != null;
        }

        private void EnterCommand(object obj)
        {          
            //TODO реализовать привязку кнопки к обоим полям 
            var _user = context.Пользователи.Where(c => c.Логин == Login && c.Пароль == Password);
            if (_user.Count() != 0)
            {
                _user.FirstOrDefault();
                MessageBox.Show("Пользователь успешно авторизировался");
                MainMenuView?.Show();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
                        
        }

        private void ExitCommand(object obj)
        {
            //TODO найти решение позже 


            MessageBox.Show("Я реализую это");
        }

    }
}
