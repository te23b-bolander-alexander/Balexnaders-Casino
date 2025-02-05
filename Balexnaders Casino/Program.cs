 
string money = "300";
string slots = ("");
string horsebetting = ("");
string plinko = ("");

Console.WriteLine("HELLO AND WELCOME TO BALEXANDERS CASINO! THE BEST CASINO IN THE ENTIRE WORLD!!!!");
Console.WriteLine("WE HAVE A BUNCH OF DIFFRENT GAMES LIKE SLOTS!! HORSEBETTING!! AND LAST BUT NOT LEAST PLINKO!!!!");
Console.WriteLine($"You have {money} Euro");
Console.WriteLine("What game would you like to play?");
Console.WriteLine("slots, horsebetting or plinko?");


//Checker that checks if you have chosen a game or not.
string right = Console.ReadLine();
int rightnum = 0;
bool success = int.TryParse(right, out rightnum);
if (success == false)
{
    Console.WriteLine("You have to select a game");
}





Console.ReadLine();
