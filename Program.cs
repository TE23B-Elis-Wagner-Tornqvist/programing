
// using System.Formats.Asn1;

// List<string> pokemons = [" 0. Pikachu", " 1. squirtle"];
// List<string> Pattacks = ["thunderbolt", "electroball", "thundershock"];
// List<string> Sattacks = ["waterpulse", "aquatail", "watergun"];
// int sHP = 250;
// int watergunDamage = 20;
// int waterpulseDamage = 50;
// int aquatailDamage = 80;


// int OpponentPokemon = Random.Shared.Next(0, 2);
// int pHP = 250;
// int thunderboltDamage = 50;
// int electroballDamage = 80;
// int thundershockDamage = 20;


// Console.WriteLine("Välkommen till pokemon! Du kommer få välja en pokemon att fightas och vinna över gym ledaren Elis!");
// Console.WriteLine("Här är dina val (skriv nummer):");

// for(int i = 0; i < pokemons.Count; i++)
// {
//     Console.WriteLine($"{pokemons[i]}");
// }
// string answerText = Console.ReadLine() ?? string.Empty;
// int answer = 0;
// bool success = int.TryParse(answerText, out answer);

// if(answer == 0 && success == true)
// {


// opponent(pokemons, OpponentPokemon);
// pikachu(Pattacks, thunderboltDamage,pokemons, OpponentPokemon, electroballDamage, thundershockDamage, sHP, pHP);

// Console.ReadLine();

// }



// static void pikachu(List<string> Pattacks, int thunderboltDamage, List<string> pokemons, int OpponentPokemon, int electroballDamage, int thundershockDamage, int sHP, int pHP)
// {
// Console.WriteLine($"Du valde pikachu");
// Console.WriteLine("Pikachus attacker:");

// for(int i = 0; i < Pattacks.Count; i++)
// {
//     Console.WriteLine($"{Pattacks[i]}");
// }
// Console.WriteLine("Vilken attack vill du välja för att attackera Elis?");
// string answer = Console.ReadLine() ?? string.Empty;


// if(answer.ToLower() == "thunderbolt")
// {
//     sHP = sHP - thunderboltDamage;
//     Console.WriteLine($"Pikachu använde {answer} och gjorde {thunderboltDamage} på Elis pokemon {pokemons[OpponentPokemon]}");
//     Console.WriteLine($"Elis pokemon {pokemons[OpponentPokemon]} har {sHP} health kvar! Medans pikachu har {pHP} health kvar");
//     Console.ReadLine();
// }

// if(answer.ToLower() == "electroball")
// {
//      Console.WriteLine($"Pikachu använde {answer} och gjorde {electroballDamage} på Elis pokemon {pokemons[OpponentPokemon]}");
//     Console.ReadLine();
// }

// if(answer.ToLower() == "thundershock")
// {
//      Console.WriteLine($"Pikachu använde {answer} och gjorde {thundershockDamage} på Elis pokemon {pokemons[OpponentPokemon]}");
//     Console.ReadLine();
// }

// }

// static void opponent(List<string> pokemons, int OpponentPokemon)
// {
    
//     Console.WriteLine($"Gym ledaren Elis väljer: {pokemons[OpponentPokemon]}");
// }













Players A = new();
Players P = new();

P.HitPoints -= 50;

A.Name = "Teo";

Console.WriteLine(A.Name);
Console.WriteLine(P.HitPoints);

Console.ReadLine();

Fight(A);


static void Fight(Players A)
{
    Console.WriteLine(A.Name);
}


class Players
{
    public string Name = "Elis";
    public int HitPoints = 250;
    public int WeaponDamage = 25;

    public int Attack()
    {
        return Random.Shared.Next(WeaponDamage, 100);
    }
}





