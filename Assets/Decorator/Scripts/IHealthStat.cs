public interface IHealthStat 
{
    int MaxHealth { get; }
    int Value { get; }

    public void Reduce(int value);
    public void Add(int value);
}
