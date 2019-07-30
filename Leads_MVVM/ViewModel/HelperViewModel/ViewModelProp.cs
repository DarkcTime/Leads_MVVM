using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Leads_MVVM.ViewModel.HelperViewModel
{
    /// <summary>
    /// Класс содержаший в себе шаблон для использования интерфейса INotifyPropertyChanged
    /// </summary>

    class ViewModelProp : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Выполняет проверку на null свойства PropertyChanged
        /// </summary>
        /// <param name="prop">Имя свойства прописываемое автоматически</param>

        protected void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        /// <summary>
        /// Универсальный метод для присвоения свойству интерфейса PropertyChanged 
        /// </summary>
        /// <typeparam name="T">Универсальный шаблон для типа</typeparam>
        /// <param name="field">Значение переменной</param>
        /// <param name="value">Значение переменной после изменения свойства</param>
        /// <param name="prop">Имя свойства прописываемое автоматически</param>
        /// <returns></returns>

        
    }
}
