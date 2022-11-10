string[] CreateArray()
{
    Console.WriteLine("Введите массив строк через пробел");
    string? str = Console.ReadLine();
    if( str == null)
    {
        str = "";
    }
    string[] array=str.Split(" ");
    return array;
}

string[] arrayStr = CreateArray();
int count = 0;
for ( int i = 0; i < arrayStr.Length; i++)
{
    if ( arrayStr[i].Length <= 3)
    {
        arrayStr[count] = arrayStr [i];
        count++;
    }
}
Console.WriteLine();
Console.WriteLine("Конечный массив: [" + string.Join(", ", arrayStr, 0, count) + "]");