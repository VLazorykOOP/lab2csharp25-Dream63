namespace Lab2Cs
{
    internal class Task2_4
    {
        static int n = 10;
        int[][] arrayS = CreateStairedArray();
        int[] resultArray = new int[n];

        private static int[][] CreateStairedArray()
        {
            int[][] arr = new int[n][];
            for (int i = 0; i < n; i++)
                arr[i] = StartClass.CreateRandomArray(i + 1);

            return arr;
        }

        private int GetFirstPositiveElement(int[] arr)
        {
            int posElement = 0;
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] >= 0)
                {
                    posElement = arr[i];
                    break;
                }

            return posElement;
        }

        private void GetFirstPositiveElementsToArray()
        {
            for(int i = 0;i < n; i++)
                resultArray[i] = GetFirstPositiveElement(arrayS[i]);
        }

        public void TaskS()
        {
            Console.WriteLine(">>> Task4 - Staired");
            StartClass.PrintArray(arrayS, "Starting");
            GetFirstPositiveElementsToArray();

            StartClass.PrintArray(resultArray, "Result");
        }
    }
}
