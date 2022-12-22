int N = new Random().Next(1, 101);
Console.WriteLine($"N = {N}");

int heats = 0;      //0
int tails = 0;      //1
int[] coins = new int[N];

foreach (int item in coins)
{
    int side = new Random().Next(0, 2);
    coins[item] = side;
  Console.Write($"[{coins[item]}] ");
    if (coins[item] == 0)
    {
        heats++;
    }
    else
    {
        tails++;
    }
}
Console.WriteLine($"\nheats - {heats}\ntails - {tails}");
if (heats > tails)
{
    Console.WriteLine($"{tails} minimum number of coins to flip");
}
else
{
    Console.WriteLine($"{heats} minimum number of coins to flip");
}
