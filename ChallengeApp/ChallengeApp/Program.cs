int number = 1004566;
string numberAsString = number.ToString();
char[] digits = numberAsString.ToArray();

int count0 = 0;
int count1 = 0;
int count2 = 0;
int count3 = 0;
int count4 = 0;
int count5 = 0;
int count6 = 0;
int count7 = 0;
int count8 = 0;
int count9 = 0;

foreach (char digit in digits)
{
    if (digit == '0')
    { count0++; }

    else if (digit == '1')
    { count1++; }

    else if (digit == '2')
    { count2++; }

    else if (digit == '3')
    { count3++; }

    else if (digit == '4')
    { count4++; }

    else if (digit == '5')
    { count5++; }

    else if (digit == '6')
    { count6++; }

    else if (digit == '7')
    { count7++; }

    else if (digit == '8')
    { count8++; }

    else if (digit == '9')
    { count9++; }
}
Console.WriteLine("Ilość danych cyfr w liczbie " + number);
Console.WriteLine("0 => " + count0);
Console.WriteLine("1 => " + count1);
Console.WriteLine("2 => " + count2);
Console.WriteLine("3 => " + count3);
Console.WriteLine("4 => " + count4);
Console.WriteLine("5 => " + count5);
Console.WriteLine("6 => " + count6);
Console.WriteLine("7 => " + count7);
Console.WriteLine("8 => " + count8);
Console.WriteLine("9 => " + count9);