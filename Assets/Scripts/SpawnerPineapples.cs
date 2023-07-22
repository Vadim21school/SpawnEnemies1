using UnityEngine;

public class SpawnerPineapples : MonoBehaviour
{
    [SerializeField] private Pineapple _pineapple;

    void Update()
    {
        if (!FindObjectOfType<Pineapple>())
        {
            Instantiate(_pineapple, transform.GetChild(Random.Range(0, transform.childCount)).position, Quaternion.identity);
        }
    }
}
