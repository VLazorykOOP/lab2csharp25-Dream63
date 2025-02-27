namespace Lab2Cs
{
    internal class Task2_3
    {
        static int n = 5;
        int[,] array2 = StartClass.CreateRandomArray(n, n);


        private void SwapRowsInPlaces()
        {
            int temp = 0;
            if(n % 2 == 0)
                for(int i = 0; i < n; i++)
                {
                    temp = array2[n / 2 - 1, i];
                    array2[n / 2 - 1, i] = array2[n / 2, i];
                    array2[n / 2, i] = temp;
                }
            if(n % 2 == 1)
                for (int i = 0; i < n; i++)
                {
                    temp = array2[(n - 1) / 2, i];
                    array2[(n - 1) / 2, i] = array2[0, i];
                    array2[0, i] = temp;
                }
            
        }
        public void Task2D()
        {
            Console.WriteLine(">>> Task3 - 2D");
            StartClass.PrintArray(array2, "Starting");

            SwapRowsInPlaces();
            StartClass.PrintArray(array2, "Result");
        }

    }
}
