<Query Kind="Program">
  <NuGetReference>FileHelpers</NuGetReference>
</Query>

void Main()
{
	var engine = new FileHelpers.FileHelperEngine<Pokemon>();
	engine.Options.IgnoreFirstLines = 1;
	var pokemons = engine.ReadFile(Path.Combine(Path.GetDirectoryName(LINQPad.Util.CurrentQueryPath), "database.csv"));
	pokemons.Dump();
}

// Define other methods and classes here
[FileHelpers.DelimitedRecord(",")]
public class Pokemon
{
	public string Name;
	public string Type;
	public string Region;
	public int Weight;
	public int Height;
	public int Length;
	public string EvolvesFrom;
	public string EvolvesTo;
}