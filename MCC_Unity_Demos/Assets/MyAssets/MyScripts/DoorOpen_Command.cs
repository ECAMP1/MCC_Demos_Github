using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen_Command : MonoBehaviour
{

    public GameObject DoorObj;
    public float doorSpeed;

    private int openCounter;
    private float y;

    // Start is called before the first frame update
    void Start()
    {
        y = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        DoorObj.transform.localRotation = Quaternion.Euler(0, y, 0);

        if ((Input.GetKeyUp(KeyCode.E)) && (openCounter >= 0))
        {
            openCounter += 1;
            Debug.Log("OpenCounter: " + openCounter);
        }

        if ((Input.GetKeyUp (KeyCode.E)) && (openCounter == 2))
        {
            openCounter = 0;
            Debug.Log("OpenCounter: " + openCounter);
        }
    }

    void OnTriggerStay(Collider other)
    {
        if ((Input.GetKey(KeyCode.E)) && (openCounter == 0))
        {
            y += doorSpeed;
        }

        if ((Input.GetKey(KeyCode.E)) && (openCounter == 1))
        {
            y -= doorSpeed;

        }

    }

}
