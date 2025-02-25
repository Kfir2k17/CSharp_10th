static int FerrisWheel(int[] weights, int max_weight)
{
    int people = 0;
    int weight = 0;
    
    while(weight <= max_weight && people < weights.Length)
    {
        weight += weights[people];
        people++;
    }
    return people;
}