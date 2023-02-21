using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mainProg;
using NUnit.Framework;
namespace test_mainProg
{
    [TestFixture]
    public class TestItem
    {
        [Test]
        //this function run first
        [SetUp]
        public void Init()
        {

        }
        [Test]
        [Order(2)]
        //check second
        public void TestPlus()
        {
            Items item = new Items();
            int ret = item.Plus(5, 5);
            // if ret ==10 return sucsess else fail
            Assert.AreEqual(10, ret);    
        }
        [Test]
        //catgory for the test 
        [Category("check function")]
        //i choose what it order first
        //check first
        [Order(1)]
        public void TestMinus()
        {
            Items item = new Items();
            int ret = item.Minus(5, 5);

            Assert.AreEqual(0, ret,"result 0");
        }
        // Ignore from this function( not run)
        [Test,Ignore("this function not finished yet")]
        public void TestSomesing()
        {

        }
    }
}