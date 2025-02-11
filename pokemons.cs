
using System.Formats.Asn1;
using System.Reflection;

class PokemonAttacks
{
    public string AttackName = "p";
    public int AttackDamage;
}


class Pokemon
{
    public string name;
    public int HP;
    public List<PokemonAttacks> attacks;

    public Pokemon(string name, int HP)
    {
        this.name = name;
        this.HP = HP;
        this.attacks = new();
    }

    public void AddAttacks(string AttackName, int AttackDamage)
    {
        attacks.Add(new PokemonAttacks() { AttackName = AttackName, AttackDamage = AttackDamage});
    }



    class Program
    {


static void Main()
{

    Pokemon Pikachu = new Pokemon("Pikachu", 250);


    Pikachu.AddAttacks("Thunderbolt", 50);
    Pikachu.AddAttacks("Electroball", 80);
    Pikachu.AddAttacks("Electroshock", 20);


    Pokemon Squirtle = new Pokemon("Squirtle", 250);

    Squirtle.AddAttacks("Watergun", 20);
    Squirtle.AddAttacks("Aquatail", 50);
    Squirtle.AddAttacks("Waterpulse", 80);

    Pokemon Charmander = new Pokemon("Charmander", 250);

    Charmander.AddAttacks("flamethrower", 80);
    Charmander.AddAttacks("Firebreath", 20);
    Charmander.AddAttacks("dragontail", 50);

    Pokemon Ditto = new Pokemon("Ditto", 250);

    Ditto.AddAttacks("steal", 50);
    Ditto.AddAttacks("squirt", 80);
    Ditto.AddAttacks("Headbutt", 20);


    Console.WriteLine($"Name: {Pikachu.name}, HP: {Pikachu.HP}");
    Console.WriteLine($"Name: {Squirtle.name}, HP: {Squirtle.HP}");
    Console.WriteLine($"Name: {Charmander.name}, HP: {Charmander.HP}");
    Console.WriteLine($"Name: {Ditto.name}, HP: {Ditto.HP}");


    Console.WriteLine("Var snäll att välj en pokemon");
    string answer = Console.ReadLine() ?? string.Empty;

    if(answer.ToLower() == Pikachu.name)
    {
         Console.WriteLine("Attacks: ");
    foreach(PokemonAttacks attacks in Pikachu.attacks)
    {
        Console.WriteLine($"- {attacks.AttackName}: {attacks.AttackDamage}");
    }

    }


   

    
    // Console.WriteLine($"Attacks: ");   

    // foreach(PokemonAttacks attacks in Squirtle.attacks)
    // {
    //     Console.WriteLine($"- {attacks.AttackName}: {attacks.AttackDamage}");
    // }

    

    

    Console.ReadLine();

}



    }
    }
    


