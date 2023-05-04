using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen_Rotation : MonoBehaviour
{
    public GameObject DoorObj;
    public float doorSpeed;
    public float rotationLimit;

    private float y;
    private int openCounter;
    private bool _isOpen;

    // Start is called before the first frame update
    void Start()
    {
        y = 0.0f;
        _isOpen = false;
    }

    // Update is called once per frame
    public void Add ()
    {
       
    }
    void Update()
    {
        DoorObj.transform.localRotation = Quaternion.Euler(0, y, 0);

        if ((y < rotationLimit) && (_isOpen == true))
        {
            y += doorSpeed;

            if ((Input.GetKeyUp(KeyCode.E)) && (openCounter >= 0))
            {
                openCounter += 1;
                Debug.Log("OpenCounter: " + openCounter);
            }
        }

        if (( y >= 0) && (_isOpen == false))
        {
            y -= doorSpeed;

            if ((Input.GetKeyUp(KeyCode.E)) && (openCounter == 1))
            {
                openCounter = 0;
                Debug.Log("OpenCounter: " + openCounter);
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if ((Input.GetKey(KeyCode.E)) && (openCounter == 0))
        {
            _isOpen = true;
        }

        if ((Input.GetKey(KeyCode.E)) && (openCounter == 1))
        {

            _isOpen = false;
        }
    }
}
