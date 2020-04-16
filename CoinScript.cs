using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScript : MonoBehaviour
{
    public static int CoinValue = 0;
    Text Coin;
    // Start is called before the first frame update
    void Start()
    {
        Coin = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Coin.text = "Coins: " + CoinValue;
    }
}
