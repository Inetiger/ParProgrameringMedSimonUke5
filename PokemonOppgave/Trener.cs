namespace ParProgrameringMedSimonUke5.PokemonOppgave
{
    internal class Trener
    {
        public string Name { get; set; }
        public List<Pokemon> pokemons { get; set; }
        public List<Items> Inventory;

        public Trener(string name)
        {
            Name = name;
            pokemons = new List<Pokemon>
            {
                new Pokemon("Charizard", "Fire")
            };
            Inventory = new List<Items>();
        }
    }
}
