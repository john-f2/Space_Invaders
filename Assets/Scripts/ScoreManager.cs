/*
 * 
 * Score Script, used to manage the UI 
 * 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

public class ScoreManager : MonoBehaviour
{
    //I create this class as a singleton class (static) 
    //so that it can be easily access by the bullet object
    //and can invoke an event 
    public static ScoreManager instance; 

    //UI gameobject reference variables 
    public GameObject ScoreUIObject;
    private static TextMeshProUGUI ScoreText;

    //private score tracker variable 
    private static int score = 0;


    private void Awake()
    {
        ScoreText = ScoreUIObject.GetComponent<TextMeshProUGUI>();
        instance = this;
        score = 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void updateScore(int points)
    {
        score += points;
        ScoreText.text = "Score: " + score;
    }
}
