using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tilt : MonoBehaviour
{

    public float speed;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float tiltHorizontal = Input.GetAxis("Horizontal");
        float tiltVertical = Input.GetAxis("Vertical");
        transform.Rotate(new Vector3(tiltVertical, 0, -tiltHorizontal));
        /*if(Input.GetButtonDown("Horizontal"))
        {
            transform.Rotate(new Vector3(Input.GetAxis, 0, 0) * Time.deltaTime);
        }
        if(Input.GetButtonDown("Vertical"))
        {
            transform.Rotate(new Vector3(0, 0, 50) * Time.deltaTime);
        }*/

        // Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        // rb.AddForce(movement * speed);
    }
}
