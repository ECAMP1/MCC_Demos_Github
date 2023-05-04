using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Renderer renderer;

    public Material Detect;
    public Material Base;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Mouse Functions

    private void OnMouseEnter()
    {
        renderer.material = Detect;
    }

    private void OnMouseExit()
    {
        renderer.material = Base;
    }
}
