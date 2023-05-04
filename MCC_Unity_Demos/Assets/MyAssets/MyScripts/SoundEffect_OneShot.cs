using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffect_OneShot : MonoBehaviour
{
    public AudioSource soundPlayer;
    public AudioClip sound;
    [Range(0.0f, 1.0f)] public float soundVolume;

    public KeyCode keyBoardButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyBoardButton))
        {
            soundPlayer.PlayOneShot(sound, soundVolume);
        }
    }
}
