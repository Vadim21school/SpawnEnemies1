using UnityEngine;

public class Pineapple : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<MotionPlayer>())
        {
            Destroy(gameObject);
        }
    }
}
