using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMoney
{
    public class Money
    {
        private string _denominationOfBills;
        private int _numberOfBills;

        public Money(string denominationOfBills, int numberOfBills)
        {
            _denominationOfBills = denominationOfBills;
            _numberOfBills = numberOfBills;
        }
        public Money(int numberOfBills)
        {
            GetNumber();
            if (numberOfBills > _numberOfBills)
            {
                Console.WriteLine("Денег не хватает!!!");
            }
            else
                Console.WriteLine("Денег хватает!!!");
        }

        #region Methods
        public string GetDenomination() { return _denominationOfBills; }
        public void SetDenomination(string denominationB)
        {
            _denominationOfBills = denominationB;
        }
        public int GetNumber() { return _numberOfBills; }
        public void SetNumber(int numberB)
        {
            _numberOfBills = numberB;
        }

        public bool MoneyN(int numberOfBills)
        {
            if (numberOfBills > _numberOfBills)
            {
                Console.WriteLine("Денег не хватает!!!");
                return false;
            }
            else
            {
                Console.WriteLine("Денег хватает!!!");
                return true;
            }
        }
        public void AmountThings(int things)
        {
            int yes = _numberOfBills / things;
            Console.WriteLine("Кол-во вещей которые можно купить = " + yes);
        }
        #endregion

    }
}
