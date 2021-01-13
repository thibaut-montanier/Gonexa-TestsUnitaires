using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MyLibrary.Tests {
    class MathsClassTest {
        private MathsClass mc;

        private int nbInstance = 0;

        public string maPropriete { get; set; }

        public MathsClassTest() {

        }
        [SetUp]
        public void Setup() {
           this.mc = new MathsClass();
        }

        [Parallelizable]
        [TestCase(0,2,-2)]
        [TestCase(-1,2,-3)]
        [TestCase(0,3,-3)]
        [TestCase(0,2,-2)]
        public void TestAdd(int expected, int v1, int v2) {
            nbInstance++;
            int result = mc.Additionne(v1, v2);
            Assert.AreEqual(expected, result);
            Assert.Fail($"{nbInstance} - {Thread.CurrentThread.ManagedThreadId}");

        }

      

        [Test]
        public void DiviseTest() {

            Assert.Throws<DivideByZeroException>(
                    () => mc.Divise(1, 0)
                    );
            
            Assert.That(mc.Divise(1,3) ,
                    Is.EqualTo(0.33).Within(0.01));
        }

    }
}
