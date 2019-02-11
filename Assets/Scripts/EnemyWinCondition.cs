using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyWinCondition : MonoBehaviour
{
    //private void OnTriggerEnter2D(Collision2D collision)
    //{
    //    Debug.Log("1");
    //    if (collision.collider.CompareTag("Enemy"))
    //    {
    //        Debug.Log("2");
    //        SceneManager.LoadScene("EndMenu");
    //    }
    //}

    //private void OnTriggerEnter2D(Collider2D col)
    //{
    //    Debug.Log("1");
    //    if (col.CompareTag("Enemy"))
    //    {

    //        Debug.Log("2");
    //        SceneManager.LoadScene("EndMenu");
    //    }
    //}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("1");
        if (collision.collider.CompareTag("Enemy"))
        {
            Debug.Log("2");
            SceneManager.LoadScene("EndMenu");
        }
    }
}
