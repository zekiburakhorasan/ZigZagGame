using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCreator : MonoBehaviour
{
    public GameObject prefab;
    int counterX;

    private void Start()
    {
        //Invoke("CreateCube", 2);
        InvokeRepeating("CreateCube", 1, 0.5f);
    }

    void Update ()
    {
		if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject gameObject = Instantiate(prefab, new Vector3(counterX+1, 0, 5), Quaternion.identity);
            counterX++; // üst üste gelmemesi için yaptık
            Destroy(gameObject, 2); //oluşturduğumuz her gameObject i 2sn sonra silecek
        }
	}

    float counterY;
    void CreateCube()
    {
        GameObject gameObject = Instantiate(prefab, new Vector3(0, counterY, 5), Quaternion.identity);
        counterY += 0.5f;
        Destroy(gameObject, 2);
    }
}
