/*
int CutNumber (int number)
{
    int secondDigit = (number / 10 ) % 10;
    return secondDigit;
}

Console.Write("Введите трёхначное число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int result = CutNumber(userNumber);
Console.WriteLine($"Вторая цифра вашего числа: {result}");
*/
/*
int PrintThirdDigit(int number)
{
    if (number > 99)
    {
        while (number >= 1000)
        {
             number = number / 10;
        } 

       int thirdDigit = number % 10;
       return thirdDigit;
    }
    
    else 
    {
       return number = -1;
    }
}

Console.Write("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int result = PrintThirdDigit(userNumber);
if (result > 0)
{
    Console.Write($"Третья цифра вашего числа: {result}");
}

else
{
    Console.Write("В вашем числе нет третьей цифры");
}
*/

bool DayOfWeek (int day)
{
    if (day == 6 || day ==7)
        return true;
    else 
        return false;
}

Console.Write("Хотите узнать является ли день недели выходным? Введите его порядковый номер: ");
int userDay = Convert.ToInt32(Console.ReadLine());
bool result = DayOfWeek(userDay);
Console.WriteLine(result);

