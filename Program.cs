
using System.Runtime.InteropServices;
using System.Security.Cryptography;
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

        Pokemon Mew = new Pokemon("Mew", 250);

        Mew.AddAttacks("Psycic", 80);
        Mew.AddAttacks("Darkpulse", 50);
        Mew.AddAttacks("Gravity", 20);

        List<Pokemon> pokemons = [Pikachu, Squirtle, Charmander, Ditto, Mew];

        battleEnemy GymLeaderOne = new battleEnemy("ELis", 1);
        GymLeaderOne.assignedPokemon = Pikachu;
        battleEnemy GymLeaderTwo = new battleEnemy("Teo", 2);
        GymLeaderTwo.assignedPokemon = Ditto;
        battleEnemy GymLeaderThree = new battleEnemy("oscar", 3);
        GymLeaderThree.assignedPokemon = Squirtle;
        battleEnemy GymLeaderFour = new battleEnemy("Anton", 4);
        GymLeaderFour.assignedPokemon = Charmander;
        battleEnemy GymLeaderFive = new battleEnemy("CoolGuy", 5);
        GymLeaderFive.assignedPokemon = Mew;
        
        

        Console.WriteLine("Detta är dina möjliga motståndare: ");
        List<battleEnemy> battleEnemies = [GymLeaderOne, GymLeaderTwo, GymLeaderThree, GymLeaderFour, GymLeaderFive];

        foreach(battleEnemy gym in battleEnemies)
        {
            Console.WriteLine($"Name: {gym.name} Rang: {gym.rang}");
        }
        
        Console.WriteLine("Vem skulle du vilja möta?");

        string gymPick = Console.ReadLine() ?? string.Empty;

        bool successPick = false;

        while(!successPick)
        {

            foreach(battleEnemy g in battleEnemies)
            {
                if(gymPick.ToLower() == g.name.ToLower())
                {
                    successPick = true;
                    Console.WriteLine($"Du har valt att möta {g.name}, {g.name}'s pokemon är: {g.assignedPokemon.name}, HP: {g.assignedPokemon.HP}");

                    
                    break;
                }

        
            }

             if(!successPick)
                {
                    Console.WriteLine("Try again bozo");
                    gymPick = Console.ReadLine() ?? string.Empty;
                }


        }

        Console.ReadLine();
        Console.Clear();

        foreach (Pokemon p in pokemons)
        {
            Console.WriteLine($"Name: {p.name}, HP: {p.HP}");
        }

        Console.WriteLine("Var snäll att välj en pokemon");
        string answer = Console.ReadLine() ?? string.Empty;

       
    bool validPokemon = false;

    while (!validPokemon)
    {
        foreach (Pokemon p in pokemons)
        {
            if (answer.ToLower() == p.name.ToLower())
            {
                validPokemon = true;
                Console.WriteLine("Attacks: ");
                foreach (PokemonAttacks attacks in p.attacks)
                {
                    Console.WriteLine($"- {attacks.AttackName}: {attacks.AttackDamage}");
                }
                Console.WriteLine($"Välj en attack att attackera {}");
                break;
            }
        }

        if (!validPokemon)
        {
            Console.WriteLine("Så där får du inte skirva tyvärr, try again");
            answer = Console.ReadLine() ?? string.Empty;
        }
    }



        

            Console.ReadLine();

         }



    }





