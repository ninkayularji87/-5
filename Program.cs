//Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве. 
/* int size = 4;
int minValue = 100;
int maxValue = 1000;
int [] array = new int[size];
for (int i=0; i < array.Length; i++)
{
    array[i] = new Random().Next(minValue, maxValue);
}
Console.WriteLine(string.Join(",", array));
int count = 0;
foreach (int el in array) 
{ 
if (el%2==0)
    {
    count+=1;
    }
}
Console.WriteLine("Четных чисел " + count); */


//Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
/* int size = 4;
int [] array = new int[size];
for (int i=0; i < array.Length; i++)
{
    array[i] = new Random().Next(1,100);
}
Console.WriteLine(string.Join(",", array));
int sum = 0;
foreach (int el in array)
{
    sum=array[1]+array[3];
}
Console.WriteLine(sum); */


//Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

int size = 5;
int [] array = new int[size];
for (int i=0; i<array.Length; i++)
{
    array[i]= new Random().Next(1,100);
}
Console.WriteLine(string.Join(",", array));
int max = int.MinValue;
int min = int.MaxValue;
foreach (int el in array)
{
if (el>max)
{
    max=el;
}
}
foreach (int el in array)
{
if (el<min)
{
    min = el;
}
}
int p = max - min;
Console.WriteLine(p);
