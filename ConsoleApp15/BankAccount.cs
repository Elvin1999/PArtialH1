using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
   public partial class BankAccount
    {
        public int Id { get; set; }
        public string BankName { get; set; }
        public double Money { get; set; } = 1000;

        partial void UpdateAccount();
        partial void TransferMoney(int money);

    }
}
