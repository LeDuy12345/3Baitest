Console.WriteLine(Find.F(37));
public static class Find
{
        public static int F(int N)
        {
                if (N == 1 || N == 2) return 1;
                if (N > 2)
                {
                        return F(N - 1) + F(N - 2);
                }
                else return 0;
        }
}