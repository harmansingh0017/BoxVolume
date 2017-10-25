using Microsoft.VisualStudio.TestTools.UnitTesting;
using Boxvolume;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxvolume.Tests
{
    [TestClass()]
    public class Service1Tests
    {
        [TestMethod()]
        public void GetSideTest()
        {
            Service1 test = new Service1();
            double vol = test.GetSide(16, 2, 2);
            Assert.AreEqual(4, 4);
        }

        [TestMethod()]
        public void GetVolumeTest()
        {
            Service1 test = new Service1();
            double side = test.GetVolume(2, 2, 2);
            Assert.AreEqual(8, 8);
        }
    }
}