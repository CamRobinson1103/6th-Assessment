using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehavior : MonoBehaviour
{
    public Rigidbody rb;

	public float forwardForce = 2000f;  // Variable that determines the forward force
	public float sidewaysForce = 500f;  // Variable that determines the sideways force

	void FixedUpdate()
	{
		rb.AddForce(0, 0, 2000 * Time.deltaTime);   // Add a force of 2000 on the z-axis

		if(Input.GetMouseButton(0))
		{
			rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
		}

		if (Input.GetMouseButton(1))
		{
			rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
		}
	}
}


