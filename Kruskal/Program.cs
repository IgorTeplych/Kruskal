using Kruskal;

class Programm
{
    public static void Main()
    {
        int[][] vect = new int[6][];
        vect[0] = new int[] { 1, 2 };
        vect[1] = new int[] { 0, 2, 3 };
        vect[2] = new int[] { 0, 1, 3, 4 };
        vect[3] = new int[] { 1, 2, 4, 5 };
        vect[4] = new int[] { 2, 3, 5 };
        vect[5] = new int[] { 3, 4 };

        int m = int.MaxValue;
        int[][] vect2 = new int[6][];
        vect2[0] = new int[6] { 0, 7, 8, m, m, m };
        vect2[1] = new int[6] { 7, 0, 11, 2, m, m };
        vect2[2] = new int[6] { 8, 11, 0, 6, 9, m };
        vect2[3] = new int[6] { m, 2, 6, 0, 11, 9 };
        vect2[4] = new int[6] { m, m, 9, 11, 0, 10 };
        vect2[5] = new int[6] { m, m, m, 9, 10, 0 };

        Graf graf = new Graf();
        var vr = graf.Kruskal(vect2);
    }
}