using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetterJumping : MonoBehaviour
{

    Rigidbody2D arigidbody2D;
    [SerializeField] float fallMultipler = 2.5f;
    //[SerializeField] float lowFallMultipler = 1.5f;

    private void Awake()
    {
        arigidbody2D = GetComponent<Rigidbody2D>();  
    }
    

    void Update()
    {
        if(arigidbody2D.velocity.y < 0)
        {
            arigidbody2D.velocity += Vector2.up * Physics2D.gravity.y * (fallMultipler - 1) * Time.deltaTime;
        }    
    }
}
