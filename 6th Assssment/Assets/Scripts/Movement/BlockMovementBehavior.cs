using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMovementBehavior : MonoBehaviour
{
    public float HSpeed = 2;
    public float StartCos = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void ResetPosition()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(HSpeed, 0, 0) * Time.deltaTime;
        StartCos += Time.deltaTime;
        transform.position += new Vector3(0, Mathf.Cos(Time.time), 0) * Time.deltaTime;
    }
}