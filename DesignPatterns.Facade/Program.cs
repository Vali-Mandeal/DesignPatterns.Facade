using System;
using DesignPatterns.Facade.Models;
using DesignPatterns.Facade.LoanFacade;

namespace DesignPatterns.Facade
{
    class Program
    {
       // The Client does not need to depend on all bank sub systems
       // in order to check mortgage eligibility. We can replace that
       // with a Mortgage Facade

        // Also, if the bank framework changes, just the Facade should be updated
        static void Main()
        {
            Mortgage mortgage = new Mortgage();

            Customer customer = new Customer("John Doe");
            bool eligible = mortgage.IsEligible(customer, 166000);

            Console.WriteLine("\n" + customer.Name +
                    " has been " + (eligible ? "Approved" : "Rejected"));

            Console.ReadKey();
        }
    }
}
