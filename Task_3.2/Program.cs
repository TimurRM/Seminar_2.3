
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21


double SystemCoor(int x1, int y1, int x2, int y2){
    return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
}

                Console.WriteLine("Введите координату x1");
                int Ax = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите координату y1");
                int Ay = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите координату x2");
                int Bx = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите координату y2");
                int By = Convert.ToInt32(Console.ReadLine());
                
        Console.WriteLine(Math.Round(SystemCoor(Ax, Ay, Bx, By), 4));

                
            