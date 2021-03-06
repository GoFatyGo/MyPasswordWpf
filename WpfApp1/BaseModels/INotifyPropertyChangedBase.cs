using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfApp01.BaseModels
{
    /// <summary>
    /// Базовый класс для моделей к которым будет осущесвляться привязка
    /// </summary>
    public abstract class INotifyPropertyChangedBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        // This method is called by the Set accessor of each property.
        // The CallerMemberName attribute that is applied to the optional propertyName
        // parameter causes the property name of the caller to be substituted as an argument.
        protected void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}

