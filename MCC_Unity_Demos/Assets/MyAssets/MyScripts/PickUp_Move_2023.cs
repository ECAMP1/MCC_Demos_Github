using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp_Move_2023 : MonoBehaviour
{

    public GameObject asset;

    public Transform AssetPosition;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.Q))
        {
            Drop();
        }
    }

    void Drop()
    {
        asset.transform.position =  AssetPosition.position;
        asset.transform.rotation = AssetPosition.rotation;
        asset.transform.parent = null;
    }
}
