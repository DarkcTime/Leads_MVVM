using Leads_MVVM.ViewModel.HelperViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace Leads_MVVM.ViewModel
{
    class MainMenuViewModel : ViewModelProp
    {
        public ICommand Calls { get; set; }
        public ICommand Exit { get; set; }

        private Page callsPage;

        private Page currentPage;
        public Page CurrentPage
        {
            get => currentPage;
            set
            {
                currentPage = value;
                OnPropertyChanged();
            }
        }

        public MainMenuViewModel()
        {
            
            Calls = new Command(CallsCommand);
        }

        private void CallsCommand(object obj)
        {
            callsPage = new View.Pages.Calls();

            CurrentPage = callsPage;
        }
    }
}
