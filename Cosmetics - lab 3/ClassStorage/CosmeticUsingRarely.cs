using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStorage
{
    public class CosmeticUsingRarely : Cosmetic
    {
        public CosmeticUsingRarely(string name, decimal price, int count, TimeSpan receiveTime, ServiceTypes serviceType)
        : base(name, price, count, receiveTime, serviceType)
        {
            
        }

        public override string ToString()
        {
            return $"Name: {name}  Price: {price}  Count: {count}  Receive time: {receiveTime}  Service type: {serviceType}";
        }
    }
}
