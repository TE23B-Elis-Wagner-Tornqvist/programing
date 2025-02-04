class Pokemon
{
    public string name = "Pikachu";
    public int HP = 250;

    public List<PokemonAttacks> attacks = new();
}

class Pikachu : Pokemon
{
    public Pikachu()
    {
        name = "Pikachu";
        attacks.Add(new() { name = "Elrctroball", AttackDamage = 80 });
        
    }
}


class PokemonAttacks
{
    public string name = "Electroball";
    public int AttackDamage = 80;
}
