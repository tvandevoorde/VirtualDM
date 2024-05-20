using VirtualDM.Game;

Console.WriteLine("Welcome to VirtualDM");

var character = new Character();

Console.WriteLine("Please enter your character's name:");
character.Name = Console.ReadLine()!;

Console.WriteLine("Please enter your character's background:");
character.Background = Console.ReadLine()!;

Console.WriteLine($"Your character is named {character.Name}");
Console.WriteLine($"Your character's background is: {character.Background}");

Console.ReadLine();