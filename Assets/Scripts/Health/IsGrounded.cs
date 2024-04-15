using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Mario.Grounded
{
    public class IsGrounded : MonoBehaviour
    {
        Collider2D playerColliderComp;
        [SerializeField] float maxDistance;
        [SerializeField] LayerMask jumpableLayerMask;
        RaycastHit2D[] hits2D;


        private void Awake()
        {
            playerColliderComp = GetComponent<Collider2D>();
        }
        void Start()
        {
        }

        void Update()
        {
            isGrounded();
        }





        public bool isGrounded()
        {

            RaycastHit2D raycastHit2D = Physics2D.BoxCast(playerColliderComp.bounds.center, playerColliderComp.bounds.size, 0f, Vector2.down, maxDistance, jumpableLayerMask);
            Color rayColor;
            if(raycastHit2D.collider != null)
            {
                rayColor = Color.green;
            }
            else
            {
                rayColor = Color.red;
            }
            Debug.DrawRay(playerColliderComp.bounds.center, Vector2.down * (playerColliderComp.bounds.extents.y + maxDistance), rayColor);
            //Debug.Log(raycastHit2D.collider);
            return raycastHit2D;
        }


    }


}

