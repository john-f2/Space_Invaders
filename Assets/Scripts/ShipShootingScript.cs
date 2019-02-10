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
public class ShipShootingScript : MonoBehaviour
{
    public GameObject bulletPrefab;


    //these functions are used to limit the rate of fire 
    [SerializeField] protected float rateOfFire = 0.7f;
    private float lastShot = 0.0f;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();

        }
    }

    private void Shoot()
    {
        //limits the player's rate of fire 
        if (Time.time > lastShot + rateOfFire)
        {
            //instantiates the bullet object
            //the bullet object will have a script attacted 
            //that will run movement on start()
            float x = this.transform.position.x;
            //this y position allows the bullet to come out at the front of the ship
            //it needs to be adjusted if we change the sprite
            float y = this.transform.position.y + .5f;
            Vector2 bulletPosition = new Vector2(x, y);
            Instantiate(bulletPrefab, bulletPosition, Quaternion.identity);
            lastShot = Time.time;



        }





    }
}
