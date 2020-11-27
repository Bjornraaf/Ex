using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    float timer;
    float seconds;
    float minutes;

    [SerializeField] Text stopwWatchText;
    [SerializeField] Text stopwWatchTextwin;
    [SerializeField] Text stopwWatchTextlose;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;

    }

    // Update is called once per frame
    void Update()
    {
        stopWatchCalcul();
    }

    void stopWatchCalcul() 
    {
        timer += Time.deltaTime;
        seconds = (int)(timer % 60);
        minutes = (int)((timer / 60) % 60);

        stopwWatchText.text = "Time:" +  " " + minutes.ToString("00") + ":" + seconds.ToString("00");
        stopwWatchTextwin.text = "Time:" + " " + minutes.ToString("00") + ":" + seconds.ToString("00");
        stopwWatchTextlose.text = "Time:" + " " + minutes.ToString("00") + ":" + seconds.ToString("00");

    }
}
