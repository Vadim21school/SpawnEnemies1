using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private PatrolZone _template;

    private float _waitingTimeSpawn = 2f;

    private void Start()
    {
        StartCoroutine(SpawnEnemy());
    }
   
    private IEnumerator SpawnEnemy()
    {
        var waitForTwoSeconds = new WaitForSeconds(_waitingTimeSpawn);

        for (int i = 0; i < transform.childCount; i++)
        {
            Instantiate(_template, transform.GetChild(i).position, Quaternion.identity);
            yield return waitForTwoSeconds;
        }
    }
}
