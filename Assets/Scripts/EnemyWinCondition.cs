using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyWinCondition : MonoBehaviour
{
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
