using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassStorage
{
    public abstract class Cosmetic : INotifyPropertyChanged
    {
        protected string name;

        public string Name
        {
            get { return name; }
            set 
            { 
                name = value; 
                OnPropertyChanged();
            }
        }

        protected decimal price;

        public decimal Price
        {
            get { return price; }
            set 
            {
                price = value;
                OnPropertyChanged();
            }
        }

        protected int count;

        public int Count
        {
            get { return count; }
            set 
            {
                OnPropertyChanged(); 
                count = value; 
            }
        }

        protected TimeSpan receiveTime;

        public TimeSpan ReceiveTime
        {
            get { return receiveTime; }
            set 
            {
                receiveTime = value;
                OnPropertyChanged();
            }
        }

        protected ServiceTypes serviceType;

        public ServiceTypes ServiceType
        {
            get { return serviceType; }
            set 
            { 
                serviceType = value;
                OnPropertyChanged();
            }
        }

        public Cosmetic(string name, decimal price, int count, TimeSpan receiveTime, ServiceTypes serviceType)
        {
            Name = name;
            Price = price;
            Count = count;
            ReceiveTime = receiveTime;
            ServiceType = serviceType;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
