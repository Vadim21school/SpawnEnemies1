using System.Collections;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    private Vector3[] postitionsEnemies;
    // Start is called before the first frame update

    private void Start()
    {
        StartCoroutine(SpawnEnemy());
    }
    // Update is called once per frame

    private IEnumerator SpawnEnemy()
    {
        postitionsEnemies = new Vector3[]
        {
            new Vector3(-8, 2.67f, 0),
            new Vector3(-0.09f, -0.4f, 0),
            new Vector3(7.86f, 2.59f, 0),
            new Vector3(6.91f, -3.4f, 0),
            new Vector3(-8, -3.4f, 0)
        };

        var waitForTwoSeconds = new WaitForSeconds(2f);

        for (int i = 0; i < postitionsEnemies.Length; i++)
        {
            Instantiate(enemy, postitionsEnemies[i], Quaternion.identity);
            yield return waitForTwoSeconds;
        }
    }
}
