using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp_peekAboo : MonoBehaviour
{

    public GameObject mesh;
    public float timer;

    
    // Start is called before the first frame update
    void Start()
    {
        mesh.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void meshOFF()
    {
        mesh.SetActive(false);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        mesh.SetActive(true);
        Invoke("meshOFF", timer);
    }
}
