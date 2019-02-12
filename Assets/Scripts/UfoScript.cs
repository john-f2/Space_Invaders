/*
 * 
 * ufo script
 * 
 * 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UfoScript : MonoBehaviour
{
    Rigidbody2D body;
    public UnityEvent reachedEndEvent = new UnityEvent();

    // Start is called before the first frame update
    void Start()
    {
        body = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        body.velocity = new Vector2(Vector2.right.x * 4, 0);
        if(this.transform.position.x > 12.0f )
        {
            reachedEndEvent.Invoke();
            Destroy(this.gameObject);
        }
    }
}
