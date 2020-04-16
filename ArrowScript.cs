using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*checking to see if it works*/

public class ArrowScript : MonoBehaviour
{
    public static int ArrowValue = 0;
    Text Arrow;

    // Start is called before the first frame update
    void Start()
    {
        Arrow = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Arrow.text = "Arrows: " + ArrowValue;
    }
}
