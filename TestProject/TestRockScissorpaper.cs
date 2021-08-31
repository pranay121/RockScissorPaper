using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class TestRockScissorpaper
    {
        [TestMethod]
        public void TestRSP()
        {
            RockScissorPaper.Human.userInput = "Rock";
            RockScissorPaper.Computer.systemInput = "Scissor";
            RockScissorPaper.Players.Play();
           
            Assert.IsTrue(RockScissorPaper.Players.userPoint> RockScissorPaper.Players.CompPoint, "You Win the game");
        }
    }
}
