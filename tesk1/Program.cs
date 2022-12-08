//Пример 4-го вида из леции
 string Method4(int count, string c)
{
    int i = 0;
    string result = ""; //Пустую строку можно написать String.Empty

    while (i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}

string res =  Method4(10, "мама, я гей");
Console.WriteLine(res);
