using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour
{
        public void IveBeenClicked()
        {
        Debug.Log("Heil");
        SceneManager.LoadScene("Lvl1");
        Time.timeScale = 0;
        }
     
}
