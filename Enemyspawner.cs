using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyspawner : MonoBehaviour
{
    public GameObject dragon;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ArrowScript.ArrowValue==100)
        {
            StartCoroutine(ShowAndHide(dragon, 5.0f)); // 1 second
        }

        

        IEnumerator ShowAndHide(GameObject go, float delay)
        {
            go.SetActive(true);
            yield return new WaitForSeconds(delay);
            go.SetActive(false);
        }
    }
}
