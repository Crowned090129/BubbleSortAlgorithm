namespace Console
{
    public static class Program
    {
        public static void Main()
        {
            int[] arr = { 5, 8, 12, 1, 2 };

            foreach (int i in arr)
                System.Console.Write(i + " ");

            int[] array = BubbleSortAlgorithm_Library.BubbleSort.SortIntegers(arr);

            System.Console.Write("\n");
            foreach (int i in array)
                System.Console.Write(i + " ");

        }
    }
}