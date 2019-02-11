using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 
 * ship movement script 
 * Space Invaders Project
 * 
 * 
 */
public class ShipMovementScript : MonoBehaviour
{

    [SerializeField] protected float playerSpeed = 5.0f;

    private Rigidbody2D shipRigidBody;
    private float xMovement;

    // Start is called before the first frame update
    void Start()
    {
        //gets the ship's RigidBody2D, used for movement 
        shipRigidBody = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //gets the x movement from the horizontal axis
        //applies velocity to the ship based on the xMovement 
        xMovement = Input.GetAxis("Horizontal");
        shipRigidBody.velocity = new Vector2(xMovement * playerSpeed, shipRigidBody.velocity.y);
    }

    public void ResetToMiddle()
    {
        this.shipRigidBody.MovePosition(new Vector2(0, -4));
    }
}
