using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Leads_MVVM.ViewModel.HelperViewModel
{
    /// <summary>
    /// Класс реализующий интерфейс ICommand, служит для упрощения привязки к кнопкам
    /// </summary>

    class Command : ICommand
    {
       /// <summary>
       /// Событие в котором реализовано поведение на добавление и удаление свойтва 
       /// </summary>

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }

        }

        readonly  Action<object> execute;
        readonly  Func<object, bool> canExecute;

        /// <summary>
        /// Констуруктов в который передаются входные параметры
        /// </summary>
        /// <param name="executeAction">Значение свойства Execute</param>
        /// <param name="canExecuteAction">Значение свойства canExecute</param>

        public Command(Action<object> executeAction, Func<object, bool> canExecuteFunc = null)
        {
            execute = executeAction;
            canExecute = canExecuteFunc; 
        }

        /// <summary>
        /// Определяет статус возможности нажатия на кнопку
        /// </summary>
        /// <param name="parameter">Имя параметра</param>
        /// <returns>Если canExecute = null, то true иначе присваивает canExecute значение параметра</returns>

        public bool CanExecute(object parameter)
        {
            if (canExecute != null) return canExecute(parameter);
            return true;
        }

        /// <summary>
        /// Метод определяющий поведение на нормальную работу кнопки
        /// </summary>
        /// <param name="parameter">имя свойства</param>
        /// 
        public void Execute(object parameter)
        {
            execute(parameter);
        }
    }
}
