using IO.Swagger.Models;
using IO.Swagger.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IBreachedeMailRepository _breachedeMailRepo = new BreachedeMailRepository();
            Breachedemail b = new IO.Swagger.Models.Breachedemail();
            b.Name = "janez@test.si";
            bool returntrue = _breachedeMailRepo.Add(b); //add email
            //Assert.AreEqual(returntrue, true);

            Breachedemail bid = _breachedeMailRepo.GetByEmail(b.Name); //get by email
            Assert.AreEqual(bid, b);

            _breachedeMailRepo.Delete(b.Name); //delete email
            Breachedemail bdel = _breachedeMailRepo.GetByEmail(b.Name); //get by email
            Assert.IsNull(bdel);

            bool returntrue2 = _breachedeMailRepo.Add(b); //add email
            Assert.IsTrue(returntrue2);
        }

        [TestMethod]
        public void TestMethod2()
        {
            IBreachedeMailRepository _breachedeMailRepo = new BreachedeMailRepository();
            HashSet<string> list = _breachedeMailRepo.GetAll(); //add email
            Assert.AreNotEqual(list.Count, 0);
        }
    }
}
