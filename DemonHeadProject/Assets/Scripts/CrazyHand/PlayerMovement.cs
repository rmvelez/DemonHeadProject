using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DemonHead.Player
{
    public class PlayerMovement : MonoBehaviour
    {
        //Member variables for movement
        private Vector2 desiredDirection, lastNonZero;
        private float movementSpeed = 7.5f;
        private Rigidbody2D rb;

        //Getter property for last non-zero direction of input
        //Use this to orient character in the right direction when they stop
        public Vector2 LastNonZero { get { return lastNonZero; } }

        //Initialiser method, setup rigidbody here, define any constant behaviours or values
        internal void Init()
        {
            rb = gameObject.AddComponent<Rigidbody2D>();
        }

        //Update considers input and gets last non-zero input
        private void Update()
        {
            desiredDirection = new Vector2((Input.GetKey(KeyCode.A) ? -1 : 0) + (Input.GetKey(KeyCode.D) ? 1 : 0),
                (Input.GetKey(KeyCode.S) ? -1 : 0) + (Input.GetKey(KeyCode.W) ? 1 : 0)
                );
            if (desiredDirection == Vector2.zero)
            {
                return;
            }
            desiredDirection.Normalize();
            lastNonZero = desiredDirection;
        }

        //Fixed update applies velocity with physics
        private void FixedUpdate()
        {
            rb.velocity = desiredDirection * movementSpeed;
        }
    }
}