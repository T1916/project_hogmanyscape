using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerscore : MonoBehaviour
{
    public GameObject player;
    public AudioSource coinchange;
    public void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == ("fire"))
        {
            Destroy(player.gameObject);
            SceneManager.LoadScene(2);
            


        }
        if (collision.gameObject.tag == ("Arrow"))
        {
            Destroy(collision.gameObject);
            ArrowScript.ArrowValue += 50;

            if(ArrowScript.ArrowValue==100)
            {
                SceneManager.LoadScene(5);
            }
        

        }

        if(collision.gameObject.tag==("coin"))
        {
            Destroy(collision.gameObject);
            CoinScript.CoinValue += 10;
            coinchange = GetComponent<AudioSource>();
            coinchange.Play();
        }

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
