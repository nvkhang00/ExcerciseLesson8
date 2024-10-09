class Method {
    public static int SumArr(List<int> arr) {
        if(arr == null || arr.Count == 0) return 0;
        //using foreach
        // int sum = 0;
        // foreach(int num in arr) {
        //     sum += num;
        // }
        // return sum;
        //using Method Sum
        return arr.Sum();
    }

    
}