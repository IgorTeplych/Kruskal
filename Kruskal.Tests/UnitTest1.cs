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
        [Test]
        public void TestGraf2()
        {
            //graph from the webinar
            int m = int.MaxValue;
            int[][] vect = new int[9][];
            vect[0] = new int[] { 0, 9, m, 10, m, m, m, m, 3 };
            vect[1] = new int[] { 9, 0, 4, m, 8, m, m, m, 16 };
            vect[2] = new int[] { m, 4, 0, m, 14, 1, m, m, m };
            vect[3] = new int[] { 10, m, m, 0, 7, m, 13, 5, 11 };
            vect[4] = new int[] { m, 8, 14, 7, 0, 12, 15, m, m };
            vect[5] = new int[] { m, m, 1, m, 12, 0, 2, m, m };
            vect[6] = new int[] { m, m, m, 13, 15, 2, 0, 6, m };
            vect[7] = new int[] { m, m, m, 5,  m,  m, 6, 0, m };
            vect[8] = new int[] { 3,16, m, 11, m,  m, m, m, 0};

            Graf graf = new Graf();
            List<Edge> result = graf.Kruskal(vect).ToList();
            Assert.AreEqual(result.Count, vect.Length - 1);

            Assert.NotNull(result.Find(x => (x.V1 == 0 && x.V2 == 8) || (x.V1 == 8 && x.V2 == 0)));
            Assert.NotNull(result.Find(x => (x.V1 == 0 && x.V2 == 1) || (x.V1 == 1 && x.V2 == 0)));
            Assert.NotNull(result.Find(x => (x.V1 == 2 && x.V2 == 1) || (x.V1 == 1 && x.V2 == 2)));
            Assert.NotNull(result.Find(x => (x.V1 == 2 && x.V2 == 5) || (x.V1 == 5 && x.V2 == 2)));
            Assert.NotNull(result.Find(x => (x.V1 == 5 && x.V2 == 6) || (x.V1 == 6 && x.V2 == 5)));
            Assert.NotNull(result.Find(x => (x.V1 == 6 && x.V2 == 7) || (x.V1 == 7 && x.V2 == 6)));
            Assert.NotNull(result.Find(x => (x.V1 == 3 && x.V2 == 7) || (x.V1 == 7 && x.V2 == 3)));
            Assert.NotNull(result.Find(x => (x.V1 == 3 && x.V2 == 4) || (x.V1 == 4 && x.V2 == 3)));
        }

    }
}