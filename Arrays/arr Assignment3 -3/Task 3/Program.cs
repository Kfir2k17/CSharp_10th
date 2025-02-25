int[] electives = new int[100];
for (int i = 0; i < 300; i++)
{
    Console.WriteLine("\nstudent " + i);
    Console.WriteLine("\n\nHow many electives would you want?");
    int count = int.Parse(Console.ReadLine());
    for (int b = 0; b < count; b++)
    {
        Console.WriteLine("Please enter the number of elective " + b);
        electives[int.Parse(Console.ReadLine())]++;
    }
}

int max = 0;
int maxnum = 0;
for (int i = 0; i < electives.Length; i++)
{
    if (electives[i] > max)
    {
        max = electives[i];
        maxnum = i;
    }
}

for (int i = 0; i < electives.Length; i++)
    Console.WriteLine("{0} students chose elective {1}", electives[i], i);

Console.WriteLine("The elective that was chosen the most was elective ", maxnum);