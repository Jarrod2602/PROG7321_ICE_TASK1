using PROG7312_ICE1_LinkedList;

namespace LinkedListTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestUpdatedName()
        {
            UserAccount userAcc = new UserAccount(21000.00, "ACC123456789", "Current", "Jarrod", "Claassen");
            userAcc["name"] = "Adriano";
            Assert.AreEqual(userAcc[2], "Adriano");
        }

        [TestMethod]
        public void TestUpdatedSurname()
        {
            UserAccount userAcc = new UserAccount(21000.00, "ACC123456789", "Current", "Jarrod", "Claassen");
            userAcc["surname"] = "Webster";
            Assert.AreEqual(userAcc[3], "Webster");
        }

        [TestMethod]
        public void TestUpdatedBalance()
        {
            UserAccount userAcc = new UserAccount(21000.00, "ACC123456789", "Current", "Jarrod", "Claassen");
            userAcc["balance"] = 32000.00;
            Assert.AreEqual(userAcc[4], 32000.00);
        }

        [TestMethod]
        public void TestUpdatedAccountType()
        {
            UserAccount userAcc = new UserAccount(21000.00, "ACC123456789", "Current", "Jarrod", "Claassen");
            userAcc["acctype"] = "Savings";
            Assert.AreEqual(userAcc[1], "Savings");
        }

        [TestMethod]
        public void TestUpdatedAccountNumber()
        {
            UserAccount userAcc = new UserAccount(21000.00, "ACC123456789", "Current", "Jarrod", "Claassen");
            userAcc["accnumber"] = "ACCCUR1268325";
            Assert.AreEqual(userAcc[0], "ACCCUR1268325");
        }

        [TestMethod]
        public void TestUpdatedUserAccount()
        {
            UserAccount userAcc = new UserAccount(21000.00, "ACC123456789", "Current", "Jarrod", "Claassen");
            userAcc["acctype"] = "Savings";
            userAcc["name"] = "Dakota";
            userAcc["surname"] = "Webster";
            userAcc["accnumber"] = "ACCSAVE98765432";
            userAcc["balance"] = 54000.00;
            Assert.AreEqual(userAcc[1], "Savings");
            Assert.AreEqual(userAcc[2], "Dakota");
            Assert.AreEqual(userAcc[3], "Webster");
            Assert.AreEqual(userAcc[0], "ACCSAVE98765432");
            Assert.AreEqual(userAcc[4], 54000.00);
        }

        [TestMethod]
        public void TestAccountIndexing()
        {
            UserAccount userAcc = new UserAccount(95000.00, "ACCCUR18424735", "Current", "Reece", "Wanvig");
            Assert.AreEqual(userAcc["acctype"], "Current");
            Assert.AreEqual(userAcc["name"], "Reece");
            Assert.AreEqual(userAcc["surname"], "Wanvig");
            Assert.AreEqual(userAcc["accnumber"], "ACCCUR18424735");
            Assert.AreEqual(userAcc["balance"], 95000.00);
        }
    }
}