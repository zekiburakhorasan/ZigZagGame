using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastTest : MonoBehaviour
{
	void Start ()
    {
		
	}
	
	void Update ()
    {
        Ray ray = new Ray(transform.position, -transform.up);
        RaycastHit hitInfo;
		if(Physics.Raycast(ray, out hitInfo, 5)) //boolean döner
        {
            Debug.Log(hitInfo.transform.name);
        }
        //Debug.DrawRay(transform.position, -transform.up * 10, Color.yellow);

	}
}
