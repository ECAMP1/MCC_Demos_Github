using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight_Script : MonoBehaviour {

    public GameObject flash;

    private int flashCounter;

    public AudioSource soundPlayer;
    public AudioClip click;
    [Range(0.0f, 1.0f)] public float clickVolume;

    // Use this for initialization
    void Start () 
    {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
		if (Input.GetKeyDown(KeyCode.F))
        {
            flash.SetActive(false);
            flashCounter += 1;
            soundPlayer.PlayOneShot(click, clickVolume);
        }

        if (flashCounter>= 2)
        {
            flash.SetActive(true);
            flashCounter = 0;
        }
	}
}
