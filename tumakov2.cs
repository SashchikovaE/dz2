using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum AccountType
{
    Current,
    Savings
}
enum University
{
    KGU,
    KAI,
    KHTI
}

struct Worker
{
    public string Name;
    public University University;
}

struct BankAccount
{
    public long Number;
    public int Balance;
    public AccountType AccountType;
}
namespace tumakov2
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 3.1");
            AccountType myAccountType = AccountType.Current;
            Console.WriteLine("Мой банковский счет типа: " + myAccountType.ToString());

            Console.WriteLine("Упражнение 3.2");
            BankAccount bankaccount1 = new BankAccount { Number = 2222222222222222, Balance = 1547838, AccountType = AccountType.Savings };
            BankAccount bankaccount2 = new BankAccount { Number = 1111111111111111, Balance = 0, AccountType = AccountType.Current };
            Console.WriteLine("Работники:");
            Console.WriteLine($"{bankaccount1.Number} {bankaccount1.Balance} {bankaccount1.AccountType}");
            Console.WriteLine($"{bankaccount2.Number} {bankaccount2.Balance} {bankaccount2.AccountType}");

            Console.WriteLine("Домашнее задание 3.1");
            Worker worker1 = new Worker { Name = "Настя Стпнва", University = University.KGU };
            Worker worker2 = new Worker { Name = "Максим Зеленюк", University = University.KAI };
            Worker worker3 = new Worker { Name = "Шабардин ЕГОР", University = University.KHTI };
            Console.WriteLine("Работники:");
            Console.WriteLine($"{worker1.Name} ({worker1.University})");
            Console.WriteLine($"{worker2.Name} ({worker2.University})");
            Console.WriteLine($"{worker3.Name} ({worker3.University})");
            Console.ReadKey();
        }
    }
}