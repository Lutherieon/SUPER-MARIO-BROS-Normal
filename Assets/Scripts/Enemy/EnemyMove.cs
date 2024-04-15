using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float enemySpeed;
    public float xMoveDirection;
    [SerializeField] float maxDistance;
    RaycastHit2D hits;
    bool isFacingRight;
    [SerializeField] LayerMask tup;
    void Update()
    {
        Debug.DrawRay(GetComponent<BoxCollider2D>().bounds.center, new Vector2(xMoveDirection, 0) * (GetComponent<BoxCollider2D>().bounds.extents.x + maxDistance), Color.green);
        
        hits = Physics2D.Raycast(GetComponent<BoxCollider2D>().bounds.center, new Vector2(xMoveDirection, 0), maxDistance, tup);
      

        
        


        if(xMoveDirection > 0 && hits.collider != null)
        {
            Flipping();
        }

        else if (xMoveDirection < 0 && hits.collider !=null)
        {
            Flipping();
        }

        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(xMoveDirection * enemySpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }


    void Flipping()
    {
        xMoveDirection = -xMoveDirection;
        Vector3 localScale = transform.localScale;
        localScale.x *= -1f;
        transform.localScale = localScale;

    }
}
