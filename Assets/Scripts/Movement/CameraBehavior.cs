using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{

	public Transform player;
	public Vector3 offset;

	// Update is called once per frame
	void Update()
	{
		// Set our position to the players position and offset it
		transform.position = player.position + offset;
	}
}
