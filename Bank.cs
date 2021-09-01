using System;
using System.Collections;

namespace BankProject
{
    class Bank
    {
        private int ACCOUNT_NUMBER;
        private string name;
        private string AccountType;
        private double Balance;
        private ArrayList AccountNumbers = new ArrayList();
        private Random rand = new Random();
        private int randomNum;

        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }

        public void setAccType(string Acc)
        {
            this.AccountType = Acc;
        }
        public string getAccType()
        {
            return AccountType;
        }

        public void setAccNum()
        {
            while(true)
            {
                randomNum = rand.Next(1, 100);
                if(AccountNumbers.Contains(randomNum))
                {
                    continue;
                } else
                {
                    AccountNumbers.Add(randomNum);
                    ACCOUNT_NUMBER = randomNum;
                    break;
                }
            }
        }
        public int getAccNum()
        {
            return ACCOUNT_NUMBER;
        }

        public bool setBalance(double amount)
        {
            if (amount < 10000) return false;
            this.Balance = amount;
            return true;
        }
        public double getBalance()
        {
            return this.Balance;
        }


        public double deposit(double amount)
        {
            this.Balance += amount;
            return this.Balance;
        }

        public double Withdraw(double amount)
        {
            if (this.Balance - amount < 0) return -1;
            this.Balance -= amount;
            return this.Balance;
        }

       
    }
}
