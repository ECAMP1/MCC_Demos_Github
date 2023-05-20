using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character_Controller : MonoBehaviour
{
    public GameObject character_OBJ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            character_OBJ.GetComponent<Animator>().SetBool("isRunning", true);
        else
            character_OBJ.GetComponent<Animator>().SetBool("isRunning", false);
        if (Input.GetKey(KeyCode.S))
            character_OBJ.GetComponent<Animator>().SetBool("isRunning", true);
    }
}
