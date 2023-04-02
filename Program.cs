List<int> a = new List<int> { 13, 9, 8, 7, 5,6,3,15,2,11,10,12 };      
Sorted(a); 
static void Sorted(List<int> a)
{
        int index = 0;
        int n = a.Count;
        List<int> b = new List<int>();
        do
        {
                if (IsPrime(a[index]))   
                        index++;
                else
                        {
                        b.Add(a[index]); // insertion_sort--O(n^2)
                        if (b.Count > 1)
                        {
                                int i = b.Count - 1;
                                int key = b[i];
                                int j = i - 1;
                                while (j >= 0 && key < b[j])
                                {
                                        b[j + 1] = b[j];
                                        j--;
                                }
                                        b[j + 1] = key;
                                }
                                index++;
                        }
                } while (index < n );
                
        foreach(var i in b)
                Console.WriteLine(i);              
}
static Boolean IsPrime(int n)
{     
        if (n < 2)
        {
                return false;
        }
        int sqrt = (int)Math.Sqrt(n);
        int i;
        for (i = 2; i <= sqrt; i++)
        {
                if (n % i == 0)
                {
                        return false;
                }
        }
        return true;
}