/*
 * Enemy bullet Script 
 * 
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyBulletScript : MonoBehaviour
{
    public UnityEvent onlivesUpdate = new UnityEvent();
    public Vector2 playerStartCoordinates = new Vector2(0, (float)-4.5);
    public GameObject playerShip;

    // Start is called before the first frame update
    void Start()
    {
        onlivesUpdate.AddListener(LivesManager.updateLives);
        this.playerShip = GameObject.Find("player_object");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("bulletNet"))
        {
            Destroy(this.gameObject);
        }
        if(col.CompareTag("Player"))
        {
            //destory player object, decrement lives 
            Debug.Log("player hit");
            onlivesUpdate.Invoke();
            this.playerShip.transform.position = this.playerStartCoordinates;

            //col.gameObject.SetActive(false);
            //GameObject.Find("level_manager").GetComponent<EnemySpawner>().shootingAllowed = false;
            //StartCoroutine(delayspawn());
            //col.gameObject.SetActive(true);
            //GameObject.Find("level_manager").GetComponent<EnemySpawner>().shootingAllowed = true;

            


        }
    }

    IEnumerator delayspawn()
    {
        yield return new WaitForSeconds(3);

    }




}
