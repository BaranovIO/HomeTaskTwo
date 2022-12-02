
int CutNumber (int number)
{
    int secondDigit = (number / 10 ) % 10;
    return secondDigit;
}

Console.Write("Введите трёхначное число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int result = CutNumber(userNumber);
Console.WriteLine($"Вторая цифра вашего числа: {result}");
