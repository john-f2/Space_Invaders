using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class LivesManager : MonoBehaviour
{
    public static LivesManager instance;
    public GameObject LivesUIObject;
    private static TextMeshProUGUI livesText;

    //variable used to keep track of lives 
    private static int lives;

    private void Awake()
    {
        instance = this;
        lives = 3;
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
        
    }

    public static void updateLives()
    {
        lives--;
        livesText.text = "Lives: " + lives;
        

    }
}
