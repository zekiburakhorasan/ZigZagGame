using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
	void Start ()
    {
        GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 1000));
	}
	
	void Update ()
    {
		
	}
}
