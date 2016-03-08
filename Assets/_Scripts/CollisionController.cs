using UnityEngine;
using System.Collections;
using DG.Tweening;

public class CollisionController : MonoBehaviour
{
    public UILabel labelCount;
    public int circleCount = 5;
    private int _count = 0;

    void Start()
    {
        _count = circleCount;

        if ( labelCount )
        {
            labelCount.text = _count.ToString();
        }
    }

    void OnCollisionEnter2D( Collision2D collision )
    {
        //for ( int i = 0; i < collision.contacts.Length; ++i )
        //{
        //    Debug.Log( collision.contacts[i].collider.name + " - " + collision.contacts[i].normal );
        //}

        if ( collision.transform.name.Equals( "SpriteBall" ) )
        {
            _count--;

            GetComponent<Animation>().Play( "BumperHit" );

            if ( _count < 0 )
            {
                _count = circleCount;
            }

            if ( labelCount )
            {
                labelCount.text = _count.ToString();
            }

        }
    }

    void OnCollisionEnter( Collision collision )
    {
        //foreach ( var data in collision.contacts )
        //{
        //    Debug.Log( collision.transform.name );
        //}

        if ( collision.transform.name.Equals( "SpriteBall" ) )
        {
            _count--;

            GetComponent<Animation>().Play( "BumperHit" );

            if ( _count < 0 )
            {
                _count = circleCount;
            }

            if ( labelCount )
            {
                labelCount.text = _count.ToString();
            }
           
        }
    }
}
