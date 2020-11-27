using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Hit : Score
{
    int damn;
    [SerializeField] public GameObject loseWindow;
    [SerializeField] Text HitText;
    public AudioSource audioSource2;


    void OnCollisionEnter2D(Collision2D collision2D)
    {
            if (collision2D.gameObject.tag == "Enemy")
            {
            dead();
            }

        if (collision2D.gameObject.tag == "Wall")
        {
            dead();

            if (damn == 0)
            {
                Destroy(gameObject);
                loseWindow.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        damn = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    protected void dead()
    {
        damn--;
        Debug.Log(damn);
        audioSource2.Play();
        transform.position = new Vector3(-14, 2, 0);
        HitText.text = "Lives:" + " " + damn.ToString();
    }
}
