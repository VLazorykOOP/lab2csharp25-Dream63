namespace Lab2Cs
{
    internal class Task2_1
    {
        int[] array = StartClass.CreateRandomArray(10);
        int[,] array2 = StartClass.CreateRandomArray(5, 6);

        int selectedNumber = 8;

        private void ReplaceNumbers()
        {
            for(int i = 0; i < array.Length; i++)
                if (array[i] <= selectedNumber) array[i] = selectedNumber;
        }
        private void ReplaceNumbers2D()
        {
            for (int i = 0; i < array2.GetLength(0); i++)
                for (int j = 0; j < array2.GetLength(1); j++)
                    if (array2[i, j] <= selectedNumber) array2[i, j] = selectedNumber;
        }

        public void Task1D()
        {
            Console.WriteLine(">>> Task1 - 1D");
            StartClass.PrintArray(array, "Starting");

            ReplaceNumbers();
            StartClass.PrintArray(array, "Result");
        }
        public void Task2D()
        {
            Console.WriteLine(">>> Task1 - 2D");
            StartClass.PrintArray(array2, "Starting");

            ReplaceNumbers2D();
            StartClass.PrintArray(array2, "Result");
        }
    }
}
