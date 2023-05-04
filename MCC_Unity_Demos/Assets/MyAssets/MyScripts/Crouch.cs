using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crouch : MonoBehaviour
{
    public float crouchScale;
    public KeyCode crouchButton;

    private float startYScale;
    private bool _buttonDown;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startYScale = transform.localScale.y;
    }

    // Update is called once per frame
    void Update()
    {
        MyInput();
    }

    void MyInput()
    {
        if (Input.GetKeyDown(crouchButton))
        {
            _buttonDown =!_buttonDown;
            if (_buttonDown)
            {
                transform.localScale = new Vector3(transform.localScale.x, crouchScale, transform.localScale.z);
                rb.AddForce(Vector3.down * 5f, ForceMode.Impulse);
            }
            else
            {
                transform.localScale = new Vector3(transform.localScale.x, startYScale, transform.localScale.z);
            }
        }
    }
}
