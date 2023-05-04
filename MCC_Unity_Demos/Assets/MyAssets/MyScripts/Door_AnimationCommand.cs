using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_AnimationCommand : MonoBehaviour
{
    public GameObject door;
    public KeyCode keyBoardbutton;

    private bool _isOpen;
    private bool _isActivated;
    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        if (_isActivated)
            OpeningCheck();
    }

    private void OnTriggerEnter(Collider other)
    {
        _isActivated = true;
    }

    private void OnTriggerExit(Collider other)
    {
        _isActivated = false;
    }

    void OpeningCheck()
    {
        if (Input.GetKeyDown(keyBoardbutton))
        {
            print("Checking");
            _isOpen = !_isOpen;
            if (_isOpen)
                door.GetComponent<Animator>().SetTrigger("Opening");
            else
                door.GetComponent<Animator>().SetTrigger("Closing");
        }
    }

}
