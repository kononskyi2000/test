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

        [Test]
        public void AdditionTest2(){
            int a = 11;
            int b = 3;
            int expected = 18;
            MathFunc mathFunc = new MathFunc();
            Assert.AreNotEqual(expected, mathFunc.Addition(a, b));
        }
        [Test]
        public void AdditionTest(){
            int a = 11;
            int b = 3;
            int expected = 14;
            MathFunc mathFunc = new MathFunc();
            Assert.AreEqual(expected, mathFunc.Addition(a, b));
        }

        [Test]
        public void DivisionTest(){
            int a = 12;
            int b = 3;
            int expected = 4;
            MathFunc mathFunc = new MathFunc();
            Assert.AreEqual(expected, mathFunc.Division(a, b));
        }

        [Test]
        public void DivisionTest2(){
            int a = 12;
            int b = 3;
            int expected = 9;
            MathFunc mathFunc = new MathFunc();
            Assert.AreNotEqual(expected, mathFunc.Division(a, b));
        }
    }

}