// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

//методы обработки
//метод запроса данных пользователя
int SetSize(string message=" ")
{
    Console.WriteLine($" {message}: ");
    string size_mass=Console.ReadLine();
    int size=int.Parse(size_mass);
    return size;
}

//метод создания массива
double[] FillArray (int Size)
{
    double[] array=new double[Size];

    Random rnd =new Random();

    for(int i=0;i<array.Length;i++)
    {
        int minValue=10;
        int maxValue=99;
       
        array[i]=Math.Round(rnd.Next(minValue,maxValue)*0.1,1);

    }
    return array;
}

//метод поиска максимума
double MaxArray(double[] array)
{
    double max=array[0];

    for (int i=0;i<array.Length;i++)
    {
        if(array[i]>max)
        {
            max=array[i];
        }
    }
    
    return max;
}

//метод поиска минимума
double MinArray(double[] array)
{
    double min=array[0];

    for (int i=0;i<array.Length;i++)
    {
        if(array[i]<min)
        {
            min=array[i];
        }
    }
    
    return min;
}

//метод расчета разности
double Raznost(double min,double max)
{
  return max-min;
}

//выполнение
int size=SetSize("Введите размер массива: ");
double[] array=FillArray(size);

Console.WriteLine("Созданный массив:");
Console.WriteLine(string.Join(" ",array));

double min=MinArray(array);
double max=MaxArray(array);

Console.WriteLine($"Максимальное число: {max}");
Console.WriteLine($"Минимальное число: {min}");
Console.WriteLine($"Разность: {Raznost(min,max)}");


