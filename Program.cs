string [] CreateArray()
{
    Console.WriteLine("Введите массив строк через пробел");
    string str = Console.ReadLine();
    string  [] array=stroka.Split(" ");
    return array;
}
string [] array = CreateArray();
int count = 0;
for ( int i = 0; i < array.Lenght; i++)
{
    if ( array [i].Lenght <= 3)
    {
        array [count] = array [i];
        count++;
    }
}


