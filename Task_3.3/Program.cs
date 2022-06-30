// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

        Console.Write("Input number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.Write(number + " ->  ");
        
         if (number >= 0)
        {
            for (int current = 0; current <= number; current ++)
                Console.Write(current * current + " ");      
        }
        else
        {
            for (int current = -1; current >= number; current --)
                Console.Write(current * current + " ");
        }