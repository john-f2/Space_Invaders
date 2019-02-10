/*
 * 
 * Enemy Script
 * Gives functionality to the Enemy GameObject
 * 
 * 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{

    public GameObject enemyBulletPrefab;
    //scoreValue variable, this value is added to the score when 
    //the enemy object is destroyed 
    public int scoreValue;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    //shooting function for the enemies 
    public void shoot()
    {

        //instantiates the bullet object
        GameObject newBullet = Instantiate(enemyBulletPrefab, this.transform.position, Quaternion.identity);
        //ignores collision with original object 
        Physics2D.IgnoreCollision(this.GetComponent<Collider2D>(), newBullet.GetComponent<Collider2D>());

    }
}
