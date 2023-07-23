using System.Collections;
using UnityEngine;

public class SpawnerPineapples : MonoBehaviour
{
    [SerializeField] private Pineapple _pineapple;

    private void Start()
    {
        CreatePineapple();
    }

    public void CreatePineapple()
    {
        Instantiate(_pineapple, transform.GetChild(Random.Range(0, transform.childCount)).position, Quaternion.identity);
    }
}
