using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Losewin : MonoBehaviour
{
    [SerializeField] public GameObject loseWindow;
    public void Losed()
    { 
            loseWindow.SetActive(true);
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
