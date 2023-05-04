using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Passing_Lights : MonoBehaviour
{
    public GameObject Lightbulb;

    // Start is called before the first frame update
    void Start()
    {
        Lightbulb.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Lightbulb.SetActive(true);
    }
}
