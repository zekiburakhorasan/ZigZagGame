using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject Prefab;
    public Transform Spawn;
	void Start ()
    {
		
	}
	
	void Update ()
    {
		if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject gameObject = Instantiate(Prefab, Spawn.position, Quaternion.identity);
            Destroy(gameObject, 1);
        }
	}
}
