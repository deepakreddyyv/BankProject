using System;

namespace BankProject
{
    class BankTest
    {
        public static void Main(String[] args)
        {
            Console.Write("Numbers of Accounts to create : ");
            int usersCount = int.Parse(Console.ReadLine());
            BankUsers users = new BankUsers(usersCount);
            string isDone;
            for(int i=0; i<usersCount; i++)
            {

                Console.WriteLine("Enter Account " + (i + 1) + " details");

                Console.Write("Name : ");
                string name = Console.ReadLine();
                Console.Write("Enter Account Type Savings/Current: ");
                string accType = Console.ReadLine();
                Console.Write("Enter amount to open a " + accType + " account : ");
                double amt = double.Parse(Console.ReadLine());

                bool status = users.createAccount(i, name, accType, amt);
                Console.WriteLine("Status : " + status);
                Console.Clear();

                users.viewAcc(i);
            }
            do
            {
                Console.WriteLine("1. Withdraw");
                Console.WriteLine("2. deposit");
                Console.WriteLine("3. Account Details");
                Console.WriteLine("4. View All Accounts");
                Console.WriteLine("5. Total Accounts");
                Console.WriteLine("6. exit");

                Console.Write("Enter Your Option : ");
                int option = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (option)
                {
                    case 1:
                        Console.Write("Enter Acc Num : ");
                        int accNum = int.Parse(Console.ReadLine());
                        if (users.getAccount(accNum) != null)
                        {
                            Console.Write("Enter Amount to Withdraw : ");
                            double amt = double.Parse(Console.ReadLine());
                            if (users.getAccount(accNum).Withdraw(amt) != -1)
                            {
                                users.viewBalance(accNum);
                            } else
                            {
                                Console.WriteLine("Insuffient Balance...");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid Acc Number");
                            break;
                        }
                        break;

                    case 2:
                        Console.Write("Enter Acc Num : ");
                        int accNum1 = int.Parse(Console.ReadLine());
                        if (users.getAccount(accNum1) != null)
                        {
                            Console.Write("Enter Amount to Deposit : ");
                            double amt = double.Parse(Console.ReadLine());
                            users.getAccount(accNum1).deposit(amt);
                            Console.WriteLine("Deposited Succesfully..");
                            users.viewBalance(accNum1);
                        }
                        else
                        {
                            Console.WriteLine("Invalid acc num..");
                            break;
                        }
                        break;
                    case 3:
                        Console.Write("Enter Acc Num : ");
                        int accnum2 = int.Parse(Console.ReadLine());
                        if (users.getAccount(accnum2) != null)
                        {
                            users.viewSpecifiedAcc(accnum2);
                        }
                        else
                        {
                            Console.WriteLine("Invalid Acc Num");
                            break;
                        }
                        break;
                    case 4: Console.Clear();
                            users.viewAllAccounts();
                        break;
                    case 5: Console.Clear();
                        Console.WriteLine(users.totalAccounts()+" Accounts");
                        break;
                    case 6:
                        Console.WriteLine("bye..");
                        Environment.Exit(0);
                        break;
                }
                Console.Write("Do you Want to Continue(Y/N) : ");
                isDone = Console.ReadLine();
                
            } while (isDone.ToLower() == "y");

        } 
    }
}

