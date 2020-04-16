using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musiconoff : MonoBehaviour
{
    public AudioSource aud;

    public void OnClick()
    {
       if(aud.mute==true)
        {
            aud.mute = false;
        }
        if (aud.mute == false)
        {
            aud.mute = true;
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
