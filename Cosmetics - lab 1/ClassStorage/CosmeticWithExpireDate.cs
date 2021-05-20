using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStorage
{
    public class CosmeticWithExpireDate : Cosmetic
    {
        private DateTime expireDate;

        public DateTime ExpireDate
        {
            get { return expireDate; }
            set { expireDate = value; }
        }

        public CosmeticWithExpireDate(string name, decimal price, int count, TimeSpan receiveTime, ServiceTypes serviceType, DateTime expireDate)
        : base(name, price, count, receiveTime, serviceType)
        {
            ExpireDate = expireDate;
        }
        public override string ToString()
        {
            return $"Name: {name}  Price: {price}  Count: {count}  Receive time: {receiveTime}  Service type: {serviceType}  Expire date: {expireDate}";
        }
    }
}
