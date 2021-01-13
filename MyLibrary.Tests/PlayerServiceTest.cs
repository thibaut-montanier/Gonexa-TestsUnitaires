using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.Tests {
    class PlayerServiceTest {
        [Test]
        public void TestDesctructor() {
            var v = new PlayerService();

            v = null;

            GC.Collect();
        }
        [Test]
        public void TestgetPlayerList() {
            var mockPlSrv = new Mock<PlayerService>();
            mockPlSrv.CallBase = true;


            mockPlSrv.Setup(v => v.getAll())
                    .Returns(() => new List<Player> 
                    { new Player() { FirstName = "Alain", Name = "Prost" }, 
                        new Player() { FirstName = "Lewis", Name = "Hamilton" } });
            var plSrv =  mockPlSrv.Object;

            var result = plSrv.getPlayerLst();

            Assert.AreEqual("Nom : Prost, prenom : Alain\nNom : Hamilton, prenom : Lewis", result);
        }


        [Test]
        public void TestLoadData() {
            var plSrv = new PlayerService();
            var result = plSrv.LoadDataFromTxt(@"./Resources/dataPlayer.txt");

            Assert.AreEqual("bonjour", result);
        }


    }
}
