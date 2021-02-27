/* Class Practice
 * Created by: Cameron Brantley
 * Last Successful Debugging Date: 2/23/2021
 */

using System;
using System.Collections.Generic;

namespace classes {
    class Program{
        //Lists created for dynamic implementation. (For Futher usage)
        private static List<string> ownersList = new List<string>();
        private static List<int> bankNumbers = new List<int>();
        public static Random r = new Random();
        public static bool conRunning = true;

        //Creating Bank Number
        private static int bankingNum(){
            int generatedNum = r.Next(1000000000, 2000000000);
            foreach(int bNumber in bankNumbers){
                if(generatedNum == bankNumbers[bNumber]) return bankingNum();
            }
            bankNumbers.Add(generatedNum);
            return generatedNum;
        }

        //String Variance for user Input
        public static string userOwners(){
            bool userSanitized = false;
            string userLine = "";
            while(!userSanitized){
                try{
                    userLine = Console.ReadLine();
                    userSanitized = true;
                } catch (Exception e){
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }
            return userLine;
        }

        //Implicit Type Casting
        public static long userMoney(){
            bool userIntegrity = false;
            long userEnteredAmount = 0;
            while(!userIntegrity){
                try{
                    int convertedStr = Convert.ToInt32(Console.ReadLine());
                    userEnteredAmount = (long) convertedStr;
                    userIntegrity = true;
                } catch (Exception e){
                    Console.WriteLine("Invalid amount. Please try again.");
                }
            }
            return userEnteredAmount;
        }
        
        public static List<string> ownersInput(int num){
            Console.WriteLine("Please enter in the name(s): ");
            for(int i = 0; i < num; i++){
                ownersList.Add(Console.ReadLine());
            }
            return ownersList;
        }

        public static void promptDeposit(BankAccount bankObj){
            Console.WriteLine("How much would you like to deposit?");
            bankObj.bankDeposit(userMoney());
        }

        public static void promptWithdrawl(BankAccount bankObj){
            Console.WriteLine("How much would you like to Withdrawl?");
            bankObj.bankWithdrawals(userMoney());
        }

        public static void Main(string[] args){
            Console.WriteLine("Welcome to New Florida Banking Agency! Your account will be created for you.");
            Console.WriteLine("New Account Created. How much money to place into your account?");
            long enteredInitialDeposit = userMoney();

            Console.WriteLine("How many owners for this account?");
            ownersInput(Convert.ToInt32(Console.ReadLine()));

            //Testing purposes
            //Can be revised later to fit scalability
            BankAccount bank1 = new BankAccount(bankingNum(), enteredInitialDeposit, ownersList);
            bank1.printOwners();
            promptDeposit(bank1);
            promptWithdrawl(bank1);
            bank1.bankBalance();
        }
    }
}
