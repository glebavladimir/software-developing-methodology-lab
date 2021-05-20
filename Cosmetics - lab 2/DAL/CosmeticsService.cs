using ClassStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CosmeticsService
    {
        private List<Cosmetic> cosmetics = null;
        public CosmeticsService()
        {
            cosmetics = CosmeticsDataFiller.GetCosmetics();
        }

        public List<Cosmetic> GetAllCosmetics()
        {
            return cosmetics;
        }
        public void AddCosmetic(Cosmetic cosmetic)
        {
            if (cosmetic == null) return;
            cosmetics.Add(cosmetic);
        }
    }
}
