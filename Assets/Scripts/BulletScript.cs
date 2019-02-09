﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class IntUnityEvent : UnityEvent<int> { }

public class BulletScript : MonoBehaviour
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

    private void OnTriggerEnter2D(Collider2D col)
    {
        //if the bullet hits the "bullet net" game object
        //it will destory the bullet
        //reduces the amount of stray bullets
        if (col.CompareTag("bulletNet"))
        {
            Destroy(this.gameObject);
        }
        if (col.CompareTag("Enemy"))
        {
            Debug.Log("Enemy has been hit");
            //when enemy is hit destory the gameObject
            Destroy(col.gameObject);
            Destroy(this.gameObject);
        }

    }
}