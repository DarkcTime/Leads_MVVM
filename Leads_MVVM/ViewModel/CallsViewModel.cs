using Leads_MVVM.Model;
using Leads_MVVM.ViewModel.HelperViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Leads_MVVM.ViewModel
{
    class CallsViewModel
    {
        LeadsEntities context = new LeadsEntities();

        public List<Лиды> CallsList;

        public static Пользователи User { get; set; }

        public ICommand Remove { get; set; }
        public ICommand Modify { get; set; }    
        public ICommand Add { get; set; }

        public CallsViewModel()
        {
            CallsList = context.Лиды.ToList();
            

            Remove = new HelperViewModel.Command(RemoveCommand);
            Modify = new Command(ModifyCommand);
            Add = new Command(AddCommand);
        }

        private void AddCommand(object obj)
        {

        }

        private void ModifyCommand(object obj)
        {
            
        }

        private void RemoveCommand(object obj)
        {
            MessageBox.Show("Работает");
        }
    }
}
