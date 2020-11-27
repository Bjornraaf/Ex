using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Normal : MonoBehaviour
{
    public void IveBeenClicked()
    {
        SceneManager.LoadScene("Lvl2");
        Time.timeScale = 0;

    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
