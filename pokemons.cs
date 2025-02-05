// using System.Reflection.Metadata.Ecma335;


// class Pokemon
// {
//     public string name = "Pikachu";
//     public int HP = 250;

//     public List<PokemonAttacks> attacks = new();
// }


// class Pikachu : Pokemon
// {
//     public Pikachu()
//     {
//         name = "Pikachu";
//         attacks.Add(new() {name = "Elrctroball", AttackDamage = 80 });
//         attacks.Add(new() {name = "Thunderbolt", AttackDamage = 50});
//         attacks.Add(new() {name = "Thundershock", AttackDamage = 20});
//     }
// }



// class Squirtle : Pokemon
// {
//  public Squirtle()
//  {
//     name = "Squirtle";
//     attacks.Add(new() {name = "Watergun", AttackDamage = 20});
//  }  
// }






using System.Reflection;

class PokemonAttacks
{
    public string AttackName;
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


}


    }


}