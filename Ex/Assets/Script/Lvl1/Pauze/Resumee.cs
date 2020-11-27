using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resumee : Pausesc
{
    public void Jeff()
    {
        pauseWindow.SetActive(false);
        Time.timeScale = 1;
        gamePaused = false;
    }
}
