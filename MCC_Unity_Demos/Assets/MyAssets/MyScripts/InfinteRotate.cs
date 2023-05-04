using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfinteRotate : MonoBehaviour
{
    private float y;
    private float z;
    private bool rotateY;
    private float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        y = 0.0f;
        //z = 0.0f;
        rotateY = true;
        rotationSpeed = 75.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (rotateY == true)
        {
            y += Time.deltaTime * rotationSpeed;

            //if (y > 360.0f)
            //{
            //    y = 0.0f;
            //    rotateY = false;
            //}
        }
        //else
        //{
        //    z += Time.deltaTime * rotationSpeed;

        //    if (z > 360.0f)
        //    {
        //        z = 0.0f;
        //        rotateY = true;
        //    }
        //}

        transform.localRotation = Quaternion.Euler(0, y, 0);
    }
}
