class Program
{
    static void Main(string[] args)
    {
        double[] array1 = new double[7];
        double[] array2 = new double[9];
        
        Console.WriteLine("Введите значения первого массива:");
        for (int i = 0; i < array1.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array1[i] = Convert.ToDouble(Console.ReadLine());
        }
        
        Console.WriteLine("\nВведите значения второго массива:");
        for (int i = 0; i < array2.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array2[i] = Convert.ToDouble(Console.ReadLine());
        }
        

        double[] sortedArray = new double[array1.Length + array2.Length];
        

        for (int i = 0; i < array1.Length; i++)
        {
            sortedArray[i] = array1[i];
        }
        

        for (int i = 0; i < array2.Length; i++)
        {
            sortedArray[array1.Length + i] = array2[i];
        }
        

        for (int i = 0; i < sortedArray.Length - 1; i++)
        {
            for (int j = 0; j < sortedArray.Length - 1 - i; j++)
            {
                if (sortedArray[j] < sortedArray[j + 1])
                {
                    double temp = sortedArray[j];
                    sortedArray[j] = sortedArray[j + 1];
                    sortedArray[j + 1] = temp;
                }
            }
        }

        
        Console.WriteLine("\nТретий массив, упорядоченный по убыванию:");
        foreach (double num in sortedArray)
        {
            Console.Write(num + " ");
        }
        
        Console.ReadLine();
    }
}
