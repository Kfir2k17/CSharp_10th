using System.Security.AccessControl;

static int Divider(int num)
{
    int  digit_count = 0;
    int num2 = num;
    int right = 0;
    int left = 0;
    while (num2 > 0)
    {
        num2 /= 10;
        digit_count++;
    }

    if (digit_count % 2 == 0)
    {    
        right = num % (int)Math.Pow(10, digit_count / 2);
        left = num / (int)Math.Pow(10, digit_count / 2);
        
    }

    else
    {
        right = num % (int)Math.Pow(10, digit_count / 2);
        left = num / (int)Math.Pow(10, (digit_count / 2) + 1);
    }

    return Math.Max(right, left);
}

Console.WriteLine("Please Enter Number");
int num = int.Parse(Console.ReadLine());

Console.WriteLine("The bigger part is " + Divider(num));
