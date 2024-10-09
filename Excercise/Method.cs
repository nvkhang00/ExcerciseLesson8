class Method
{
    public static int SumArr(List<int> arr)
    {
        if (arr == null || arr.Count == 0) return 0;
        //using foreach
        // int sum = 0;
        // foreach(int num in arr) {
        //     sum += num;
        // }
        // return sum;
        //using Method Sum
        return arr.Sum();
    }

    public static (int a, int b)? TwoSumEqualTarget(List<int> arr, int target = 9)
    {
        if (arr == null || arr.Count == 0) return null;
        var dicNum = new Dictionary<int, int>();
        for (int i = 0; i < arr.Count; i++)
        {
            int completed = target - arr[i];
            if (dicNum.TryGetValue(completed, out var index))
            {
                return (index, i);
            }
            if (!dicNum.ContainsKey(arr[i])) dicNum[arr[i]] = i;
        }
        return null;
    }

    public static int MaxProfit(List<int> prices)
    {
        if (prices == null || prices.Count == 0) return 0;
        int minPrice = int.MaxValue;
        int maxProfit = 0;
        foreach (int price in prices) {
            if(price < minPrice) minPrice = price;
            else {
                int profit = price - minPrice;
                maxProfit = profit > maxProfit ? profit : maxProfit;
            }
        }
        return maxProfit;
    }


    // Only count length array with unique number
    // public static int CountUnique(List<int> list) {
    //     if (list == null || list.Count == 0) return 0;
    //     list.Sort((a,b) => a-b);
    //     int uniqueIndex = 0;
    //     for(int i = 1; i < list.Count; i++) {
    //         if(list[i] != list[uniqueIndex]) {
    //             uniqueIndex++;
    //             list[uniqueIndex] = list[i];
    //         }
    //     }
    //     return uniqueIndex + 1;
    // }

    public static int[] UniqueArray(List<int> list) {
        if (list == null || list.Count == 0) return [];
        list.Sort((a,b) => a - b);
        List<int> uniqueList = [list[0]];
        for(int i = 1; i < list.Count; i++) {
            if(list[i] != list[i-1]) uniqueList.Add(list[i]);
        }
        return [..uniqueList];
    }

    public static IList<int>? FindMostFrequentElements(List<int> list, int k) {
        if (list == null || list.Count==0) return null;
        var dicNum = new Dictionary<int, int>();
        foreach (int num in list) {
            if(dicNum.ContainsKey(num)) dicNum[num]++;
            else dicNum[num] = 1;
        }
        if(k > dicNum.Count || k == 0) return [];
        return dicNum.OrderByDescending(pair => pair.Value).Take(k).Select(pair => pair.Key).ToList();
    }

    public static T ConvertTo<T>(object? input)
    {
        try
        {
            if (input == null || (input is string inputString) && string.IsNullOrEmpty(inputString))
                throw new ArgumentNullException(nameof(input), "Input can not null or empty.");
            return (T)Convert.ChangeType(input, typeof(T));
        }
        catch (ArgumentNullException ex)
        {
            throw new ArgumentException(ex.Message);
        }
        catch (FormatException)
        {
            throw new FormatException("Data not correct format");
        }
        catch (InvalidCastException)
        {
            throw new InvalidCastException($"Cannot convert to type: {typeof(T)}.");
        }
        catch (Exception)
        {
            throw new Exception("An unexpected error occurred.");
        }
    }
}