using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSpawn : MonoBehaviour
{

    public GameObject effect;
    public GameObject pickUp;
    public Transform holdPosition;

    public AudioSource soundPlayer;
    public AudioClip EffectSound;
    [Range(0.0f, 1.0f)] public float EffectVolume;

    private bool _isSpawned;

    public static string _Appeared;
    public static string _Moved;
    
    // Start is called before the first frame update
    void Start()
    {
        _isSpawned = false;
        _Moved = "No";
    }

    // Update is called once per frame
    void Update()
    {
        if ((pickUp.activeInHierarchy == false) && (_isSpawned == false))
        {
            Spawn();
            soundPlayer.PlayOneShot(EffectSound, EffectVolume);
            _isSpawned = true;
        }

        if ((pickUp.transform.parent == holdPosition) && (_isSpawned == false))
        {
            Spawn();
            soundPlayer.PlayOneShot(EffectSound, EffectVolume);
            _isSpawned = true;
        }
    }

    void Spawn ()
    {
        Instantiate(effect, pickUp.transform.position, pickUp.transform.rotation);
    }
}
