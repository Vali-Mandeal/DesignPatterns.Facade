using System;
using DesignPatterns.Facade.Models;

namespace DesignPatterns.Facade.LoanFacade.SubSystems
{
    public class Credit
    {
        public bool HasGoodCredit(Customer c)
        {
            Console.WriteLine("Check credit for " + c.Name);
            return true;
        }
    }
}
