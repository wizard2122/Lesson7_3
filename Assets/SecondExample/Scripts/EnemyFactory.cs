using System;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyFactory", menuName = "Factory/EnemyFactory")]
public class EnemyFactory : ScriptableObject
{
    [SerializeField] private EnemyConfig _small, _medium, _large;

    public Enemy Get(EnemyType type)
    {
        EnemyConfig config = GetConfig(type);
        Enemy instance = Instantiate(config.Prefab);
        instance.Initialize(config.Health, config.Speed);
        return instance;
    }

    private EnemyConfig GetConfig(EnemyType type)
    {
        switch (type)
        {
            case EnemyType.Small:
                return _small;

            case EnemyType.Medium:
                return _medium;

            case EnemyType.Large:
                return _large;

            default:
                throw new ArgumentException(nameof(type));
        }
    }
}
