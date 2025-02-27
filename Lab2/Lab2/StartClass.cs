namespace Lab2Cs
{
    internal class StartClass
    {
        static void Main(string[] args)
        {
            Task2_1 task2_1 = new();
            task2_1.Task1D();
            task2_1.Task2D();

            Task2_2 task2_2 = new();
            task2_2.Task1D();

            Task2_3 task2_3 = new();
            task2_3.Task2D();

            Task2_4 task2_4 = new();
            task2_4.TaskS();
        }

        public static void PrintArray(int[] array, string title)
        {
            Console.WriteLine($"{title} 1D array: ");
            foreach (int element in array)
                Console.Write(element + " ");

            Console.WriteLine(); 
        }

        public static void PrintArray(int[,] array, string title)
        {
            Console.WriteLine($"{title} 2D array: ");

            int rows = array.GetLength(0);
            int columns = array.GetLength(1); 

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                    Console.Write(array[i, j] + " ");
                Console.WriteLine();
            }
        }
        public static void PrintArray(int[][] array, string title)
        {
            Console.WriteLine($"{title} staired array: ");

            int rows = array.GetLength(0);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                    Console.Write(array[i][j] + " ");
                Console.WriteLine();
            }
        }
        public static int[] CreateRandomArray(int length)
        {
            Random random = new Random((int)DateTime.Now.Ticks);

            int[] array = new int[length];
            for (int i = 0;i < length;i++)
                array[i] = random.Next(-20, 20);

            return array;
        }
        public static int[,] CreateRandomArray(int height, int width)
        {
            Random random = new Random((int)DateTime.Now.Ticks);

            int[,] array = new int[height, width];
            for (int i = 0; i < height; i++)
                for (int j = 0; j < width; j++)
                    array[i, j] = random.Next(-20, 20);

            return array;
        }
    }
}
