namespace BubbleSortAlgorithm_Library
{
    public class BubbleSort
    {
        public static int[] SortIntegers(int[] IntegersArray)
        {
            int AuxVar, primaryIndex, secIndex;
            int steps = IntegersArray.Length;

            for (int i = 0; i < steps; i++)
            {
                primaryIndex = 0;
                secIndex = primaryIndex + 1;

                for (int o = 0; o < steps; o++)
                {
                    // Good Logic Code
                    if (IntegersArray[primaryIndex] > IntegersArray[secIndex])
                    {
                        AuxVar = IntegersArray[secIndex];
                        IntegersArray[secIndex] = IntegersArray[primaryIndex];
                        IntegersArray[primaryIndex] = AuxVar;
                    }

                    primaryIndex = o;
                    secIndex = primaryIndex + 1;
                }
            }
            return IntegersArray;
        }
    }
}