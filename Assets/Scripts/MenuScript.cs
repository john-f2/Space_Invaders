using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    public static MenuScript instance;
    public GameObject menuPanel;
    public static bool isPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }

    }


    public void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            Time.timeScale = 0;
            //m_meshProUGUI.text = "Resume";
            menuPanel.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            //m_meshProUGUI.text = "Pause";
            menuPanel.SetActive(false);
        }

    }

    public void QuitButton()
    {
        Application.Quit();
    }

}
