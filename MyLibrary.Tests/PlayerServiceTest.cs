using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.Tests {
    class PlayerServiceTest {

        [Test]
        public void TestgetPlayerList() {
            var plSrv = new PlayerService();

            var result = plSrv.getPlayerLst();

            Assert.AreEqual(result, "Nom : Prost, prenom : Alain\nNom: Hamilton, prenom: Lewis");
        }
    }
}
