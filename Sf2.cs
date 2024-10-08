public class Sf2 : Character{
    public List<string> SpecialMoves { get; set; } = [];

    public override string Display()
    {
        return  $"Id: {Id}\nName: {Name}\nDescription: {Description}\nSpecial Moves: {string.Join(", ", SpecialMoves)}\n";
    }
}