using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * Ship shooting script
 * used to instantiate a new bullet instance 
 * 
 * 
 * 
 */
public class shipShootingScript : MonoBehaviour
{
    public GameObject bulletPrefab;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            shoot();

        }
    }

    void shoot()
    {
        //instantiates the bullet object
        //the bullet object will have a script attacted 
        //that will run movement on start()
        float x = this.transform.position.x;
        //this y position allows the bullet to come out at the front of the ship
        //it needs to be adjusted if we change the sprite
        float y = this.transform.position.y + .5f;
        Vector2 bulletPosition = new Vector2(x,y);
        Instantiate(bulletPrefab, bulletPosition, Quaternion.identity);
        
    }
}
