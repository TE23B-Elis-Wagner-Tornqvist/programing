
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



}