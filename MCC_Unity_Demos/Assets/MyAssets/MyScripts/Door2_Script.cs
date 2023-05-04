using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door2_Script : MonoBehaviour {

    public GameObject door;

    private int bCounter;

    private bool isOpen;

	// Use this for initialization
	void Start () 
    {
        isOpen = false;
        bCounter = 0;
	}
	
	// Update is called once per frame
	void Update () 
    {

        if(isOpen == true)
        {
            Opening();
            if (Input.GetKeyDown(KeyCode.Q))
            {
                bCounter += 1;
                print("Pressed:" + bCounter);
            }
        }

        if ((Input.GetKey(KeyCode.Q)) && (bCounter == 2))
        {
            Invoke("Closing", 1f);
            Debug.Log("is Invoked");
        }
    }

    private void OnTriggerStay(Collider other)
    {
        isOpen = true;
    }

    private void OnTriggerExit(Collider other)
    {
        isOpen = false;
    }

    void Opening ()
    {
        if ((Input.GetKey(KeyCode.Q)) && (bCounter >= 0))
        {
            door.GetComponent<Animator>().SetBool("isOpening", true);

            if (bCounter >= 2)
            {
                isOpen = false;
            }
        }
    }

    void Closing ()
    {
        door.GetComponent<Animator>().SetBool("isOpening", false);
        bCounter = 0;
    }
}
