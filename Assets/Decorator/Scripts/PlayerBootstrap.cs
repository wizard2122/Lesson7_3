using UnityEngine;

public class PlayerBootstrap : MonoBehaviour
{
    [SerializeField] private Player _player;

    private void Awake()
    {
        _player.Initialize(new AngelHealth(new Health(50), 4, 4, this));

    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
            _player.TakeDamage(6);

        if (Input.GetKeyUp(KeyCode.F))
            _player.Heal(6);
    }
}
