using System;

public class Pokemon
{
    public string name { get; set; }
    public int id { get; set; }
    public PokemonStat[] stats { get; set; }


    public PokemonSprites sprites { get; set; }

    public void PrintStat(string statName)
    {
        foreach (PokemonStat singleStat in stats)
        {
            if (singleStat.stat.name == statName)
            {
                Console.WriteLine($"{statName}: {singleStat.base_stat}");
            }
        }
    }
}