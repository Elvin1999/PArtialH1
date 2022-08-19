using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public partial class BankAccount
    {
        public BankAccount(int id,string name,double money)
        {
            Id = id;
            BankName = name;
            Money = money;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"ID : {Id}");
            Console.WriteLine($"Bank Name : {BankName}");
            Console.WriteLine($"Money : {Money}$");
        }

        partial void TransferMoney(int money)
        {
            Money += money;
        }
        partial void UpdateAccount()
        {
            Console.WriteLine("Your account updated successfully");
        }

        public void CallTransferMoney(int money)
        {
            TransferMoney(money);
        }

        public void CallUpdateAccount()
        {
            UpdateAccount();
        }
    }
}
