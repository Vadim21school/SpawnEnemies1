using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]
public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _JumpStrength;

    private Animator _runAnimantion;
    private float _horizontalInput;
    private Rigidbody2D _rigidbody2D;
    private int _nameTriggerHash;

    private void Start()
    {
        _runAnimantion = GetComponent<Animator>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _nameTriggerHash = Animator.StringToHash("isWalk");
    }


    private void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");

        PlayRunAnimation();
        ControlRotationByY();

        _rigidbody2D.AddForce(Vector2.right * _speed * _horizontalInput, ForceMode2D.Force);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody2D.AddForce(Vector2.up * _JumpStrength, ForceMode2D.Impulse);
        }
    }

    private void PlayRunAnimation()
    {
        if (Input.anyKey)
        {
            _runAnimantion.SetTrigger(_nameTriggerHash);
        }
    }

    private void ControlRotationByY()
    {
        if (_horizontalInput > 0)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        else if (_horizontalInput < 0)
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
    }
}
