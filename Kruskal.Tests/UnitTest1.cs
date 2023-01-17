namespace Kruskal.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public void TestGraf1()
        {
            //link to source
            //https://habr.com/ru/post/569444/

            int m = int.MaxValue;
            int[][] vect = new int[6][];
            vect[0] = new int[6] { 0, 7, 8, m, m, m };
            vect[1] = new int[6] { 7, 0, 11, 2, m, m };
            vect[2] = new int[6] { 8, 11, 0, 6, 9, m };
            vect[3] = new int[6] { m, 2, 6, 0, 11, 9 };
            vect[4] = new int[6] { m, m, 9, 11, 0, 10 };
            vect[5] = new int[6] { m, m, m, 9, 10, 0 };

            Graf graf = new Graf();
            List<Edge> result = graf.Kruskal(vect).ToList();
            Assert.AreEqual(result.Count, vect.Length - 1);

            Assert.NotNull(result.Find(x => (x.V1 == 0 && x.V2 == 1) || (x.V1 == 1 && x.V2 == 0)));
            Assert.NotNull(result.Find(x => (x.V1 == 1 && x.V2 == 3) || (x.V1 == 3 && x.V2 == 1)));
            Assert.NotNull(result.Find(x => (x.V1 == 3 && x.V2 == 5) || (x.V1 == 5 && x.V2 == 3)));
            Assert.NotNull(result.Find(x => (x.V1 == 2 && x.V2 == 3) || (x.V1 == 3 && x.V2 == 2)));
            Assert.NotNull(result.Find(x => (x.V1 == 2 && x.V2 == 4) || (x.V1 == 4 && x.V2 == 2)));
        }
    }
}