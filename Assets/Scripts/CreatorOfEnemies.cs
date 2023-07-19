using System.Collections;
using UnityEngine;

public class CreatorOfEnemies : MonoBehaviour
{
    [SerializeField] private Player _template;

    private void Start()
    {
        StartCoroutine(SpawnEnemy());
    }
   
    private IEnumerator SpawnEnemy()
    {
        var waitForTwoSeconds = new WaitForSeconds(2f);

        for (int i = 0; i < transform.childCount; i++)
        {
            Instantiate(_template, transform.GetChild(i).position, Quaternion.identity);
            yield return waitForTwoSeconds;
        }
    }
}
