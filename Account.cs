using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solve_task_8
{
    internal struct Account
    {
         int Account_ID {  get; set; }
         string Account_Holder { get; set; }

         double Balance { get; set; }
        

        public int ID
        {
            get { return Account_ID; }
            set { Account_ID = value; }
        }

        public string Holder
        {
            get { return Account_Holder; }
            set { Account_Holder = value; }
        }

        public  double balance
        {
            get { return Balance; }
            set { Balance = value; }
        }

        public Account(int id, string holder, double balance)
        { Account_ID = id; Account_Holder = holder; Balance = balance; }

        public override string ToString() =>
            $"Account#{Account_ID} | {Account_Holder} | Balance: ${Balance}";



    }
}
