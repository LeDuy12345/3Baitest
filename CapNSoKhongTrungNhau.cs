public class Program
{
        static int CountPairs(int[] arr, int n, int k)// 1 cặp gồm k số khác nhau
        {
                if (n < k) // Kiểm tra độ dài 
                {
                        return 0;
                }
                Array.Sort(arr); // Sắp xếp dãy A theo thứ tự tăng dần
                int count = 0;
                Count(arr, n, k, 0, new int[k], 0, ref count);
                return count;
        }
        static void Count(int[] arr, int n, int k, int index, int[] temp, int i, ref int count)
        {
                if (index == k)// đầy mảng temp
                {
                        count++;
                        foreach(var a in temp)
                                Console.Write(a);
                        Console.WriteLine("");
                        return;
                }
                if (i >= n) //đầy mảng arr
                {
                        return;
                }
                temp[index] = arr[i];
                Count(arr, n, k, index+1, temp, i + 1, ref count); // Đệ quy tìm cặp n - 1 phần tử khác nhau bắt đầu từ phần tử thứ i + 1
                
                while (i < n - 1 && arr[i] == arr[i + 1]) {// bỏ qua phần tử lặp trong mảng arr
                        i++;
                }
                Count(arr, n, k, index, temp, i + 1, ref count); // Đệ quy tìm các cặp phần tử khác nhau trong dãy con bắt đầu từ phần tử thứ i + 1
        }
        public static void Main()
        {
                int[] arr = { 1, 2, 3};
                int n = arr.Length;
                int k = 2;
                int count = CountPairs(arr, n, k);
                Console.WriteLine($"{count} pairs");
        }
}