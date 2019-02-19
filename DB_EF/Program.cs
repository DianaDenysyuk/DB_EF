using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_EF
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MarketModel db = new MarketModel())
            {
                var res = db.Users.Count().ToString();
                Debug.WriteLine(res);
            }
        }
    }
}
