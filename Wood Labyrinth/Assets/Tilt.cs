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

		print (transform.localRotation.z);
		if(transform.localRotation.x > .05 && tiltVertical > 0)
		{
			tiltVertical = 0;
		}

		if (transform.localRotation.x < -.05 && tiltVertical < 0) 
		{
			tiltVertical = 0;
		}

		if(transform.localRotation.z > .05 && tiltHorizontal < 0)
		{
			tiltHorizontal = 0;

		}
		if (transform.localRotation.z < -.05 && tiltHorizontal > 0) {
			tiltHorizontal = 0;
		}

        transform.Rotate(new Vector3(tiltVertical, 0, -tiltHorizontal));

    }
}
