using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestJump : MonoBehaviour
{
    private Rigidbody _rigidbody;
    [SerializeField] private float _jumpForce;
    [SerializeField] private float _highestPoint;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log(Time.deltaTime);
            _rigidbody.AddForce(transform.up * _jumpForce, ForceMode.VelocityChange);

        }

        if(transform.position.y > _highestPoint)
        {
            _highestPoint = transform.position.y;
        }
    }
}
