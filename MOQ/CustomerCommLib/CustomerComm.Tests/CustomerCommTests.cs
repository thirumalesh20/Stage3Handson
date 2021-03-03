using NUnit.Framework;
using Moq;
using System;
using CustomerCommLib;


namespace CustomerCommTests
{
    [TestFixture]
    public class CustomerCommTests
    {
        Mock<IMailSender> _mock;
        CustomerComm customerComm;

        [OneTimeSetUp]
        public void Init()
        {
            _mock = new Mock<IMailSender>(MockBehavior.Strict);
            customerComm = new CustomerComm(_mock.Object);
        }

        [Test]
        [TestCase("cust123@abc.com","some message1")]
        [TestCase("cust123@abc.com", "some message2")]
        [TestCase("cust123@abc.com", "some message3")]

        public void SendMailToCustomer_whenCalled_SendEmailAndReturnTrue(string email,string message)
        {
            _mock.Setup(p => p.SendMail(email, message)).Returns(true);
            bool result = customerComm.SendMailToCustomer(email, message);
            Assert.AreEqual(result, true);
        }
    }
}
