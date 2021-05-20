using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStorage
{
    public abstract class Cosmetic
    {
        protected string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        protected decimal price;

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        protected int count;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        protected TimeSpan receiveTime;

        public TimeSpan ReceiveTime
        {
            get { return receiveTime; }
            set { receiveTime = value; }
        }

        protected ServiceTypes serviceType;

        public ServiceTypes ServiceType
        {
            get { return serviceType; }
            set { serviceType = value; }
        }

        public Cosmetic(string name, decimal price, int count, TimeSpan receiveTime, ServiceTypes serviceType)
        {
            Name = name;
            Price = price;
            Count = count;
            ReceiveTime = receiveTime;
            ServiceType = serviceType;
        }


    }
}
