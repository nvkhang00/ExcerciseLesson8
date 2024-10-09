internal class Program
{
    private static void Main(string[] args)
    {
        #region Tính tổng các số trong mảng
        int result = Method.SumArr([20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20]);
        if(result == 0) {
            Console.WriteLine("Input array is null or empty. Please input array has at least 1 element.");
        }
        else {
            Console.Write($"Sum of array [20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20] is: {result}");
        }
        #endregion
    }
}