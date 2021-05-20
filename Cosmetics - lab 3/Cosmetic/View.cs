using ClassStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetic_
{
    public class View
    {
        public void ShowMessage(string message, bool isNewLine = true)
        {
            if(isNewLine)
                Console.WriteLine(message);
            else Console.Write(message);
        }

        public void ShowAllCosmetics(List<Cosmetic> cosmetics)
        {
            if(cosmetics.Count == 0)
            {
                Console.WriteLine("List is empty!");
                return;
            }
            Console.WriteLine($"{"Name",25} {"Price",7} {"Count",7} {"Receive time",15} {"Service type",20}     {"Expire date",20}");
            foreach (var item in cosmetics)
            {
                Console.Write($"{item.Name,25} {item.Price,5} {item.Count,7} {item.ReceiveTime,15} {item.ServiceType,20}");
                if (item is CosmeticWithExpireDate)
                    Console.Write($"{ (item as CosmeticWithExpireDate).ExpireDate,30}");
                Console.WriteLine();
            }
        }
    }
}
