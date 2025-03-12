
using System.Runtime.InteropServices;
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

        List<Pokemon> pokemons = [Pikachu, Squirtle, Charmander, Ditto];

        foreach (Pokemon p in pokemons)
        {
            Console.WriteLine($"Name: {p.name}, HP: {p.HP}");
        }

        Console.WriteLine("Var snäll att välj en pokemon");
        string answer = Console.ReadLine() ?? string.Empty;

        foreach (Pokemon p in pokemons)
        {
            if (answer.ToLower() == p.name.ToLower())
            {
                Console.WriteLine("Attacks: ");
                foreach (PokemonAttacks attacks in p.attacks)
                {
                    Console.WriteLine($"- {attacks.AttackName}: {attacks.AttackDamage}");
                }
            }
        }

        

            Console.ReadLine();

         }



    }





