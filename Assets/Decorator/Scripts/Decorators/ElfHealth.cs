public class ElfHealth : IHealthStat
{
    private IHealthStat _healthStat;
    private int _healMulriplier;

    public ElfHealth(IHealthStat healthStat, int healMulriplier)
    {
        _healthStat = healthStat;
        _healMulriplier = healMulriplier;
    }

    public int MaxHealth => _healthStat.MaxHealth;

    public int Value => _healthStat.Value;

    public void Add(int value)
    {
        value *= _healMulriplier;

        _healthStat.Add(value);
    }

    public void Reduce(int value) => _healthStat.Reduce(value);
}
