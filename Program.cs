//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
Console.WriteLine ("Введите число A: ");
int A = int.Parse (Console.ReadLine()!);
Console.WriteLine ("Введите число B: ");
int B = int.Parse (Console.ReadLine()!);
Console.WriteLine($"Произведение числа {A} в степень {B} = {GetDegree(A,B)}");
int GetDegree (int a, int b){
    int result = Convert.ToInt32(Math.Pow(a,b));
    return result;
}
*/


//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
Console.WriteLine ("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine ($"Сумма цифр в числе {a} = {GetSum(a)}");

int GetSum(int a){
int sum = 0;
while (a > 0){
    sum = sum + a%10;
    a = a/10;
}

    return sum;
}
*/

//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*
int[] array = new int[8];
FillArray(array.Length);

Console.WriteLine ("[");
Console.WriteLine(String.Join(",",array));
Console.WriteLine("]");

void FillArray(int size){
    for (int i = 0; i < size; i++)
    {
array[i] = new Random().Next(8);
    }
}
*/

