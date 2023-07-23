using UnityEngine;

public class Pineapple : MonoBehaviour
{
    private SpawnerPineapples _spawnerPineapples;

    private void Start()
    {
        _spawnerPineapples = FindObjectOfType<SpawnerPineapples>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent<PlayerMover>(out PlayerMover playerMover))
        {
            if (playerMover)
            {
                Destroy(gameObject);
                _spawnerPineapples.CreatePineapple();
            }
        }
    }
}
