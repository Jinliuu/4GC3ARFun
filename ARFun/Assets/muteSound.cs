using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muteSound : MonoBehaviour {

    public AudioSource audioSource1;
    public AudioSource audioSource2;
    void Start()
    {

    }

    void Update()
    {
        
           
    }
    
    public void onClick()
    {
        audioSource1.mute = !audioSource1.mute;
        audioSource2.mute = !audioSource2.mute;
    }
}
