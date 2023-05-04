using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Master_CTRL : MonoBehaviour
{
    public bool _isUsing_DoorTrig;
    public bool _isUsing_DoorCommand;
    public bool _isUsing_Door_Lock;


    public GameObject Door;
    public float OpenDelay;

    public GameObject original;
    public GameObject KeyInserted;

    public AudioSource soundPlayer;
    public AudioClip doorSwing;
    [Range(0.0f, 1.0f)] public float DoorVolume;

    private bool _isDoorCommandActive;
    private bool _isDoorLockActive;
    private bool _isOpen;

    public static string _isLocked;


    // Start is called before the first frame update
    void Start()
    {
        _isDoorCommandActive = false;
        _isDoorLockActive = false;
        _isLocked = "true";

        KeyInserted.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if ((_isUsing_DoorCommand == true) && (_isDoorCommandActive == true))
        {
            CommandCheck();
        }

        if ((_isUsing_Door_Lock == true) && (_isDoorLockActive == true))
        {
            LockCheck();
        }
    }


    // Trigger Functions
    private void OnTriggerEnter(Collider other)
    {
        if (_isUsing_DoorTrig == true)
        {
            Opening();
            soundPlayer.PlayOneShot(doorSwing, DoorVolume);
        }

        if ((_isUsing_Door_Lock == true) && (PickUp_Master_CTRL._hasFinished == "Yes"))
        {
            _isDoorLockActive = true;
            _isLocked = "false";
        }

    }

    private void OnTriggerStay(Collider other)
    {

        if (_isUsing_DoorCommand == true)
        {
            _isDoorCommandActive = true;
        }

        if ((_isUsing_Door_Lock == true) && (PickUp_Master_CTRL._hasKey == "Yes"))
        {
            _isDoorLockActive = true;
            _isLocked = "false";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (_isUsing_DoorTrig == true)
        {
            Closing();
            soundPlayer.PlayOneShot(doorSwing, DoorVolume);
        }

        if (_isUsing_DoorCommand == true)
        {
            _isDoorCommandActive = false;
        }

        if (_isUsing_Door_Lock == true)
        {
            _isDoorLockActive = false;
            _isLocked = "true";
        }
    }

    // void Functions
    void Opening()
    {
        Door.GetComponent<Animator>().SetTrigger("Opening");
    }
    void Closing()
    {
        Door.GetComponent<Animator>().SetTrigger("Closing");
    }
    void CommandCheck()
    {
        if (Input.GetKeyDown(KeyCode.E) && (_isOpen == false))
        {
            Opening();
            soundPlayer.PlayOneShot(doorSwing, DoorVolume);
            Invoke("TrueFunction", OpenDelay);
        }

        if (Input.GetKeyDown(KeyCode.E) && (_isOpen == true))
        {
            Closing();
            soundPlayer.PlayOneShot(doorSwing, DoorVolume);
            _isOpen = false;
        }
    }
    void LockCheck()
    {
        if (Input.GetKeyDown(KeyCode.E) && (_isLocked == "false"))
        {
            Opening();
            soundPlayer.PlayOneShot(doorSwing, DoorVolume);
            Invoke("KeyTrueFunction", OpenDelay);
            PickUp_Master_CTRL._hasKey = "No";
            KeyOff();
            KeyInserted.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.E) && (_isLocked == "true"))
        {
            Closing();
            soundPlayer.PlayOneShot(doorSwing, DoorVolume);
            _isLocked = "false";
            
        }
    }
    void TrueFunction()
    {
        _isOpen = true;
    }
    void KeyTrueFunction()
    {
        _isLocked = "true";
    }
    void KeyOff()
    {
        original.SetActive(false);
    }


}
