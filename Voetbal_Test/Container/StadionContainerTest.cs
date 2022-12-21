using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic.Container;
using UnitTest.DALTest;

namespace UnitTest.Container
{

    [TestClass]
    public class StadionContainerTest
    {
        [TestMethod]
        public void GetAllStadions()
        {
            StadionContainer stadionContainer = new StadionContainer(new stadion());
            stadionContainer.GetAllStadions();
            Assert.AreEqual(3, stadionContainer.GetAllStadions().Count);
        }
    }
}
