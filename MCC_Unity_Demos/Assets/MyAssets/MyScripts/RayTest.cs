using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayTest : MonoBehaviour
{
    public GameObject lastHit;


    public Vector3 collision = Vector3.zero;
    public LayerMask layer;

    public float rayLength;

    private Renderer renderer;

    public Color colorPick;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * rayLength, Color.red);

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //var ray = new Ray(origin: this.transform.position, direction: this.transform.forward);
        RaycastHit hit; 
        if(Physics.Raycast(ray, out hit, rayLength, layer))
        {
            lastHit = hit.transform.gameObject;
            collision = hit.point;
            lastHit.GetComponent<Renderer>().material.color = colorPick;
        }

        else
        {
            lastHit.GetComponent<Renderer>().material.color = Color.white;
        }
    }

    // Methods to that can be called

    void onDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(collision, radius:0.2f);
    }
}
