using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.Tests {
    class DisposableObjectTest {
        [Test]
        public void TestDispose() {
            try {
                UtiliseDisposableObject();
            } catch (Exception) { 
            }

        }

        public void UtiliseDisposableObject() {

            using (var v = new DisposableObject()) {
                // do some job here
                throw new Exception("une erreur non gérée");

            }
        }
    }
}
