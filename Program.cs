// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

//Примеры: ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
//["1234", "1567", "-2", "computer science"] -> ["-2"] 
//["Russia", "Denmark", "Kazan"] -> []





    

Console.WriteLine("Введите количество элементов массива");
int N = int.Parse(Console.ReadLine());
string[] arrayIn=new string[N];
string[] arrayOut=new string[N];

Console.WriteLine("Введите элементы массива ");
for(int i =0; i < arrayIn.Length; i=i+1)
{
        arrayIn[i] = Console.ReadLine();
}
Console.WriteLine();

Console.WriteLine("Массив введенных данных : ");
Console.Write("[");
for(int i =0; i < N; i=i+1)
{    
    Console.Write($"{arrayIn[i]}   ");
}
Console.WriteLine("]");
Console.WriteLine();

int j = 0;
 
for(int i=0; i<N; i=i+1)
{
    if (arrayIn[i].Length <=3)
    {
        arrayOut[j]=arrayIn[i];
        j=j+1;
    }
}

Console.WriteLine("Преобразованный массив  данных (длина элементов не более 3) : ");
Console.Write("[");
for(int i =0; i <=j; i=i+1)
{    
    Console.Write($"{arrayOut[i]}   " );
}
Console.WriteLine("]");