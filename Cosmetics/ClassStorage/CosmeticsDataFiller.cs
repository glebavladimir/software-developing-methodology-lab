using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStorage
{
    public static class CosmeticsDataFiller
    {
        public static List<Cosmetic> GetCosmetics()
        {
            List<Cosmetic> cosmetics = new List<Cosmetic>();


            cosmetics.Add(new CosmeticUsingRarely("Oxygenation Cream", 80, 20, new TimeSpan(3, 2, 30, 0, 0), ServiceTypes.SKINCARE));
            cosmetics.Add(new CosmeticUsingRarely("Enzyme Peel", 58, 32, new TimeSpan(1, 2, 50, 0, 0), ServiceTypes.SKINCARE));
            cosmetics.Add(new CosmeticUsingRarely("Healing Clay", 15, 60, new TimeSpan(7, 6, 0, 0, 0), ServiceTypes.SKINCARE));


            cosmetics.Add(new CosmeticWithExpireDate("Acne gel treatment", 28, 14, new TimeSpan(4, 3, 40, 0, 0), ServiceTypes.TREATMENT, new DateTime(2022, 12, 30)));
            cosmetics.Add(new CosmeticWithExpireDate("Acne spot treatment", 9, 3, new TimeSpan(14, 18, 20, 0, 0), ServiceTypes.TREATMENT, new DateTime(2021, 08, 08)));
            cosmetics.Add(new CosmeticWithExpireDate("Power D treatment Drops", 185, 2, new TimeSpan(5, 13, 50, 0, 0), ServiceTypes.TREATMENT, new DateTime(2021, 10, 10)));


            cosmetics.Add(new CosmeticWithExpireDate("Smoothing shampoo", 52, 8, new TimeSpan(2, 15, 50, 0, 0), ServiceTypes.HAIRCARE, new DateTime(2021, 06, 20)));
            cosmetics.Add(new CosmeticUsingRarely("Deep conditioner", 40, 2, new TimeSpan(1, 10, 30, 0, 0), ServiceTypes.HAIRCARE));
            cosmetics.Add(new CosmeticWithExpireDate("Hair oil", 69, 5, new TimeSpan(5, 4, 0, 0, 0), ServiceTypes.HAIRCARE, new DateTime(2021, 05, 20)));


            cosmetics.Add(new CosmeticWithExpireDate("BB Cream", 80, 43, new TimeSpan(2, 10, 0, 0, 0), ServiceTypes.FACECARE, new DateTime(2021, 06, 20)));
            cosmetics.Add(new CosmeticWithExpireDate("Highlighter", 130, 18, new TimeSpan(1, 4, 0, 0, 0), ServiceTypes.FACECARE, new DateTime(2022, 05, 25)));
            cosmetics.Add(new CosmeticUsingRarely("Blush", 49, 29, new TimeSpan(3, 15, 20, 0, 0), ServiceTypes.FACECARE));


            cosmetics.Add(new CosmeticUsingRarely("Cotton swabs", 80, 20, new TimeSpan(3, 2, 30, 0, 0), ServiceTypes.PERSONALCARE));
            cosmetics.Add(new CosmeticUsingRarely("Nail files", 58, 32, new TimeSpan(1, 2, 50, 0, 0), ServiceTypes.PERSONALCARE));
            cosmetics.Add(new CosmeticUsingRarely("Hair clippers", 15, 60, new TimeSpan(7, 6, 0, 0, 0), ServiceTypes.PERSONALCARE));


            return cosmetics;
        }
    }
}
