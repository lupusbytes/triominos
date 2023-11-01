Console.Write("Indtast antal spillere: ");
var playerCount = int.Parse(Console.ReadLine()!);
var players = new Player[playerCount];

for (var i = 0; i < playerCount; i++)
{
    Console.Write($"Spiller {i + 1} navn: ");
    var playerName = Console.ReadLine();
    players[i] = new Player(playerName!);
}

var turn = 0;
while (true)
{
    var playerTurnIndex = turn % players.Length;
    var player = players[playerTurnIndex];
    var validPoints = false;
    while (!validPoints)
    {
        Console.Write($"{player.Name}: ");
        var stringPoints = Console.ReadLine();
        validPoints = int.TryParse(stringPoints, out var points);
        if (validPoints)
        {
            player.Points += points;
        }
    }
    Console.WriteLine($"{player.Name} har nu {player.Points} point.");
    turn++;
}


public class Player
{
    public string Name { get; }

    public int Points { get; set; } = 0;

    public Player(string name)
    {
        Name = name;
    }
}