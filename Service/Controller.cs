using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Service
{
    internal class Controller
    {
        public static List<Good> Goods = new List<Good>();

        public void AddGood(string name, float price, float sale, string description)
        {
            Good good = new Good()
            {
                Name = name,
                Price = price,
                Sale = sale,
                Description = description,
            };

            Goods.Add(good);
        }

        public string GetGoods()
        {
            string wording = "";

            foreach (var item in Goods)
            {
                wording += $"{item.Name} цена - {item.Price}\n";
            }
            return wording;
        }

        public void SaveList()
        {
            var json = JsonSerializer.Serialize<List<Good>>(Goods);

            File.WriteAllText("db.json", json);
        }

        public void OpenList()
        {
            if (!File.Exists("db.json"))
                return;

            var json = File.ReadAllText("db.json");

            Goods = JsonSerializer.Deserialize<List<Good>>(json);
        }
    }
}
