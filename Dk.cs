public class Dk : Character{
    public string Spieces;

    public override string Display()
    {
        return $"Id: {Id}\nName: {Name}\nDescription: {Description}\nSpi";
    }
}