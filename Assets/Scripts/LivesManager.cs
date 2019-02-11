using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class LivesManager : MonoBehaviour
{
    public static LivesManager instance;
    public GameObject LivesUIObject;
    private static TextMeshProUGUI livesText;

    //variable used to keep track of lives 
    private static int lives;
    private static int enemyLives;

    private void Awake()
    {
        instance = this;
        lives = 3;
        enemyLives = 55;
        livesText = LivesUIObject.GetComponent<TextMeshProUGUI>();
    }

    // Start is called before the first frame update
    void Start()
    {
        livesText.text = "Lives: " + lives;
    }

    // Update is called once per frame
    void Update()
    {
        if (lives <= 0 || enemyLives <= 0)
        {
            SceneManager.LoadScene("EndMenu");
        }
    }

    public static void updateLives()
    {
        lives--;
        livesText.text = "Lives: " + lives;
    }

    public static void updateEnemyLives()
    {
        enemyLives--;
        Debug.Log("Enemy lives: " + enemyLives);
    }
}
