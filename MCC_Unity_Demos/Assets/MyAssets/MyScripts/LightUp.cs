using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightUp : MonoBehaviour
{
    public GameObject flame;

    // Start is called before the first frame update
    void Start()
    {
        flame.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.Q))
        {
            flame.SetActive(true);
        }
    }
}
