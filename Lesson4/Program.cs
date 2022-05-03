namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            short arrayLenght;
            Console.WriteLine("Enter the size of the array");

            try
            {
                arrayLenght = short.Parse(Console.ReadLine());
                if (arrayLenght == 0)
                    throw new IndexOutOfRangeException();
                else if (arrayLenght < 0)
                    throw new ArgumentException();
                else if (arrayLenght > 10 || arrayLenght == 1)
                    throw new Exception(message: "Choose number betweeen 2 and 10");

                int[] array = new int[arrayLenght];
                Console.WriteLine("Enter array numbers");

                short i = 0;
                while (i < arrayLenght)
                {
                    while (!Int32.TryParse(Console.ReadLine(), out array[i]))
                    {
                        Console.WriteLine("Incorrect value. Try again.");
                    }
                    i++;
                }

                // Поиск 2-го максимального элемента
                int iMax1, iMax2;
                bool justDecreasing = true; 
                if (array[0] > array[1])
                {
                    iMax1 = 0;
                    iMax2 = 1;
                    justDecreasing = false;
                }
                else if (array[1] > array[0]) 
                {
                    iMax1 = 1;
                    iMax2 = 0;
                    justDecreasing=false;
                }
                else
                {
                    iMax1 = 1;
                    iMax2 = 0;
                }
                    
                for (i = 2; i < arrayLenght; i++)
                {
                    if (array[i] > array[iMax1])
                    {
                        iMax2 = iMax1;
                        iMax1 = i;
                    }
                    else if (array[i] > array[iMax2] && array[i] != array[iMax1])
                    {
                        iMax2 = i;
                    }
                    else if (array[i] < array[iMax2] && justDecreasing)
                    {
                        iMax2 = i;
                        justDecreasing = false;
                    }
                }
                if (justDecreasing)
                    Console.WriteLine("All the elements are equal");
                else
                    Console.WriteLine($"pre-max element: {array[iMax2]}"); 

            }
            catch (FormatException ex)
            {
                Console.WriteLine($"{ex.GetType().Name}: Incorrect value entered.");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"{ex.GetType().Name}: Array size cannot be equal 0.");
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine($"{ex.GetType().Name}: The size of the array cannot be less than 0.");
            }
            catch  (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();

        }
    }
}