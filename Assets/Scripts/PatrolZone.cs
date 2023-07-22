using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PatrolZone : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    private float _diapason = 2f;

    [SerializeField] private float _moveSpeed = 1f;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();

        StartCoroutine(c_Move());
    }

    private IEnumerator c_Move()
    {
        float min = transform.position.x - _diapason;
        float max = transform.position.x + _diapason;

        float direction = Mathf.Sign(_moveSpeed);

        while (true)
        {
            if (transform.position.x > max && direction > 0.0f)
            {
                transform.localRotation = Quaternion.Euler(0, 180, 0);
                direction = -direction;
            }
            else if (transform.position.x < min && direction < 0.0f)
            {
                transform.localRotation = Quaternion.Euler(0, 0, 0);
                direction = -direction;
            }

            _rigidbody2D.velocity = new Vector2(_moveSpeed * direction, _rigidbody2D.velocity.y);

            yield return null;
        }
    }
}
