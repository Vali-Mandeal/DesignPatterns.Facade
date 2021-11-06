using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Facade.Models;
using DesignPatterns.Facade.LoanFacade.SubSystems;


namespace DesignPatterns.Facade.LoanFacade
{
    /// <summary>
    /// The 'Facade' class
    /// </summary>
    class Mortgage
    {
        private readonly Bank _bank = new();
        private readonly Loan _loan = new();
        private readonly Credit _credit = new();

        public bool IsEligible(Customer cust, int amount)
        {
            Console.WriteLine("{0} applies for {1:C} loan\n",
                cust.Name, amount);

            bool eligible = true;

            // Check creditworthyness of applicant
            if (!_bank.HasSufficientSavings(cust, amount))
            {
                eligible = false;
            }
            else if (!_loan.HasNoBadLoans(cust))
            {
                eligible = false;
            }
            else if (!_credit.HasGoodCredit(cust))
            {
                eligible = false;
            }

            return eligible;
        }
    }
}
