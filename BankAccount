using System;
using System.Collections.Generic;


namespace classes{
    class BankAccount{

        public int bankNumber;
        public long moneyAmount;
        private List<string> ownerNames = new List<string>();

        //Constructor
        public BankAccount(int abankNumber, long amoneyAmount, List<string> aownerNames){
            bankNumber = abankNumber;
            moneyAmount = amoneyAmount;
            ownerNames = aownerNames;
        }

        //Retrieve Balance Method
        public long bankBalance(){
            return moneyAmount;
        }


        //Accept Deposits
        public void bankDeposit(long Deposit){
            moneyAmount += Deposit;
            Console.WriteLine($"Current Balance is: {moneyAmount}");
        }

        //Withdrawls
        public void bankWithdrawals(long Withdrawl){
            if(Withdrawl > moneyAmount){
                Console.WriteLine("Insufficent funds. Try Again.");
            return;
            }
            moneyAmount = moneyAmount - Withdrawl;
            Console.WriteLine($"Current Balance is: {moneyAmount}.");
        }

        public void printOwners(){
            Console.WriteLine("\nOwners are: ");
            int i = 1;
            foreach(string name in ownerNames){
                Console.WriteLine($"{i} {name}");
                i++;
            }
        }
    }
}
