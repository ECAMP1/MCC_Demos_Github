using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp_Master_CTRL : MonoBehaviour
{

    public bool _isUsingPickUp_General;
    public bool _isUsingPickUp_Move;
    public bool _isUsingPickUp_Lock;

    public GameObject original;
    public GameObject pickUp;
    //public GameObject particle;
    public GameObject Movable_Object;

    public Transform dropOffPosition;
    public Transform holdPosition;

    public static string _hasKey;
    public static string _hasFinished;

    private bool _isholding;

    // Start is called before the first frame update
    void Start()
    {
        original.SetActive(false);
        _isholding = false;
        _hasKey = "No";
        _hasFinished = "No";
    }

    // Update is called once per frame
    void Update()
    {
        if ((_isUsingPickUp_Move == true) && (_isholding == true))
        {
            Drop();
        }
    }

    //Trigger Functions

    private void OnTriggerEnter(Collider other)
    {

    }

    private void OnTriggerStay(Collider other)
    {
        if (_isUsingPickUp_General == true)
        {
            Collect();
        }

        if ((_isUsingPickUp_Lock == true) && (_hasFinished == "No"))
        {
            if (Input.GetKey(KeyCode.E))
            {
                pickUp.SetActive(false);
                original.SetActive(true);
                _hasKey = "Yes";
                Debug.Log("has Key");

            }
        }

        if (_isUsingPickUp_Move == true)
        {
            Grab();
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (_isUsingPickUp_Move == true)
        {
            _isholding = true;
        }

       if (_isUsingPickUp_Lock == true)
        {
            _hasFinished = "Yes";
        }

    }
    //void Functions
    void Collect ()
    {
        if ((Input.GetKey(KeyCode.E)) && (_isUsingPickUp_General == true))
        {
            pickUp.SetActive(false);
        }
    }
    void PickUp()
    {
        if ((Input.GetKey(KeyCode.E)) && (_isUsingPickUp_Move == true))
        {
            pickUp.SetActive(false);
            original.SetActive(true);
        }
    }
    void Grab ()
    {
        if (Input.GetKey (KeyCode.E))
        {
            Movable_Object.transform.position = holdPosition.position;
            Movable_Object.transform.rotation = holdPosition.rotation;
            Movable_Object.transform.parent = holdPosition;
        }
    }
    void Drop()
    {
        if ((Input.GetKeyDown(KeyCode.E)) && (_isholding == true))
        {
            Movable_Object.transform.position = dropOffPosition.position;
            Movable_Object.transform.rotation = dropOffPosition.rotation;
            Movable_Object.transform.parent = null;
        }
    }
}


