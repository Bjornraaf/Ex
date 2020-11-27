using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] protected int scor;
    public Text scoretxt;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoretxt.text = "Score:" + " " + scor.ToString();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Coin>())
        {
            audioSource.Play();
            scor += 1;
            Destroy(collision.gameObject);

        }
        if (collision.GetComponent<Bigcoin>())
        {
            scor += 10;
            Destroy(collision.gameObject);
        }
    }
}
