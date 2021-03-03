using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using PlayersManagerLib;


namespace PlayerManager.Tests
{
    [TestFixture]
    public class PlayerManagerLibTest
    {
        Mock<IPlayerMapper> _mock;

        [OneTimeSetUp]

        public void Init()
        {
            _mock = new Mock<IPlayerMapper>(MockBehavior.Loose);

        }
        [Test]
        [TestCase("Kasim")]
        [TestCase("Thirumalesh")]
        [TestCase("Vamsi")]
        public void RegisterNewplayer_whencalled_RegisterANewPlayer(String name)
        {
            _mock.Setup(p => p.IsPlayerNameExistsInDb(name)).Returns(false);
            Player result = Player.RegisterNewPlayer(name, _mock.Object);
            NUnit.Framework.Assert.AreEqual(result.Name, name);
        }
        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase("  ")]
       

        public void RegisterNewPlayer_whencalled_ReturnsArgumentException(string name)
        {
            NUnit.Framework.Assert.That(() => Player.RegisterNewPlayer(name, _mock.Object), Throws.ArgumentException);S
        }
 


    }
}
