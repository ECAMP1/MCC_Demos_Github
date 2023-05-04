using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Triggering : MonoBehaviour
{
    public GameObject Door;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Door.GetComponent<Animator>().SetTrigger("Opening");
    }

    private void OnTriggerExit(Collider other)
    {
        Door.GetComponent<Animator>().SetTrigger("Closing");
    }
}
