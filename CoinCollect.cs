using UnityEngine;
using System.Collections;

public class CoinCollect : MonoBehaviour
{

    public float delay = 10f;
    public GameObject coin;

    private void Start()
    {
        InvokeRepeating("Spawn", delay, delay);
        
     }

    void Spawn()
    {
        Instantiate(coin, new Vector3(Random.Range(-9, 9), -3, 0), Quaternion.identity);
    }

   // void Update()
    //{

        //transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);
        //transform.Rotate(Vector3.forward, spinSpeed * Time.deltaTime);

   // }

    //void OnMouseDown()
    //{

        //GetComponent<Renderer>().enabled = false;

    //}

}

