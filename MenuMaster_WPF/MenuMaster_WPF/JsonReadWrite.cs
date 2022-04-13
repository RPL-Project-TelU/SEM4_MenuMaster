using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MenuMaster_WPF
{
    public class JsonReadWrite
    {
        public void WriteJson(Account_Json data)
        {
            string file = JsonConvert.SerializeObject(data, Formatting.Indented);
            System.IO.File.WriteAllText(@"D:\Programs\Universitas\semester_4\Proting\MenuMaster\SEM4_MenuMaster\MenuMaster_WPF\MenuMaster_WPF\Account.json", file);
            
        }
        public Account_Json ReadJson()
        {
            dynamic data = System.IO.File.ReadAllText(@"D:\Programs\Universitas\semester_4\Proting\MenuMaster\SEM4_MenuMaster\MenuMaster_WPF\MenuMaster_WPF\Account.json");
            Account_Json account = JsonConvert.DeserializeObject<Account_Json>(data);
            return account;
        }

    }
}
