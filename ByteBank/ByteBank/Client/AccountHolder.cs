using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Client
{
    public class AccountHolder
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public string Profession { get; set; }
        public static int TotalClients { get; set; }

        public AccountHolder()
        {
            TotalClients++;
        }
    }
}
