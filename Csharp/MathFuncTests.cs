using System;
using System.Threading.Tasks;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using NUnit.Framework;

namespace ConsoleApp.tests
{
    [TestFixture]
    class MathFuncTest
    {
        [Test]
        public void MultyplyTest(){
            int a = 2;
            int b = 3;
            int expected = 6;
            MathFunc mathFunc = new MathFunc();
            Assert.AreEqual(expected, mathFunc.Multiply(a, b));
        }
        
        [Test]
        public void MultyplyTest2(){
            int a = 2;
            int b = 3;
            int expected = 8;
            MathFunc mathFunc = new MathFunc();
            Assert.AreNotEqual(expected, mathFunc.Multiply(a, b));
        }
        
    }

}