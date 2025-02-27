namespace Lab2Cs
{
    internal class Task2_2
    {
        int[] array = StartClass.CreateRandomArray(100);

        private void PrintArrayMinimalElementIndexes()
        {
            int minElement = array[0];
            for (int i = 0; i < array.Length; i++)
                if (array[i] <= minElement) minElement = array[i];

            Console.WriteLine($"Indexes of minimal element ({minElement}):");
            for (int i = 0; i < array.Length; i++)
                if (array[i] == minElement) Console.Write(i + " ");

            Console.WriteLine();
        }
        public void Task1D()
        {
            Console.WriteLine(">>> Task2 - 1D");
            StartClass.PrintArray(array, "Starting");

            PrintArrayMinimalElementIndexes();
        }
    }
}
