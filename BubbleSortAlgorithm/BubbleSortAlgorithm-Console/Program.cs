namespace Console
{
    public static class Program
    {
        public static void Main()
        {
            int[] arr = { 5, 8, 12, 1, 2 };

            foreach (int i in arr)
                System.Console.Write(i + " ");

            int aux = 0;
            int aputador1 = 0;
            int aputador2 = aputador1 + 1;
            int vueltas = arr.Length;

            foreach (int item in arr)
            {
                // Good Logic Code
                if (arr[aputador1] > arr[aputador2])
                {
                    aux = arr[aputador2];
                    arr[aputador2] = arr[aputador1];
                    arr[aputador1] = aux;
                }
            }

            System.Console.Write("\n");
            foreach (int i in arr)
                System.Console.Write(i + " ");

        }
    }
}