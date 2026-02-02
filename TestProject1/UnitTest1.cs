namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestWhenGameStartedScoreIsLoveAll()
        {
            var tennis = new TennisTDDKata.Tennis();
            var score = tennis.GetScore(0,0);
            Assert.That("Love-All", Is.EqualTo(score));
        }
    }
}
