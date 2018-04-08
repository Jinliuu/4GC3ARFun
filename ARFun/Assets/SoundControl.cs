using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControl : MonoBehaviour {
    public AudioClip sound1;
   

    public AudioSource AudioS1;

    int a;
   
    // Use this for initialization
    void Start () {
        a = 1;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void soundStep1()
    {
        a = a + 1;
        if (a == 2)
        {
            AudioS1.PlayOneShot(sound1);
            a = 0;
        }
       
        
    }


}
