// Рашит Фатхутдинов, [01/07/22 00:54]
//Задача №21
//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 2D пространстве
//A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,21

//Метод - подпрограмма 1: ввод координаты, т.е. х и у
int[] Input()
{
    //Инициализация пустого массива из 2-х элементов
    int[] Array = new int[2];
    Console.Write("Введите координату x: ");
        //Присвоение значение 0-му элементу массива (точке х)
        Array[0] = Convert.ToInt32(Console.ReadLine()); 
    Console.Write("Введите координату y: ");
        //Присвоение значение 1-му элементу массива (точке у)
        Array[1]  = Convert.ToInt32(Console.ReadLine());
    //возвращаем массив из 2-х точек (координату в двухмерном пространстве)
    return Array;
}
//Метод - подпрограмма 2: вычисляем точку С 
int[] calc_point_C(int[] arr1, int[] arr2)
{
    int[] arr_vector = new int[2];
    arr_vector[0] = arr2[0]-arr1[0];
    arr_vector[1] = arr2[1]-arr1[1];
    return arr_vector;
}
//Метод - подпрограмма 3: вывод точки в консоль
void print_point(int[] arr1)
{
    Console.Write('['+Convert.ToString(arr1[0]) +';'+ Convert.ToString(arr1[1])+']');
}

//Основное тело программы
Console.WriteLine("Введите координату начала отрезка");
    int[] arr_point_A = Input();
Console.WriteLine("Введите координату конца отрезка");
    int[] arr_point_B = Input();
//Координата точки С: демонстрация передачи и возвращения массива в метод
int[] arr_point_C = calc_point_C(arr_point_A,arr_point_B);
//длина отрезка, заданная двумя коорбинатами (вычисляем как длину вектора)
double vector_len = Math.Sqrt(arr_point_C[0]*arr_point_C[0] + arr_point_C[1]*arr_point_C[1]);
//Вывод результата вычислений - длины отрезка
Console.Write("Длина отрезка по точкам ");
    print_point(arr_point_A); //вызов подпрограммы 3
Console.Write(" и ");
    print_point(arr_point_B); //вызов подпрограммы 3
Console.Write(" -> " + Math.Round(vector_len,2));
    //Добавляем переход на новую строку в консоли
    Console.WriteLine();


    // https://docs.microsoft.com/ru-ru/dotnet/api/system.math.round?view=net-6.0