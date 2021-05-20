using ClassStorage;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetic_
{
    public class CosmeticViewModel
    {
        View view = null;
        Model model = null;

        public CosmeticViewModel()
        {
            view = new View();
            model = new Model();
        }

        public void Execute()
        {
            string selector;
            do
            {
                view.ShowMessage("" +
                    "[1] - Find cosmetics by service type\n" +
                    "[2] - Add cosmetic\n" +
                    "[3] - View all cosmetics\n" +
                    "[4] - View cosmetics to order\n" +
                    "[E]xit");
                view.ShowMessage("Enter your choise: ", false);
                selector = DataReader.ReadString();
                switch (selector)
                {
                    case "1":
                        FindCosmeticByServiceType();
                        break;
                    case "2":
                        model.AddCosmetic(CreateCosmetic());
                        break;
                    case "3":
                        view.ShowAllCosmetics(model.GetAllCosmetics());
                        break;
                    case "4":
                        view.ShowAllCosmetics(model.GetCosmeticsToOrder());
                        break;
                    case "E":
                    case "e":
                        view.ShowMessage("Closing...");
                        return;
                    default:
                        view.ShowMessage("You`ve chosen wrong menu item!");
                        break;
                }
            } while (true);
        }

        public void FindCosmeticByServiceType()
        {
            string selector;
            int i = 0;
            ServiceTypes st = ServiceTypes.SKINCARE;
            bool isCorrect = true;

            do
            {

                view.ShowMessage("\tChoose cosmetic type");
                foreach (var item in Enum.GetValues(typeof(ServiceTypes)))
                {
                    view.ShowMessage($"{++i}. {item}");
                }
                view.ShowMessage("Enter your choise: ", false);
                selector = DataReader.ReadString();
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
                        view.ShowMessage("Wrong type number!");
                        isCorrect = false;
                        break;
                }
            } while (!isCorrect);
            var list = model.GetCosmeticsByServiceType(st);
            
            if (list.Count == 0)
            {
                view.ShowMessage($"There is no cosmetics having {st} type");
                return;
            }

            view.ShowAllCosmetics(list);
        }

        public Cosmetic CreateCosmetic()
        {
            bool isCosmeticWithExpDate = false;
            view.ShowMessage("[1] - Cosmetic with expire date\n" +
               "[2] - Cosmetic that uses rarely");
            view.ShowMessage("Choose cosmetic type to add: ", false);
            if (DataReader.ReadString() == "1")
            {
                isCosmeticWithExpDate = true;
            }

            view.ShowMessage("Enter cosmetic name: ", false);
            string name = DataReader.ReadString();;
            decimal price = 0;
            string priceStr;
            do
            {
                view.ShowMessage("Enter cosmetic price: ", false);
                priceStr = DataReader.ReadString();
                if (!decimal.TryParse(priceStr, out price) || price < 0)
                {
                    view.ShowMessage("You have entered wrong price type!");
                }
                else break;
            } while (true);
            int count = 0;
            string countStr;
            do
            {
                view.ShowMessage($"Enter {name} count: ", false);
                countStr = DataReader.ReadString();;
                if (!int.TryParse(countStr, out count) || count < 0)
                {
                    view.ShowMessage("You have entered wrong count type!");
                }
                else break;
            } while (true);

            int days = 0;
            int hours = 0;
            int minutes = 0;

            string tempStr;

            view.ShowMessage($"\tEnter time to receive {name}");
            do
            {
                view.ShowMessage("Enter days: ", false);
                tempStr = DataReader.ReadString();
                if (!int.TryParse(tempStr, out days) || days < 0 || days > 365)
                {
                    view.ShowMessage("Wrong days value!");
                }
                else break;
            } while (true);

            do
            {
                view.ShowMessage("Enter hours: ", false);
                tempStr = DataReader.ReadString();
                if (!int.TryParse(tempStr, out hours) || hours < 0 || hours > 24)
                {
                    view.ShowMessage("Wrong hours value!");
                }
                else break;
            } while (true);

            do
            {
                view.ShowMessage("Enter minutes: ", false);
                tempStr = DataReader.ReadString();
                if (!int.TryParse(tempStr, out minutes) || minutes < 0 || minutes > 60)
                {
                    view.ShowMessage("Wrong minutes value!");
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
                view.ShowMessage("\tChoose cosmetic type");
                foreach (var item in Enum.GetValues(typeof(ServiceTypes)))
                {
                    view.ShowMessage($"{++i}. {item}");
                }
                view.ShowMessage("Enter your choise: ", false);
                selector = DataReader.ReadString();;
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
                        view.ShowMessage("Wrong type number!");
                        isCorrect = false;
                        break;
                }
            } while (!isCorrect);

            if (isCosmeticWithExpDate)
            {
                int year = 0;
                int month = 0;
                int day = 0;
                view.ShowMessage("\tEnter expire date: ");
                do
                {
                    view.ShowMessage("Enter year: ", false);
                    tempStr = DataReader.ReadString();;
                    if (!int.TryParse(tempStr, out year) || year < 2000 || year > 3000)
                    {
                        view.ShowMessage("Wrong year value!");
                    }
                    else break;
                } while (true);

                do
                {
                    view.ShowMessage("Enter month: ", false);
                    tempStr = DataReader.ReadString();;
                    if (!int.TryParse(tempStr, out month) || month < 1 || month > 12)
                    {
                        view.ShowMessage("Wrong month value!");
                    }
                    else break;
                } while (true);

                do
                {
                    view.ShowMessage("Enter day: ", false);
                    tempStr = DataReader.ReadString();;
                    if (!int.TryParse(tempStr, out day) || day < 1 || day > 30)
                    {
                        view.ShowMessage("Wrong day value!");
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
