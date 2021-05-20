using ClassStorage;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CosmeticWPF
{
    public class ViewModel : INotifyPropertyChanged
    {
        Model model = null;
        private string serviceType;

        public string ServiceTypeStr
        {
            get { return serviceType; }
            set 
            { 
                serviceType = value;
                OnPropertyChanged();
            }
        }

        private Cosmetic selectedCosmetic = new CosmeticUsingRarely("",0,0,new TimeSpan(),ServiceTypes.FACECARE);

        public Cosmetic SelectedCosmetic
        {
            get
            {
                return selectedCosmetic;
            }
            set
            {
                selectedCosmetic = value;
                OnPropertyChanged();
            }
        }
        private ICollection<Cosmetic> cosmetics = new ObservableCollection<Cosmetic>();
        public IEnumerable<Cosmetic> Cosmetics => cosmetics;

        private readonly ICommand showAllCommand;
        private readonly ICommand showOrderCommand;
        private readonly ICommand findCommand;

        public ViewModel()
        {
            model = new Model();

            showAllCommand = new DelegateCommand(ShowAllCosmetics);
            showOrderCommand = new DelegateCommand(ShowOrderCosmetics);
            findCommand = new DelegateCommand(FindCosmetics);

            foreach (var item in model.GetAllCosmetics())
            {
                cosmetics.Add(item);
            }
        }

        public ICommand ShowAllCommand => showAllCommand;
        public ICommand ShowOrderCommand => showOrderCommand;
        public ICommand FindCommand => findCommand;


        void ShowAllCosmetics()
        {
            cosmetics.Clear();
            foreach (var item in model.GetAllCosmetics())
            {
                cosmetics.Add(item);
            }
        }

        void ShowOrderCosmetics()
        {
            cosmetics.Clear();
            foreach (var item in model.GetCosmeticsToOrder())
            {
                cosmetics.Add(item);
            }
        }

        void FindCosmetics()
        {
            try
            {
                ServiceTypes type = (ServiceTypes)Enum.Parse(typeof(ServiceTypes), ServiceTypeStr);
                cosmetics.Clear();
                foreach (var item in model.GetCosmeticsByServiceType(type))
                {
                    cosmetics.Add(item);
                }
            }
            catch
            {

            }
        }



        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
