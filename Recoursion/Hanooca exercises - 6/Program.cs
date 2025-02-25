//תרגיל 1
using System.Transactions;

static bool OnlyOddOrEvenR(int num, bool even) //בודקת האם כל המספרים זוגיים או אי זוגיים
{
    if (num == 0)
        return true;

    if ((num % 10) % 2 == 0 != even)
        return false;

    return OnlyOddOrEvenR(num / 10, even);
}

static bool OnlyOddOrEven(int num) //פעולת מעטפת
{
    return OnlyOddOrEvenR(num, num % 2 == 0);
}

Console.WriteLine(OnlyOddOrEven(2467));

//תרגיל 2
static int DisR(int num1, int num2, int counter1, int counter2)// בודקת את כמות הספרות של כל מספר, ואז מוציאה את ההפרש בינהם
{
    if (num1 > 0 && num2 > 0)
        return DisR(num1 / 10, num2 / 10, counter1 + 1, counter2 + 1);

    if (num1 == 0 && num2 > 0)
        return DisR(num1, num2 / 10, counter1, counter2 + 1);

    if (num2 == 0 && num1 > 0)
        return DisR(num1 / 10, num2, counter1 + 1, counter2);

    return Math.Abs(counter1 - counter2);
}

static int Dis(int num1, int num2) //פעולת מעטפת
{
    return DisR(num1, num2, 0, 0);
}

Console.WriteLine(Dis(123, 1234));

//תרגיל 3
static int AbsDis(int num1, int num2) //מוצאת את ההפרש של ספרות תואמות
{
    if (num1 == 0 || num2 == 0)
        return 0;

    return Math.Abs(num1 % 10 - num2 % 10) + AbsDis(num1 / 10, num2 / 10);
}

Console.WriteLine(AbsDis(666, 123));

//תרגיל 4
static int CheckPosition(int num1, int num2)
{
    if (num1 == 0 || num2 == 0)
        return 0;

    if (num1 % 10 == num2 % 10)
        return CheckPosition(num1 / 10, num2 / 10) + 1;

    return CheckPosition(num1 / 10, num2 / 10);
}

Console.WriteLine(AbsDis(6423, 123));