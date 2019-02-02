using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    //speed variable, used to adjust the speed of the bullet 
    [SerializeField] protected float bulletSpeed = 5.0f;

    private Rigidbody2D bulletRigidBody; 


    // Start is called before the first frame update
    void Start()
    {
        bulletRigidBody = this.gameObject.GetComponent<Rigidbody2D>();
        bulletRigidBody.velocity = Vector2.up * bulletSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
