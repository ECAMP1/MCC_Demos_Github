using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen_Trigger : MonoBehaviour
{
    public GameObject DoorObj;
    public float doorSpeed;
    public float rotationLimit;

    private float y;
    private bool _isOpen;

    // Start is called before the first frame update
    void Start()
    {
        y = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        DoorObj.transform.localRotation = Quaternion.Euler(0, y, 0);

        if ((y < rotationLimit ) && (_isOpen == true))
        {
            y += doorSpeed;
        }

        if ((y >= 0) && (_isOpen == false))
        {
            y -= doorSpeed;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        _isOpen = true;
    }

    void OnTriggerExit(Collider other)
    {
        _isOpen = false;
    }
}
