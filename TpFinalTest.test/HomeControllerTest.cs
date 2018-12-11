using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TpFinal.Models;

namespace TpFinalTest.test
{
    [TestClass]
    public sealed class HomeControllerTest
    {
        [TestMethod]
        public void PeutAjouterParticipant()
        {
            // Arranger
            Participant participant = new Participant();
            ArchiveDb archiveDb = new ArchiveDb();
            // Agir
            archiveDb.AjouterParticipant(participant);
            // Auditer
            Assert.AreEqual(participant, archiveDb.Participants().LastOrDefault());
        }
    }
}
