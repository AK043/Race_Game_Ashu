using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race_Game_Ashu
{
    public class details
    {
        public String Name { get; set; }
        public int Dog { get; set; }
        public int betAmount { get; set; }
        public int balance { get; set; }

        public details(String Name,int Dog,int Amount,int balance) {
            this.Name = Name;
            this.Dog = Dog;
            this.betAmount = Amount;
            this.balance = balance;
        }
        public int Playerbalance(int Winner) {
            if (Dog == Winner)
            {
                return (balance + betAmount);
            }
            else {
                return (balance - betAmount);
            }
        }

    }
}
