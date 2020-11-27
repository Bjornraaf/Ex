using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausesc : MonoBehaviour
{
    public GameObject pauseWindow;
    public static bool gamePaused = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gamePaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
        
    }
    void Resume()
    {
        pauseWindow.SetActive(false);
        Time.timeScale = 1;
        gamePaused = false;
    }
    void Pause()
    {
        pauseWindow.SetActive(true);
        Time.timeScale = 0;
        gamePaused = true;
    }
}
