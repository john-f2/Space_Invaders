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

public class ScoreScript : MonoBehaviour
{
    public GameObject ScoreUIObject;
    private TextMeshProUGUI ScoreText;
    public UnityEvent onScoreUpdate = new UnityEvent();

    private void Awake()
    {
        ScoreText = ScoreUIObject.GetComponent<TextMeshProUGUI>();
    }

    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
