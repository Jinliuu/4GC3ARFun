using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonControl : MonoBehaviour {

    public AudioSource audioSource1;
    public AudioSource audioSource2;
    public GameObject currentTarget;
    public GameObject currentTarget2;
    Animator currentAnimator;
    Animator currentAnimator2;
    Animator myAnimator;
	// Use this for initialization
	void Start () {
        currentAnimator = currentTarget.GetComponent<Animator>();
        currentAnimator2 = currentTarget2.GetComponent<Animator>();
        myAnimator = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void onButtonClick()
    {
        myAnimator.SetTrigger("onClick");
        currentAnimator.SetBool("Next",true);
        currentAnimator2.SetBool("Next", true);
    
    }

    public void onStopClick()
    {
        myAnimator.SetTrigger("onClick");
        currentAnimator.SetBool("Next", false);
        currentAnimator2.SetBool("Next", false);
        audioSource1.mute = !audioSource1.mute;
        audioSource2.mute = !audioSource2.mute;

    }

    public void onEnterEvent()
    {
        myAnimator.SetBool("onEnter", true);
    }

    public void onExitEvent()
    {
        myAnimator.SetBool("onEnter", false);
    }
}
