using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mario.Grounded;
namespace Mario.Movement
{
    public class Mover : MonoBehaviour
    {

        [Header("Physics")]
        Rigidbody2D rigidbodyComponent;
        float HorizontalInput;

        [SerializeField] public float movementSpeedX = 10f;
        [SerializeField] public float movementSpeedY = 1000f;

        [Header("PlayerTransform")]
        Transform playerTransformComp;
        bool isFacingRight;
        IsGrounded isGrounded_;
        private void Awake()
        {
            isGrounded_ = GetComponent<IsGrounded>();
            rigidbodyComponent = GetComponent<Rigidbody2D>();
        }
        void Start()
        {
            
        }

        private void Update()
        {

        }
        void LateUpdate()
        {
            FlipingAction();
            Movement();
            Jumping();
        }


        // Control x axis 
        void Movement()
        {
            HorizontalInput = Input.GetAxis("Horizontal");
            rigidbodyComponent.velocity = new Vector2(HorizontalInput * movementSpeedX * Time.fixedDeltaTime, this.rigidbodyComponent.velocity.y);
        }


        // Control y axis 
        void Jumping()
        {
            if (Input.GetKeyDown(KeyCode.Space) && isGrounded_.isGrounded())
            {
                rigidbodyComponent.AddForce(Vector2.up * movementSpeedY);

            }


        }


        // Control character direction and fliping



        void FlipingAction()
        {
            if (HorizontalInput > 0 && isFacingRight)
            {
                Fliping();
            }

            else if (HorizontalInput < 0 && !isFacingRight)
            {
                Fliping();
            }

        }
        void Fliping()
        {
            isFacingRight = !isFacingRight;
            Vector2 localScale = gameObject.transform.localScale;
            localScale.x *= -1;
            transform.localScale = localScale;



        }

    }



}
