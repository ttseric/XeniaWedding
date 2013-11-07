using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XeniaWedding.Core;

namespace XeniaWedding.Data.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var guestRepository = new EfRepository<Guest>(new XeniaWeddingDbContext());

            Guest guest = new Guest();

            guest.Email = "ttseric@hotmail.com";
            guest.GuestGroup = "Eric's Family";
            guest.Name = "Eric Tsang";
            guest.Sex = "M";
            
            guestRepository.Insert(guest);
        }
    }
}
