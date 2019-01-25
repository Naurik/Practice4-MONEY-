using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMoney
{
    class Program
    {
        static void Main(string[] args)
        {
            Money money = new Money("Euro", 100);
            money.SetDenomination("Dollar");
            money.SetNumber(25);

            Console.WriteLine("Кол-во купюр = " + money.GetNumber());
            Console.WriteLine("Номинал купюры = " + money.GetDenomination());
            money.MoneyN(20);
            money.AmountThings(5);

            Console.ReadLine();
        }
    }
}
