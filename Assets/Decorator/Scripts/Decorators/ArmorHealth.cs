public class ArmorHealth : IHealthStat
{
    private IHealthStat _healthStat;
    private int _armor;

    public ArmorHealth(IHealthStat healhStat, int armor)
    {
        _healthStat = healhStat;
        _armor = armor;
    }

    public int MaxHealth => _healthStat.MaxHealth;

    public int Value => _healthStat.Value;

    public void Add(int value) => _healthStat.Add(value);   

    public void Reduce(int value)
    {
        value -= _armor;

        if(value < 0)
            value = 0;

        _healthStat.Reduce(value);  
    }
}
