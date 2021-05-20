using ClassStorage;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetic_
{
    public class Model
    {
        CosmeticsService cs = null;

        public Model()
        {
            cs = new CosmeticsService();
        }

        public List<Cosmetic> GetCosmeticsToOrder()
        {
            List<Cosmetic> cosmeticsToOrder = new List<Cosmetic>();
            int minCount = 5;
            foreach (var item in cs.GetAllCosmetics())
            {
                if (item.Count < minCount)
                {
                    cosmeticsToOrder.Add(item);
                }
                else if (item is CosmeticWithExpireDate)
                {
                    if (DateTime.Now.Add(item.ReceiveTime) > (item as CosmeticWithExpireDate).ExpireDate)
                    {
                        cosmeticsToOrder.Add(item);
                    }
                }
            }
            return cosmeticsToOrder;
        }

        public List<Cosmetic> GetAllCosmetics()
        {
            return cs.GetAllCosmetics();
        }

        public List<Cosmetic> GetCosmeticsByServiceType(ServiceTypes serviceType)
        {
            return cs.GetAllCosmetics().Where(c => c.ServiceType == serviceType).ToList();
        }

        public void AddCosmetic(Cosmetic cosmetic)
        {
            cs.AddCosmetic(cosmetic);
        }
    }
}
