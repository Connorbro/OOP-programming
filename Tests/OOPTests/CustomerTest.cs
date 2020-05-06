using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OOPTests
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            Customer customer = new Customer();
            customer.FirstName = "Connor";
            customer.LastName = "Brookes";

        }
    }
}
