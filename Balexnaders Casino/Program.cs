
using System.Net.WebSockets;
using System.Xml.Serialization;

static void Metod()
{


Random rnd = new Random();
int AlphaHp = 40;
int SigmaHp = 40;
int AlphaAttack = rnd.Next(1, 10);
int SigmaAttack = rnd.Next(1, 10);
int AlphaHeal = rnd.Next(1, 3);
int SigmaHeal = rnd.Next(1, 5);


bool kall = false;

string[] namn = ["sigma", "alpha"];

//everything that the alpha can do :)
while(AlphaHp > 0 && SigmaHp > 0)
{

//The Alphas turn
Console.WriteLine( $" Its time for the {namn[1]} to attack ");
Console.WriteLine($"p-p {namn[1]} Hp is {AlphaHp} p-p The Sigmas Hp is {SigmaHp}");
Console.WriteLine($" press 'a' to attack the sigma or 'h' to heal yourself (the alpha)");

string Alphachoose = Console.ReadLine();
if (Alphachoose == "a" || Alphachoose == "h")
      {
        kall = true;
 
      }
while ( kall == false)
{
    Console.WriteLine("You have to press a or h");
    Alphachoose = Console.ReadLine();
      

      if (Alphachoose == "a" || Alphachoose == "h")
      {
        kall = true;
 
      }
}
kall = false;

if (Alphachoose == "a")
{
    SigmaHp -= AlphaAttack;
    Console.WriteLine($"The {namn[1]} attacked the {namn[0]} and did {AlphaAttack} Damage!!! Wowzers");
}
if (Alphachoose == "h") 
{
    AlphaHp += AlphaHeal;
    Console.WriteLine($"the {namn[1]} choose to heal for {AlphaHeal} amount of health");
}


// everything the sigma can do
if(SigmaHp > 0)
{
    Console.WriteLine($"|| huh i guess tis time for the {namn[0]} to attack ||");
    Console.WriteLine($"p-p {namn[1]} Hp is {AlphaHp} p-p The Sigmas Hp is {SigmaHp}");
    int SigmaChoose = rnd.Next(0, 2);

    if(SigmaChoose == 0)
    {
        AlphaHp -= SigmaAttack;
        Console.WriteLine($"|| THe sigma choose to attack the {namn[1]} and did {SigmaAttack} Damage ||");
    }
    else
    {
        SigmaHp += SigmaHeal;
        Console.WriteLine($"|| The {namn[0]} choose to heal for {SigmaHeal} health||");
    }

    if(AlphaHp > 0)
    {
        Console.WriteLine($"Huh the {namn[1]} stays victorious what a suprise  : o");
    }
    else
    {
        Console.WriteLine($"Seems like the {namn[0]} won i mean {namn[0]} and smegma are kinda close so it makes sense i guess");//wtf /alex.s och jack gisslan
    }
}
}



}
Metod();
Console.ReadLine();
