using System.Diagnostics;

static int[] Game1(int num)
    {
    int[] players = new int[num+1];
    for (int i = 1; i < num+1; i++)
    {
        int current = 0;
        int prev = -1;
        int counter = 1;

        Console.WriteLine("\n\nPlease enter the scores of player " + i);
        while (current > prev)
        {   
            prev = current;
            Console.WriteLine("\nPlease enter the distance of throw {0}", counter);
            current = int.Parse(Console.ReadLine());
            counter++;

        }
        players[i] = prev;
    }
    return players;
}

static int Game2(int[] players)
{
    int max = 0;
    int max_num = 0;

    for (int i = 1; i <= players.Length;i++) 
    {
        if (players[i] > max)
        {
            max_num = i;
            max = players[i];
        }
    }
    return max_num;

}