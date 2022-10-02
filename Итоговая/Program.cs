// Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна которых меньше либо равна 3 символам 
//Первоначальный массив можно ввести с клавиатуры либо задать на старте выполнения алгоритма.
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
string [] array =  {"hello","привет","hi","Cześć","ola","123","685","456789"};
int size = array.Length;
string [] emptyarray= new string[size];
int indexEmptyarray = 0;
int limitation=3;

for(int k= 0;k<array.Length;k++)
{
    Console.Write($"{array[k]} |");
}
Console.WriteLine();
for(int i= 0;i<size;i++)
{
    if(array[i].Length<=limitation)
    {
        emptyarray[indexEmptyarray]=array[i];
        indexEmptyarray++;
    }
    else;
    
}for(int j= 0;j<emptyarray.Length;j++)
{
    Console.Write($"{emptyarray[j]} |");
}