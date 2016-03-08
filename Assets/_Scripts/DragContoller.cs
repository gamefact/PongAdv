using UnityEngine;
using System.Collections;

public class DragContoller : MonoBehaviour
{
    public Transform target;
    public float speed = 20;
    private Rigidbody _rigidbody;
    private Rigidbody2D _rigidbody2D;

    void Start()
    {
        _rigidbody = target.GetComponent<Rigidbody>();
        _rigidbody2D = target.GetComponent<Rigidbody2D>();

        //if ( _rigidbody )
        //{
        //    _rigidbody.velocity = Vector2.one.normalized * speed;
        //}

        //if ( _rigidbody2D )
        //{
        //    _rigidbody2D.velocity = Vector2.one.normalized * speed;
        //}
    }

    void OnDrag( Vector2 delta )
    {
        if ( _rigidbody )
        {
            Vector2 dir = delta.normalized;
            _rigidbody.velocity = dir * speed;
        }

        if ( _rigidbody2D )
        {
            Vector2 dir = delta.normalized;
            _rigidbody2D.velocity = dir * speed;
        }
    }
}
