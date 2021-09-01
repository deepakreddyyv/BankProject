using System;
using System.Collections;


namespace BankProject
{
    class BankUsers
    {
        private int totalUsers;
        private Bank[] customers;
        private ArrayList AccountNumbers = new ArrayList();
        public BankUsers(int users)
        {
            this.totalUsers = users;
            customers = new Bank[users];
            for (int i = 0; i < users; i++) customers[i] = new Bank();
        }

        public bool createAccount(int index, string name, string accType, double amount)
        {
            customers[index].setAccNum();
            customers[index].setName(name);
            customers[index].setAccType(accType);
            customers[index].setBalance(amount);

            return true;
        }

        public void viewAcc(int index)
        {
            Console.WriteLine("Account Number : "+customers[index].getAccNum());
            Console.WriteLine("Name : " + customers[index].getName());
            Console.WriteLine("Account Type : " + customers[index].getAccType());
            Console.WriteLine("Balance : " + customers[index].getBalance());
        }

        public Bank getAccount(int accNum)
        {
            for(int i=0; i<totalUsers; i++)
            {
                if (customers[i].getAccNum() == accNum) return customers[i];
            }
            return null;
        }

        public void viewBalance(int accNum)
        {
            for(int i=0; i<totalUsers; i++)
            {
                if(customers[i].getAccNum() == accNum)
                {
                    Console.WriteLine("Account Number : " + customers[i].getAccNum());
                    Console.WriteLine("Name : " + customers[i].getName());
                    Console.WriteLine("Balance : " + customers[i].getBalance());
                }
            }
        }

        public void viewSpecifiedAcc(int accNum)
        {
            for (int i = 0; i < totalUsers; i++)
            {
                if (customers[i].getAccNum() == accNum)
                {
                    Console.WriteLine("Account Number : " + customers[i].getAccNum());
                    Console.WriteLine("Name : " + customers[i].getName());
                    Console.WriteLine("Account Type : " + customers[i].getAccType());
                    Console.WriteLine("Balance : " + customers[i].getBalance());
                }
            }
        }

        public int totalAccounts()
        {
            return customers.Length;
        }

        public void viewAllAccounts()
        {
            for(int i=0; i<customers.Length; i++)
            {
                Console.WriteLine("Account " + (i + 1) + " Details");
                Console.WriteLine("===============================");
                Console.WriteLine("Account Number : " + customers[i].getAccNum());
                Console.WriteLine("Name : " + customers[i].getName());
                Console.WriteLine("Account Type : " + customers[i].getAccType());
                Console.WriteLine("Balance : " + customers[i].getBalance());
                Console.WriteLine();
            }
        }
    }
}
