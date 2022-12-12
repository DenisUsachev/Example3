//Пример 4-го вида из леции циклом for
 string Method4(int count, string c)
{
    string result = ""; //Пустую строку можно написать String.Empty
    
    for( int i = 0; i < count; i++)
    {
        result = result + c;
    }
    return result;
}

string res =  Method4(10, "мама, я гей! ");
Console.WriteLine(res);