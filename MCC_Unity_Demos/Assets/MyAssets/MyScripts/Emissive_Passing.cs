using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emissive_Passing : MonoBehaviour
{

    public GameObject emmisiveObj;
    public Material emissiveMat;
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
        emmisiveObj.GetComponent<Renderer>().material = emissiveMat; 
    }
}
