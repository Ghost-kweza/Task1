using NUnit.Framework;

namespace Oware.Tests
{
    public class mockScoreHouse : IScoreHouse
    {

        public void AddSeed(Seed seed)
        {
            
        }

        public int GetCount()
        {
            throw new System.NotImplementedException();
        }

        public void Reset()
        {
            throw new System.NotImplementedException();
        }
    }
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]

        public void checkingIfResetHouseWorks(){
            //ARRANGE:
            House h = new House(0,0);
            //ACT:
            h.AddSeedInPot(new Seed()); // Adding one seed to test
            h.ResetHouse();

            //Assert
            Assert.AreEqual(4, h.GetCount(), "Restores house to initialized state");

        }
        
        [Test]

        public void testingIfAddseedIsUsed(){
            //ARRANGE:
            Player p1 = new Player("Steve");
            Seed seed1 = new Seed();

            //ACT:
            p1.AddSeedToScoreHouse(seed1);

            //Assert
            Assert.AreEqual(1, p1.GetScore(),"AddSeedToScoreHouse works");


        }
    }
}