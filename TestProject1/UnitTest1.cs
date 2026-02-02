namespace TestProject1
{
    public class Tests
    {
        private TennisTDDKata.Tennis _tennis;
        [SetUp]
        public void Setup()
        {
            _tennis = new TennisTDDKata.Tennis();
        }

        [Test]
        public void TestWhenGameStartedScoreIsLoveAll()
        {

            var score = _tennis.GetScore(0, 0);
            Assert.That("Love-All", Is.EqualTo(score));
        }


        [Test]
        public void TestWhenPlayerOneScoresFirstPointScoreIsFifteenLove()
        {

            var score = _tennis.GetScore(1, 0);
            Assert.That("Fifteen-Love", Is.EqualTo(score));
        }

        []
        public void WhenPlayerTwoScoresFirstPointScoreIsLoveFifteen()
        {
            var score = _tennis.GetScore(0, 1);
            Assert.That("Love-Fifteen", Is.EqualTo(score));
        }


    }
}
