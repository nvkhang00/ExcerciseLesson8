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
        for(int i = 0; i < arr.Count; i++) {
            int completed = target - arr[i];
            if(dicNum.TryGetValue(completed, out var index)) {
                return (index, i);
            }
            if(!dicNum.ContainsKey(arr[i])) dicNum[arr[i]] = i;
        }
        return null;
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