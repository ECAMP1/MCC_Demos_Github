using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door2_2023 : MonoBehaviour
{
    public GameObject DoorObj;
    public float doorSpeed;
    public float rotationLimit;
    public KeyCode keyBoardButton;

    public bool using_XAxis;
    public bool using_YAxis;
    public bool using_ZAxis;


    private float y;

    private bool _isUsing;
    private bool _isActivated;
    private bool _isOpen;
    

    // Start is called before the first frame update
    void Start()
    {
        y = 0.0f;
        _isUsing = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (using_YAxis)
        {
            DoorObj.transform.localRotation = Quaternion.Euler(0, y, 0);
        }

       if (_isUsing)
        {
            RotateCheck();
            UpdatingRotation();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        _isUsing = true;
    }
    private void OnTriggerExit(Collider other)
    {
        _isUsing = false;
    }

    void RotateCheck()
    {
        if (Input.GetKeyDown(keyBoardButton))
        {
            _isActivated = !_isActivated;
            if (_isActivated)
                _isOpen = true;
            else
                _isOpen = false;
        }
    }

    void UpdatingRotation ()
    {
        if (_isOpen && y < rotationLimit)
            y += doorSpeed;
        else if (!_isOpen && y >= 0)
            y -= doorSpeed;
    }
}
