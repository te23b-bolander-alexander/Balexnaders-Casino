
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



//everything that the alpha can do :)
while(AlphaHp > 0 && SigmaHp > 0)
{

//The Alphas turn
Console.WriteLine(" Its time for the Alpha to attack ");
Console.WriteLine($"p-p Alphas Hp is {AlphaHp} p-p The Sigmas Hp is {SigmaHp}");
Console.WriteLine(" press 'a' to attack the sigma or 'h' to heal yourself (the alpha)");

string Alphachoose = Console.ReadLine();

if (Alphachoose == "a")
{
    SigmaHp -= AlphaAttack;
    Console.WriteLine($"The alpha attacked the sigma and did {AlphaAttack} Damage!!! Wowzers");
}
if (Alphachoose == "h") 
{
    AlphaHp += AlphaHeal;
    Console.WriteLine($"the alpha choose to heal for {AlphaHeal} amount of health");
}
//while (Alphachoose != "a" || "h")
{
    Console.WriteLine("You have to press a or h");
      
}


// everything the sigma can do
if(SigmaHp > 0)
{
    Console.WriteLine("|| huh i guess tis time for the sigma to attack ||");
    Console.WriteLine($"p-p Alphas Hp is {AlphaHp} p-p The Sigmas Hp is {SigmaHp}");
    int SigmaChoose = rnd.Next(0, 2);

    if(SigmaChoose == 0)
    {
        AlphaHp -= SigmaAttack;
        Console.WriteLine($"|| THe sigma choose to attack the alpha and did {SigmaAttack} Damage ||");
    }
    else
    {
        SigmaHp += SigmaHeal;
        Console.WriteLine($"|| The sigma choose to heal for {SigmaHeal} health||");
    }

    if(AlphaHp > 0)
    {
        Console.WriteLine("Huh the alpha stays victorious what a suprise  : o");
    }
    else
    {
        Console.WriteLine("Seems like the Sigma won i mean sigma and smegma are kinda close so it makes sense i guess");//wtf /alex.s och jack gisslan
    }
}
}



}
Console.ReadLine();
