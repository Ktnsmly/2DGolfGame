using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contact : MonoBehaviour
{
    [SerializeField] float _launchForce = 20.0f;
    [SerializeField] float _torque = 10.0f;
    Rigidbody2D _rigidbody2D;
    SpriteRenderer _spriteRenderer;

    public Aim _aimScript;
    public float angularVelocity = 0f;

    void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    //Break Apart Deg2Rad and Launching Code
    public void LaunchTheBall(float power)
    {
        float radians = _aimScript.aimDeg * Mathf.Deg2Rad;
        Vector2 direction = new Vector2(Mathf.Cos(radians), Mathf.Sin(radians));
        float force = _launchForce * power;
        _rigidbody2D.isKinematic = false;
        _rigidbody2D.AddForce(direction * force);
        _rigidbody2D.AddTorque(_torque);
    }

    public void deg2rad(float deg)
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        angularVelocity = _rigidbody2D.angularVelocity;
    }
}
