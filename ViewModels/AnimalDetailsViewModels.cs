using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShellLessonStep2.Models;
using ShellLessonStep2.Services;

namespace ShellLessonStep2.ViewModels
{
    [QueryProperty(nameof(SelectedAnimal), "selectedAnimal")]
    public class AnimalDetailsViewModels: INotifyPropertyChanged
    {
        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        private Animal selectedAnimal;
        public Animal SelectedAnimal
        {
            get { return selectedAnimal; }
            set
            {
                this.selectedAnimal = value;
                OnPropertyChanged();
            }
        }
      

    }
}
