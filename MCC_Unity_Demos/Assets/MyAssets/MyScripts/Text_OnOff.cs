using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text_OnOff : MonoBehaviour
{
    public GameObject textOBJ;
    // Start is called before the first frame update
    void Start()
    {
        textOBJ.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        textOBJ.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        textOBJ.SetActive(false);
    }
}
