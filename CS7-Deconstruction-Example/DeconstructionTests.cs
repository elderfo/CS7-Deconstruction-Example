using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CS7_Deconstruction_Example
{
    [TestClass]
    public class DeconstructionTests
    {
 
        public class Person
        {
            public string Name { get; set; }
            public string City { get; set; }

            public void Deconstruct(out string name, out string city)
            {
                (name, city) = (Name, City);
            }

            public void Deconstruct(out string name)
            {
                name = Name;
            }
        }

        [TestMethod]
        public void Can_Deconstruct()
        {
            var obj = new Person
            {
                Name = "Chris",
                City = "Omaha"
            };

            var (name) = obj;
            Assert.AreEqual(obj.Name, name);

            var (name2, city) = obj;
            Assert.AreEqual(obj.Name, name2);
            Assert.AreEqual(obj.City, city);

        }
    }
}
