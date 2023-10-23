using Microsoft.VisualStudio.TestTools.UnitTesting;
using crab2.Modeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crab2.Modeles.Tests
{
    [TestClass()]
    public class BorneTests
    {
        [TestMethod()]
        public void EstAReviserTest()
        {
            // Arrange
            var borne = new Borne
            {
                DateDerniereRevision = DateTime.Now.AddDays(-15), // Supposons 14 jours entre les révisions
                LeType = new TypeBorne { NbJoursEntreRevisions = 14 }
            };

            // Act
            var resultat = borne.EstAReviser();

            // Assert
            Assert.IsTrue(resultat);
        }
    }
}