﻿using System.Security.Cryptography;
using Microsoft.VisualBasic;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Tính tổng các số trong mảng
        // int result = Method.SumArr([20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20]);
        // if(result == 0) {
        //     Console.WriteLine("Input array is null or empty. Please input array has at least 1 element.");
        // }
        // else {
        //     Console.Write($"Sum of array [20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20] is: {result}");
        // }
        #endregion

        #region Tìm hai số trong tổng danh sách số nguyên sao cho tổng của chúng bằng mộ t giá trị target cho trước\
        // List<int> lst_number = [2, 7, 11, 15];
        // int target = Input<int>("Enter target: ", true);
        // (int index1, int index2)? result = Method.TwoSumEqualTarget(lst_number, target);
        // if (!result.HasValue)
        // {
        //     Console.WriteLine("No value satisfies the condition");
        // }
        // else
        // {
        //     Console.WriteLine($"Sum of two number in array equals target: {target} is indicates: [{result.Value.index1}, {result.Value.index2}]");
        // }
        #endregion

        #region Remove duplicates from sorted Array(Easy)
        // List<int> lstNumber = [1, 1, 2, 2, 2, 3, 4, 4, 5];
        // int[] newArr = Method.UniqueArray(lstNumber);
        // string result = string.Join(", ", newArr);
        // if (result.Length == 0) Console.WriteLine("Input array null or empty.");
        // else Console.WriteLine($"Unique Araay: {result}, Length: {newArr.Length}");
        #endregion

        #region Find Most Frequence
        List<int> nums = [1, 1, 1, 2, 2, 3];
        int k = Input<int>("Enter k: ");
        var result = Method.FindMostFrequentElements(nums, k);
        var message = result switch
        {
        [] => $"No value satisfies the condition: k = {k}",
            null => "Input list cannot null or empty.",
            _ => $"[{string.Join(", ", result)}]",
        };
        Console.WriteLine($"Corresponding k = {k} that result is: {message}");
        #endregion

        #region Best time to Buy and Sell Stock
        // List<int> prices = [7, 1, 5, 3, 6 ,4];
        // Console.WriteLine($"Max profit: {Method.MaxProfit(prices)}");
        #endregion
    }


    private static T Input<T>(string mess, bool? allowNegativeNum = false)
    where T : struct, IComparable<T>
    {
        while (true)
        {
            try
            {
                Console.Write(mess);
                string? input = Console.ReadLine();
                var value = Method.ConvertTo<T>(input);
                if (allowNegativeNum.HasValue && !allowNegativeNum.Value)
                {
                    var zero = default(T);
                    if(value.CompareTo(zero) < 0) {
                        throw new InvalidOperationException("Negative numbers are not allowed.");
                    }
                }
                return value;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}