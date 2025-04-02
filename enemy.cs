using System.Security.Cryptography;

class battleEnemy
{
    public string name;
    public int rang;
    public List<Pokemon> leaderPokemon;
    public List<PokemonAttacks> LeaderPAttacks;

    public battleEnemy(string name, int rang){
        this.name = name;
        this.rang = rang;
        this.leaderPokemon = new List<Pokemon>();
        this.LeaderPAttacks = new List<PokemonAttacks>();
    }

     public void AddPokemon(string name, int HP, string AttackName, int AttackDamage)
    {
        leaderPokemon.Add(new Pokemon(name, HP));
        //LeaderPAttacks.Add(new PokemonAttacks(AttackName, AttackDamage));
    }
    


}