using System;
using DesignPatterns.Facade.Models;

namespace DesignPatterns.Facade.LoanFacade.SubSystems
{
    class Loan
    {
        public bool HasNoBadLoans(Customer c)
        {
            Console.WriteLine("Check loans for " + c.Name);
            return true;
        }
    }
}
