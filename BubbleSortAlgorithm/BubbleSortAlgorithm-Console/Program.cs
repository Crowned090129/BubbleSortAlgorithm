namespace Console
{
    public static class Program
    {
        public static void Main()
        {
            int[] arr = { 5, 8, 12, 1, 2 };

            foreach (int i in arr)
                System.Console.Write(i + " ");

            int aux, aputador1, aputador2, vueltas;
            vueltas = arr.Length;

            for (int i = 0; i < vueltas; i++)
            {
                aputador1 = 0;
                aputador2 = aputador1 + 1;

                for (int o = 0; o < vueltas; o++)
                {
                    // Good Logic Code
                    if (arr[aputador1] > arr[aputador2])
                    {
                        aux = arr[aputador2];
                        arr[aputador2] = arr[aputador1];
                        arr[aputador1] = aux;
                    }

                    aputador1 = o;
                    aputador2 = aputador1 + 1;
                }
            }

            System.Console.Write("\n");
            foreach (int i in arr)
                System.Console.Write(i + " ");

        }
    }
}