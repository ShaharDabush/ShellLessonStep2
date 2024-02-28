using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ShellLessonStep2.Models;
using ShellLessonStep2.Services;
using System.Collections.ObjectModel;


namespace ShellLessonStep2.ViewModels
{

    public class AnimalViewModel: INotifyPropertyChanged
    {
        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion


        private ObservableCollection<Animal> dogs;
        private ObservableCollection<Animal> cats;
        private ObservableCollection<Animal> bears;
        private ObservableCollection<Animal> monkeys;
        private ObservableCollection<Animal> elephants;
        private string name;

        public ObservableCollection<Animal> Dogs
        {
            get { return this.dogs; }
            set
            {
                this.dogs = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<Animal> Cats
        {
            get { return this.cats; }
            set
            {
                this.cats = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<Animal> Bears
        {
            get { return this.bears; }
            set
            {
                this.bears = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<Animal> Monkeys
        {
            get { return this.monkeys; }
            set
            {
                this.monkeys = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<Animal> Elephants
        {
            get { return this.elephants; }
            set
            {
                this.elephants = value;
                OnPropertyChanged();
            }
        }

        private AnimalService animalService;
        public AnimalViewModel()
        {
            animalService = new AnimalService();
            List<Animal> list;

            list  = animalService.GetCats().ToList();
            this.cats = new ObservableCollection<Animal>(list);

            list = animalService.GetDogs().ToList();
            this.dogs = new ObservableCollection<Animal>(list);

            list = animalService.GetMonkeys().ToList();
            this.monkeys = new ObservableCollection<Animal>(list);

            list = animalService.GetBears().ToList();
            this.bears = new ObservableCollection<Animal>(list);

            list = animalService.GetElephants().ToList();
            this.elephants = new ObservableCollection<Animal>(list);
        }



        public string Name
        {
            get { return this.name; }
            set
            {
                this.name = value;
                OnPropertyChanged();
            }
        }
        private string location;
        public string Location
        {
            get { return this.location; }
            set
            {
                this.location = value;
                OnPropertyChanged();
            }
        }

        private string imageUrl;
        public string ImageUrl
        {
            get { return this.imageUrl; }
            set
            {
                this.imageUrl = value;
                OnPropertyChanged();
            }
        }
        private Object selectedAnimal;
        public Object SelectedAnimal
        {
            get
            {
                return this.selectedAnimal;
            }
            set
            {
                this.selectedAnimal = value;
                OnPropertyChanged();
            }
        }

        public ICommand SingleSelectCommand => new Command(OnSingleSelectMonkey);

        async void OnSingleSelectMonkey()
        {
            if (SelectedAnimal != null)
            {
                var navParam = new Dictionary<string, object>()
                {
                    { "selectedAnimal",SelectedAnimal }
                };
                await Shell.Current.GoToAsync($"Details", navParam);
                SelectedAnimal = null;
            }
        }
    }
}
