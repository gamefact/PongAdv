using UnityEngine;
using System.Collections;

public class MoveBlock : MonoBehaviour
{
    public Vector2 moveSpeed = Vector2.zero;

    private float _accumTime;

    void FixedUpdate()
    {
        _accumTime += Time.fixedDeltaTime;
        Vector3 pos = transform.localPosition;
        if ( moveSpeed.x > 0 )
        {
            pos.x = Mathf.Sin( _accumTime ) * moveSpeed.x;
        }
        else if ( moveSpeed.y > 0 )
        {
            pos.y = Mathf.Sin( _accumTime ) * moveSpeed.y;
        }
        transform.localPosition = pos;
    }
}
