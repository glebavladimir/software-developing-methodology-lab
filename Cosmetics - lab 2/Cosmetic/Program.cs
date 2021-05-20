using ClassStorage;
using DAL;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetic_
{
    class Program
    {
        static void Main(string[] args)
        {
            CosmeticsService cs = new CosmeticsService();
            string selector;
            do
            {
                Console.WriteLine("" +
                    "[1] - Find cosmetics by service type\n" +
                    "[2] - Add cosmetic\n" +
                    "[3] - View all cosmetics\n" +
                    "[4] - View cosmetics to order\n" +
                    "[E]xit");
                Console.Write("Enter your choise: ");
                selector = Console.ReadLine();
                switch (selector)
                {
                    case "1":
                        FindCosmeticByServiceType(cs.GetAllCosmetics());
                        break;
                    case "2":
                        cs.AddCosmetic(FillCosmetic());
                        break;
                    case "3":
                        ShowAllCosmetics(cs.GetAllCosmetics());
                        break;
                    case "4":
                        ViewCosmeticsToOrder(cs.GetAllCosmetics());
                        break;

                    case "E":
                    case "e":
                        Console.WriteLine("Closing...");
                        return;
                    default:
                        Console.WriteLine("You`ve chosen wrong menu type!");
                        break;
                }
            } while (true);
        }

        private static void ViewCosmeticsToOrder(List<Cosmetic> cosmetics)
        {
            int minCount = 5;
            bool wasFound = false;
            foreach (var item in cosmetics)
            {
                if(item.Count < minCount)
                {
                    Console.WriteLine($"{item.Name} has to be ordered as it has low count of goods ({item.Count} items)");
                    wasFound = true;
                }
                else if(item is CosmeticWithExpireDate)
                {
                    if(DateTime.Now.Add(item.ReceiveTime) > (item as CosmeticWithExpireDate).ExpireDate)
                    {
                        Console.WriteLine($"{item.Name} has to be ordered as it has expire date at {(item as CosmeticWithExpireDate).ExpireDate} and will receive in {item.ReceiveTime}");
                    }
                    wasFound = true;
                }
            }
            if(!wasFound)
            {
                Console.WriteLine("All the cosmetics is in good condition!");
            }
        }

        static void ShowAllCosmetics(List<Cosmetic> cosmetics)
        {
            Console.WriteLine($"{"Name",25} {"Price",7} {"Count",7} {"Receive time",15} {"Service type",20}     {"Expire date",20}");
            foreach (var item in cosmetics)
            {
                Console.Write($"{item.Name,25} {item.Price,5} {item.Count,7} {item.ReceiveTime,15} {item.ServiceType,20}");
                if (item is CosmeticWithExpireDate)
                    Console.Write($"{ (item as CosmeticWithExpireDate).ExpireDate,30}");
                Console.WriteLine();
            }
        }

        static void FindCosmeticByServiceType(List<Cosmetic> cosmetics)
        {
            string selector;
            int i = 0;
            ServiceTypes st = ServiceTypes.SKINCARE;
            bool isCorrect = true;

            do
            {

                Console.WriteLine("\tChoose cosmetic type");
                foreach (var item in Enum.GetValues(typeof(ServiceTypes)))
                {
                    Console.WriteLine($"{++i}. {item}");
                }
                Console.Write("Enter your choise: ");
                selector = Console.ReadLine();
                isCorrect = true;
                switch (selector)
                {
                    case "1":
                        st = ServiceTypes.SKINCARE;
                        break;
                    case "2":
                        st = ServiceTypes.HAIRCARE;
                        break;
                    case "3":
                        st = ServiceTypes.FACECARE;
                        break;
                    case "4":
                        st = ServiceTypes.TREATMENT;
                        break;
                    case "5":
                        st = ServiceTypes.PERSONALCARE;
                        break;
                    default:
                        Console.WriteLine("Wrong type number!");
                        isCorrect = false;
                        break;
                }
            } while (!isCorrect);
            bool wasFound = false;
            foreach (var item in cosmetics)
            {
                if (item.ServiceType == st)
                {
                    Console.WriteLine(item);
                    wasFound = true;
                }
            }
            if (!wasFound)
            {
                Console.WriteLine($"There is no cosmetics having {st} type");
            }

        }

        static Cosmetic FillCosmetic()
        {
            bool isCosmeticWithExpDate = false;
            Console.WriteLine("[1] - Cosmetic with expire date\n" +
               "[2] - Cosmetic that uses rarely");
            Console.Write("Choose cosmetic type to add: ");
            if (Console.ReadLine() == "1")
            {
                isCosmeticWithExpDate = true;
            }

            Console.Write("Enter cosmetic name: ");
            string name = Console.ReadLine();
            decimal price = 0;
            string priceStr;
            do
            {
                Console.Write("Enter cosmetic price: ");
                priceStr = Console.ReadLine();
                if (!decimal.TryParse(priceStr, out price) || price < 0)
                {
                    Console.WriteLine("You have entered wrong price type!");
                }
                else break;
            } while (true);
            int count = 0;
            string countStr;
            do
            {
                Console.Write($"Enter {name} count: ");
                countStr = Console.ReadLine();
                if (!int.TryParse(countStr, out count) || count < 0)
                {
                    Console.WriteLine("You have entered wrong count type!");
                }
                else break;
            } while (true);

            int days = 0;
            int hours = 0;
            int minutes = 0;

            string tempStr;

            Console.WriteLine($"\tEnter time to receive {name}");
            do
            {
                Console.Write("Enter days: ");
                tempStr = Console.ReadLine();
                if (!int.TryParse(tempStr, out days) || days < 0 || days > 365)
                {
                    Console.WriteLine("Wrong days value!");
                }
                else break;
            } while (true);

            do
            {
                Console.Write("Enter hours: ");
                tempStr = Console.ReadLine();
                if (!int.TryParse(tempStr, out hours) || hours < 0 || hours > 24)
                {
                    Console.WriteLine("Wrong hours value!");
                }
                else break;
            } while (true);

            do
            {
                Console.Write("Enter minutes: ");
                tempStr = Console.ReadLine();
                if (!int.TryParse(tempStr, out minutes) || minutes < 0 || minutes > 60)
                {
                    Console.WriteLine("Wrong minutes value!");
                }
                else break;
            } while (true);

            TimeSpan ts = new TimeSpan(days, hours, minutes, 0);

            string selector;
            int i = 0;
            ServiceTypes st = ServiceTypes.SKINCARE;
            bool isCorrect = true;

            do
            {
                Console.WriteLine("\tChoose cosmetic type");
                foreach (var item in Enum.GetValues(typeof(ServiceTypes)))
                {
                    Console.WriteLine($"{++i}. {item}");
                }
                Console.Write("Enter your choise: ");
                selector = Console.ReadLine();
                isCorrect = true;
                switch (selector)
                {
                    case "1":
                        st = ServiceTypes.SKINCARE;
                        break;
                    case "2":
                        st = ServiceTypes.HAIRCARE;
                        break;
                    case "3":
                        st = ServiceTypes.FACECARE;
                        break;
                    case "4":
                        st = ServiceTypes.TREATMENT;
                        break;
                    case "5":
                        st = ServiceTypes.PERSONALCARE;
                        break;
                    default:
                        Console.WriteLine("Wrong type number!");
                        isCorrect = false;
                        break;
                }
            } while (!isCorrect);

            if (isCosmeticWithExpDate)
            {
                int year = 0;
                int month = 0;
                int day = 0;
                Console.WriteLine("\tEnter expire date: ");
                do
                {
                    Console.Write("Enter year: ");
                    tempStr = Console.ReadLine();
                    if (!int.TryParse(tempStr, out year) || year < 2000 || year > 3000)
                    {
                        Console.WriteLine("Wrong year value!");
                    }
                    else break;
                } while (true);

                do
                {
                    Console.Write("Enter month: ");
                    tempStr = Console.ReadLine();
                    if (!int.TryParse(tempStr, out month) || month < 1 || month > 12)
                    {
                        Console.WriteLine("Wrong month value!");
                    }
                    else break;
                } while (true);

                do
                {
                    Console.Write("Enter day: ");
                    tempStr = Console.ReadLine();
                    if (!int.TryParse(tempStr, out day) || day < 1 || day > 30)
                    {
                        Console.WriteLine("Wrong day value!");
                    }
                    else break;
                } while (true);

                DateTime expDate = new DateTime(year, month, day);
                return new CosmeticWithExpireDate(name, price, count, ts, st, expDate);
            }
            return new CosmeticUsingRarely(name, price, count, ts, st);
        }
    }
}
