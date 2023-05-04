using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappear : MonoBehaviour
{

    public GameObject Obj;
    private int flashCpunter;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Obj.SetActive(false);
            flashCpunter += 1;
            
        }

        if (flashCpunter >= 2)
        {
            Obj.SetActive(true);
            flashCpunter = 0;
        }
    }
}

